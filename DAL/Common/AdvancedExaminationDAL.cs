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
    /// 对象名称：高级体检表通用数据访问父类（数据访问层）
    /// 对象说明：提供“高级体检表类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“高级体检表类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 17:12:40
    /// </summary>
    public abstract class AdvancedExaminationDAL
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“高级体检表（AdvancedExaminationDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static AdvancedExaminationDAL advancedExaminationDAL;


        /// <summary>
        /// 获取“高级体检表（AdvancedExaminationDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“高级体检表（AdvancedExaminationDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static AdvancedExaminationDAL Instance
        {
            get
            {
                if (advancedExaminationDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            advancedExaminationDAL = new SqlServer.AdvancedExaminationDAL();
                            break;

                        case "Oracle":
                            advancedExaminationDAL = new Oracle.AdvancedExaminationDAL();
                            break;

                        case "OleDb":
                            advancedExaminationDAL = new OleDb.AdvancedExaminationDAL();
                            break;

                        default:
                            advancedExaminationDAL = new SqlServer.AdvancedExaminationDAL();
                            break;
                    }
                }
                return advancedExaminationDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为AdvancedExamination对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="advancedExamination">高级体检表（AdvancedExamination）实例对象</param>
        protected void ReadAdvancedExaminationAllData(IDataReader dataReader, AdvancedExamination advancedExamination)
        {
            // 检查编号
            if (dataReader["Id"] != DBNull.Value)
                advancedExamination.Id = Convert.ToInt32(dataReader["Id"]);
            // 口腔
            if (dataReader["Oral"] != DBNull.Value)
                advancedExamination.Oral = Convert.ToString(dataReader["Oral"]);
            // 左眼视力
            if (dataReader["LeftEye"] != DBNull.Value)
                advancedExamination.LeftEye = Convert.ToDecimal(dataReader["LeftEye"]);
            // 右眼视力
            if (dataReader["RightEye"] != DBNull.Value)
                advancedExamination.RightEye = Convert.ToDecimal(dataReader["RightEye"]);
            // 听力
            if (dataReader["Hearing"] != DBNull.Value)
                advancedExamination.Hearing = Convert.ToString(dataReader["Hearing"]);
            // 运动功能
            if (dataReader["FMA"] != DBNull.Value)
                advancedExamination.FMA = Convert.ToString(dataReader["FMA"]);
            // 眼底
            if (dataReader["Fundus"] != DBNull.Value)
                advancedExamination.Fundus = Convert.ToString(dataReader["Fundus"]);
            // 皮肤
            if (dataReader["Skin"] != DBNull.Value)
                advancedExamination.Skin = Convert.ToString(dataReader["Skin"]);
            // 巩膜
            if (dataReader["Sclera"] != DBNull.Value)
                advancedExamination.Sclera = Convert.ToString(dataReader["Sclera"]);
            // 淋巴结
            if (dataReader["LN"] != DBNull.Value)
                advancedExamination.LN = Convert.ToString(dataReader["LN"]);
            // 肺功能
            if (dataReader["Lung"] != DBNull.Value)
                advancedExamination.Lung = Convert.ToString(dataReader["Lung"]);
            // 心脏
            if (dataReader["Heart"] != DBNull.Value)
                advancedExamination.Heart = Convert.ToString(dataReader["Heart"]);
            // 腹部
            if (dataReader["Abdomen"] != DBNull.Value)
                advancedExamination.Abdomen = Convert.ToString(dataReader["Abdomen"]);
            // 下肢水肿
            if (dataReader["LowerExtremityEdema"] != DBNull.Value)
                advancedExamination.LowerExtremityEdema = Convert.ToString(dataReader["LowerExtremityEdema"]);
            // 足背动脉搏动
            if (dataReader["DPAP"] != DBNull.Value)
                advancedExamination.DPAP = Convert.ToString(dataReader["DPAP"]);
            // 肛门指诊
            if (dataReader["Dre"] != DBNull.Value)
                advancedExamination.Dre = Convert.ToString(dataReader["Dre"]);
            // 空腹血糖
            if (dataReader["FBG"] != DBNull.Value)
                advancedExamination.FBG = Convert.ToString(dataReader["FBG"]);
            // 血常规
            if (dataReader["CBCId"] != DBNull.Value)
                //参照完整性捆绑子对象
                advancedExamination.CBC = T_CBC.GetDataById(Convert.ToInt32(dataReader["CBCId"])) ?? T_CBC.Empty;
            // 尿常规
            if (dataReader["RoutineUrineId"] != DBNull.Value)
                //参照完整性捆绑子对象
                advancedExamination.RoutineUrine = T_RoutineUrine.GetDataById(Convert.ToInt32(dataReader["RoutineUrineId"])) ?? T_RoutineUrine.Empty;
            // 尿微量蛋白
            if (dataReader["U_MTB"] != DBNull.Value)
                advancedExamination.U_MTB = Convert.ToString(dataReader["U_MTB"]);
            // 肝功能
            if (dataReader["LiverId"] != DBNull.Value)
                //参照完整性捆绑子对象
                advancedExamination.Liver = T_Liver.GetDataById(Convert.ToInt32(dataReader["LiverId"])) ?? T_Liver.Empty;
            // 肾功能
            if (dataReader["RenalId"] != DBNull.Value)
                //参照完整性捆绑子对象
                advancedExamination.Renal = T_Renal.GetDataById(Convert.ToInt32(dataReader["RenalId"])) ?? T_Renal.Empty;
            // 血脂 
            if (dataReader["TGId"] != DBNull.Value)
                //参照完整性捆绑子对象
                advancedExamination.TG = T_TG.GetDataById(Convert.ToInt32(dataReader["TGId"])) ?? T_TG.Empty;
            // 糖化血红蛋白
            if (dataReader["GHb"] != DBNull.Value)
                advancedExamination.GHb = Convert.ToString(dataReader["GHb"]);
            // 乙型肝炎表面抗原
            if (dataReader["HBsAG"] != DBNull.Value)
                advancedExamination.HBsAG = Convert.ToString(dataReader["HBsAG"]);
            // 心电图
            if (dataReader["ECG"] != DBNull.Value)
                advancedExamination.ECG = Convert.ToString(dataReader["ECG"]);
            // 胸部Ｘ线片
            if (dataReader["XRay"] != DBNull.Value)
                advancedExamination.XRay = Convert.ToString(dataReader["XRay"]);
            // B超
            if (dataReader["BUltrasonic"] != DBNull.Value)
                advancedExamination.BUltrasonic = Convert.ToString(dataReader["BUltrasonic"]);
            // 宫颈涂片
            if (dataReader["CervicalSmear"] != DBNull.Value)
                advancedExamination.CervicalSmear = Convert.ToString(dataReader["CervicalSmear"]);
            // 其他
            if (dataReader["Other"] != DBNull.Value)
                advancedExamination.Other = Convert.ToString(dataReader["Other"]);
            // 体质
            if (dataReader["Physical"] != DBNull.Value)
                advancedExamination.Physical = Convert.ToString(dataReader["Physical"]);
            // 保健指导意见
            if (dataReader["Guidance"] != DBNull.Value)
                advancedExamination.Guidance = Convert.ToString(dataReader["Guidance"]);
        }


        /// <summary>
        /// 从DataReader中读取数据，并为AdvancedExamination对象需要进行显示的属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="advancedExamination">高级体检表（AdvancedExamination）实例对象</param>
        protected void ReadAdvancedExaminationPageData(IDataReader dataReader, AdvancedExamination advancedExamination)
        {
            // 检查编号
            if (dataReader["Id"] != DBNull.Value)
                advancedExamination.Id = Convert.ToInt32(dataReader["Id"]);
            // 口腔
            if (dataReader["Oral"] != DBNull.Value)
                advancedExamination.Oral = Convert.ToString(dataReader["Oral"]);
            // 左眼视力
            if (dataReader["LeftEye"] != DBNull.Value)
                advancedExamination.LeftEye = Convert.ToDecimal(dataReader["LeftEye"]);
            // 右眼视力
            if (dataReader["RightEye"] != DBNull.Value)
                advancedExamination.RightEye = Convert.ToDecimal(dataReader["RightEye"]);
            // 听力
            if (dataReader["Hearing"] != DBNull.Value)
                advancedExamination.Hearing = Convert.ToString(dataReader["Hearing"]);
            // 保健指导意见
            if (dataReader["Guidance"] != DBNull.Value)
                advancedExamination.Guidance = Convert.ToString(dataReader["Guidance"]);
        }


        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将高级体检表（AdvancedExamination）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="advancedExamination">高级体检表（AdvancedExamination）实例对象</param>
        public abstract int Insert(AdvancedExamination advancedExamination);


        /// <summary>
        /// 将高级体检表（AdvancedExamination）数据，根据主键“检查编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="advancedExamination">高级体检表（AdvancedExamination）实例对象</param>
        public abstract int Update(AdvancedExamination advancedExamination);


        /// <summary>
        /// 根据高级体检表（AdvancedExamination）的主键“检查编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">高级体检表（AdvancedExamination）的主键“检查编号（Id）”</param>
        public abstract int Delete(int id);


        /// <summary>
        /// 根据高级体检表（AdvancedExamination）的主键“检查编号（Id）”从数据库中获取高级体检表（AdvancedExamination）的实例。
        /// 成功从数据库中取得记录返回新高级体检表（AdvancedExamination）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">高级体检表（AdvancedExamination）的主键“检查编号（Id）”</param>
        public abstract AdvancedExamination GetDataById(int id);


        /// <summary>
        /// 从数据库中读取并返回所有高级体检表（AdvancedExamination）List列表。
        /// </summary>
        public abstract List<AdvancedExamination> GetAllList();


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的高级体检表（AdvancedExamination）的列表及分页信息。
        /// 该方法所获取的高级体检表（AdvancedExamination）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public abstract PageData GetPageList(int pageSize, int curPage);


        #endregion 多层框架式下的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
