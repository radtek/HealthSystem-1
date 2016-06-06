using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// 对象名称：居民疾病信息数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-7 17:24:34
    /// </summary>
    [Serializable]
    public class ResidentDiseaseInfo
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]居民内部编号</summary>
        private string id;
        /// <summary>[变量]药物过敏史</summary>
        private string hODA;
        /// <summary>[变量]暴露史</summary>
        private string eH;
        /// <summary>[变量]高血压</summary>
        private string hBP;
        /// <summary>[变量]高血压确诊时间</summary>
        private DateTime? hBPTime;
        /// <summary>[变量]糖尿病</summary>
        private string gDM;
        /// <summary>[变量]糖尿病确诊时间</summary>
        private DateTime? gDMTime;
        /// <summary>[变量]冠心病</summary>
        private string cH;
        /// <summary>[变量]冠心病确诊时间</summary>
        private DateTime? cHTime;
        /// <summary>[变量]慢性阻塞性肺疾病</summary>
        private string cOP;
        /// <summary>[变量]慢性阻塞性肺疾病确诊时间</summary>
        private DateTime? cOPTime;
        /// <summary>[变量]恶性肿瘤</summary>
        private string mTC;
        /// <summary>[变量]恶性肿瘤确诊时间</summary>
        private DateTime? mTCTime;
        /// <summary>[变量]脑卒中</summary>
        private string stroke;
        /// <summary>[变量]脑卒中确诊时间</summary>
        private DateTime? strokeTime;
        /// <summary>[变量]重性精神</summary>
        private string sMI;
        /// <summary>[变量]重性精神疾病确诊时间</summary>
        private DateTime? sMITime;
        /// <summary>[变量]结核病</summary>
        private string tB;
        /// <summary>[变量]结核病确诊时间</summary>
        private DateTime? tBTime;
        /// <summary>[变量]肝炎</summary>
        private string hepatitis;
        /// <summary>[变量]肝炎确诊时间</summary>
        private DateTime? hepatitisTime;
        /// <summary>[变量]其他法定传染病</summary>
        private string oLID;
        /// <summary>[变量]其他法定传染病确诊时间</summary>
        private DateTime? oLIDTime;
        /// <summary>[变量]职业病</summary>
        private string oD;
        /// <summary>[变量]职业病确诊时间</summary>
        private DateTime? oDTime;
        /// <summary>[变量]其他</summary>
        private string other;
        /// <summary>[变量]其他确诊时间</summary>
        private DateTime? otherTime;
        /// <summary>[变量]父亲病史</summary>
        private string historyOfFather;
        /// <summary>[变量]母亲病史</summary>
        private string historyOfMother;
        /// <summary>[变量]兄弟姐妹病史</summary>
        private string historyOfBrothers;
        /// <summary>[变量]子女病史</summary>
        private string historyOfChildren;
        /// <summary>[变量]遗传病史</summary>
        private string geneticHistory;
        /// <summary>[变量]残疾情况</summary>
        private string disability;
        /// <summary>[变量]备注</summary>
        private string remarks;


        /// <summary>[属性]居民内部编号</summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]药物过敏史</summary>
        public string HODA
        {
            get { return hODA; }
            set { hODA = value; }
        }
        /// <summary>[属性]暴露史</summary>
        public string EH
        {
            get { return eH; }
            set { eH = value; }
        }
        /// <summary>[属性]高血压</summary>
        public string HBP
        {
            get { return hBP; }
            set { hBP = value; }
        }
        /// <summary>[属性]高血压确诊时间</summary>
        public DateTime? HBPTime
        {
            get { return hBPTime; }
            set { hBPTime = value; }
        }
        /// <summary>[属性]糖尿病</summary>
        public string GDM
        {
            get { return gDM; }
            set { gDM = value; }
        }
        /// <summary>[属性]糖尿病确诊时间</summary>
        public DateTime? GDMTime
        {
            get { return gDMTime; }
            set { gDMTime = value; }
        }
        /// <summary>[属性]冠心病</summary>
        public string CH
        {
            get { return cH; }
            set { cH = value; }
        }
        /// <summary>[属性]冠心病确诊时间</summary>
        public DateTime? CHTime
        {
            get { return cHTime; }
            set { cHTime = value; }
        }
        /// <summary>[属性]慢性阻塞性肺疾病</summary>
        public string COP
        {
            get { return cOP; }
            set { cOP = value; }
        }
        /// <summary>[属性]慢性阻塞性肺疾病确诊时间</summary>
        public DateTime? COPTime
        {
            get { return cOPTime; }
            set { cOPTime = value; }
        }
        /// <summary>[属性]恶性肿瘤</summary>
        public string MTC
        {
            get { return mTC; }
            set { mTC = value; }
        }
        /// <summary>[属性]恶性肿瘤确诊时间</summary>
        public DateTime? MTCTime
        {
            get { return mTCTime; }
            set { mTCTime = value; }
        }
        /// <summary>[属性]脑卒中</summary>
        public string Stroke
        {
            get { return stroke; }
            set { stroke = value; }
        }
        /// <summary>[属性]脑卒中确诊时间</summary>
        public DateTime? StrokeTime
        {
            get { return strokeTime; }
            set { strokeTime = value; }
        }
        /// <summary>[属性]重性精神</summary>
        public string SMI
        {
            get { return sMI; }
            set { sMI = value; }
        }
        /// <summary>[属性]重性精神疾病确诊时间</summary>
        public DateTime? SMITime
        {
            get { return sMITime; }
            set { sMITime = value; }
        }
        /// <summary>[属性]结核病</summary>
        public string TB
        {
            get { return tB; }
            set { tB = value; }
        }
        /// <summary>[属性]结核病确诊时间</summary>
        public DateTime? TBTime
        {
            get { return tBTime; }
            set { tBTime = value; }
        }
        /// <summary>[属性]肝炎</summary>
        public string Hepatitis
        {
            get { return hepatitis; }
            set { hepatitis = value; }
        }
        /// <summary>[属性]肝炎确诊时间</summary>
        public DateTime? HepatitisTime
        {
            get { return hepatitisTime; }
            set { hepatitisTime = value; }
        }
        /// <summary>[属性]其他法定传染病</summary>
        public string OLID
        {
            get { return oLID; }
            set { oLID = value; }
        }
        /// <summary>[属性]其他法定传染病确诊时间</summary>
        public DateTime? OLIDTime
        {
            get { return oLIDTime; }
            set { oLIDTime = value; }
        }
        /// <summary>[属性]职业病</summary>
        public string OD
        {
            get { return oD; }
            set { oD = value; }
        }
        /// <summary>[属性]职业病确诊时间</summary>
        public DateTime? ODTime
        {
            get { return oDTime; }
            set { oDTime = value; }
        }
        /// <summary>[属性]其他</summary>
        public string Other
        {
            get { return other; }
            set { other = value; }
        }
        /// <summary>[属性]其他确诊时间</summary>
        public DateTime? OtherTime
        {
            get { return otherTime; }
            set { otherTime = value; }
        }
        /// <summary>[属性]父亲病史</summary>
        public string HistoryOfFather
        {
            get { return historyOfFather; }
            set { historyOfFather = value; }
        }
        /// <summary>[属性]母亲病史</summary>
        public string HistoryOfMother
        {
            get { return historyOfMother; }
            set { historyOfMother = value; }
        }
        /// <summary>[属性]兄弟姐妹病史</summary>
        public string HistoryOfBrothers
        {
            get { return historyOfBrothers; }
            set { historyOfBrothers = value; }
        }
        /// <summary>[属性]子女病史</summary>
        public string HistoryOfChildren
        {
            get { return historyOfChildren; }
            set { historyOfChildren = value; }
        }
        /// <summary>[属性]遗传病史</summary>
        public string GeneticHistory
        {
            get { return geneticHistory; }
            set { geneticHistory = value; }
        }
        /// <summary>[属性]残疾情况</summary>
        public string Disability
        {
            get { return disability; }
            set { disability = value; }
        }
        /// <summary>[属性]备注</summary>
        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }

        #endregion 多层框架式下的默认代码
    }
}
