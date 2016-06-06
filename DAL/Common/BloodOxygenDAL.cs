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
    /// �������ƣ�Ѫ�������ͨ�����ݷ��ʸ��ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ��Ѫ��������ࣨҵ���߼��㣩����SqlServer,Oracle,OleDb�����ݿ���з��ʵ���ط������Լ�����ͨ�÷�������������е��á�
    /// ����˵��������Ϊ�������޷�����ʵ������ͨ������ʹ�á�Ѫ��������ࣨҵ���߼��㣩���е�DataAccess���������ñ��������������ݷ��ʷ�����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 16:55:49
    /// </summary>
    public abstract class BloodOxygenDAL
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬�ṩ�������ݷ��ʵĻ����������벻Ҫֱ���޸ĸ������е��κδ��룬  
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        //���棺�����ڻ��桰Ѫ������ࣨBloodOxygenDAL�����ݷ����ࡱ�ĵ���ʵ������Զ��Ҫֱ�ӷ��ʸñ�����
        private static BloodOxygenDAL bloodOxygenDAL;


        /// <summary>
        /// ��ȡ��Ѫ������ࣨBloodOxygenDAL�����ݷ����ࡱ��ʵ����������ͨ���ж�Ӧ�ó��������ļ������ݿ����͡�DataBaseType����ֵ��
        /// ����һ�����ڶ�ָ���������ݿ���з��ʵġ�Ѫ������ࣨBloodOxygenDAL�����ݷ����ࡱ��SqlServer/Oracle/OleDb��������ʵ����
        /// </summary>
        public static BloodOxygenDAL Instance
        {
            get
            {
                if (bloodOxygenDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            bloodOxygenDAL = new SqlServer.BloodOxygenDAL();
                            break;

                        case "Oracle":
                            bloodOxygenDAL = new Oracle.BloodOxygenDAL();
                            break;

                        case "OleDb":
                            bloodOxygenDAL = new OleDb.BloodOxygenDAL();
                            break;

                        default:
                            bloodOxygenDAL = new SqlServer.BloodOxygenDAL();
                            break;
                    }
                }
                return bloodOxygenDAL;
            }
        }


        /// <summary>
        /// ��DataReader�ж�ȡ���ݣ���ΪBloodOxygen������������Ը�ֵ���÷�����Ҫ�ɸ����������á�
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="bloodOxygen">Ѫ������ࣨBloodOxygen��ʵ������</param>
        protected void ReadBloodOxygenAllData(IDataReader dataReader, BloodOxygen bloodOxygen)
        {
            // ���
            if (dataReader["Id"] != DBNull.Value)
                bloodOxygen.Id = Convert.ToInt32(dataReader["Id"]);
            // �������
            if (dataReader["Checkdate"] != DBNull.Value)
                bloodOxygen.Checkdate = Convert.ToDateTime(dataReader["Checkdate"]);
            // �����
            if (dataReader["ExamNo"] != DBNull.Value)
                bloodOxygen.ExamNo = Convert.ToString(dataReader["ExamNo"]);
            // ����
            if (dataReader["CheckID"] != DBNull.Value)
                bloodOxygen.CheckID = Convert.ToString(dataReader["CheckID"]);
            // ����
            if (dataReader["Name"] != DBNull.Value)
                bloodOxygen.Name = Convert.ToString(dataReader["Name"]);
            // �Ա�
            if (dataReader["SexId"] != DBNull.Value)
                //�����������������
                bloodOxygen.Sex = T_Sex.GetDataById(Convert.ToString(dataReader["SexId"])) ?? T_Sex.Empty;
            // ����
            if (dataReader["Age"] != DBNull.Value)
                bloodOxygen.Age = Convert.ToInt32(dataReader["Age"]);
            // ����ҽ��
            if (dataReader["Doctor"] != DBNull.Value)
                bloodOxygen.Doctor = Convert.ToString(dataReader["Doctor"]);
            // �豸��
            if (dataReader["DeviceID"] != DBNull.Value)
                bloodOxygen.DeviceID = Convert.ToString(dataReader["DeviceID"]);
            // �汾��
            if (dataReader["Version"] != DBNull.Value)
                bloodOxygen.Version = Convert.ToString(dataReader["Version"]);
            // �����ֶ�
            if (dataReader["Reserve"] != DBNull.Value)
                bloodOxygen.Reserve = Convert.ToString(dataReader["Reserve"]);
            // �����
            if (dataReader["Check_flagId"] != DBNull.Value)
                //�����������������
                bloodOxygen.Check_flag = T_Check_Flag.GetDataById(Convert.ToInt32(dataReader["Check_flagId"])) ?? T_Check_Flag.Empty;
            // ҽԺ
            if (dataReader["Hosname"] != DBNull.Value)
                bloodOxygen.Hosname = Convert.ToString(dataReader["Hosname"]);
            // ���ҽ��
            if (dataReader["Auditdoctor"] != DBNull.Value)
                bloodOxygen.Auditdoctor = Convert.ToString(dataReader["Auditdoctor"]);
            // �������
            if (dataReader["Auditdate"] != DBNull.Value)
                bloodOxygen.Auditdate = Convert.ToDateTime(dataReader["Auditdate"]);
            // ״̬
            if (dataReader["StatusId"] != DBNull.Value)
                //�����������������
                bloodOxygen.Status = T_Status.GetDataById(Convert.ToInt32(dataReader["StatusId"])) ?? T_Status.Empty;
            // �ĵ����
            if (dataReader["Str1"] != DBNull.Value)
                bloodOxygen.Str1 = Convert.ToString(dataReader["Str1"]);
            // ����
            if (dataReader["Str2"] != DBNull.Value)
                bloodOxygen.Str2 = Convert.ToString(dataReader["Str2"]);
            // ���֤��
            if (dataReader["Str3"] != DBNull.Value)
                bloodOxygen.Str3 = Convert.ToString(dataReader["Str3"]);
            // ����
            if (dataReader["Str4"] != DBNull.Value)
                bloodOxygen.Str4 = Convert.ToString(dataReader["Str4"]);
            // ����
            if (dataReader["Str5"] != DBNull.Value)
                bloodOxygen.Str5 = Convert.ToString(dataReader["Str5"]);
            // ����
            if (dataReader["Str6"] != DBNull.Value)
                bloodOxygen.Str6 = Convert.ToString(dataReader["Str6"]);
            // ����
            if (dataReader["Str7"] != DBNull.Value)
                bloodOxygen.Str7 = Convert.ToString(dataReader["Str7"]);
            // ����
            if (dataReader["Str8"] != DBNull.Value)
                bloodOxygen.Str8 = Convert.ToString(dataReader["Str8"]);
            // ����
            if (dataReader["Str9"] != DBNull.Value)
                bloodOxygen.Str9 = Convert.ToString(dataReader["Str9"]);
            // ����
            if (dataReader["Str10"] != DBNull.Value)
                bloodOxygen.Str10 = Convert.ToString(dataReader["Str10"]);
            // Ѫ�����
            if (dataReader["T3001005_ename"] != DBNull.Value)
                bloodOxygen.T3001005_ename = Convert.ToString(dataReader["T3001005_ename"]);
            // Ѫ��ȫ��
            if (dataReader["T3001005_cname"] != DBNull.Value)
                bloodOxygen.T3001005_cname = Convert.ToString(dataReader["T3001005_cname"]);
            // Ѫ��UNIT
            if (dataReader["T3001005_unit"] != DBNull.Value)
                bloodOxygen.T3001005_unit = Convert.ToString(dataReader["T3001005_unit"]);
            // Ѫ������
            if (dataReader["T3001005_srange"] != DBNull.Value)
                bloodOxygen.T3001005_srange = Convert.ToInt32(dataReader["T3001005_srange"]);
            // Ѫ������
            if (dataReader["T3001005_lrange"] != DBNull.Value)
                bloodOxygen.T3001005_lrange = Convert.ToInt32(dataReader["T3001005_lrange"]);
            // Ѫ��ֵ
            if (dataReader["T3001005_value"] != DBNull.Value)
                bloodOxygen.T3001005_value = Convert.ToInt32(dataReader["T3001005_value"]);
            // ���ʼ��
            if (dataReader["T3001009_ename"] != DBNull.Value)
                bloodOxygen.T3001009_ename = Convert.ToString(dataReader["T3001009_ename"]);
            // ����ȫ��
            if (dataReader["T3001009_cname"] != DBNull.Value)
                bloodOxygen.T3001009_cname = Convert.ToString(dataReader["T3001009_cname"]);
            // UNIT(BPM)
            if (dataReader["T3001009_unit"] != DBNull.Value)
                bloodOxygen.T3001009_unit = Convert.ToString(dataReader["T3001009_unit"]);
            // ��������
            if (dataReader["T3001009_srange"] != DBNull.Value)
                bloodOxygen.T3001009_srange = Convert.ToInt32(dataReader["T3001009_srange"]);
            // ��������
            if (dataReader["T3001009_lrange"] != DBNull.Value)
                bloodOxygen.T3001009_lrange = Convert.ToInt32(dataReader["T3001009_lrange"]);
            // ����ֵ
            if (dataReader["T3001009_value"] != DBNull.Value)
                bloodOxygen.T3001009_value = Convert.ToInt32(dataReader["T3001009_value"]);
        }


        /// <summary>
        /// ��DataReader�ж�ȡ���ݣ���ΪBloodOxygen������Ҫ������ʾ�����Ը�ֵ���÷�����Ҫ�ɸ����������á�
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="bloodOxygen">Ѫ������ࣨBloodOxygen��ʵ������</param>
        protected void ReadBloodOxygenPageData(IDataReader dataReader, BloodOxygen bloodOxygen)
        {
            // ���
            if (dataReader["Id"] != DBNull.Value)
                bloodOxygen.Id = Convert.ToInt32(dataReader["Id"]);
            // �������
            if (dataReader["Checkdate"] != DBNull.Value)
                bloodOxygen.Checkdate = Convert.ToDateTime(dataReader["Checkdate"]);
            // �����
            if (dataReader["ExamNo"] != DBNull.Value)
                bloodOxygen.ExamNo = Convert.ToString(dataReader["ExamNo"]);
            // ����
            if (dataReader["CheckID"] != DBNull.Value)
                bloodOxygen.CheckID = Convert.ToString(dataReader["CheckID"]);
            // ����
            if (dataReader["Name"] != DBNull.Value)
                bloodOxygen.Name = Convert.ToString(dataReader["Name"]);
            // �Ա�
            if (dataReader["SexId"] != DBNull.Value)
                //�����������������
                bloodOxygen.Sex = T_Sex.GetDataById(Convert.ToString(dataReader["SexId"])) ?? T_Sex.Empty;
            // ����ҽ��
            if (dataReader["Doctor"] != DBNull.Value)
                bloodOxygen.Doctor = Convert.ToString(dataReader["Doctor"]);
            // �豸��
            if (dataReader["DeviceID"] != DBNull.Value)
                bloodOxygen.DeviceID = Convert.ToString(dataReader["DeviceID"]);
            // �����
            if (dataReader["Check_flagId"] != DBNull.Value)
                //�����������������
                bloodOxygen.Check_flag = T_Check_Flag.GetDataById(Convert.ToInt32(dataReader["Check_flagId"])) ?? T_Check_Flag.Empty;
            // ҽԺ
            if (dataReader["Hosname"] != DBNull.Value)
                bloodOxygen.Hosname = Convert.ToString(dataReader["Hosname"]);
            // ״̬
            if (dataReader["StatusId"] != DBNull.Value)
                //�����������������
                bloodOxygen.Status = T_Status.GetDataById(Convert.ToInt32(dataReader["StatusId"])) ?? T_Status.Empty;
        }


        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  �������ݷ�������󷽷����壬��SqlServer/Oracle/OleDb������ʵ�־��巽����  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>
        /// ��Ѫ������ࣨBloodOxygen�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="bloodOxygen">Ѫ������ࣨBloodOxygen��ʵ������</param>
        public abstract int Insert(BloodOxygen bloodOxygen);


        /// <summary>
        /// ��Ѫ������ࣨBloodOxygen�����ݣ�������������ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="bloodOxygen">Ѫ������ࣨBloodOxygen��ʵ������</param>
        public abstract int Update(BloodOxygen bloodOxygen);


        /// <summary>
        /// ����Ѫ������ࣨBloodOxygen������������ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">Ѫ������ࣨBloodOxygen������������ţ�Id����</param>
        public abstract int Delete(int id);


        /// <summary>
        /// ����Ѫ������ࣨBloodOxygen������������ţ�Id���������ݿ��л�ȡѪ������ࣨBloodOxygen����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼������Ѫ������ࣨBloodOxygen����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">Ѫ������ࣨBloodOxygen������������ţ�Id����</param>
        public abstract BloodOxygen GetDataById(int id);


        public abstract List<BloodOxygen> GetDatasByName(string name);
        /// <summary>
        /// �����ݿ��ж�ȡ����������Ѫ������ࣨBloodOxygen��List�б�
        /// </summary>
        public abstract List<BloodOxygen> GetAllList();


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ���Ѫ������ࣨBloodOxygen�����б���ҳ��Ϣ��
        /// �÷�������ȡ��Ѫ������ࣨBloodOxygen���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
        /// </summary>
        public abstract PageData GetPageList(int pageSize, int curPage);


        #endregion �����ʽ�µ�Ĭ�ϴ���

        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ˵������������Ĵ���Ϊ��ƿ�����Ա����д����ҪΪ��չ�����ݷ�����Ĺ��ܣ�������ı��������Լ�������ݷ��ʷ�����  
        //  ע�⣺Ϊ�˱�֤����Ŀ�Ķ����ݿ�֧������չ�ԣ������еķ���ͨ��Ϊ���󷽷�������ʵ���ɱ��������ͨ��������д��ɡ�  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l










    }
}
