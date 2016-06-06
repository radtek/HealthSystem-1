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
    /// �������ƣ�Ѫѹ�����ͨ�����ݷ��ʸ��ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ��Ѫѹ������ࣨҵ���߼��㣩����SqlServer,Oracle,OleDb�����ݿ���з��ʵ���ط������Լ�����ͨ�÷�������������е��á�
    /// ����˵��������Ϊ�������޷�����ʵ������ͨ������ʹ�á�Ѫѹ������ࣨҵ���߼��㣩���е�DataAccess���������ñ��������������ݷ��ʷ�����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 16:56:45
    /// </summary>
    public abstract class PressureDAL
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬�ṩ�������ݷ��ʵĻ����������벻Ҫֱ���޸ĸ������е��κδ��룬  
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        //���棺�����ڻ��桰Ѫѹ����ࣨPressureDAL�����ݷ����ࡱ�ĵ���ʵ������Զ��Ҫֱ�ӷ��ʸñ�����
        private static PressureDAL pressureDAL;


        /// <summary>
        /// ��ȡ��Ѫѹ����ࣨPressureDAL�����ݷ����ࡱ��ʵ����������ͨ���ж�Ӧ�ó��������ļ������ݿ����͡�DataBaseType����ֵ��
        /// ����һ�����ڶ�ָ���������ݿ���з��ʵġ�Ѫѹ����ࣨPressureDAL�����ݷ����ࡱ��SqlServer/Oracle/OleDb��������ʵ����
        /// </summary>
        public static PressureDAL Instance
        {
            get
            {
                if (pressureDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            pressureDAL = new SqlServer.PressureDAL();
                            break;

                        case "Oracle":
                            pressureDAL = new Oracle.PressureDAL();
                            break;

                        case "OleDb":
                            pressureDAL = new OleDb.PressureDAL();
                            break;

                        default:
                            pressureDAL = new SqlServer.PressureDAL();
                            break;
                    }
                }
                return pressureDAL;
            }
        }


        /// <summary>
        /// ��DataReader�ж�ȡ���ݣ���ΪPressure������������Ը�ֵ���÷�����Ҫ�ɸ����������á�
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="pressure">Ѫѹ����ࣨPressure��ʵ������</param>
        protected void ReadPressureAllData(IDataReader dataReader, Pressure pressure)
        {
            // ���
            if (dataReader["Id"] != DBNull.Value)
                pressure.Id = Convert.ToInt32(dataReader["Id"]);
            // �������
            if (dataReader["Checkdate"] != DBNull.Value)
                pressure.Checkdate = Convert.ToDateTime(dataReader["Checkdate"]);
            // �����
            if (dataReader["ExamNo"] != DBNull.Value)
                pressure.ExamNo = Convert.ToString(dataReader["ExamNo"]);
            // ����
            if (dataReader["CheckID"] != DBNull.Value)
                pressure.CheckID = Convert.ToString(dataReader["CheckID"]);
            // ����
            if (dataReader["Name"] != DBNull.Value)
                pressure.Name = Convert.ToString(dataReader["Name"]);
            // �Ա�
            if (dataReader["SexId"] != DBNull.Value)
                //���������������Ӷ���
                pressure.Sex = T_Sex.GetDataById(Convert.ToString(dataReader["SexId"])) ?? T_Sex.Empty;
            // ����
            if (dataReader["Age"] != DBNull.Value)
                pressure.Age = Convert.ToInt32(dataReader["Age"]);
            // ����ҽ��
            if (dataReader["Doctor"] != DBNull.Value)
                pressure.Doctor = Convert.ToString(dataReader["Doctor"]);
            // �豸��
            if (dataReader["DeviceID"] != DBNull.Value)
                pressure.DeviceID = Convert.ToString(dataReader["DeviceID"]);
            // �汾��
            if (dataReader["Version"] != DBNull.Value)
                pressure.Version = Convert.ToString(dataReader["Version"]);
            // �����ֶ�
            if (dataReader["Reserve"] != DBNull.Value)
                pressure.Reserve = Convert.ToString(dataReader["Reserve"]);
            // ����־
            if (dataReader["Check_flagId"] != DBNull.Value)
                //���������������Ӷ���
                pressure.Check_flag = T_Check_Flag.GetDataById(Convert.ToInt32(dataReader["Check_flagId"])) ?? T_Check_Flag.Empty;
            // ҽԺ
            if (dataReader["Hosname"] != DBNull.Value)
                pressure.Hosname = Convert.ToString(dataReader["Hosname"]);
            // ���ҽ��
            if (dataReader["Auditdoctor"] != DBNull.Value)
                pressure.Auditdoctor = Convert.ToString(dataReader["Auditdoctor"]);
            // �������
            if (dataReader["Auditdate"] != DBNull.Value)
                pressure.Auditdate = Convert.ToDateTime(dataReader["Auditdate"]);
            // ״̬
            if (dataReader["StatusId"] != DBNull.Value)
                //���������������Ӷ���
                pressure.Status = T_Status.GetDataById(Convert.ToInt32(dataReader["StatusId"])) ?? T_Status.Empty;
            // ��Ա����
            if (dataReader["Str1"] != DBNull.Value)
                pressure.Str1 = Convert.ToString(dataReader["Str1"]);
            // Ѫѹ��λ
            if (dataReader["Str2"] != DBNull.Value)
                pressure.Str2 = Convert.ToString(dataReader["Str2"]);
            // ���֤��
            if (dataReader["Str3"] != DBNull.Value)
                pressure.Str3 = Convert.ToString(dataReader["Str3"]);
            // Ѫѹ����
            if (dataReader["Str4"] != DBNull.Value)
                pressure.Str4 = Convert.ToString(dataReader["Str4"]);
            // ���۽���
            if (dataReader["Str5"] != DBNull.Value)
                pressure.Str5 = Convert.ToString(dataReader["Str5"]);
            // ����
            if (dataReader["Str6"] != DBNull.Value)
                pressure.Str6 = Convert.ToString(dataReader["Str6"]);
            // ����
            if (dataReader["Str7"] != DBNull.Value)
                pressure.Str7 = Convert.ToString(dataReader["Str7"]);
            // ����
            if (dataReader["Str8"] != DBNull.Value)
                pressure.Str8 = Convert.ToString(dataReader["Str8"]);
            // ����
            if (dataReader["Str9"] != DBNull.Value)
                pressure.Str9 = Convert.ToString(dataReader["Str9"]);
            // ����
            if (dataReader["Str10"] != DBNull.Value)
                pressure.Str10 = Convert.ToString(dataReader["Str10"]);
            // ����ѹ���
            if (dataReader["T3001002_ename"] != DBNull.Value)
                pressure.T3001002_ename = Convert.ToString(dataReader["T3001002_ename"]);
            // ����ѹȫ��
            if (dataReader["T3001002_cname"] != DBNull.Value)
                pressure.T3001002_cname = Convert.ToString(dataReader["T3001002_cname"]);
            // ����ѹUNIT
            if (dataReader["T3001002_unit"] != DBNull.Value)
                pressure.T3001002_unit = Convert.ToString(dataReader["T3001002_unit"]);
            // ����ѹ����
            if (dataReader["T3001002_srange"] != DBNull.Value)
                pressure.T3001002_srange = Convert.ToInt32(dataReader["T3001002_srange"]);
            // ����ѹ����
            if (dataReader["T3001002_lrange"] != DBNull.Value)
                pressure.T3001002_lrange = Convert.ToInt32(dataReader["T3001002_lrange"]);
            // ����ѹֵ
            if (dataReader["T3001002_value"] != DBNull.Value)
                pressure.T3001002_value = Convert.ToInt32(dataReader["T3001002_value"]);
            // ����ѹ���
            if (dataReader["T3001003_ename"] != DBNull.Value)
                pressure.T3001003_ename = Convert.ToString(dataReader["T3001003_ename"]);
            // ����ѹȫ��
            if (dataReader["T3001003_cname"] != DBNull.Value)
                pressure.T3001003_cname = Convert.ToString(dataReader["T3001003_cname"]);
            // ����ѹUNIT
            if (dataReader["T3001003_unit"] != DBNull.Value)
                pressure.T3001003_unit = Convert.ToString(dataReader["T3001003_unit"]);
            // ����ѹ����
            if (dataReader["T3001003_srange"] != DBNull.Value)
                pressure.T3001003_srange = Convert.ToInt32(dataReader["T3001003_srange"]);
            // ����ѹ����
            if (dataReader["T3001003_lrange"] != DBNull.Value)
                pressure.T3001003_lrange = Convert.ToInt32(dataReader["T3001003_lrange"]);
            // ����ѹֵ
            if (dataReader["T3001003_value"] != DBNull.Value)
                pressure.T3001003_value = Convert.ToInt32(dataReader["T3001003_value"]);
            // ƽ��ѹ���
            if (dataReader["T3001004_ename"] != DBNull.Value)
                pressure.T3001004_ename = Convert.ToString(dataReader["T3001004_ename"]);
            // ƽ��ѹȫ��
            if (dataReader["T3001004_cname"] != DBNull.Value)
                pressure.T3001004_cname = Convert.ToString(dataReader["T3001004_cname"]);
            // ƽ��ѹUNIT
            if (dataReader["T3001004_unit"] != DBNull.Value)
                pressure.T3001004_unit = Convert.ToString(dataReader["T3001004_unit"]);
            // ƽ��ѹ����
            if (dataReader["T3001004_srange"] != DBNull.Value)
                pressure.T3001004_srange = Convert.ToInt32(dataReader["T3001004_srange"]);
            // ƽ��ѹ����
            if (dataReader["T3001004_lrange"] != DBNull.Value)
                pressure.T3001004_lrange = Convert.ToInt32(dataReader["T3001004_lrange"]);
            // ƽ��ѹֵ
            if (dataReader["T3001004_value"] != DBNull.Value)
                pressure.T3001004_value = Convert.ToInt32(dataReader["T3001004_value"]);
            // ���ʼ��
            if (dataReader["T3001008_ename"] != DBNull.Value)
                pressure.T3001008_ename = Convert.ToString(dataReader["T3001008_ename"]);
            // ����ȫ��
            if (dataReader["T3001008_cname"] != DBNull.Value)
                pressure.T3001008_cname = Convert.ToString(dataReader["T3001008_cname"]);
            // ����UNIT
            if (dataReader["T3001008_unit"] != DBNull.Value)
                pressure.T3001008_unit = Convert.ToString(dataReader["T3001008_unit"]);
            // ��������
            if (dataReader["T3001008_srange"] != DBNull.Value)
                pressure.T3001008_srange = Convert.ToInt32(dataReader["T3001008_srange"]);
            // ��������
            if (dataReader["T3001008_lrange"] != DBNull.Value)
                pressure.T3001008_lrange = Convert.ToInt32(dataReader["T3001008_lrange"]);
            // ����ֵ
            if (dataReader["T3001008_value"] != DBNull.Value)
                pressure.T3001008_value = Convert.ToInt32(dataReader["T3001008_value"]);
        }


        /// <summary>
        /// ��DataReader�ж�ȡ���ݣ���ΪPressure������Ҫ������ʾ�����Ը�ֵ���÷�����Ҫ�ɸ����������á�
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="pressure">Ѫѹ����ࣨPressure��ʵ������</param>
        protected void ReadPressurePageData(IDataReader dataReader, Pressure pressure)
        {
            // ���
            if (dataReader["Id"] != DBNull.Value)
                pressure.Id = Convert.ToInt32(dataReader["Id"]);
            // �������
            if (dataReader["Checkdate"] != DBNull.Value)
                pressure.Checkdate = Convert.ToDateTime(dataReader["Checkdate"]);
            // �����
            if (dataReader["ExamNo"] != DBNull.Value)
                pressure.ExamNo = Convert.ToString(dataReader["ExamNo"]);
            // ����
            if (dataReader["CheckID"] != DBNull.Value)
                pressure.CheckID = Convert.ToString(dataReader["CheckID"]);
            // ����
            if (dataReader["Name"] != DBNull.Value)
                pressure.Name = Convert.ToString(dataReader["Name"]);
            // �Ա�
            if (dataReader["SexId"] != DBNull.Value)
                pressure.Sex = T_Sex.GetDataById(Convert.ToString(dataReader["SexId"])) ?? T_Sex.Empty;
            // ����ҽ��
            if (dataReader["Doctor"] != DBNull.Value)
                pressure.Doctor = Convert.ToString(dataReader["Doctor"]);
            // ����־
            if (dataReader["Check_flagId"] != DBNull.Value)
                pressure.Check_flag = T_Check_Flag.GetDataById(Convert.ToInt32(dataReader["Check_flagId"])) ?? T_Check_Flag.Empty;
            // ҽԺ
            if (dataReader["Hosname"] != DBNull.Value)
                pressure.Hosname = Convert.ToString(dataReader["Hosname"]);
            // ״̬
            if (dataReader["StatusId"] != DBNull.Value)
                pressure.Status = T_Status.GetDataById(Convert.ToInt32(dataReader["StatusId"])) ?? T_Status.Empty;
        }


        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  �������ݷ�������󷽷����壬��SqlServer/Oracle/OleDb������ʵ�־��巽����  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>
        /// ��Ѫѹ����ࣨPressure�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="pressure">Ѫѹ����ࣨPressure��ʵ������</param>
        public abstract int Insert(Pressure pressure);


        /// <summary>
        /// ��Ѫѹ����ࣨPressure�����ݣ�������������ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="pressure">Ѫѹ����ࣨPressure��ʵ������</param>
        public abstract int Update(Pressure pressure);


        /// <summary>
        /// ����Ѫѹ����ࣨPressure������������ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">Ѫѹ����ࣨPressure������������ţ�Id����</param>
        public abstract int Delete(int id);


        /// <summary>
        /// ����Ѫѹ����ࣨPressure������������ţ�Id���������ݿ��л�ȡѪѹ����ࣨPressure����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼������Ѫѹ����ࣨPressure����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">Ѫѹ����ࣨPressure������������ţ�Id����</param>
        public abstract Pressure GetDataById(int id);


        /// <summary>
        /// �����ݿ��ж�ȡ����������Ѫѹ����ࣨPressure��List�б�
        /// </summary>
        public abstract List<Pressure> GetAllList();


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ���Ѫѹ����ࣨPressure�����б���ҳ��Ϣ��
        /// �÷�������ȡ��Ѫѹ����ࣨPressure���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
        /// </summary>
        public abstract PageData GetPageList(int pageSize, int curPage);


        #endregion �����ʽ�µ�Ĭ�ϴ���

        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ˵������������Ĵ���Ϊ��ƿ�����Ա����д����ҪΪ��չ�����ݷ�����Ĺ��ܣ�������ı��������Լ�������ݷ��ʷ�����  
        //  ע�⣺Ϊ�˱�֤����Ŀ�Ķ����ݿ�֧������չ�ԣ������еķ���ͨ��Ϊ���󷽷�������ʵ���ɱ��������ͨ��������д��ɡ�  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l










    }
}
