using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using Zhbit.HealthSystem.Model;
using Zhbit.HealthSystem.SFL;

namespace Zhbit.HealthSystem.DAL.Common
{
    /// <summary>
    /// 对象名称：居民通用数据访问父类（数据访问层）
    /// 对象说明：提供“居民类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“居民类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 16:41:14
    /// </summary>
    public abstract class ResidentDAL
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“居民（ResidentDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static ResidentDAL residentDAL;


        /// <summary>
        /// 获取“居民（ResidentDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“居民（ResidentDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static ResidentDAL Instance
        {
            get
            {
                if (residentDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            residentDAL = new SqlServer.ResidentDAL();
                            break;

                        case "Oracle":
                            residentDAL = new Oracle.ResidentDAL();
                            break;

                        case "OleDb":
                            residentDAL = new OleDb.ResidentDAL();
                            break;

                        default:
                            residentDAL = new SqlServer.ResidentDAL();
                            break;
                    }
                }
                return residentDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为Resident对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="resident">居民（Resident）实例对象</param>
        protected void ReadResidentAllData(IDataReader dataReader, Resident resident)
        {
            // 自动编号
            if (dataReader["Id"] != DBNull.Value)
                resident.Id = Convert.ToInt32(dataReader["Id"]);
            // 居民号
            if (dataReader["ResidentId"] != DBNull.Value)
                resident.ResidentId = Convert.ToString(dataReader["ResidentId"]);
            // 姓名
            if (dataReader["Name"] != DBNull.Value)
                resident.Name = Convert.ToString(dataReader["Name"]);
            // 身份证号
            if (dataReader["IdNumber"] != DBNull.Value)
                resident.IdNumber = Convert.ToString(dataReader["IdNumber"]);
            // 性别
            if (dataReader["Sex"] != DBNull.Value)
                resident.Sex = Convert.ToInt32(dataReader["Sex"]);
            // 联系电话
            if (dataReader["Phone"] != DBNull.Value)
                resident.Phone = Convert.ToString(dataReader["Phone"]);
            // 出生日期
            if (dataReader["DateOfBirth"] != DBNull.Value)
                resident.DateOfBirth = Convert.ToDateTime(dataReader["DateOfBirth"]);
            // 民族
            if (dataReader["Nation"] != DBNull.Value)
                resident.Nation = Convert.ToString(dataReader["Nation"]);
            // 联系人姓名
            if (dataReader["ContactName"] != DBNull.Value)
                resident.ContactName = Convert.ToString(dataReader["ContactName"]);
            // 联系人电话
            if (dataReader["ContactPhone"] != DBNull.Value)
                resident.ContactPhone = Convert.ToString(dataReader["ContactPhone"]);
            // 文化程度
            if (dataReader["Education"] != DBNull.Value)
                resident.Education = Convert.ToInt32(dataReader["Education"]);
            // 血型
            if (dataReader["BloodType"] != DBNull.Value)
                resident.BloodType = Convert.ToInt32(dataReader["BloodType"]);
            // 职业
            if (dataReader["Professional"] != DBNull.Value)
                resident.Professional = Convert.ToString(dataReader["Professional"]);
            // 工作单位
            if (dataReader["WorkUnits"] != DBNull.Value)
                resident.WorkUnits = Convert.ToString(dataReader["WorkUnits"]);
            // 医疗费用支付方式
            if (dataReader["Payment"] != DBNull.Value)
                resident.Payment = Convert.ToInt32(dataReader["Payment"]);
            // 家庭档案号
            if (dataReader["FamilyId"] != DBNull.Value)
            {
                Family tmpFamily = FamilyDAL.Instance.GetDataById(Convert.ToInt32(dataReader["FamilyId"]));
                if (tmpFamily != null) resident.FamilyId = tmpFamily;
            }
            // 婚姻状况
            if (dataReader["MaritalStatus"] != DBNull.Value)
                resident.MaritalStatus = Convert.ToInt32(dataReader["MaritalStatus"]);
            // 子女数
            if (dataReader["Children"] != DBNull.Value)
                resident.Children = Convert.ToInt32(dataReader["Children"]);
            // 父亲姓名
            if (dataReader["FathersName"] != DBNull.Value)
                resident.FathersName = Convert.ToString(dataReader["FathersName"]);
            // 母亲姓名
            if (dataReader["MotherName"] != DBNull.Value)
                resident.MotherName = Convert.ToString(dataReader["MotherName"]);
            // 监护人姓名
            if (dataReader["GuardiansName"] != DBNull.Value)
                resident.GuardiansName = Convert.ToString(dataReader["GuardiansName"]);
            // 监护人电话
            if (dataReader["GuardianPhone"] != DBNull.Value)
                resident.GuardianPhone = Convert.ToString(dataReader["GuardianPhone"]);
            // 人群类型
            if (dataReader["CrowdType"] != DBNull.Value)
                resident.CrowdType = Convert.ToInt32(dataReader["CrowdType"]);
            // 居住类型
            if (dataReader["ResidentialType"] != DBNull.Value)
                resident.ResidentialType = Convert.ToInt32(dataReader["ResidentialType"]);
            // 常住类型
            if (dataReader["PermanentType"] != DBNull.Value)
                resident.PermanentType = Convert.ToInt32(dataReader["PermanentType"]);
            // 户籍所在地
            if (dataReader["Registered"] != DBNull.Value)
                resident.Registered = Convert.ToString(dataReader["Registered"]);
            // 户籍地址
            if (dataReader["RegisteredAddress"] != DBNull.Value)
                resident.RegisteredAddress = Convert.ToString(dataReader["RegisteredAddress"]);
            // 现居住所在地
            if (dataReader["Live"] != DBNull.Value)
                resident.Live = Convert.ToString(dataReader["Live"]);
            // 现居住地址
            if (dataReader["LiveAddress"] != DBNull.Value)
                resident.LiveAddress = Convert.ToString(dataReader["LiveAddress"]);
            // 建档机构
            if (dataReader["InputtingInstitutions"] != DBNull.Value)
            {
                Institutions tmpInstitutions = InstitutionsDAL.Instance.GetDataById(Convert.ToInt32(dataReader["InputtingInstitutions"]));
                if (tmpInstitutions != null) resident.InputtingInstitutions = tmpInstitutions;
            }
            // 建档人
            if (dataReader["InputtingPerson"] != DBNull.Value)
                resident.InputtingPerson = Convert.ToString(dataReader["InputtingPerson"]);
            // 建档时间
            if (dataReader["InputtingTime"] != DBNull.Value)
                resident.InputtingTime = Convert.ToDateTime(dataReader["InputtingTime"]);
            // 责任医生
            if (dataReader["ResponsibleDoctor"] != DBNull.Value)
                resident.ResponsibleDoctor = Convert.ToString(dataReader["ResponsibleDoctor"]);
            // 管理状态
            if (dataReader["ManagementStatus"] != DBNull.Value)
                resident.ManagementStatus = Convert.ToInt32(dataReader["ManagementStatus"]);
            // 启用时间
            if (dataReader["EnableTime"] != DBNull.Value)
                resident.EnableTime = Convert.ToDateTime(dataReader["EnableTime"]);
            // 是否社会关注人群
            if (dataReader["FocusOn"] != DBNull.Value)
                resident.FocusOn = Convert.ToBoolean(dataReader["FocusOn"]);
            // RH阴性
            if (dataReader["RHNegative"] != DBNull.Value)
                resident.RHNegative = Convert.ToBoolean(dataReader["RHNegative"]);
            // 备注
            if (dataReader["Remarks"] != DBNull.Value)
                resident.Remarks = Convert.ToString(dataReader["Remarks"]);
        }


        /// <summary>
        /// 从DataReader中读取数据，并为Resident对象需要进行显示的属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="resident">居民（Resident）实例对象</param>
        protected void ReadResidentPageData(IDataReader dataReader, Resident resident)
        {
            // 自动编号
            if (dataReader["Id"] != DBNull.Value)
                resident.Id = Convert.ToInt32(dataReader["Id"]);
            // 居民号
            if (dataReader["ResidentId"] != DBNull.Value)
                resident.ResidentId = Convert.ToString(dataReader["ResidentId"]);
            // 姓名
            if (dataReader["Name"] != DBNull.Value)
                resident.Name = Convert.ToString(dataReader["Name"]);
            // 身份证号
            if (dataReader["IdNumber"] != DBNull.Value)
                resident.IdNumber = Convert.ToString(dataReader["IdNumber"]);
            // 性别
            if (dataReader["Sex"] != DBNull.Value)
                resident.Sex = Convert.ToInt32(dataReader["Sex"]);
            // 家庭档案号
            if (dataReader["FamilyId"] != DBNull.Value)
            {
                Family tmpFamily = FamilyDAL.Instance.GetDataById(Convert.ToInt32(dataReader["FamilyId"]));
                if (tmpFamily != null) resident.FamilyId = tmpFamily;
            }
            // 建档机构
            if (dataReader["InputtingInstitutions"] != DBNull.Value)
            {
                Institutions tmpInstitutions = InstitutionsDAL.Instance.GetDataById(Convert.ToInt32(dataReader["InputtingInstitutions"]));
                if (tmpInstitutions != null) resident.InputtingInstitutions = tmpInstitutions;
            }
            // 建档人
            if (dataReader["InputtingPerson"] != DBNull.Value)
                resident.InputtingPerson = Convert.ToString(dataReader["InputtingPerson"]);
            // 建档时间
            if (dataReader["InputtingTime"] != DBNull.Value)
                resident.InputtingTime = Convert.ToDateTime(dataReader["InputtingTime"]);
            // 责任医生
            if (dataReader["ResponsibleDoctor"] != DBNull.Value)
                resident.ResponsibleDoctor = Convert.ToString(dataReader["ResponsibleDoctor"]);
            // 管理状态
            if (dataReader["ManagementStatus"] != DBNull.Value)
                resident.ManagementStatus = Convert.ToInt32(dataReader["ManagementStatus"]);
            // 启用时间
            if (dataReader["EnableTime"] != DBNull.Value)
                resident.EnableTime = Convert.ToDateTime(dataReader["EnableTime"]);
        }


        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将居民（Resident）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="resident">居民（Resident）实例对象</param>
        public abstract int Insert(Resident resident);


        /// <summary>
        /// 将居民（Resident）数据，根据主键“自动编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="resident">居民（Resident）实例对象</param>
        public abstract int Update(Resident resident);


        /// <summary>
        /// 根据居民（Resident）的主键“自动编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">居民（Resident）的主键“自动编号（Id）”</param>
        public abstract int Delete(int id);


        /// <summary>
        /// 根据居民（Resident）的主键“自动编号（Id）”从数据库中获取居民（Resident）的实例。
        /// 成功从数据库中取得记录返回新居民（Resident）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">居民（Resident）的主键“自动编号（Id）”</param>
        public abstract Resident GetDataById(int id);


        /// <summary>
        /// 从数据库中读取并返回所有居民（Resident）List列表。
        /// </summary>
        public abstract List<Resident> GetAllList();


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的居民（Resident）的列表及分页信息。
        /// 该方法所获取的居民（Resident）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public abstract PageData GetPageList(int pageSize, int curPage);


        #endregion 多层框架式下的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
