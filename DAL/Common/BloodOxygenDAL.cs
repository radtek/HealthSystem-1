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
    /// 对象名称：血氧检测类通用数据访问父类（数据访问层）
    /// 对象说明：提供“血氧检测类类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“血氧检测类类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 16:55:49
    /// </summary>
    public abstract class BloodOxygenDAL
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“血氧检测类（BloodOxygenDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static BloodOxygenDAL bloodOxygenDAL;


        /// <summary>
        /// 获取“血氧检测类（BloodOxygenDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“血氧检测类（BloodOxygenDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static BloodOxygenDAL Instance
        {
            get
            {
                if (bloodOxygenDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            bloodOxygenDAL = new SqlServer.BloodOxygenDAL();
                            break;

                        case "Oracle":
                            bloodOxygenDAL = new Oracle.BloodOxygenDAL();
                            break;

                        case "OleDb":
                            bloodOxygenDAL = new OleDb.BloodOxygenDAL();
                            break;

                        default:
                            bloodOxygenDAL = new SqlServer.BloodOxygenDAL();
                            break;
                    }
                }
                return bloodOxygenDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为BloodOxygen对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="bloodOxygen">血氧检测类（BloodOxygen）实例对象</param>
        protected void ReadBloodOxygenAllData(IDataReader dataReader, BloodOxygen bloodOxygen)
        {
            // 编号
            if (dataReader["Id"] != DBNull.Value)
                bloodOxygen.Id = Convert.ToInt32(dataReader["Id"]);
            // 检查日期
            if (dataReader["Checkdate"] != DBNull.Value)
                bloodOxygen.Checkdate = Convert.ToDateTime(dataReader["Checkdate"]);
            // 门诊号
            if (dataReader["ExamNo"] != DBNull.Value)
                bloodOxygen.ExamNo = Convert.ToString(dataReader["ExamNo"]);
            // 检查号
            if (dataReader["CheckID"] != DBNull.Value)
                bloodOxygen.CheckID = Convert.ToString(dataReader["CheckID"]);
            // 姓名
            if (dataReader["Name"] != DBNull.Value)
                bloodOxygen.Name = Convert.ToString(dataReader["Name"]);
            // 性别
            if (dataReader["SexId"] != DBNull.Value)
                //参照完整性捆绑对象
                bloodOxygen.Sex = T_Sex.GetDataById(Convert.ToString(dataReader["SexId"])) ?? T_Sex.Empty;
            // 年龄
            if (dataReader["Age"] != DBNull.Value)
                bloodOxygen.Age = Convert.ToInt32(dataReader["Age"]);
            // 开单医生
            if (dataReader["Doctor"] != DBNull.Value)
                bloodOxygen.Doctor = Convert.ToString(dataReader["Doctor"]);
            // 设备号
            if (dataReader["DeviceID"] != DBNull.Value)
                bloodOxygen.DeviceID = Convert.ToString(dataReader["DeviceID"]);
            // 版本号
            if (dataReader["Version"] != DBNull.Value)
                bloodOxygen.Version = Convert.ToString(dataReader["Version"]);
            // 保留字段
            if (dataReader["Reserve"] != DBNull.Value)
                bloodOxygen.Reserve = Convert.ToString(dataReader["Reserve"]);
            // 检查标记
            if (dataReader["Check_flagId"] != DBNull.Value)
                //参照完整性捆绑对象
                bloodOxygen.Check_flag = T_Check_Flag.GetDataById(Convert.ToInt32(dataReader["Check_flagId"])) ?? T_Check_Flag.Empty;
            // 医院
            if (dataReader["Hosname"] != DBNull.Value)
                bloodOxygen.Hosname = Convert.ToString(dataReader["Hosname"]);
            // 审核医生
            if (dataReader["Auditdoctor"] != DBNull.Value)
                bloodOxygen.Auditdoctor = Convert.ToString(dataReader["Auditdoctor"]);
            // 审核日期
            if (dataReader["Auditdate"] != DBNull.Value)
                bloodOxygen.Auditdate = Convert.ToDateTime(dataReader["Auditdate"]);
            // 状态
            if (dataReader["StatusId"] != DBNull.Value)
                //参照完整性捆绑对象
                bloodOxygen.Status = T_Status.GetDataById(Convert.ToInt32(dataReader["StatusId"])) ?? T_Status.Empty;
            // 心电诊断
            if (dataReader["Str1"] != DBNull.Value)
                bloodOxygen.Str1 = Convert.ToString(dataReader["Str1"]);
            // 冗余
            if (dataReader["Str2"] != DBNull.Value)
                bloodOxygen.Str2 = Convert.ToString(dataReader["Str2"]);
            // 身份证号
            if (dataReader["Str3"] != DBNull.Value)
                bloodOxygen.Str3 = Convert.ToString(dataReader["Str3"]);
            // 冗余
            if (dataReader["Str4"] != DBNull.Value)
                bloodOxygen.Str4 = Convert.ToString(dataReader["Str4"]);
            // 冗余
            if (dataReader["Str5"] != DBNull.Value)
                bloodOxygen.Str5 = Convert.ToString(dataReader["Str5"]);
            // 冗余
            if (dataReader["Str6"] != DBNull.Value)
                bloodOxygen.Str6 = Convert.ToString(dataReader["Str6"]);
            // 冗余
            if (dataReader["Str7"] != DBNull.Value)
                bloodOxygen.Str7 = Convert.ToString(dataReader["Str7"]);
            // 冗余
            if (dataReader["Str8"] != DBNull.Value)
                bloodOxygen.Str8 = Convert.ToString(dataReader["Str8"]);
            // 冗余
            if (dataReader["Str9"] != DBNull.Value)
                bloodOxygen.Str9 = Convert.ToString(dataReader["Str9"]);
            // 冗余
            if (dataReader["Str10"] != DBNull.Value)
                bloodOxygen.Str10 = Convert.ToString(dataReader["Str10"]);
            // 血氧简称
            if (dataReader["T3001005_ename"] != DBNull.Value)
                bloodOxygen.T3001005_ename = Convert.ToString(dataReader["T3001005_ename"]);
            // 血氧全称
            if (dataReader["T3001005_cname"] != DBNull.Value)
                bloodOxygen.T3001005_cname = Convert.ToString(dataReader["T3001005_cname"]);
            // 血氧UNIT
            if (dataReader["T3001005_unit"] != DBNull.Value)
                bloodOxygen.T3001005_unit = Convert.ToString(dataReader["T3001005_unit"]);
            // 血氧上限
            if (dataReader["T3001005_srange"] != DBNull.Value)
                bloodOxygen.T3001005_srange = Convert.ToInt32(dataReader["T3001005_srange"]);
            // 血氧下限
            if (dataReader["T3001005_lrange"] != DBNull.Value)
                bloodOxygen.T3001005_lrange = Convert.ToInt32(dataReader["T3001005_lrange"]);
            // 血氧值
            if (dataReader["T3001005_value"] != DBNull.Value)
                bloodOxygen.T3001005_value = Convert.ToInt32(dataReader["T3001005_value"]);
            // 脉率简称
            if (dataReader["T3001009_ename"] != DBNull.Value)
                bloodOxygen.T3001009_ename = Convert.ToString(dataReader["T3001009_ename"]);
            // 脉率全称
            if (dataReader["T3001009_cname"] != DBNull.Value)
                bloodOxygen.T3001009_cname = Convert.ToString(dataReader["T3001009_cname"]);
            // UNIT(BPM)
            if (dataReader["T3001009_unit"] != DBNull.Value)
                bloodOxygen.T3001009_unit = Convert.ToString(dataReader["T3001009_unit"]);
            // 脉率上限
            if (dataReader["T3001009_srange"] != DBNull.Value)
                bloodOxygen.T3001009_srange = Convert.ToInt32(dataReader["T3001009_srange"]);
            // 脉率下限
            if (dataReader["T3001009_lrange"] != DBNull.Value)
                bloodOxygen.T3001009_lrange = Convert.ToInt32(dataReader["T3001009_lrange"]);
            // 脉率值
            if (dataReader["T3001009_value"] != DBNull.Value)
                bloodOxygen.T3001009_value = Convert.ToInt32(dataReader["T3001009_value"]);
        }


        /// <summary>
        /// 从DataReader中读取数据，并为BloodOxygen对象需要进行显示的属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="bloodOxygen">血氧检测类（BloodOxygen）实例对象</param>
        protected void ReadBloodOxygenPageData(IDataReader dataReader, BloodOxygen bloodOxygen)
        {
            // 编号
            if (dataReader["Id"] != DBNull.Value)
                bloodOxygen.Id = Convert.ToInt32(dataReader["Id"]);
            // 检查日期
            if (dataReader["Checkdate"] != DBNull.Value)
                bloodOxygen.Checkdate = Convert.ToDateTime(dataReader["Checkdate"]);
            // 门诊号
            if (dataReader["ExamNo"] != DBNull.Value)
                bloodOxygen.ExamNo = Convert.ToString(dataReader["ExamNo"]);
            // 检查号
            if (dataReader["CheckID"] != DBNull.Value)
                bloodOxygen.CheckID = Convert.ToString(dataReader["CheckID"]);
            // 姓名
            if (dataReader["Name"] != DBNull.Value)
                bloodOxygen.Name = Convert.ToString(dataReader["Name"]);
            // 性别
            if (dataReader["SexId"] != DBNull.Value)
                //参照完整性捆绑对象
                bloodOxygen.Sex = T_Sex.GetDataById(Convert.ToString(dataReader["SexId"])) ?? T_Sex.Empty;
            // 开单医生
            if (dataReader["Doctor"] != DBNull.Value)
                bloodOxygen.Doctor = Convert.ToString(dataReader["Doctor"]);
            // 设备号
            if (dataReader["DeviceID"] != DBNull.Value)
                bloodOxygen.DeviceID = Convert.ToString(dataReader["DeviceID"]);
            // 检查标记
            if (dataReader["Check_flagId"] != DBNull.Value)
                //参照完整性捆绑对象
                bloodOxygen.Check_flag = T_Check_Flag.GetDataById(Convert.ToInt32(dataReader["Check_flagId"])) ?? T_Check_Flag.Empty;
            // 医院
            if (dataReader["Hosname"] != DBNull.Value)
                bloodOxygen.Hosname = Convert.ToString(dataReader["Hosname"]);
            // 状态
            if (dataReader["StatusId"] != DBNull.Value)
                //参照完整性捆绑对象
                bloodOxygen.Status = T_Status.GetDataById(Convert.ToInt32(dataReader["StatusId"])) ?? T_Status.Empty;
        }


        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将血氧检测类（BloodOxygen）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="bloodOxygen">血氧检测类（BloodOxygen）实例对象</param>
        public abstract int Insert(BloodOxygen bloodOxygen);


        /// <summary>
        /// 将血氧检测类（BloodOxygen）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="bloodOxygen">血氧检测类（BloodOxygen）实例对象</param>
        public abstract int Update(BloodOxygen bloodOxygen);


        /// <summary>
        /// 根据血氧检测类（BloodOxygen）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">血氧检测类（BloodOxygen）的主键“编号（Id）”</param>
        public abstract int Delete(int id);


        /// <summary>
        /// 根据血氧检测类（BloodOxygen）的主键“编号（Id）”从数据库中获取血氧检测类（BloodOxygen）的实例。
        /// 成功从数据库中取得记录返回新血氧检测类（BloodOxygen）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">血氧检测类（BloodOxygen）的主键“编号（Id）”</param>
        public abstract BloodOxygen GetDataById(int id);


        public abstract List<BloodOxygen> GetDatasByName(string name);
        /// <summary>
        /// 从数据库中读取并返回所有血氧检测类（BloodOxygen）List列表。
        /// </summary>
        public abstract List<BloodOxygen> GetAllList();


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的血氧检测类（BloodOxygen）的列表及分页信息。
        /// 该方法所获取的血氧检测类（BloodOxygen）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public abstract PageData GetPageList(int pageSize, int curPage);


        #endregion 多层框架式下的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
