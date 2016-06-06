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
    /// �������ƣ�����ͨ�����ݷ��ʸ��ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ�������ࣨҵ���߼��㣩����SqlServer,Oracle,OleDb�����ݿ���з��ʵ���ط������Լ�����ͨ�÷�������������е��á�
    /// ����˵��������Ϊ�������޷�����ʵ������ͨ������ʹ�á������ࣨҵ���߼��㣩���е�DataAccess���������ñ��������������ݷ��ʷ�����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 16:41:14
    /// </summary>
    public abstract class ResidentDAL
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬�ṩ�������ݷ��ʵĻ����������벻Ҫֱ���޸ĸ������е��κδ��룬  
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        //���棺�����ڻ��桰����ResidentDAL�����ݷ����ࡱ�ĵ���ʵ������Զ��Ҫֱ�ӷ��ʸñ�����
        private static ResidentDAL residentDAL;


        /// <summary>
        /// ��ȡ������ResidentDAL�����ݷ����ࡱ��ʵ����������ͨ���ж�Ӧ�ó��������ļ������ݿ����͡�DataBaseType����ֵ��
        /// ����һ�����ڶ�ָ���������ݿ���з��ʵġ�����ResidentDAL�����ݷ����ࡱ��SqlServer/Oracle/OleDb��������ʵ����
        /// </summary>
        public static ResidentDAL Instance
        {
            get
            {
                if (residentDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            residentDAL = new SqlServer.ResidentDAL();
                            break;

                        case "Oracle":
                            residentDAL = new Oracle.ResidentDAL();
                            break;

                        case "OleDb":
                            residentDAL = new OleDb.ResidentDAL();
                            break;

                        default:
                            residentDAL = new SqlServer.ResidentDAL();
                            break;
                    }
                }
                return residentDAL;
            }
        }


        /// <summary>
        /// ��DataReader�ж�ȡ���ݣ���ΪResident������������Ը�ֵ���÷�����Ҫ�ɸ����������á�
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="resident">����Resident��ʵ������</param>
        protected void ReadResidentAllData(IDataReader dataReader, Resident resident)
        {
            // �Զ����
            if (dataReader["Id"] != DBNull.Value)
                resident.Id = Convert.ToInt32(dataReader["Id"]);
            // �����
            if (dataReader["ResidentId"] != DBNull.Value)
                resident.ResidentId = Convert.ToString(dataReader["ResidentId"]);
            // ����
            if (dataReader["Name"] != DBNull.Value)
                resident.Name = Convert.ToString(dataReader["Name"]);
            // ���֤��
            if (dataReader["IdNumber"] != DBNull.Value)
                resident.IdNumber = Convert.ToString(dataReader["IdNumber"]);
            // �Ա�
            if (dataReader["Sex"] != DBNull.Value)
                resident.Sex = Convert.ToInt32(dataReader["Sex"]);
            // ��ϵ�绰
            if (dataReader["Phone"] != DBNull.Value)
                resident.Phone = Convert.ToString(dataReader["Phone"]);
            // ��������
            if (dataReader["DateOfBirth"] != DBNull.Value)
                resident.DateOfBirth = Convert.ToDateTime(dataReader["DateOfBirth"]);
            // ����
            if (dataReader["Nation"] != DBNull.Value)
                resident.Nation = Convert.ToString(dataReader["Nation"]);
            // ��ϵ������
            if (dataReader["ContactName"] != DBNull.Value)
                resident.ContactName = Convert.ToString(dataReader["ContactName"]);
            // ��ϵ�˵绰
            if (dataReader["ContactPhone"] != DBNull.Value)
                resident.ContactPhone = Convert.ToString(dataReader["ContactPhone"]);
            // �Ļ��̶�
            if (dataReader["Education"] != DBNull.Value)
                resident.Education = Convert.ToInt32(dataReader["Education"]);
            // Ѫ��
            if (dataReader["BloodType"] != DBNull.Value)
                resident.BloodType = Convert.ToInt32(dataReader["BloodType"]);
            // ְҵ
            if (dataReader["Professional"] != DBNull.Value)
                resident.Professional = Convert.ToString(dataReader["Professional"]);
            // ������λ
            if (dataReader["WorkUnits"] != DBNull.Value)
                resident.WorkUnits = Convert.ToString(dataReader["WorkUnits"]);
            // ҽ�Ʒ���֧����ʽ
            if (dataReader["Payment"] != DBNull.Value)
                resident.Payment = Convert.ToInt32(dataReader["Payment"]);
            // ��ͥ������
            if (dataReader["FamilyId"] != DBNull.Value)
            {
                Family tmpFamily = FamilyDAL.Instance.GetDataById(Convert.ToInt32(dataReader["FamilyId"]));
                if (tmpFamily != null) resident.FamilyId = tmpFamily;
            }
            // ����״��
            if (dataReader["MaritalStatus"] != DBNull.Value)
                resident.MaritalStatus = Convert.ToInt32(dataReader["MaritalStatus"]);
            // ��Ů��
            if (dataReader["Children"] != DBNull.Value)
                resident.Children = Convert.ToInt32(dataReader["Children"]);
            // ��������
            if (dataReader["FathersName"] != DBNull.Value)
                resident.FathersName = Convert.ToString(dataReader["FathersName"]);
            // ĸ������
            if (dataReader["MotherName"] != DBNull.Value)
                resident.MotherName = Convert.ToString(dataReader["MotherName"]);
            // �໤������
            if (dataReader["GuardiansName"] != DBNull.Value)
                resident.GuardiansName = Convert.ToString(dataReader["GuardiansName"]);
            // �໤�˵绰
            if (dataReader["GuardianPhone"] != DBNull.Value)
                resident.GuardianPhone = Convert.ToString(dataReader["GuardianPhone"]);
            // ��Ⱥ����
            if (dataReader["CrowdType"] != DBNull.Value)
                resident.CrowdType = Convert.ToInt32(dataReader["CrowdType"]);
            // ��ס����
            if (dataReader["ResidentialType"] != DBNull.Value)
                resident.ResidentialType = Convert.ToInt32(dataReader["ResidentialType"]);
            // ��ס����
            if (dataReader["PermanentType"] != DBNull.Value)
                resident.PermanentType = Convert.ToInt32(dataReader["PermanentType"]);
            // �������ڵ�
            if (dataReader["Registered"] != DBNull.Value)
                resident.Registered = Convert.ToString(dataReader["Registered"]);
            // ������ַ
            if (dataReader["RegisteredAddress"] != DBNull.Value)
                resident.RegisteredAddress = Convert.ToString(dataReader["RegisteredAddress"]);
            // �־�ס���ڵ�
            if (dataReader["Live"] != DBNull.Value)
                resident.Live = Convert.ToString(dataReader["Live"]);
            // �־�ס��ַ
            if (dataReader["LiveAddress"] != DBNull.Value)
                resident.LiveAddress = Convert.ToString(dataReader["LiveAddress"]);
            // ��������
            if (dataReader["InputtingInstitutions"] != DBNull.Value)
            {
                Institutions tmpInstitutions = InstitutionsDAL.Instance.GetDataById(Convert.ToInt32(dataReader["InputtingInstitutions"]));
                if (tmpInstitutions != null) resident.InputtingInstitutions = tmpInstitutions;
            }
            // ������
            if (dataReader["InputtingPerson"] != DBNull.Value)
                resident.InputtingPerson = Convert.ToString(dataReader["InputtingPerson"]);
            // ����ʱ��
            if (dataReader["InputtingTime"] != DBNull.Value)
                resident.InputtingTime = Convert.ToDateTime(dataReader["InputtingTime"]);
            // ����ҽ��
            if (dataReader["ResponsibleDoctor"] != DBNull.Value)
                resident.ResponsibleDoctor = Convert.ToString(dataReader["ResponsibleDoctor"]);
            // ����״̬
            if (dataReader["ManagementStatus"] != DBNull.Value)
                resident.ManagementStatus = Convert.ToInt32(dataReader["ManagementStatus"]);
            // ����ʱ��
            if (dataReader["EnableTime"] != DBNull.Value)
                resident.EnableTime = Convert.ToDateTime(dataReader["EnableTime"]);
            // �Ƿ�����ע��Ⱥ
            if (dataReader["FocusOn"] != DBNull.Value)
                resident.FocusOn = Convert.ToBoolean(dataReader["FocusOn"]);
            // RH����
            if (dataReader["RHNegative"] != DBNull.Value)
                resident.RHNegative = Convert.ToBoolean(dataReader["RHNegative"]);
            // ��ע
            if (dataReader["Remarks"] != DBNull.Value)
                resident.Remarks = Convert.ToString(dataReader["Remarks"]);
        }


        /// <summary>
        /// ��DataReader�ж�ȡ���ݣ���ΪResident������Ҫ������ʾ�����Ը�ֵ���÷�����Ҫ�ɸ����������á�
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="resident">����Resident��ʵ������</param>
        protected void ReadResidentPageData(IDataReader dataReader, Resident resident)
        {
            // �Զ����
            if (dataReader["Id"] != DBNull.Value)
                resident.Id = Convert.ToInt32(dataReader["Id"]);
            // �����
            if (dataReader["ResidentId"] != DBNull.Value)
                resident.ResidentId = Convert.ToString(dataReader["ResidentId"]);
            // ����
            if (dataReader["Name"] != DBNull.Value)
                resident.Name = Convert.ToString(dataReader["Name"]);
            // ���֤��
            if (dataReader["IdNumber"] != DBNull.Value)
                resident.IdNumber = Convert.ToString(dataReader["IdNumber"]);
            // �Ա�
            if (dataReader["Sex"] != DBNull.Value)
                resident.Sex = Convert.ToInt32(dataReader["Sex"]);
            // ��ͥ������
            if (dataReader["FamilyId"] != DBNull.Value)
            {
                Family tmpFamily = FamilyDAL.Instance.GetDataById(Convert.ToInt32(dataReader["FamilyId"]));
                if (tmpFamily != null) resident.FamilyId = tmpFamily;
            }
            // ��������
            if (dataReader["InputtingInstitutions"] != DBNull.Value)
            {
                Institutions tmpInstitutions = InstitutionsDAL.Instance.GetDataById(Convert.ToInt32(dataReader["InputtingInstitutions"]));
                if (tmpInstitutions != null) resident.InputtingInstitutions = tmpInstitutions;
            }
            // ������
            if (dataReader["InputtingPerson"] != DBNull.Value)
                resident.InputtingPerson = Convert.ToString(dataReader["InputtingPerson"]);
            // ����ʱ��
            if (dataReader["InputtingTime"] != DBNull.Value)
                resident.InputtingTime = Convert.ToDateTime(dataReader["InputtingTime"]);
            // ����ҽ��
            if (dataReader["ResponsibleDoctor"] != DBNull.Value)
                resident.ResponsibleDoctor = Convert.ToString(dataReader["ResponsibleDoctor"]);
            // ����״̬
            if (dataReader["ManagementStatus"] != DBNull.Value)
                resident.ManagementStatus = Convert.ToInt32(dataReader["ManagementStatus"]);
            // ����ʱ��
            if (dataReader["EnableTime"] != DBNull.Value)
                resident.EnableTime = Convert.ToDateTime(dataReader["EnableTime"]);
        }


        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  �������ݷ�������󷽷����壬��SqlServer/Oracle/OleDb������ʵ�־��巽����  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>
        /// ������Resident�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="resident">����Resident��ʵ������</param>
        public abstract int Insert(Resident resident);


        /// <summary>
        /// ������Resident�����ݣ������������Զ���ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="resident">����Resident��ʵ������</param>
        public abstract int Update(Resident resident);


        /// <summary>
        /// ���ݾ���Resident�����������Զ���ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">����Resident�����������Զ���ţ�Id����</param>
        public abstract int Delete(int id);


        /// <summary>
        /// ���ݾ���Resident�����������Զ���ţ�Id���������ݿ��л�ȡ����Resident����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�����¾���Resident����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">����Resident�����������Զ���ţ�Id����</param>
        public abstract Resident GetDataById(int id);


        /// <summary>
        /// �����ݿ��ж�ȡ���������о���Resident��List�б�
        /// </summary>
        public abstract List<Resident> GetAllList();


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ��ľ���Resident�����б���ҳ��Ϣ��
        /// �÷�������ȡ�ľ���Resident���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
        /// </summary>
        public abstract PageData GetPageList(int pageSize, int curPage);


        #endregion �����ʽ�µ�Ĭ�ϴ���

        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ˵������������Ĵ���Ϊ��ƿ�����Ա����д����ҪΪ��չ�����ݷ�����Ĺ��ܣ�������ı��������Լ�������ݷ��ʷ�����  
        //  ע�⣺Ϊ�˱�֤����Ŀ�Ķ����ݿ�֧������չ�ԣ������еķ���ͨ��Ϊ���󷽷�������ʵ���ɱ��������ͨ��������д��ɡ�  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l










    }
}
