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
    /// �������ƣ��ִ潡�������ͨ�����ݷ��ʸ��ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ���ִ潡��������ࣨҵ���߼��㣩����SqlServer,Oracle,OleDb�����ݿ���з��ʵ���ط������Լ�����ͨ�÷�������������е��á�
    /// ����˵��������Ϊ�������޷�����ʵ������ͨ������ʹ�á��ִ潡��������ࣨҵ���߼��㣩���е�DataAccess���������ñ��������������ݷ��ʷ�����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:01:17
    /// </summary>
    public abstract class MajorProblemsDAL
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬�ṩ�������ݷ��ʵĻ����������벻Ҫֱ���޸ĸ������е��κδ��룬  
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        //���棺�����ڻ��桰�ִ潡�������MajorProblemsDAL�����ݷ����ࡱ�ĵ���ʵ������Զ��Ҫֱ�ӷ��ʸñ�����
        private static MajorProblemsDAL majorProblemsDAL;


        /// <summary>
        /// ��ȡ���ִ潡�������MajorProblemsDAL�����ݷ����ࡱ��ʵ����������ͨ���ж�Ӧ�ó��������ļ������ݿ����͡�DataBaseType����ֵ��
        /// ����һ�����ڶ�ָ���������ݿ���з��ʵġ��ִ潡�������MajorProblemsDAL�����ݷ����ࡱ��SqlServer/Oracle/OleDb��������ʵ����
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
        /// ��DataReader�ж�ȡ���ݣ���ΪMajorProblems������������Ը�ֵ���÷�����Ҫ�ɸ����������á�
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="majorProblems">�ִ潡�������MajorProblems��ʵ������</param>
        protected void ReadMajorProblemsAllData(IDataReader dataReader, MajorProblems majorProblems)
        {
            // �����
            if (dataReader["CheckId"] != DBNull.Value)
                majorProblems.CheckId = Convert.ToInt32(dataReader["CheckId"]);
            // ��Ѫ�ܼ���
            if (dataReader["CerebrovascularDiseaseId"] != DBNull.Value)
                //���������������Ӷ���
                majorProblems.CerebrovascularDisease = T_CerebrovascularDisease.GetDataById(Convert.ToInt32(dataReader["CerebrovascularDiseaseId"])) ?? T_CerebrovascularDisease.Empty;
            // ���༲��
            if (dataReader["KidneyDiseaseId"] != DBNull.Value)
                //���������������Ӷ���
                majorProblems.KidneyDisease = T_KidneyDisease.GetDataById(Convert.ToInt32(dataReader["KidneyDiseaseId"])) ?? T_KidneyDisease.Empty;
            // ���༲��
            if (dataReader["HeartDiseaseId"] != DBNull.Value)
                //���������������Ӷ���
                majorProblems.HeartDisease = T_HeartDisease.GetDataById(Convert.ToInt32(dataReader["HeartDiseaseId"])) ?? T_HeartDisease.Empty;
            // Ѫ�ܼ���
            if (dataReader["VascularDiseaseId"] != DBNull.Value)
                //���������������Ӷ���
                majorProblems.VascularDisease = T_VascularDisease.GetDataById(Convert.ToInt32(dataReader["VascularDiseaseId"])) ?? T_VascularDisease.Empty;
            // �۲�����
            if (dataReader["EyeDiseaseId"] != DBNull.Value)
                //���������������Ӷ���
                majorProblems.EyeDisease = T_EyeDisease.GetDataById(Convert.ToInt32(dataReader["EyeDiseaseId"])) ?? T_EyeDisease.Empty;
            // ��ϵͳ����
            if (dataReader["DiseasesOfTheNervousSystem"] != DBNull.Value)
                majorProblems.DiseasesOfTheNervousSystem = Convert.ToString(dataReader["DiseasesOfTheNervousSystem"]);
            // ����ϵͳ����
            if (dataReader["OtherSystemDiseases"] != DBNull.Value)
                majorProblems.OtherSystemDiseases = Convert.ToString(dataReader["OtherSystemDiseases"]);
            // סԺ�������
            if (dataReader["HospitalizationIs"] != DBNull.Value)
                majorProblems.HospitalizationIs = Convert.ToString(dataReader["HospitalizationIs"]);
            // ��Ҫ��ҩ���
            if (dataReader["MainMedications"] != DBNull.Value)
                majorProblems.MainMedications = Convert.ToString(dataReader["MainMedications"]);
            // �����߹滮Ԥ������ʷ
            if (dataReader["IPVHistory"] != DBNull.Value)
                majorProblems.IPVHistory = Convert.ToString(dataReader["IPVHistory"]);
            // ��������
            if (dataReader["HealthAssessment"] != DBNull.Value)
                majorProblems.HealthAssessment = Convert.ToString(dataReader["HealthAssessment"]);
            // ����ָ��
            if (dataReader["Guidance"] != DBNull.Value)
                majorProblems.Guidance = Convert.ToString(dataReader["Guidance"]);
            // Σ�����ؿ��ƽ���
            if (dataReader["RiskControlSuggestions"] != DBNull.Value)
                majorProblems.RiskControlSuggestions = Convert.ToString(dataReader["RiskControlSuggestions"]);
        }


        /// <summary>
        /// ��DataReader�ж�ȡ���ݣ���ΪMajorProblems������Ҫ������ʾ�����Ը�ֵ���÷�����Ҫ�ɸ����������á�
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="majorProblems">�ִ潡�������MajorProblems��ʵ������</param>
        protected void ReadMajorProblemsPageData(IDataReader dataReader, MajorProblems majorProblems)
        {
            // �����
            if (dataReader["CheckId"] != DBNull.Value)
                majorProblems.CheckId = Convert.ToInt32(dataReader["CheckId"]);
            // ��������
            if (dataReader["HealthAssessment"] != DBNull.Value)
                majorProblems.HealthAssessment = Convert.ToString(dataReader["HealthAssessment"]);
            // Σ�����ؿ��ƽ���
            if (dataReader["RiskControlSuggestions"] != DBNull.Value)
                majorProblems.RiskControlSuggestions = Convert.ToString(dataReader["RiskControlSuggestions"]);
        }


        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  �������ݷ�������󷽷����壬��SqlServer/Oracle/OleDb������ʵ�־��巽����  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>
        /// ���ִ潡�������MajorProblems�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="majorProblems">�ִ潡�������MajorProblems��ʵ������</param>
        public abstract int Insert(MajorProblems majorProblems);


        /// <summary>
        /// ���ִ潡�������MajorProblems�����ݣ���������������ţ�CheckId��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="majorProblems">�ִ潡�������MajorProblems��ʵ������</param>
        public abstract int Update(MajorProblems majorProblems);


        /// <summary>
        /// �����ִ潡�������MajorProblems��������������ţ�CheckId��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="checkId">�ִ潡�������MajorProblems��������������ţ�CheckId����</param>
        public abstract int Delete(int checkId);


        /// <summary>
        /// �����ִ潡�������MajorProblems��������������ţ�CheckId���������ݿ��л�ȡ�ִ潡�������MajorProblems����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�������ִ潡�������MajorProblems����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="checkId">�ִ潡�������MajorProblems��������������ţ�CheckId����</param>
        public abstract MajorProblems GetDataByCheckId(int checkId);


        /// <summary>
        /// �����ݿ��ж�ȡ�����������ִ潡�������MajorProblems��List�б�
        /// </summary>
        public abstract List<MajorProblems> GetAllList();


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ����ִ潡�������MajorProblems�����б���ҳ��Ϣ��
        /// �÷�������ȡ���ִ潡�������MajorProblems���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
        /// </summary>
        public abstract PageData GetPageList(int pageSize, int curPage);


        #endregion �����ʽ�µ�Ĭ�ϴ���

        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ˵������������Ĵ���Ϊ��ƿ�����Ա����д����ҪΪ��չ�����ݷ�����Ĺ��ܣ�������ı��������Լ�������ݷ��ʷ�����  
        //  ע�⣺Ϊ�˱�֤����Ŀ�Ķ����ݿ�֧������չ�ԣ������еķ���ͨ��Ϊ���󷽷�������ʵ���ɱ��������ͨ��������д��ɡ�  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l










    }
}
