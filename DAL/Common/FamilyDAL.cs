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
    /// 对象名称：家庭通用数据访问父类（数据访问层）
    /// 对象说明：提供“家庭类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“家庭类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 17:18:21
    /// </summary>
    public abstract class FamilyDAL
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“家庭（FamilyDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static FamilyDAL familyDAL;


        /// <summary>
        /// 获取“家庭（FamilyDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“家庭（FamilyDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static FamilyDAL Instance
        {
            get
            {
                if (familyDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            familyDAL = new SqlServer.FamilyDAL();
                            break;

                        case "Oracle":
                            familyDAL = new Oracle.FamilyDAL();
                            break;

                        case "OleDb":
                            familyDAL = new OleDb.FamilyDAL();
                            break;

                        default:
                            familyDAL = new SqlServer.FamilyDAL();
                            break;
                    }
                }
                return familyDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为Family对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="family">家庭（Family）实例对象</param>
        protected void ReadFamilyAllData(IDataReader dataReader, Family family)
        {
            // 家庭档案号
            if (dataReader["Id"] != DBNull.Value)
                family.Id = Convert.ToInt32(dataReader["Id"]);
            // 家庭名称
            if (dataReader["Name"] != DBNull.Value)
                family.Name = Convert.ToString(dataReader["Name"]);
            // 户主
            if (dataReader["Owner"] != DBNull.Value)
                family.Owner = Convert.ToString(dataReader["Owner"]);
            // 家庭类型
            if (dataReader["FamilyType"] != DBNull.Value)
                family.FamilyType = Convert.ToInt32(dataReader["FamilyType"]);
            // 住房类型
            if (dataReader["HousingTypes"] != DBNull.Value)
                family.HousingTypes = Convert.ToInt32(dataReader["HousingTypes"]);
            // 家庭总人数
            if (dataReader["Total"] != DBNull.Value)
                family.Total = Convert.ToInt32(dataReader["Total"]);
            // 负责老人数
            if (dataReader["Old"] != DBNull.Value)
                family.Old = Convert.ToInt32(dataReader["Old"]);
            // 责任医生
            if (dataReader["ResponsibleDoctor"] != DBNull.Value)
                family.ResponsibleDoctor = Convert.ToString(dataReader["ResponsibleDoctor"]);
            // 创建日期
            if (dataReader["CreateDate"] != DBNull.Value)
                family.CreateDate = Convert.ToDateTime(dataReader["CreateDate"]);
            // 管理机构
            if (dataReader["ManageInstitutionsId"] != DBNull.Value)
            {
                Institutions temp = InstitutionsDAL.Instance.GetDataById(Convert.ToInt32(dataReader["ManageInstitutionsId"]));
                if (temp != null) family.ManageInstitutions = temp;
            }
            // 备注
            if (dataReader["Remark"] != DBNull.Value)
                family.Remark = Convert.ToString(dataReader["Remark"]);
        }


        /// <summary>
        /// 从DataReader中读取数据，并为Family对象需要进行显示的属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="family">家庭（Family）实例对象</param>
        protected void ReadFamilyPageData(IDataReader dataReader, Family family)
        {
            // 家庭档案号
            if (dataReader["Id"] != DBNull.Value)
                family.Id = Convert.ToInt32(dataReader["Id"]);
            // 家庭名称
            if (dataReader["Name"] != DBNull.Value)
                family.Name = Convert.ToString(dataReader["Name"]);
            // 户主
            if (dataReader["Owner"] != DBNull.Value)
                family.Owner = Convert.ToString(dataReader["Owner"]);
            // 家庭类型
            if (dataReader["FamilyType"] != DBNull.Value)
                family.FamilyType = Convert.ToInt32(dataReader["FamilyType"]);
            // 住房类型
            if (dataReader["HousingTypes"] != DBNull.Value)
                family.HousingTypes = Convert.ToInt32(dataReader["HousingTypes"]);
            // 家庭总人数
            if (dataReader["Total"] != DBNull.Value)
                family.Total = Convert.ToInt32(dataReader["Total"]);
            // 负责老人数
            if (dataReader["Old"] != DBNull.Value)
                family.Old = Convert.ToInt32(dataReader["Old"]);
            // 责任医生
            if (dataReader["ResponsibleDoctor"] != DBNull.Value)
                family.ResponsibleDoctor = Convert.ToString(dataReader["ResponsibleDoctor"]);
            // 创建日期
            if (dataReader["CreateDate"] != DBNull.Value)
                family.CreateDate = Convert.ToDateTime(dataReader["CreateDate"]);
        }


        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将家庭（Family）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="family">家庭（Family）实例对象</param>
        public abstract int Insert(Family family);


        /// <summary>
        /// 将家庭（Family）数据，根据主键“家庭档案号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="family">家庭（Family）实例对象</param>
        public abstract int Update(Family family);


        /// <summary>
        /// 根据家庭（Family）的主键“家庭档案号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">家庭（Family）的主键“家庭档案号（Id）”</param>
        public abstract int Delete(int id);


        /// <summary>
        /// 根据家庭（Family）的主键“家庭档案号（Id）”从数据库中获取家庭（Family）的实例。
        /// 成功从数据库中取得记录返回新家庭（Family）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">家庭（Family）的主键“家庭档案号（Id）”</param>
        public abstract Family GetDataById(int id);


        /// <summary>
        /// 从数据库中读取并返回所有家庭（Family）List列表。
        /// </summary>
        public abstract List<Family> GetAllList();


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的家庭（Family）的列表及分页信息。
        /// 该方法所获取的家庭（Family）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public abstract PageData GetPageList(int pageSize, int curPage);


        #endregion 多层框架式下的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
