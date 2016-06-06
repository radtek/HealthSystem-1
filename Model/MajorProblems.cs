using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// �������ƣ��ִ潡�����������ʵ���ࣨ����ʵ��㣩
    /// ����˵����������Ϊ�������壬��ҵ���߼��㡢���ݷ��ʲ���á�
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:01:17
    /// </summary>
    [Serializable]
    public class MajorProblems
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬��Ҫ���ڶ������ı������ԡ��벻Ҫֱ���޸ĸ������е��κδ��룬  
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>[����]�����</summary>
        private int? checkId;
        /// <summary>[����]��Ѫ�ܼ���</summary>
        private T_CerebrovascularDisease cerebrovascularDisease;
        /// <summary>[����]���༲��</summary>
        private T_KidneyDisease kidneyDisease;
        /// <summary>[����]���༲��</summary>
        private T_HeartDisease heartDisease;
        /// <summary>[����]Ѫ�ܼ���</summary>
        private T_VascularDisease vascularDisease;
        /// <summary>[����]�۲�����</summary>
        private T_EyeDisease eyeDisease;
        /// <summary>[����]��ϵͳ����</summary>
        private string diseasesOfTheNervousSystem;
        /// <summary>[����]����ϵͳ����</summary>
        private string otherSystemDiseases;
        /// <summary>[����]סԺ�������</summary>
        private string hospitalizationIs;
        /// <summary>[����]��Ҫ��ҩ���</summary>
        private string mainMedications;
        /// <summary>[����]�����߹滮Ԥ������ʷ</summary>
        private string iPVHistory;
        /// <summary>[����]��������</summary>
        private string healthAssessment;
        /// <summary>[����]����ָ��</summary>
        private string guidance;
        /// <summary>[����]Σ�����ؿ��ƽ���</summary>
        private string riskControlSuggestions;


        /// <summary>[����]�����</summary>
        public int? CheckId
        {
            get { return checkId; }
            set { checkId = value; }
        }
        /// <summary>[����]��Ѫ�ܼ���</summary>
        public T_CerebrovascularDisease CerebrovascularDisease
        {
            get { return cerebrovascularDisease; }
            set { cerebrovascularDisease = value; }
        }
        /// <summary>[����]���༲��</summary>
        public T_KidneyDisease KidneyDisease
        {
            get { return kidneyDisease; }
            set { kidneyDisease = value; }
        }
        /// <summary>[����]���༲��</summary>
        public T_HeartDisease HeartDisease
        {
            get { return heartDisease; }
            set { heartDisease = value; }
        }
        /// <summary>[����]Ѫ�ܼ���</summary>
        public T_VascularDisease VascularDisease
        {
            get { return vascularDisease; }
            set { vascularDisease = value; }
        }
        /// <summary>[����]�۲�����</summary>
        public T_EyeDisease EyeDisease
        {
            get { return eyeDisease; }
            set { eyeDisease = value; }
        }
        /// <summary>[����]��ϵͳ����</summary>
        public string DiseasesOfTheNervousSystem
        {
            get { return diseasesOfTheNervousSystem; }
            set { diseasesOfTheNervousSystem = value; }
        }
        /// <summary>[����]����ϵͳ����</summary>
        public string OtherSystemDiseases
        {
            get { return otherSystemDiseases; }
            set { otherSystemDiseases = value; }
        }
        /// <summary>[����]סԺ�������</summary>
        public string HospitalizationIs
        {
            get { return hospitalizationIs; }
            set { hospitalizationIs = value; }
        }
        /// <summary>[����]��Ҫ��ҩ���</summary>
        public string MainMedications
        {
            get { return mainMedications; }
            set { mainMedications = value; }
        }
        /// <summary>[����]�����߹滮Ԥ������ʷ</summary>
        public string IPVHistory
        {
            get { return iPVHistory; }
            set { iPVHistory = value; }
        }
        /// <summary>[����]��������</summary>
        public string HealthAssessment
        {
            get { return healthAssessment; }
            set { healthAssessment = value; }
        }
        /// <summary>[����]����ָ��</summary>
        public string Guidance
        {
            get { return guidance; }
            set { guidance = value; }
        }
        /// <summary>[����]Σ�����ؿ��ƽ���</summary>
        public string RiskControlSuggestions
        {
            get { return riskControlSuggestions; }
            set { riskControlSuggestions = value; }
        }

        #endregion �����ʽ�µ�Ĭ�ϴ���
    }
}
