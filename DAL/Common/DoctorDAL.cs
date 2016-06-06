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
    /// �������ƣ�����ҽ��ͨ�����ݷ��ʸ��ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ������ҽ���ࣨҵ���߼��㣩����SqlServer,Oracle,OleDb�����ݿ���з��ʵ���ط������Լ�����ͨ�÷�������������е��á�
    /// ����˵��������Ϊ�������޷�����ʵ������ͨ������ʹ�á�����ҽ���ࣨҵ���߼��㣩���е�DataAccess���������ñ��������������ݷ��ʷ�����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016/4/28 13:59:21
    /// </summary>
    public abstract class DoctorDAL
    {
        #region ������µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ��������Զ����ɣ��ṩ�������ݷ��ʵĻ����������벻Ҫֱ���޸ĸ������е��κδ��룬  
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö�����������ɸ������еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        //���棺�����ڻ��桰����ҽ����DoctorDAL�����ݷ����ࡱ�ĵ���ʵ������Զ��Ҫֱ�ӷ��ʸñ�����
        private static DoctorDAL doctorDAL;


        /// <summary>
        /// ��ȡ������ҽ����DoctorDAL�����ݷ����ࡱ��ʵ����������ͨ���ж�Ӧ�ó��������ļ������ݿ����͡�DataBaseType����ֵ��
        /// ����һ�����ڶ�ָ���������ݿ���з��ʵġ�����ҽ����DoctorDAL�����ݷ����ࡱ��SqlServer/Oracle/OleDb��������ʵ����
        /// </summary>
        public static DoctorDAL Instance
        {
            get
            {
                if (doctorDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            doctorDAL = new SqlServer.DoctorDAL();
                            break;

                        case "Oracle":
                            doctorDAL = new Oracle.DoctorDAL();
                            break;

                        case "OleDb":
                            doctorDAL = new OleDb.DoctorDAL();
                            break;

                        default:
                            doctorDAL = new SqlServer.DoctorDAL();
                            break;
                    }
                }
                return doctorDAL;
            }
        }


        /// <summary>
        /// ��DataReader�ж�ȡ���ݣ���ΪDoctor������������Ը�ֵ���÷�����Ҫ�ɸ����������á�
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="doctor">����ҽ����Doctor��ʵ������</param>
        protected void ReadDoctorAllData(IDataReader dataReader, Doctor doctor)
        {
            // �Զ����
            if (dataReader["Id"] != DBNull.Value)
                doctor.Id = Convert.ToInt32(dataReader["Id"]);
            // ҽ�����
            if (dataReader["DoctorId"] != DBNull.Value)
                doctor.DoctorId = Convert.ToString(dataReader["DoctorId"]);
            // ����
            if (dataReader["Name"] != DBNull.Value)
                doctor.Name = Convert.ToString(dataReader["Name"]);
            // �����
            if (dataReader["ExamNo"] != DBNull.Value)
                doctor.ExamNo = Convert.ToString(dataReader["ExamNo"]);
            // ����
            if (dataReader["Pwd"] != DBNull.Value)
                doctor.Pwd = Convert.ToString(dataReader["Pwd"]);
            // ���ڻ���
            if (dataReader["InstitutionId"] != DBNull.Value)
                doctor.Institution = InstitutionsDAL.Instance.GetDataById(Convert.ToInt32(dataReader["InstitutionId"]));
            // ��ע
            if (dataReader["Remarks"] != DBNull.Value)
                doctor.Remarks = Convert.ToString(dataReader["Remarks"]);
        }


        /// <summary>
        /// ��DataReader�ж�ȡ���ݣ���ΪDoctor������Ҫ������ʾ�����Ը�ֵ���÷�����Ҫ�ɸ����������á�
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="doctor">����ҽ����Doctor��ʵ������</param>
        protected void ReadDoctorPageData(IDataReader dataReader, Doctor doctor)
        {
            // �Զ����
            if (dataReader["Id"] != DBNull.Value)
                doctor.Id = Convert.ToInt32(dataReader["Id"]);
            // ҽ�����
            if (dataReader["DoctorId"] != DBNull.Value)
                doctor.DoctorId = Convert.ToString(dataReader["DoctorId"]);
            // ����
            if (dataReader["Name"] != DBNull.Value)
                doctor.Name = Convert.ToString(dataReader["Name"]);
            // �����
            if (dataReader["ExamNo"] != DBNull.Value)
                doctor.ExamNo = Convert.ToString(dataReader["ExamNo"]);
            // ����
            if (dataReader["Pwd"] != DBNull.Value)
                doctor.Pwd = Convert.ToString(dataReader["Pwd"]);
            // ���ڻ���
            if (dataReader["InstitutionId"] != DBNull.Value)
                doctor.Institution = InstitutionsDAL.Instance.GetDataById(Convert.ToInt32(dataReader["InstitutionId"]));
            // ��ע
            if (dataReader["Remarks"] != DBNull.Value)
                doctor.Remarks = Convert.ToString(dataReader["Remarks"]);
        }


        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  �������ݷ�������󷽷����壬��SqlServer/Oracle/OleDb������ʵ�־��巽����  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>
        /// ������ҽ����Doctor�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="doctor">����ҽ����Doctor��ʵ������</param>
        public abstract int Insert(Doctor doctor);


        /// <summary>
        /// ������ҽ����Doctor�����ݣ������������Զ���ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="doctor">����ҽ����Doctor��ʵ������</param>
        public abstract int Update(Doctor doctor);


        /// <summary>
        /// ��������ҽ����Doctor�����������Զ���ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">����ҽ����Doctor�����������Զ���ţ�Id����</param>
        public abstract int Delete(int id);


        /// <summary>
        /// ��������ҽ����Doctor�����������Զ���ţ�Id���������ݿ��л�ȡ����ҽ����Doctor����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼����������ҽ����Doctor����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">����ҽ����Doctor�����������Զ���ţ�Id����</param>
        public abstract Doctor GetDataById(int id);


        /// <summary>
        ///  ��������ҽ����Doctor���ġ�ҽ����ţ�DoctorId���������ݿ��л�ȡ����ҽ����Doctor����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼����������ҽ����Doctor����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="doctorid">����ҽ����Doctor���ġ�ҽ����ţ�DoctorId����</param>
        /// <returns></returns>
        public abstract Doctor GetDataByDoctorId(string doctorid);
      

        /// <summary>
        /// �����ݿ��ж�ȡ��������������ҽ����Doctor��List�б�
        /// </summary>
        public abstract List<Doctor> GetAllList();


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ�������ҽ����Doctor�����б���ҳ��Ϣ��
        /// �÷�������ȡ������ҽ����Doctor���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
        /// </summary>
        public abstract PageData GetPageList(int pageSize, int curPage);


        #endregion ������µ�Ĭ�ϴ���

        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ˵������������Ĵ���Ϊ��ƿ�����Ա����д����ҪΪ��չ�����ݷ�����Ĺ��ܣ�������ı��������Լ�������ݷ��ʷ�����  
        //  ע�⣺Ϊ�˱�֤����Ŀ�Ķ����ݿ�֧������չ�ԣ������еķ���ͨ��Ϊ���󷽷�������ʵ���ɱ��������ͨ��������д��ɡ�  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l










    }
}
