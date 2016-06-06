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
    /// 对象名称：基础体检表通用数据访问父类（数据访问层）
    /// 对象说明：提供“基础体检表类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“基础体检表类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 16:58:59
    /// </summary>
    public abstract class BasicExaminationDAL
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“基础体检表（BasicExaminationDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static BasicExaminationDAL basicExaminationDAL;


        /// <summary>
        /// 获取“基础体检表（BasicExaminationDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“基础体检表（BasicExaminationDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static BasicExaminationDAL Instance
        {
            get
            {
                if (basicExaminationDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            basicExaminationDAL = new SqlServer.BasicExaminationDAL();
                            break;

                        case "Oracle":
                            basicExaminationDAL = new Oracle.BasicExaminationDAL();
                            break;

                        case "OleDb":
                            basicExaminationDAL = new OleDb.BasicExaminationDAL();
                            break;

                        default:
                            basicExaminationDAL = new SqlServer.BasicExaminationDAL();
                            break;
                    }
                }
                return basicExaminationDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为BasicExamination对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="basicExamination">基础体检表（BasicExamination）实例对象</param>
        protected void ReadBasicExaminationAllData(IDataReader dataReader, BasicExamination basicExamination)
        {
            // 编号
            if (dataReader["Id"] != DBNull.Value)
                basicExamination.Id = Convert.ToInt32(dataReader["Id"]);
            // 居民号
            if (dataReader["ResidentId"] != DBNull.Value)
                basicExamination.ResidentId = Convert.ToString(dataReader["ResidentId"]);
            // 姓名
            if (dataReader["TheName"] != DBNull.Value)
                basicExamination.TheName = Convert.ToString(dataReader["TheName"]);
            // 体检编号
            if (dataReader["CheckID"] != DBNull.Value)
                basicExamination.CheckID = Convert.ToString(dataReader["CheckID"]);
            // 体检日期
            if (dataReader["CheckDate"] != DBNull.Value)
                basicExamination.CheckDate = Convert.ToString(dataReader["CheckDate"]);
            // 体检医生
            if (dataReader["Doctor"] != DBNull.Value)
                basicExamination.Doctor = Convert.ToString(dataReader["Doctor"]);
            // 症状
            if (dataReader["SymptomsId"] != DBNull.Value)
                basicExamination.Symptoms = T_Symptoms.GetDataById(Convert.ToInt32(dataReader["SymptomsId"])) ?? T_Symptoms.Empty;
            // 体温
            if (dataReader["Temperature"] != DBNull.Value)
                basicExamination.Temperature = Convert.ToDecimal(dataReader["Temperature"]);
            // 脉率
            if (dataReader["BPM"] != DBNull.Value)
                basicExamination.BPM = Convert.ToDecimal(dataReader["BPM"]);
            // 呼吸频率
            if (dataReader["RR"] != DBNull.Value)
                basicExamination.RR = Convert.ToDecimal(dataReader["RR"]);
            // 血压
            if (dataReader["BP"] != DBNull.Value)
                basicExamination.BP = Convert.ToDecimal(dataReader["BP"]);
            // 身高
            if (dataReader["Height"] != DBNull.Value)
                basicExamination.Height = Convert.ToDecimal(dataReader["Height"]);
            // 体重
            if (dataReader["Weight"] != DBNull.Value)
                basicExamination.Weight = Convert.ToDecimal(dataReader["Weight"]);
            // 腰围
            if (dataReader["Waist"] != DBNull.Value)
                basicExamination.Waist = Convert.ToDecimal(dataReader["Waist"]);
            // 体质指数
            if (dataReader["BMI"] != DBNull.Value)
                basicExamination.BMI = Convert.ToDecimal(dataReader["BMI"]);
            // 体育锻炼
            if (dataReader["PhysicalExercise"] != DBNull.Value)
                basicExamination.PhysicalExercise = Convert.ToString(dataReader["PhysicalExercise"]);
            // 饮食习惯
            if (dataReader["EatingHabitsId"] != DBNull.Value)
                basicExamination.EatingHabits = T_EatingHabits.GetDataById(Convert.ToInt32(dataReader["EatingHabitsId"])) ?? T_EatingHabits.Empty;
            // 吸烟情况
            if (dataReader["Smoking"] != DBNull.Value)
                basicExamination.Smoking = Convert.ToString(dataReader["Smoking"]);
            // 饮酒情况
            if (dataReader["Drinking"] != DBNull.Value)
                basicExamination.Drinking = Convert.ToString(dataReader["Drinking"]);
            // 职业暴露情况
            if (dataReader["OccupationalExposure"] != DBNull.Value)
                basicExamination.OccupationalExposure = Convert.ToString(dataReader["OccupationalExposure"]);
        }


        /// <summary>
        /// 从DataReader中读取数据，并为BasicExamination对象需要进行显示的属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="basicExamination">基础体检表（BasicExamination）实例对象</param>
        protected void ReadBasicExaminationPageData(IDataReader dataReader, BasicExamination basicExamination)
        {
            // 编号
            if (dataReader["Id"] != DBNull.Value)
                basicExamination.Id = Convert.ToInt32(dataReader["Id"]);
            // 居民号
            if (dataReader["ResidentId"] != DBNull.Value)
                basicExamination.ResidentId = Convert.ToString(dataReader["ResidentId"]);
            // 姓名
            if (dataReader["TheName"] != DBNull.Value)
                basicExamination.TheName = Convert.ToString(dataReader["TheName"]);
            // 体检编号
            if (dataReader["CheckID"] != DBNull.Value)
                basicExamination.CheckID = Convert.ToString(dataReader["CheckID"]);
            // 体检日期
            if (dataReader["CheckDate"] != DBNull.Value)
                basicExamination.CheckDate = Convert.ToString(dataReader["CheckDate"]);
            // 体检医生
            if (dataReader["Doctor"] != DBNull.Value)
                basicExamination.Doctor = Convert.ToString(dataReader["Doctor"]);
            // 症状
            if (dataReader["SymptomsId"] != DBNull.Value)
                //参照完整性捆绑对象
                basicExamination.Symptoms = T_Symptoms.GetDataById(Convert.ToInt32(dataReader["SymptomsId"])) ?? T_Symptoms.Empty;
        }


        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将基础体检表（BasicExamination）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="basicExamination">基础体检表（BasicExamination）实例对象</param>
        public abstract int Insert(BasicExamination basicExamination);


        /// <summary>
        /// 将基础体检表（BasicExamination）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="basicExamination">基础体检表（BasicExamination）实例对象</param>
        public abstract int Update(BasicExamination basicExamination);


        /// <summary>
        /// 根据基础体检表（BasicExamination）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">基础体检表（BasicExamination）的主键“编号（Id）”</param>
        public abstract int Delete(int id);


        /// <summary>
        /// 根据基础体检表（BasicExamination）的主键“编号（Id）”从数据库中获取基础体检表（BasicExamination）的实例。
        /// 成功从数据库中取得记录返回新基础体检表（BasicExamination）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">基础体检表（BasicExamination）的主键“编号（Id）”</param>
        public abstract BasicExamination GetDataById(int id);


        /// <summary>
        /// 从数据库中读取并返回所有基础体检表（BasicExamination）List列表。
        /// </summary>
        public abstract List<BasicExamination> GetAllList();


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的基础体检表（BasicExamination）的列表及分页信息。
        /// 该方法所获取的基础体检表（BasicExamination）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public abstract PageData GetPageList(int pageSize, int curPage);


        #endregion 多层框架式下的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍

        /// <summary>
        /// 根据基础对象名称（BasicExamination）的字段“TheName（TheName）”从数据库中获取基础对象名称（BasicExamination）的实例。
        /// 成功从数据库中取得记录返回新基础对象名称（BasicExamination）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="theName">基础对象名称（BasicExamination）的字段“TheName（TheName）”</param>

        public abstract List<BasicExamination> GetDataByTheName(string theName);






    }
}
