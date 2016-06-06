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
    /// 对象名称：居民疾病信息通用数据访问父类（数据访问层）
    /// 对象说明：提供“居民疾病信息类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“居民疾病信息类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-7 17:24:34
    /// </summary>
    public abstract class ResidentDiseaseInfoDAL
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“居民疾病信息（ResidentDiseaseInfoDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static ResidentDiseaseInfoDAL residentDiseaseInfoDAL;


        /// <summary>
        /// 获取“居民疾病信息（ResidentDiseaseInfoDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“居民疾病信息（ResidentDiseaseInfoDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static ResidentDiseaseInfoDAL Instance
        {
            get
            {
                if (residentDiseaseInfoDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            residentDiseaseInfoDAL = new SqlServer.ResidentDiseaseInfoDAL();
                            break;

                        case "Oracle":
                            residentDiseaseInfoDAL = new Oracle.ResidentDiseaseInfoDAL();
                            break;

                        case "OleDb":
                            residentDiseaseInfoDAL = new OleDb.ResidentDiseaseInfoDAL();
                            break;

                        default:
                            residentDiseaseInfoDAL = new SqlServer.ResidentDiseaseInfoDAL();
                            break;
                    }
                }
                return residentDiseaseInfoDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为ResidentDiseaseInfo对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="residentDiseaseInfo">居民疾病信息（ResidentDiseaseInfo）实例对象</param>
        protected void ReadResidentDiseaseInfoAllData(IDataReader dataReader, ResidentDiseaseInfo residentDiseaseInfo)
        {
            // 居民内部编号
            if (dataReader["Id"] != DBNull.Value)
                residentDiseaseInfo.Id = Convert.ToString(dataReader["Id"]);
            // 药物过敏史
            if (dataReader["HODA"] != DBNull.Value)
                residentDiseaseInfo.HODA = Convert.ToString(dataReader["HODA"]);
            // 暴露史
            if (dataReader["EH"] != DBNull.Value)
                residentDiseaseInfo.EH = Convert.ToString(dataReader["EH"]);
            // 高血压
            if (dataReader["HBP"] != DBNull.Value)
                residentDiseaseInfo.HBP = Convert.ToString(dataReader["HBP"]);
            // 高血压确诊时间
            if (dataReader["HBPTime"] != DBNull.Value)
                residentDiseaseInfo.HBPTime = Convert.ToDateTime(dataReader["HBPTime"]);
            // 糖尿病
            if (dataReader["GDM"] != DBNull.Value)
                residentDiseaseInfo.GDM = Convert.ToString(dataReader["GDM"]);
            // 糖尿病确诊时间
            if (dataReader["GDMTime"] != DBNull.Value)
                residentDiseaseInfo.GDMTime = Convert.ToDateTime(dataReader["GDMTime"]);
            // 冠心病
            if (dataReader["CH"] != DBNull.Value)
                residentDiseaseInfo.CH = Convert.ToString(dataReader["CH"]);
            // 冠心病确诊时间
            if (dataReader["CHTime"] != DBNull.Value)
                residentDiseaseInfo.CHTime = Convert.ToDateTime(dataReader["CHTime"]);
            // 慢性阻塞性肺疾病
            if (dataReader["COP"] != DBNull.Value)
                residentDiseaseInfo.COP = Convert.ToString(dataReader["COP"]);
            // 慢性阻塞性肺疾病确诊时间
            if (dataReader["COPTime"] != DBNull.Value)
                residentDiseaseInfo.COPTime = Convert.ToDateTime(dataReader["COPTime"]);
            // 恶性肿瘤
            if (dataReader["MTC"] != DBNull.Value)
                residentDiseaseInfo.MTC = Convert.ToString(dataReader["MTC"]);
            // 恶性肿瘤确诊时间
            if (dataReader["MTCTime"] != DBNull.Value)
                residentDiseaseInfo.MTCTime = Convert.ToDateTime(dataReader["MTCTime"]);
            // 脑卒中
            if (dataReader["Stroke"] != DBNull.Value)
                residentDiseaseInfo.Stroke = Convert.ToString(dataReader["Stroke"]);
            // 脑卒中确诊时间
            if (dataReader["StrokeTime"] != DBNull.Value)
                residentDiseaseInfo.StrokeTime = Convert.ToDateTime(dataReader["StrokeTime"]);
            // 重性精神
            if (dataReader["SMI"] != DBNull.Value)
                residentDiseaseInfo.SMI = Convert.ToString(dataReader["SMI"]);
            // 重性精神疾病确诊时间
            if (dataReader["SMITime"] != DBNull.Value)
                residentDiseaseInfo.SMITime = Convert.ToDateTime(dataReader["SMITime"]);
            // 结核病
            if (dataReader["TB"] != DBNull.Value)
                residentDiseaseInfo.TB = Convert.ToString(dataReader["TB"]);
            // 结核病确诊时间
            if (dataReader["TBTime"] != DBNull.Value)
                residentDiseaseInfo.TBTime = Convert.ToDateTime(dataReader["TBTime"]);
            // 肝炎
            if (dataReader["Hepatitis"] != DBNull.Value)
                residentDiseaseInfo.Hepatitis = Convert.ToString(dataReader["Hepatitis"]);
            // 肝炎确诊时间
            if (dataReader["HepatitisTime"] != DBNull.Value)
                residentDiseaseInfo.HepatitisTime = Convert.ToDateTime(dataReader["HepatitisTime"]);
            // 其他法定传染病
            if (dataReader["OLID"] != DBNull.Value)
                residentDiseaseInfo.OLID = Convert.ToString(dataReader["OLID"]);
            // 其他法定传染病确诊时间
            if (dataReader["OLIDTime"] != DBNull.Value)
                residentDiseaseInfo.OLIDTime = Convert.ToDateTime(dataReader["OLIDTime"]);
            // 职业病
            if (dataReader["OD"] != DBNull.Value)
                residentDiseaseInfo.OD = Convert.ToString(dataReader["OD"]);
            // 职业病确诊时间
            if (dataReader["ODTime"] != DBNull.Value)
                residentDiseaseInfo.ODTime = Convert.ToDateTime(dataReader["ODTime"]);
            // 其他
            if (dataReader["Other"] != DBNull.Value)
                residentDiseaseInfo.Other = Convert.ToString(dataReader["Other"]);
            // 其他确诊时间
            if (dataReader["OtherTime"] != DBNull.Value)
                residentDiseaseInfo.OtherTime = Convert.ToDateTime(dataReader["OtherTime"]);
            // 父亲病史
            if (dataReader["HistoryOfFather"] != DBNull.Value)
                residentDiseaseInfo.HistoryOfFather = Convert.ToString(dataReader["HistoryOfFather"]);
            // 母亲病史
            if (dataReader["HistoryOfMother"] != DBNull.Value)
                residentDiseaseInfo.HistoryOfMother = Convert.ToString(dataReader["HistoryOfMother"]);
            // 兄弟姐妹病史
            if (dataReader["HistoryOfBrothers"] != DBNull.Value)
                residentDiseaseInfo.HistoryOfBrothers = Convert.ToString(dataReader["HistoryOfBrothers"]);
            // 子女病史
            if (dataReader["HistoryOfChildren"] != DBNull.Value)
                residentDiseaseInfo.HistoryOfChildren = Convert.ToString(dataReader["HistoryOfChildren"]);
            // 遗传病史
            if (dataReader["GeneticHistory"] != DBNull.Value)
                residentDiseaseInfo.GeneticHistory = Convert.ToString(dataReader["GeneticHistory"]);
            // 残疾情况
            if (dataReader["Disability"] != DBNull.Value)
                residentDiseaseInfo.Disability = Convert.ToString(dataReader["Disability"]);
            // 备注
            if (dataReader["Remarks"] != DBNull.Value)
                residentDiseaseInfo.Remarks = Convert.ToString(dataReader["Remarks"]);
        }


        /// <summary>
        /// 从DataReader中读取数据，并为ResidentDiseaseInfo对象需要进行显示的属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="residentDiseaseInfo">居民疾病信息（ResidentDiseaseInfo）实例对象</param>
        protected void ReadResidentDiseaseInfoPageData(IDataReader dataReader, ResidentDiseaseInfo residentDiseaseInfo)
        {
            // 居民内部编号
            if (dataReader["Id"] != DBNull.Value)
                residentDiseaseInfo.Id = Convert.ToString(dataReader["Id"]);
            // 药物过敏史
            if (dataReader["HODA"] != DBNull.Value)
                residentDiseaseInfo.HODA = Convert.ToString(dataReader["HODA"]);
            // 暴露史
            if (dataReader["EH"] != DBNull.Value)
                residentDiseaseInfo.EH = Convert.ToString(dataReader["EH"]);
            // 残疾情况
            if (dataReader["Disability"] != DBNull.Value)
                residentDiseaseInfo.Disability = Convert.ToString(dataReader["Disability"]);
            // 备注
            if (dataReader["Remarks"] != DBNull.Value)
                residentDiseaseInfo.Remarks = Convert.ToString(dataReader["Remarks"]);
        }


        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将居民疾病信息（ResidentDiseaseInfo）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="residentDiseaseInfo">居民疾病信息（ResidentDiseaseInfo）实例对象</param>
        public abstract int Insert(ResidentDiseaseInfo residentDiseaseInfo);


        /// <summary>
        /// 将居民疾病信息（ResidentDiseaseInfo）数据，根据主键“居民内部编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="residentDiseaseInfo">居民疾病信息（ResidentDiseaseInfo）实例对象</param>
        public abstract int Update(ResidentDiseaseInfo residentDiseaseInfo);


        /// <summary>
        /// 根据居民疾病信息（ResidentDiseaseInfo）的主键“居民内部编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">居民疾病信息（ResidentDiseaseInfo）的主键“居民内部编号（Id）”</param>
        public abstract int Delete(string id);


        /// <summary>
        /// 根据居民疾病信息（ResidentDiseaseInfo）的主键“居民内部编号（Id）”从数据库中获取居民疾病信息（ResidentDiseaseInfo）的实例。
        /// 成功从数据库中取得记录返回新居民疾病信息（ResidentDiseaseInfo）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">居民疾病信息（ResidentDiseaseInfo）的主键“居民内部编号（Id）”</param>
        public abstract ResidentDiseaseInfo GetDataById(string id);


        /// <summary>
        /// 从数据库中读取并返回所有居民疾病信息（ResidentDiseaseInfo）List列表。
        /// </summary>
        public abstract List<ResidentDiseaseInfo> GetAllList();


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的居民疾病信息（ResidentDiseaseInfo）的列表及分页信息。
        /// 该方法所获取的居民疾病信息（ResidentDiseaseInfo）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public abstract PageData GetPageList(int pageSize, int curPage);


        #endregion 多层框架式下的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
