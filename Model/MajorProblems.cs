using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// 对象名称：现存健康问题表数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 17:01:17
    /// </summary>
    [Serializable]
    public class MajorProblems
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]体检编号</summary>
        private int? checkId;
        /// <summary>[变量]脑血管疾病</summary>
        private T_CerebrovascularDisease cerebrovascularDisease;
        /// <summary>[变量]肾脏疾病</summary>
        private T_KidneyDisease kidneyDisease;
        /// <summary>[变量]心脏疾病</summary>
        private T_HeartDisease heartDisease;
        /// <summary>[变量]血管疾病</summary>
        private T_VascularDisease vascularDisease;
        /// <summary>[变量]眼部疾病</summary>
        private T_EyeDisease eyeDisease;
        /// <summary>[变量]神经系统疾病</summary>
        private string diseasesOfTheNervousSystem;
        /// <summary>[变量]其他系统疾病</summary>
        private string otherSystemDiseases;
        /// <summary>[变量]住院治疗情况</summary>
        private string hospitalizationIs;
        /// <summary>[变量]主要用药情况</summary>
        private string mainMedications;
        /// <summary>[变量]非免疫规划预防接种史</summary>
        private string iPVHistory;
        /// <summary>[变量]健康评价</summary>
        private string healthAssessment;
        /// <summary>[变量]健康指导</summary>
        private string guidance;
        /// <summary>[变量]危险因素控制建议</summary>
        private string riskControlSuggestions;


        /// <summary>[属性]体检编号</summary>
        public int? CheckId
        {
            get { return checkId; }
            set { checkId = value; }
        }
        /// <summary>[属性]脑血管疾病</summary>
        public T_CerebrovascularDisease CerebrovascularDisease
        {
            get { return cerebrovascularDisease; }
            set { cerebrovascularDisease = value; }
        }
        /// <summary>[属性]肾脏疾病</summary>
        public T_KidneyDisease KidneyDisease
        {
            get { return kidneyDisease; }
            set { kidneyDisease = value; }
        }
        /// <summary>[属性]心脏疾病</summary>
        public T_HeartDisease HeartDisease
        {
            get { return heartDisease; }
            set { heartDisease = value; }
        }
        /// <summary>[属性]血管疾病</summary>
        public T_VascularDisease VascularDisease
        {
            get { return vascularDisease; }
            set { vascularDisease = value; }
        }
        /// <summary>[属性]眼部疾病</summary>
        public T_EyeDisease EyeDisease
        {
            get { return eyeDisease; }
            set { eyeDisease = value; }
        }
        /// <summary>[属性]神经系统疾病</summary>
        public string DiseasesOfTheNervousSystem
        {
            get { return diseasesOfTheNervousSystem; }
            set { diseasesOfTheNervousSystem = value; }
        }
        /// <summary>[属性]其他系统疾病</summary>
        public string OtherSystemDiseases
        {
            get { return otherSystemDiseases; }
            set { otherSystemDiseases = value; }
        }
        /// <summary>[属性]住院治疗情况</summary>
        public string HospitalizationIs
        {
            get { return hospitalizationIs; }
            set { hospitalizationIs = value; }
        }
        /// <summary>[属性]主要用药情况</summary>
        public string MainMedications
        {
            get { return mainMedications; }
            set { mainMedications = value; }
        }
        /// <summary>[属性]非免疫规划预防接种史</summary>
        public string IPVHistory
        {
            get { return iPVHistory; }
            set { iPVHistory = value; }
        }
        /// <summary>[属性]健康评价</summary>
        public string HealthAssessment
        {
            get { return healthAssessment; }
            set { healthAssessment = value; }
        }
        /// <summary>[属性]健康指导</summary>
        public string Guidance
        {
            get { return guidance; }
            set { guidance = value; }
        }
        /// <summary>[属性]危险因素控制建议</summary>
        public string RiskControlSuggestions
        {
            get { return riskControlSuggestions; }
            set { riskControlSuggestions = value; }
        }

        #endregion 多层框架式下的默认代码
    }
}
