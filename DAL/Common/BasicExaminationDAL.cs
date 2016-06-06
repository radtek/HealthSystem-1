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
    /// �������ƣ���������ͨ�����ݷ��ʸ��ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ�����������ࣨҵ���߼��㣩����SqlServer,Oracle,OleDb�����ݿ���з��ʵ���ط������Լ�����ͨ�÷�������������е��á�
    /// ����˵��������Ϊ�������޷�����ʵ������ͨ������ʹ�á����������ࣨҵ���߼��㣩���е�DataAccess���������ñ��������������ݷ��ʷ�����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 16:58:59
    /// </summary>
    public abstract class BasicExaminationDAL
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬�ṩ�������ݷ��ʵĻ����������벻Ҫֱ���޸ĸ������е��κδ��룬  
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        //���棺�����ڻ��桰��������BasicExaminationDAL�����ݷ����ࡱ�ĵ���ʵ������Զ��Ҫֱ�ӷ��ʸñ�����
        private static BasicExaminationDAL basicExaminationDAL;


        /// <summary>
        /// ��ȡ����������BasicExaminationDAL�����ݷ����ࡱ��ʵ����������ͨ���ж�Ӧ�ó��������ļ������ݿ����͡�DataBaseType����ֵ��
        /// ����һ�����ڶ�ָ���������ݿ���з��ʵġ���������BasicExaminationDAL�����ݷ����ࡱ��SqlServer/Oracle/OleDb��������ʵ����
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
        /// ��DataReader�ж�ȡ���ݣ���ΪBasicExamination������������Ը�ֵ���÷�����Ҫ�ɸ����������á�
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="basicExamination">��������BasicExamination��ʵ������</param>
        protected void ReadBasicExaminationAllData(IDataReader dataReader, BasicExamination basicExamination)
        {
            // ���
            if (dataReader["Id"] != DBNull.Value)
                basicExamination.Id = Convert.ToInt32(dataReader["Id"]);
            // �����
            if (dataReader["ResidentId"] != DBNull.Value)
                basicExamination.ResidentId = Convert.ToString(dataReader["ResidentId"]);
            // ����
            if (dataReader["TheName"] != DBNull.Value)
                basicExamination.TheName = Convert.ToString(dataReader["TheName"]);
            // �����
            if (dataReader["CheckID"] != DBNull.Value)
                basicExamination.CheckID = Convert.ToString(dataReader["CheckID"]);
            // �������
            if (dataReader["CheckDate"] != DBNull.Value)
                basicExamination.CheckDate = Convert.ToString(dataReader["CheckDate"]);
            // ���ҽ��
            if (dataReader["Doctor"] != DBNull.Value)
                basicExamination.Doctor = Convert.ToString(dataReader["Doctor"]);
            // ֢״
            if (dataReader["SymptomsId"] != DBNull.Value)
                basicExamination.Symptoms = T_Symptoms.GetDataById(Convert.ToInt32(dataReader["SymptomsId"])) ?? T_Symptoms.Empty;
            // ����
            if (dataReader["Temperature"] != DBNull.Value)
                basicExamination.Temperature = Convert.ToDecimal(dataReader["Temperature"]);
            // ����
            if (dataReader["BPM"] != DBNull.Value)
                basicExamination.BPM = Convert.ToDecimal(dataReader["BPM"]);
            // ����Ƶ��
            if (dataReader["RR"] != DBNull.Value)
                basicExamination.RR = Convert.ToDecimal(dataReader["RR"]);
            // Ѫѹ
            if (dataReader["BP"] != DBNull.Value)
                basicExamination.BP = Convert.ToDecimal(dataReader["BP"]);
            // ���
            if (dataReader["Height"] != DBNull.Value)
                basicExamination.Height = Convert.ToDecimal(dataReader["Height"]);
            // ����
            if (dataReader["Weight"] != DBNull.Value)
                basicExamination.Weight = Convert.ToDecimal(dataReader["Weight"]);
            // ��Χ
            if (dataReader["Waist"] != DBNull.Value)
                basicExamination.Waist = Convert.ToDecimal(dataReader["Waist"]);
            // ����ָ��
            if (dataReader["BMI"] != DBNull.Value)
                basicExamination.BMI = Convert.ToDecimal(dataReader["BMI"]);
            // ��������
            if (dataReader["PhysicalExercise"] != DBNull.Value)
                basicExamination.PhysicalExercise = Convert.ToString(dataReader["PhysicalExercise"]);
            // ��ʳϰ��
            if (dataReader["EatingHabitsId"] != DBNull.Value)
                basicExamination.EatingHabits = T_EatingHabits.GetDataById(Convert.ToInt32(dataReader["EatingHabitsId"])) ?? T_EatingHabits.Empty;
            // �������
            if (dataReader["Smoking"] != DBNull.Value)
                basicExamination.Smoking = Convert.ToString(dataReader["Smoking"]);
            // �������
            if (dataReader["Drinking"] != DBNull.Value)
                basicExamination.Drinking = Convert.ToString(dataReader["Drinking"]);
            // ְҵ��¶���
            if (dataReader["OccupationalExposure"] != DBNull.Value)
                basicExamination.OccupationalExposure = Convert.ToString(dataReader["OccupationalExposure"]);
        }


        /// <summary>
        /// ��DataReader�ж�ȡ���ݣ���ΪBasicExamination������Ҫ������ʾ�����Ը�ֵ���÷�����Ҫ�ɸ����������á�
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="basicExamination">��������BasicExamination��ʵ������</param>
        protected void ReadBasicExaminationPageData(IDataReader dataReader, BasicExamination basicExamination)
        {
            // ���
            if (dataReader["Id"] != DBNull.Value)
                basicExamination.Id = Convert.ToInt32(dataReader["Id"]);
            // �����
            if (dataReader["ResidentId"] != DBNull.Value)
                basicExamination.ResidentId = Convert.ToString(dataReader["ResidentId"]);
            // ����
            if (dataReader["TheName"] != DBNull.Value)
                basicExamination.TheName = Convert.ToString(dataReader["TheName"]);
            // �����
            if (dataReader["CheckID"] != DBNull.Value)
                basicExamination.CheckID = Convert.ToString(dataReader["CheckID"]);
            // �������
            if (dataReader["CheckDate"] != DBNull.Value)
                basicExamination.CheckDate = Convert.ToString(dataReader["CheckDate"]);
            // ���ҽ��
            if (dataReader["Doctor"] != DBNull.Value)
                basicExamination.Doctor = Convert.ToString(dataReader["Doctor"]);
            // ֢״
            if (dataReader["SymptomsId"] != DBNull.Value)
                //�����������������
                basicExamination.Symptoms = T_Symptoms.GetDataById(Convert.ToInt32(dataReader["SymptomsId"])) ?? T_Symptoms.Empty;
        }


        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  �������ݷ�������󷽷����壬��SqlServer/Oracle/OleDb������ʵ�־��巽����  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>
        /// ����������BasicExamination�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="basicExamination">��������BasicExamination��ʵ������</param>
        public abstract int Insert(BasicExamination basicExamination);


        /// <summary>
        /// ����������BasicExamination�����ݣ�������������ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="basicExamination">��������BasicExamination��ʵ������</param>
        public abstract int Update(BasicExamination basicExamination);


        /// <summary>
        /// ���ݻ�������BasicExamination������������ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">��������BasicExamination������������ţ�Id����</param>
        public abstract int Delete(int id);


        /// <summary>
        /// ���ݻ�������BasicExamination������������ţ�Id���������ݿ��л�ȡ��������BasicExamination����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�����»�������BasicExamination����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">��������BasicExamination������������ţ�Id����</param>
        public abstract BasicExamination GetDataById(int id);


        /// <summary>
        /// �����ݿ��ж�ȡ���������л�������BasicExamination��List�б�
        /// </summary>
        public abstract List<BasicExamination> GetAllList();


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ��Ļ�������BasicExamination�����б���ҳ��Ϣ��
        /// �÷�������ȡ�Ļ�������BasicExamination���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
        /// </summary>
        public abstract PageData GetPageList(int pageSize, int curPage);


        #endregion �����ʽ�µ�Ĭ�ϴ���

        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ˵������������Ĵ���Ϊ��ƿ�����Ա����д����ҪΪ��չ�����ݷ�����Ĺ��ܣ�������ı��������Լ�������ݷ��ʷ�����  
        //  ע�⣺Ϊ�˱�֤����Ŀ�Ķ����ݿ�֧������չ�ԣ������еķ���ͨ��Ϊ���󷽷�������ʵ���ɱ��������ͨ��������д��ɡ�  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l

        /// <summary>
        /// ���ݻ����������ƣ�BasicExamination�����ֶΡ�TheName��TheName���������ݿ��л�ȡ�����������ƣ�BasicExamination����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�����»����������ƣ�BasicExamination����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="theName">�����������ƣ�BasicExamination�����ֶΡ�TheName��TheName����</param>

        public abstract List<BasicExamination> GetDataByTheName(string theName);






    }
}
