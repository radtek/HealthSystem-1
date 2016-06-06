
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// 对象名称：高级体检表数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 17:12:40
    /// </summary>
    [Serializable]
    public class AdvancedExamination
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]检查编号</summary>
        private int? id;
        /// <summary>[变量]口腔</summary>
        private string oral;
        /// <summary>[变量]左眼视力</summary>
        private decimal? leftEye;
        /// <summary>[变量]右眼视力</summary>
        private decimal? rightEye;
        /// <summary>[变量]听力</summary>
        private string hearing;
        /// <summary>[变量]运动功能</summary>
        private string fMA;
        /// <summary>[变量]眼底</summary>
        private string fundus;
        /// <summary>[变量]皮肤</summary>
        private string skin;
        /// <summary>[变量]巩膜</summary>
        private string sclera;
        /// <summary>[变量]淋巴结</summary>
        private string lN;
        /// <summary>[变量]肺功能</summary>
        private string lung;
        /// <summary>[变量]心脏</summary>
        private string heart;
        /// <summary>[变量]腹部</summary>
        private string abdomen;
        /// <summary>[变量]下肢水肿</summary>
        private string lowerExtremityEdema;
        /// <summary>[变量]足背动脉搏动</summary>
        private string dPAP;
        /// <summary>[变量]肛门指诊</summary>
        private string dre;
        /// <summary>[变量]空腹血糖</summary>
        private string fBG;
        /// <summary>[变量]血常规</summary>
        private T_CBC cBC;
        /// <summary>[变量]尿常规</summary>
        private T_RoutineUrine routineUrine;
        /// <summary>[变量]尿微量蛋白</summary>
        private string u_MTB;
        /// <summary>[变量]肝功能</summary>
        private T_Liver liver;
        /// <summary>[变量]肾功能</summary>
        private T_Renal renal;
        /// <summary>[变量]血脂</summary>
        private T_TG tG;
        /// <summary>[变量]糖化血红蛋白</summary>
        private string gHb;
        /// <summary>[变量]乙型肝炎表面抗原</summary>
        private string hBsAG;
        /// <summary>[变量]心电图</summary>
        private string eCG;
        /// <summary>[变量]胸部Ｘ线片</summary>
        private string xRay;
        /// <summary>[变量]B超</summary>
        private string bUltrasonic;
        /// <summary>[变量]宫颈涂片</summary>
        private string cervicalSmear;
        /// <summary>[变量]其他</summary>
        private string other;
        /// <summary>[变量]体质</summary>
        private string physical;
        /// <summary>[变量]保健指导意见</summary>
        private string guidance;


        /// <summary>[属性]检查编号</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]口腔</summary>
        public string Oral
        {
            get { return oral; }
            set { oral = value; }
        }
        /// <summary>[属性]左眼视力</summary>
        public decimal? LeftEye
        {
            get { return leftEye; }
            set { leftEye = value; }
        }
        /// <summary>[属性]右眼视力</summary>
        public decimal? RightEye
        {
            get { return rightEye; }
            set { rightEye = value; }
        }
        /// <summary>[属性]听力</summary>
        public string Hearing
        {
            get { return hearing; }
            set { hearing = value; }
        }
        /// <summary>[属性]运动功能</summary>
        public string FMA
        {
            get { return fMA; }
            set { fMA = value; }
        }
        /// <summary>[属性]眼底</summary>
        public string Fundus
        {
            get { return fundus; }
            set { fundus = value; }
        }
        /// <summary>[属性]皮肤</summary>
        public string Skin
        {
            get { return skin; }
            set { skin = value; }
        }
        /// <summary>[属性]巩膜</summary>
        public string Sclera
        {
            get { return sclera; }
            set { sclera = value; }
        }
        /// <summary>[属性]淋巴结</summary>
        public string LN
        {
            get { return lN; }
            set { lN = value; }
        }
        /// <summary>[属性]肺功能</summary>
        public string Lung
        {
            get { return lung; }
            set { lung = value; }
        }
        /// <summary>[属性]心脏</summary>
        public string Heart
        {
            get { return heart; }
            set { heart = value; }
        }
        /// <summary>[属性]腹部</summary>
        public string Abdomen
        {
            get { return abdomen; }
            set { abdomen = value; }
        }
        /// <summary>[属性]下肢水肿</summary>
        public string LowerExtremityEdema
        {
            get { return lowerExtremityEdema; }
            set { lowerExtremityEdema = value; }
        }
        /// <summary>[属性]足背动脉搏动</summary>
        public string DPAP
        {
            get { return dPAP; }
            set { dPAP = value; }
        }
        /// <summary>[属性]肛门指诊</summary>
        public string Dre
        {
            get { return dre; }
            set { dre = value; }
        }
        /// <summary>[属性]空腹血糖</summary>
        public string FBG
        {
            get { return fBG; }
            set { fBG = value; }
        }
        /// <summary>[属性]血常规</summary>
        public T_CBC CBC
        {
            get { return cBC; }
            set { cBC = value; }
        }
        /// <summary>[属性]尿常规</summary>
        public T_RoutineUrine RoutineUrine
        {
            get { return routineUrine; }
            set { routineUrine = value; }
        }
        /// <summary>[属性]尿微量蛋白</summary>
        public string U_MTB
        {
            get { return u_MTB; }
            set { u_MTB = value; }
        }
        /// <summary>[属性]肝功能</summary>
        public T_Liver Liver
        {
            get { return liver; }
            set { liver = value; }
        }
        /// <summary>[属性]肾功能</summary>
        public T_Renal Renal
        {
            get { return renal; }
            set { renal = value; }
        }
        /// <summary>[属性]血脂</summary>
        public T_TG TG
        {
            get { return tG; }
            set { tG = value; }
        }
        /// <summary>[属性]糖化血红蛋白</summary>
        public string GHb
        {
            get { return gHb; }
            set { gHb = value; }
        }
        /// <summary>[属性]乙型肝炎表面抗原</summary>
        public string HBsAG
        {
            get { return hBsAG; }
            set { hBsAG = value; }
        }
        /// <summary>[属性]心电图</summary>
        public string ECG
        {
            get { return eCG; }
            set { eCG = value; }
        }
        /// <summary>[属性]胸部Ｘ线片</summary>
        public string XRay
        {
            get { return xRay; }
            set { xRay = value; }
        }
        /// <summary>[属性]B超</summary>
        public string BUltrasonic
        {
            get { return bUltrasonic; }
            set { bUltrasonic = value; }
        }
        /// <summary>[属性]宫颈涂片</summary>
        public string CervicalSmear
        {
            get { return cervicalSmear; }
            set { cervicalSmear = value; }
        }
        /// <summary>[属性]其他</summary>
        public string Other
        {
            get { return other; }
            set { other = value; }
        }
        /// <summary>[属性]体质</summary>
        public string Physical
        {
            get { return physical; }
            set { physical = value; }
        }
        /// <summary>[属性]保健指导意见</summary>
        public string Guidance
        {
            get { return guidance; }
            set { guidance = value; }
        }

        #endregion 多层框架式下的默认代码
    }
}
