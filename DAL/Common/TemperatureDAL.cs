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
    /// �������ƣ����¼����ͨ�����ݷ��ʸ��ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ�����¼�����ࣨҵ���߼��㣩����SqlServer,Oracle,OleDb�����ݿ���з��ʵ���ط������Լ�����ͨ�÷�������������е��á�
    /// ����˵��������Ϊ�������޷�����ʵ������ͨ������ʹ�á����¼�����ࣨҵ���߼��㣩���е�DataAccess���������ñ��������������ݷ��ʷ�����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 16:57:39
    /// </summary>
    public abstract class TemperatureDAL
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬�ṩ�������ݷ��ʵĻ����������벻Ҫֱ���޸ĸ������е��κδ��룬  
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        //���棺�����ڻ��桰���¼���ࣨTemperatureDAL�����ݷ����ࡱ�ĵ���ʵ������Զ��Ҫֱ�ӷ��ʸñ�����
        private static TemperatureDAL temperatureDAL;


        /// <summary>
        /// ��ȡ�����¼���ࣨTemperatureDAL�����ݷ����ࡱ��ʵ����������ͨ���ж�Ӧ�ó��������ļ������ݿ����͡�DataBaseType����ֵ��
        /// ����һ�����ڶ�ָ���������ݿ���з��ʵġ����¼���ࣨTemperatureDAL�����ݷ����ࡱ��SqlServer/Oracle/OleDb��������ʵ����
        /// </summary>
        public static TemperatureDAL Instance
        {
            get
            {
                if (temperatureDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            temperatureDAL = new SqlServer.TemperatureDAL();
                            break;

                        case "Oracle":
                            temperatureDAL = new Oracle.TemperatureDAL();
                            break;

                        case "OleDb":
                            temperatureDAL = new OleDb.TemperatureDAL();
                            break;

                        default:
                            temperatureDAL = new SqlServer.TemperatureDAL();
                            break;
                    }
                }
                return temperatureDAL;
            }
        }


        /// <summary>
        /// ��DataReader�ж�ȡ���ݣ���ΪTemperature������������Ը�ֵ���÷�����Ҫ�ɸ����������á�
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="temperature">���¼���ࣨTemperature��ʵ������</param>
        protected void ReadTemperatureAllData(IDataReader dataReader, Temperature temperature)
        {
            // ���
            if (dataReader["Id"] != DBNull.Value)
                temperature.Id = Convert.ToInt32(dataReader["Id"]);
            // �������
            if (dataReader["Checkdate"] != DBNull.Value)
                temperature.Checkdate = Convert.ToDateTime(dataReader["Checkdate"]);
            // �����
            if (dataReader["ExamNo"] != DBNull.Value)
                temperature.ExamNo = Convert.ToString(dataReader["ExamNo"]);
            // ����
            if (dataReader["CheckID"] != DBNull.Value)
                temperature.CheckID = Convert.ToString(dataReader["CheckID"]);
            // ����
            if (dataReader["Name"] != DBNull.Value)
                temperature.Name = Convert.ToString(dataReader["Name"]);
            // �Ա�
            if (dataReader["SexId"] != DBNull.Value)
                //�����������������
                temperature.Sex = T_Sex.GetDataById(Convert.ToString(dataReader["SexId"])) ?? T_Sex.Empty;
            // ����
            if (dataReader["Age"] != DBNull.Value)
                temperature.Age = Convert.ToInt32(dataReader["Age"]);
            // ����ҽ��
            if (dataReader["Doctor"] != DBNull.Value)
                temperature.Doctor = Convert.ToString(dataReader["Doctor"]);
            // �豸��
            if (dataReader["DeviceID"] != DBNull.Value)
                temperature.DeviceID = Convert.ToString(dataReader["DeviceID"]);
            // �汾��
            if (dataReader["Version"] != DBNull.Value)
                temperature.Version = Convert.ToString(dataReader["Version"]);
            // �����ֶ�
            if (dataReader["Reserve"] != DBNull.Value)
                temperature.Reserve = Convert.ToString(dataReader["Reserve"]);
            // ����־
            if (dataReader["Check_flagId"] != DBNull.Value)
                //�����������������
                temperature.Check_flag = T_Check_Flag.GetDataById(Convert.ToInt32(dataReader["Check_flagId"])) ?? T_Check_Flag.Empty;
            // ҽԺ
            if (dataReader["Hosname"] != DBNull.Value)
                temperature.Hosname = Convert.ToString(dataReader["Hosname"]);
            // ���ҽ��
            if (dataReader["Auditdoctor"] != DBNull.Value)
                temperature.Auditdoctor = Convert.ToString(dataReader["Auditdoctor"]);
            // �������
            if (dataReader["Auditdate"] != DBNull.Value)
                temperature.Auditdate = Convert.ToDateTime(dataReader["Auditdate"]);
            // ״̬
            if (dataReader["StatusId"] != DBNull.Value)
                //�����������������
                temperature.Status = T_Status.GetDataById(Convert.ToInt32(dataReader["StatusId"])) ?? T_Status.Empty;
            // ����
            if (dataReader["Str1"] != DBNull.Value)
                temperature.Str1 = Convert.ToString(dataReader["Str1"]);
            // ����
            if (dataReader["Str2"] != DBNull.Value)
                temperature.Str2 = Convert.ToString(dataReader["Str2"]);
            // ���֤��
            if (dataReader["Str3"] != DBNull.Value)
                temperature.Str3 = Convert.ToString(dataReader["Str3"]);
            // ����
            if (dataReader["Str4"] != DBNull.Value)
                temperature.Str4 = Convert.ToString(dataReader["Str4"]);
            // ����
            if (dataReader["Str5"] != DBNull.Value)
                temperature.Str5 = Convert.ToString(dataReader["Str5"]);
            // ����
            if (dataReader["Str6"] != DBNull.Value)
                temperature.Str6 = Convert.ToString(dataReader["Str6"]);
            // ����
            if (dataReader["Str7"] != DBNull.Value)
                temperature.Str7 = Convert.ToString(dataReader["Str7"]);
            // ����
            if (dataReader["Str8"] != DBNull.Value)
                temperature.Str8 = Convert.ToString(dataReader["Str8"]);
            // ����
            if (dataReader["Str9"] != DBNull.Value)
                temperature.Str9 = Convert.ToString(dataReader["Str9"]);
            // ����
            if (dataReader["Str10"] != DBNull.Value)
                temperature.Str10 = Convert.ToString(dataReader["Str10"]);
            // ���¼��
            if (dataReader["T3001007_ename"] != DBNull.Value)
                temperature.T3001007_ename = Convert.ToString(dataReader["T3001007_ename"]);
            // ����ȫ��
            if (dataReader["T3001007_cname"] != DBNull.Value)
                temperature.T3001007_cname = Convert.ToString(dataReader["T3001007_cname"]);
            // ����UNIT
            if (dataReader["T3001007_unit"] != DBNull.Value)
                temperature.T3001007_unit = Convert.ToString(dataReader["T3001007_unit"]);
            // ��������
            if (dataReader["T3001007_srange"] != DBNull.Value)
                temperature.T3001007_srange = Convert.ToInt32(dataReader["T3001007_srange"]);
            // ��������
            if (dataReader["T3001007_lrange"] != DBNull.Value)
                temperature.T3001007_lrange = Convert.ToInt32(dataReader["T3001007_lrange"]);
            // ����ֵ
            if (dataReader["T3001007_value"] != DBNull.Value)
                temperature.T3001007_value = Convert.ToInt32(dataReader["T3001007_value"]);
        }


        /// <summary>
        /// ��DataReader�ж�ȡ���ݣ���ΪTemperature������Ҫ������ʾ�����Ը�ֵ���÷�����Ҫ�ɸ����������á�
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="temperature">���¼���ࣨTemperature��ʵ������</param>
        protected void ReadTemperaturePageData(IDataReader dataReader, Temperature temperature)
        {
            // ���
            if (dataReader["Id"] != DBNull.Value)
                temperature.Id = Convert.ToInt32(dataReader["Id"]);
            // �������
            if (dataReader["Checkdate"] != DBNull.Value)
                temperature.Checkdate = Convert.ToDateTime(dataReader["Checkdate"]);
            // �����
            if (dataReader["ExamNo"] != DBNull.Value)
                temperature.ExamNo = Convert.ToString(dataReader["ExamNo"]);
            // ����
            if (dataReader["CheckID"] != DBNull.Value)
                temperature.CheckID = Convert.ToString(dataReader["CheckID"]);
            // ����
            if (dataReader["Name"] != DBNull.Value)
                temperature.Name = Convert.ToString(dataReader["Name"]);
            // �Ա�
            if (dataReader["SexId"] != DBNull.Value)
                //�����������������
                temperature.Sex = T_Sex.GetDataById(Convert.ToString(dataReader["SexId"])) ?? T_Sex.Empty;
            // ����ҽ��
            if (dataReader["Doctor"] != DBNull.Value)
                temperature.Doctor = Convert.ToString(dataReader["Doctor"]);
            // ����־
            if (dataReader["Check_flagId"] != DBNull.Value)
                //�����������������
                temperature.Check_flag = T_Check_Flag.GetDataById(Convert.ToInt32(dataReader["Check_flagId"])) ?? T_Check_Flag.Empty;
            // ҽԺ
            if (dataReader["Hosname"] != DBNull.Value)
                temperature.Hosname = Convert.ToString(dataReader["Hosname"]);
            // ״̬
            if (dataReader["StatusId"] != DBNull.Value)
                //�����������������
                temperature.Status = T_Status.GetDataById(Convert.ToInt32(dataReader["StatusId"])) ?? T_Status.Empty;
        }


        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  �������ݷ�������󷽷����壬��SqlServer/Oracle/OleDb������ʵ�־��巽����  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>
        /// �����¼���ࣨTemperature�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="temperature">���¼���ࣨTemperature��ʵ������</param>
        public abstract int Insert(Temperature temperature);


        /// <summary>
        /// �����¼���ࣨTemperature�����ݣ�������������ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="temperature">���¼���ࣨTemperature��ʵ������</param>
        public abstract int Update(Temperature temperature);


        /// <summary>
        /// �������¼���ࣨTemperature������������ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">���¼���ࣨTemperature������������ţ�Id����</param>
        public abstract int Delete(int id);


        /// <summary>
        /// �������¼���ࣨTemperature������������ţ�Id���������ݿ��л�ȡ���¼���ࣨTemperature����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼���������¼���ࣨTemperature����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">���¼���ࣨTemperature������������ţ�Id����</param>
        public abstract Temperature GetDataById(int id);


        /// <summary>
        /// �����ݿ��ж�ȡ�������������¼���ࣨTemperature��List�б�
        /// </summary>
        public abstract List<Temperature> GetAllList();


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ������¼���ࣨTemperature�����б���ҳ��Ϣ��
        /// �÷�������ȡ�����¼���ࣨTemperature���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
        /// </summary>
        public abstract PageData GetPageList(int pageSize, int curPage);


        #endregion �����ʽ�µ�Ĭ�ϴ���

        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ˵������������Ĵ���Ϊ��ƿ�����Ա����д����ҪΪ��չ�����ݷ�����Ĺ��ܣ�������ı��������Լ�������ݷ��ʷ�����  
        //  ע�⣺Ϊ�˱�֤����Ŀ�Ķ����ݿ�֧������չ�ԣ������еķ���ͨ��Ϊ���󷽷�������ʵ���ɱ��������ͨ��������д��ɡ�  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l










    }
}
