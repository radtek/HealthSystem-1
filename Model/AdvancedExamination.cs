
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// �������ƣ��߼���������ʵ���ࣨ����ʵ��㣩
    /// ����˵����������Ϊ�������壬��ҵ���߼��㡢���ݷ��ʲ���á�
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:12:40
    /// </summary>
    [Serializable]
    public class AdvancedExamination
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬��Ҫ���ڶ������ı������ԡ��벻Ҫֱ���޸ĸ������е��κδ��룬  
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>[����]�����</summary>
        private int? id;
        /// <summary>[����]��ǻ</summary>
        private string oral;
        /// <summary>[����]��������</summary>
        private decimal? leftEye;
        /// <summary>[����]��������</summary>
        private decimal? rightEye;
        /// <summary>[����]����</summary>
        private string hearing;
        /// <summary>[����]�˶�����</summary>
        private string fMA;
        /// <summary>[����]�۵�</summary>
        private string fundus;
        /// <summary>[����]Ƥ��</summary>
        private string skin;
        /// <summary>[����]��Ĥ</summary>
        private string sclera;
        /// <summary>[����]�ܰͽ�</summary>
        private string lN;
        /// <summary>[����]�ι���</summary>
        private string lung;
        /// <summary>[����]����</summary>
        private string heart;
        /// <summary>[����]����</summary>
        private string abdomen;
        /// <summary>[����]��֫ˮ��</summary>
        private string lowerExtremityEdema;
        /// <summary>[����]�㱳��������</summary>
        private string dPAP;
        /// <summary>[����]����ָ��</summary>
        private string dre;
        /// <summary>[����]�ո�Ѫ��</summary>
        private string fBG;
        /// <summary>[����]Ѫ����</summary>
        private T_CBC cBC;
        /// <summary>[����]�򳣹�</summary>
        private T_RoutineUrine routineUrine;
        /// <summary>[����]��΢������</summary>
        private string u_MTB;
        /// <summary>[����]�ι���</summary>
        private T_Liver liver;
        /// <summary>[����]������</summary>
        private T_Renal renal;
        /// <summary>[����]Ѫ֬</summary>
        private T_TG tG;
        /// <summary>[����]�ǻ�Ѫ�쵰��</summary>
        private string gHb;
        /// <summary>[����]���͸��ױ��濹ԭ</summary>
        private string hBsAG;
        /// <summary>[����]�ĵ�ͼ</summary>
        private string eCG;
        /// <summary>[����]�ز�����Ƭ</summary>
        private string xRay;
        /// <summary>[����]B��</summary>
        private string bUltrasonic;
        /// <summary>[����]����ͿƬ</summary>
        private string cervicalSmear;
        /// <summary>[����]����</summary>
        private string other;
        /// <summary>[����]����</summary>
        private string physical;
        /// <summary>[����]����ָ�����</summary>
        private string guidance;


        /// <summary>[����]�����</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[����]��ǻ</summary>
        public string Oral
        {
            get { return oral; }
            set { oral = value; }
        }
        /// <summary>[����]��������</summary>
        public decimal? LeftEye
        {
            get { return leftEye; }
            set { leftEye = value; }
        }
        /// <summary>[����]��������</summary>
        public decimal? RightEye
        {
            get { return rightEye; }
            set { rightEye = value; }
        }
        /// <summary>[����]����</summary>
        public string Hearing
        {
            get { return hearing; }
            set { hearing = value; }
        }
        /// <summary>[����]�˶�����</summary>
        public string FMA
        {
            get { return fMA; }
            set { fMA = value; }
        }
        /// <summary>[����]�۵�</summary>
        public string Fundus
        {
            get { return fundus; }
            set { fundus = value; }
        }
        /// <summary>[����]Ƥ��</summary>
        public string Skin
        {
            get { return skin; }
            set { skin = value; }
        }
        /// <summary>[����]��Ĥ</summary>
        public string Sclera
        {
            get { return sclera; }
            set { sclera = value; }
        }
        /// <summary>[����]�ܰͽ�</summary>
        public string LN
        {
            get { return lN; }
            set { lN = value; }
        }
        /// <summary>[����]�ι���</summary>
        public string Lung
        {
            get { return lung; }
            set { lung = value; }
        }
        /// <summary>[����]����</summary>
        public string Heart
        {
            get { return heart; }
            set { heart = value; }
        }
        /// <summary>[����]����</summary>
        public string Abdomen
        {
            get { return abdomen; }
            set { abdomen = value; }
        }
        /// <summary>[����]��֫ˮ��</summary>
        public string LowerExtremityEdema
        {
            get { return lowerExtremityEdema; }
            set { lowerExtremityEdema = value; }
        }
        /// <summary>[����]�㱳��������</summary>
        public string DPAP
        {
            get { return dPAP; }
            set { dPAP = value; }
        }
        /// <summary>[����]����ָ��</summary>
        public string Dre
        {
            get { return dre; }
            set { dre = value; }
        }
        /// <summary>[����]�ո�Ѫ��</summary>
        public string FBG
        {
            get { return fBG; }
            set { fBG = value; }
        }
        /// <summary>[����]Ѫ����</summary>
        public T_CBC CBC
        {
            get { return cBC; }
            set { cBC = value; }
        }
        /// <summary>[����]�򳣹�</summary>
        public T_RoutineUrine RoutineUrine
        {
            get { return routineUrine; }
            set { routineUrine = value; }
        }
        /// <summary>[����]��΢������</summary>
        public string U_MTB
        {
            get { return u_MTB; }
            set { u_MTB = value; }
        }
        /// <summary>[����]�ι���</summary>
        public T_Liver Liver
        {
            get { return liver; }
            set { liver = value; }
        }
        /// <summary>[����]������</summary>
        public T_Renal Renal
        {
            get { return renal; }
            set { renal = value; }
        }
        /// <summary>[����]Ѫ֬</summary>
        public T_TG TG
        {
            get { return tG; }
            set { tG = value; }
        }
        /// <summary>[����]�ǻ�Ѫ�쵰��</summary>
        public string GHb
        {
            get { return gHb; }
            set { gHb = value; }
        }
        /// <summary>[����]���͸��ױ��濹ԭ</summary>
        public string HBsAG
        {
            get { return hBsAG; }
            set { hBsAG = value; }
        }
        /// <summary>[����]�ĵ�ͼ</summary>
        public string ECG
        {
            get { return eCG; }
            set { eCG = value; }
        }
        /// <summary>[����]�ز�����Ƭ</summary>
        public string XRay
        {
            get { return xRay; }
            set { xRay = value; }
        }
        /// <summary>[����]B��</summary>
        public string BUltrasonic
        {
            get { return bUltrasonic; }
            set { bUltrasonic = value; }
        }
        /// <summary>[����]����ͿƬ</summary>
        public string CervicalSmear
        {
            get { return cervicalSmear; }
            set { cervicalSmear = value; }
        }
        /// <summary>[����]����</summary>
        public string Other
        {
            get { return other; }
            set { other = value; }
        }
        /// <summary>[����]����</summary>
        public string Physical
        {
            get { return physical; }
            set { physical = value; }
        }
        /// <summary>[����]����ָ�����</summary>
        public string Guidance
        {
            get { return guidance; }
            set { guidance = value; }
        }

        #endregion �����ʽ�µ�Ĭ�ϴ���
    }
}
