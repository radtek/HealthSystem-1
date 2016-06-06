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
    /// 对象名称：现存健康问题表通用数据访问父类（数据访问层）
    /// 对象说明：提供“现存健康问题表类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“现存健康问题表类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 17:01:17
    /// </summary>
    public abstract class MajorProblemsDAL
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“现存健康问题表（MajorProblemsDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static MajorProblemsDAL majorProblemsDAL;


        /// <summary>
        /// 获取“现存健康问题表（MajorProblemsDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“现存健康问题表（MajorProblemsDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static MajorProblemsDAL Instance
        {
            get
            {
                if (majorProblemsDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            majorProblemsDAL = new SqlServer.MajorProblemsDAL();
                            break;

                        case "Oracle":
                            majorProblemsDAL = new Oracle.MajorProblemsDAL();
                            break;

                        case "OleDb":
                            majorProblemsDAL = new OleDb.MajorProblemsDAL();
                            break;

                        default:
                            majorProblemsDAL = new SqlServer.MajorProblemsDAL();
                            break;
                    }
                }
                return majorProblemsDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为MajorProblems对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="majorProblems">现存健康问题表（MajorProblems）实例对象</param>
        protected void ReadMajorProblemsAllData(IDataReader dataReader, MajorProblems majorProblems)
        {
            // 体检编号
            if (dataReader["CheckId"] != DBNull.Value)
                majorProblems.CheckId = Convert.ToInt32(dataReader["CheckId"]);
            // 脑血管疾病
            if (dataReader["CerebrovascularDiseaseId"] != DBNull.Value)
                //参照完整性捆绑子对象
                majorProblems.CerebrovascularDisease = T_CerebrovascularDisease.GetDataById(Convert.ToInt32(dataReader["CerebrovascularDiseaseId"])) ?? T_CerebrovascularDisease.Empty;
            // 肾脏疾病
            if (dataReader["KidneyDiseaseId"] != DBNull.Value)
                //参照完整性捆绑子对象
                majorProblems.KidneyDisease = T_KidneyDisease.GetDataById(Convert.ToInt32(dataReader["KidneyDiseaseId"])) ?? T_KidneyDisease.Empty;
            // 心脏疾病
            if (dataReader["HeartDiseaseId"] != DBNull.Value)
                //参照完整性捆绑子对象
                majorProblems.HeartDisease = T_HeartDisease.GetDataById(Convert.ToInt32(dataReader["HeartDiseaseId"])) ?? T_HeartDisease.Empty;
            // 血管疾病
            if (dataReader["VascularDiseaseId"] != DBNull.Value)
                //参照完整性捆绑子对象
                majorProblems.VascularDisease = T_VascularDisease.GetDataById(Convert.ToInt32(dataReader["VascularDiseaseId"])) ?? T_VascularDisease.Empty;
            // 眼部疾病
            if (dataReader["EyeDiseaseId"] != DBNull.Value)
                //参照完整性捆绑子对象
                majorProblems.EyeDisease = T_EyeDisease.GetDataById(Convert.ToInt32(dataReader["EyeDiseaseId"])) ?? T_EyeDisease.Empty;
            // 神经系统疾病
            if (dataReader["DiseasesOfTheNervousSystem"] != DBNull.Value)
                majorProblems.DiseasesOfTheNervousSystem = Convert.ToString(dataReader["DiseasesOfTheNervousSystem"]);
            // 其他系统疾病
            if (dataReader["OtherSystemDiseases"] != DBNull.Value)
                majorProblems.OtherSystemDiseases = Convert.ToString(dataReader["OtherSystemDiseases"]);
            // 住院治疗情况
            if (dataReader["HospitalizationIs"] != DBNull.Value)
                majorProblems.HospitalizationIs = Convert.ToString(dataReader["HospitalizationIs"]);
            // 主要用药情况
            if (dataReader["MainMedications"] != DBNull.Value)
                majorProblems.MainMedications = Convert.ToString(dataReader["MainMedications"]);
            // 非免疫规划预防接种史
            if (dataReader["IPVHistory"] != DBNull.Value)
                majorProblems.IPVHistory = Convert.ToString(dataReader["IPVHistory"]);
            // 健康评价
            if (dataReader["HealthAssessment"] != DBNull.Value)
                majorProblems.HealthAssessment = Convert.ToString(dataReader["HealthAssessment"]);
            // 健康指导
            if (dataReader["Guidance"] != DBNull.Value)
                majorProblems.Guidance = Convert.ToString(dataReader["Guidance"]);
            // 危险因素控制建议
            if (dataReader["RiskControlSuggestions"] != DBNull.Value)
                majorProblems.RiskControlSuggestions = Convert.ToString(dataReader["RiskControlSuggestions"]);
        }


        /// <summary>
        /// 从DataReader中读取数据，并为MajorProblems对象需要进行显示的属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="majorProblems">现存健康问题表（MajorProblems）实例对象</param>
        protected void ReadMajorProblemsPageData(IDataReader dataReader, MajorProblems majorProblems)
        {
            // 体检编号
            if (dataReader["CheckId"] != DBNull.Value)
                majorProblems.CheckId = Convert.ToInt32(dataReader["CheckId"]);
            // 健康评价
            if (dataReader["HealthAssessment"] != DBNull.Value)
                majorProblems.HealthAssessment = Convert.ToString(dataReader["HealthAssessment"]);
            // 危险因素控制建议
            if (dataReader["RiskControlSuggestions"] != DBNull.Value)
                majorProblems.RiskControlSuggestions = Convert.ToString(dataReader["RiskControlSuggestions"]);
        }


        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将现存健康问题表（MajorProblems）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="majorProblems">现存健康问题表（MajorProblems）实例对象</param>
        public abstract int Insert(MajorProblems majorProblems);


        /// <summary>
        /// 将现存健康问题表（MajorProblems）数据，根据主键“体检编号（CheckId）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="majorProblems">现存健康问题表（MajorProblems）实例对象</param>
        public abstract int Update(MajorProblems majorProblems);


        /// <summary>
        /// 根据现存健康问题表（MajorProblems）的主键“体检编号（CheckId）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="checkId">现存健康问题表（MajorProblems）的主键“体检编号（CheckId）”</param>
        public abstract int Delete(int checkId);


        /// <summary>
        /// 根据现存健康问题表（MajorProblems）的主键“体检编号（CheckId）”从数据库中获取现存健康问题表（MajorProblems）的实例。
        /// 成功从数据库中取得记录返回新现存健康问题表（MajorProblems）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="checkId">现存健康问题表（MajorProblems）的主键“体检编号（CheckId）”</param>
        public abstract MajorProblems GetDataByCheckId(int checkId);


        /// <summary>
        /// 从数据库中读取并返回所有现存健康问题表（MajorProblems）List列表。
        /// </summary>
        public abstract List<MajorProblems> GetAllList();


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的现存健康问题表（MajorProblems）的列表及分页信息。
        /// 该方法所获取的现存健康问题表（MajorProblems）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public abstract PageData GetPageList(int pageSize, int curPage);


        #endregion 多层框架式下的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
