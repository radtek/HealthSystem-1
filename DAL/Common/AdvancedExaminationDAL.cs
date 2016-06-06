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
    /// �������ƣ��߼�����ͨ�����ݷ��ʸ��ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ���߼������ࣨҵ���߼��㣩����SqlServer,Oracle,OleDb�����ݿ���з��ʵ���ط������Լ�����ͨ�÷�������������е��á�
    /// ����˵��������Ϊ�������޷�����ʵ������ͨ������ʹ�á��߼������ࣨҵ���߼��㣩���е�DataAccess���������ñ��������������ݷ��ʷ�����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:12:40
    /// </summary>
    public abstract class AdvancedExaminationDAL
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬�ṩ�������ݷ��ʵĻ����������벻Ҫֱ���޸ĸ������е��κδ��룬  
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        //���棺�����ڻ��桰�߼�����AdvancedExaminationDAL�����ݷ����ࡱ�ĵ���ʵ������Զ��Ҫֱ�ӷ��ʸñ�����
        private static AdvancedExaminationDAL advancedExaminationDAL;


        /// <summary>
        /// ��ȡ���߼�����AdvancedExaminationDAL�����ݷ����ࡱ��ʵ����������ͨ���ж�Ӧ�ó��������ļ������ݿ����͡�DataBaseType����ֵ��
        /// ����һ�����ڶ�ָ���������ݿ���з��ʵġ��߼�����AdvancedExaminationDAL�����ݷ����ࡱ��SqlServer/Oracle/OleDb��������ʵ����
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
        /// ��DataReader�ж�ȡ���ݣ���ΪAdvancedExamination������������Ը�ֵ���÷�����Ҫ�ɸ����������á�
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="advancedExamination">�߼�����AdvancedExamination��ʵ������</param>
        protected void ReadAdvancedExaminationAllData(IDataReader dataReader, AdvancedExamination advancedExamination)
        {
            // �����
            if (dataReader["Id"] != DBNull.Value)
                advancedExamination.Id = Convert.ToInt32(dataReader["Id"]);
            // ��ǻ
            if (dataReader["Oral"] != DBNull.Value)
                advancedExamination.Oral = Convert.ToString(dataReader["Oral"]);
            // ��������
            if (dataReader["LeftEye"] != DBNull.Value)
                advancedExamination.LeftEye = Convert.ToDecimal(dataReader["LeftEye"]);
            // ��������
            if (dataReader["RightEye"] != DBNull.Value)
                advancedExamination.RightEye = Convert.ToDecimal(dataReader["RightEye"]);
            // ����
            if (dataReader["Hearing"] != DBNull.Value)
                advancedExamination.Hearing = Convert.ToString(dataReader["Hearing"]);
            // �˶�����
            if (dataReader["FMA"] != DBNull.Value)
                advancedExamination.FMA = Convert.ToString(dataReader["FMA"]);
            // �۵�
            if (dataReader["Fundus"] != DBNull.Value)
                advancedExamination.Fundus = Convert.ToString(dataReader["Fundus"]);
            // Ƥ��
            if (dataReader["Skin"] != DBNull.Value)
                advancedExamination.Skin = Convert.ToString(dataReader["Skin"]);
            // ��Ĥ
            if (dataReader["Sclera"] != DBNull.Value)
                advancedExamination.Sclera = Convert.ToString(dataReader["Sclera"]);
            // �ܰͽ�
            if (dataReader["LN"] != DBNull.Value)
                advancedExamination.LN = Convert.ToString(dataReader["LN"]);
            // �ι���
            if (dataReader["Lung"] != DBNull.Value)
                advancedExamination.Lung = Convert.ToString(dataReader["Lung"]);
            // ����
            if (dataReader["Heart"] != DBNull.Value)
                advancedExamination.Heart = Convert.ToString(dataReader["Heart"]);
            // ����
            if (dataReader["Abdomen"] != DBNull.Value)
                advancedExamination.Abdomen = Convert.ToString(dataReader["Abdomen"]);
            // ��֫ˮ��
            if (dataReader["LowerExtremityEdema"] != DBNull.Value)
                advancedExamination.LowerExtremityEdema = Convert.ToString(dataReader["LowerExtremityEdema"]);
            // �㱳��������
            if (dataReader["DPAP"] != DBNull.Value)
                advancedExamination.DPAP = Convert.ToString(dataReader["DPAP"]);
            // ����ָ��
            if (dataReader["Dre"] != DBNull.Value)
                advancedExamination.Dre = Convert.ToString(dataReader["Dre"]);
            // �ո�Ѫ��
            if (dataReader["FBG"] != DBNull.Value)
                advancedExamination.FBG = Convert.ToString(dataReader["FBG"]);
            // Ѫ����
            if (dataReader["CBCId"] != DBNull.Value)
                //���������������Ӷ���
                advancedExamination.CBC = T_CBC.GetDataById(Convert.ToInt32(dataReader["CBCId"])) ?? T_CBC.Empty;
            // �򳣹�
            if (dataReader["RoutineUrineId"] != DBNull.Value)
                //���������������Ӷ���
                advancedExamination.RoutineUrine = T_RoutineUrine.GetDataById(Convert.ToInt32(dataReader["RoutineUrineId"])) ?? T_RoutineUrine.Empty;
            // ��΢������
            if (dataReader["U_MTB"] != DBNull.Value)
                advancedExamination.U_MTB = Convert.ToString(dataReader["U_MTB"]);
            // �ι���
            if (dataReader["LiverId"] != DBNull.Value)
                //���������������Ӷ���
                advancedExamination.Liver = T_Liver.GetDataById(Convert.ToInt32(dataReader["LiverId"])) ?? T_Liver.Empty;
            // ������
            if (dataReader["RenalId"] != DBNull.Value)
                //���������������Ӷ���
                advancedExamination.Renal = T_Renal.GetDataById(Convert.ToInt32(dataReader["RenalId"])) ?? T_Renal.Empty;
            // Ѫ֬ 
            if (dataReader["TGId"] != DBNull.Value)
                //���������������Ӷ���
                advancedExamination.TG = T_TG.GetDataById(Convert.ToInt32(dataReader["TGId"])) ?? T_TG.Empty;
            // �ǻ�Ѫ�쵰��
            if (dataReader["GHb"] != DBNull.Value)
                advancedExamination.GHb = Convert.ToString(dataReader["GHb"]);
            // ���͸��ױ��濹ԭ
            if (dataReader["HBsAG"] != DBNull.Value)
                advancedExamination.HBsAG = Convert.ToString(dataReader["HBsAG"]);
            // �ĵ�ͼ
            if (dataReader["ECG"] != DBNull.Value)
                advancedExamination.ECG = Convert.ToString(dataReader["ECG"]);
            // �ز�����Ƭ
            if (dataReader["XRay"] != DBNull.Value)
                advancedExamination.XRay = Convert.ToString(dataReader["XRay"]);
            // B��
            if (dataReader["BUltrasonic"] != DBNull.Value)
                advancedExamination.BUltrasonic = Convert.ToString(dataReader["BUltrasonic"]);
            // ����ͿƬ
            if (dataReader["CervicalSmear"] != DBNull.Value)
                advancedExamination.CervicalSmear = Convert.ToString(dataReader["CervicalSmear"]);
            // ����
            if (dataReader["Other"] != DBNull.Value)
                advancedExamination.Other = Convert.ToString(dataReader["Other"]);
            // ����
            if (dataReader["Physical"] != DBNull.Value)
                advancedExamination.Physical = Convert.ToString(dataReader["Physical"]);
            // ����ָ�����
            if (dataReader["Guidance"] != DBNull.Value)
                advancedExamination.Guidance = Convert.ToString(dataReader["Guidance"]);
        }


        /// <summary>
        /// ��DataReader�ж�ȡ���ݣ���ΪAdvancedExamination������Ҫ������ʾ�����Ը�ֵ���÷�����Ҫ�ɸ����������á�
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="advancedExamination">�߼�����AdvancedExamination��ʵ������</param>
        protected void ReadAdvancedExaminationPageData(IDataReader dataReader, AdvancedExamination advancedExamination)
        {
            // �����
            if (dataReader["Id"] != DBNull.Value)
                advancedExamination.Id = Convert.ToInt32(dataReader["Id"]);
            // ��ǻ
            if (dataReader["Oral"] != DBNull.Value)
                advancedExamination.Oral = Convert.ToString(dataReader["Oral"]);
            // ��������
            if (dataReader["LeftEye"] != DBNull.Value)
                advancedExamination.LeftEye = Convert.ToDecimal(dataReader["LeftEye"]);
            // ��������
            if (dataReader["RightEye"] != DBNull.Value)
                advancedExamination.RightEye = Convert.ToDecimal(dataReader["RightEye"]);
            // ����
            if (dataReader["Hearing"] != DBNull.Value)
                advancedExamination.Hearing = Convert.ToString(dataReader["Hearing"]);
            // ����ָ�����
            if (dataReader["Guidance"] != DBNull.Value)
                advancedExamination.Guidance = Convert.ToString(dataReader["Guidance"]);
        }


        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  �������ݷ�������󷽷����壬��SqlServer/Oracle/OleDb������ʵ�־��巽����  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>
        /// ���߼�����AdvancedExamination�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="advancedExamination">�߼�����AdvancedExamination��ʵ������</param>
        public abstract int Insert(AdvancedExamination advancedExamination);


        /// <summary>
        /// ���߼�����AdvancedExamination�����ݣ���������������ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="advancedExamination">�߼�����AdvancedExamination��ʵ������</param>
        public abstract int Update(AdvancedExamination advancedExamination);


        /// <summary>
        /// ���ݸ߼�����AdvancedExamination��������������ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">�߼�����AdvancedExamination��������������ţ�Id����</param>
        public abstract int Delete(int id);


        /// <summary>
        /// ���ݸ߼�����AdvancedExamination��������������ţ�Id���������ݿ��л�ȡ�߼�����AdvancedExamination����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�����¸߼�����AdvancedExamination����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">�߼�����AdvancedExamination��������������ţ�Id����</param>
        public abstract AdvancedExamination GetDataById(int id);


        /// <summary>
        /// �����ݿ��ж�ȡ���������и߼�����AdvancedExamination��List�б�
        /// </summary>
        public abstract List<AdvancedExamination> GetAllList();


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ��ĸ߼�����AdvancedExamination�����б���ҳ��Ϣ��
        /// �÷�������ȡ�ĸ߼�����AdvancedExamination���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
        /// </summary>
        public abstract PageData GetPageList(int pageSize, int curPage);


        #endregion �����ʽ�µ�Ĭ�ϴ���

        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ˵������������Ĵ���Ϊ��ƿ�����Ա����д����ҪΪ��չ�����ݷ�����Ĺ��ܣ�������ı��������Լ�������ݷ��ʷ�����  
        //  ע�⣺Ϊ�˱�֤����Ŀ�Ķ����ݿ�֧������չ�ԣ������еķ���ͨ��Ϊ���󷽷�������ʵ���ɱ��������ͨ��������д��ɡ�  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l










    }
}
