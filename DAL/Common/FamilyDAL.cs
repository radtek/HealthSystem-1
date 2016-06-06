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
    /// �������ƣ���ͥͨ�����ݷ��ʸ��ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ����ͥ�ࣨҵ���߼��㣩����SqlServer,Oracle,OleDb�����ݿ���з��ʵ���ط������Լ�����ͨ�÷�������������е��á�
    /// ����˵��������Ϊ�������޷�����ʵ������ͨ������ʹ�á���ͥ�ࣨҵ���߼��㣩���е�DataAccess���������ñ��������������ݷ��ʷ�����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:18:21
    /// </summary>
    public abstract class FamilyDAL
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬�ṩ�������ݷ��ʵĻ����������벻Ҫֱ���޸ĸ������е��κδ��룬  
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        //���棺�����ڻ��桰��ͥ��FamilyDAL�����ݷ����ࡱ�ĵ���ʵ������Զ��Ҫֱ�ӷ��ʸñ�����
        private static FamilyDAL familyDAL;


        /// <summary>
        /// ��ȡ����ͥ��FamilyDAL�����ݷ����ࡱ��ʵ����������ͨ���ж�Ӧ�ó��������ļ������ݿ����͡�DataBaseType����ֵ��
        /// ����һ�����ڶ�ָ���������ݿ���з��ʵġ���ͥ��FamilyDAL�����ݷ����ࡱ��SqlServer/Oracle/OleDb��������ʵ����
        /// </summary>
        public static FamilyDAL Instance
        {
            get
            {
                if (familyDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            familyDAL = new SqlServer.FamilyDAL();
                            break;

                        case "Oracle":
                            familyDAL = new Oracle.FamilyDAL();
                            break;

                        case "OleDb":
                            familyDAL = new OleDb.FamilyDAL();
                            break;

                        default:
                            familyDAL = new SqlServer.FamilyDAL();
                            break;
                    }
                }
                return familyDAL;
            }
        }


        /// <summary>
        /// ��DataReader�ж�ȡ���ݣ���ΪFamily������������Ը�ֵ���÷�����Ҫ�ɸ����������á�
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="family">��ͥ��Family��ʵ������</param>
        protected void ReadFamilyAllData(IDataReader dataReader, Family family)
        {
            // ��ͥ������
            if (dataReader["Id"] != DBNull.Value)
                family.Id = Convert.ToInt32(dataReader["Id"]);
            // ��ͥ����
            if (dataReader["Name"] != DBNull.Value)
                family.Name = Convert.ToString(dataReader["Name"]);
            // ����
            if (dataReader["Owner"] != DBNull.Value)
                family.Owner = Convert.ToString(dataReader["Owner"]);
            // ��ͥ����
            if (dataReader["FamilyType"] != DBNull.Value)
                family.FamilyType = Convert.ToInt32(dataReader["FamilyType"]);
            // ס������
            if (dataReader["HousingTypes"] != DBNull.Value)
                family.HousingTypes = Convert.ToInt32(dataReader["HousingTypes"]);
            // ��ͥ������
            if (dataReader["Total"] != DBNull.Value)
                family.Total = Convert.ToInt32(dataReader["Total"]);
            // ����������
            if (dataReader["Old"] != DBNull.Value)
                family.Old = Convert.ToInt32(dataReader["Old"]);
            // ����ҽ��
            if (dataReader["ResponsibleDoctor"] != DBNull.Value)
                family.ResponsibleDoctor = Convert.ToString(dataReader["ResponsibleDoctor"]);
            // ��������
            if (dataReader["CreateDate"] != DBNull.Value)
                family.CreateDate = Convert.ToDateTime(dataReader["CreateDate"]);
            // �������
            if (dataReader["ManageInstitutionsId"] != DBNull.Value)
            {
                Institutions temp = InstitutionsDAL.Instance.GetDataById(Convert.ToInt32(dataReader["ManageInstitutionsId"]));
                if (temp != null) family.ManageInstitutions = temp;
            }
            // ��ע
            if (dataReader["Remark"] != DBNull.Value)
                family.Remark = Convert.ToString(dataReader["Remark"]);
        }


        /// <summary>
        /// ��DataReader�ж�ȡ���ݣ���ΪFamily������Ҫ������ʾ�����Ը�ֵ���÷�����Ҫ�ɸ����������á�
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="family">��ͥ��Family��ʵ������</param>
        protected void ReadFamilyPageData(IDataReader dataReader, Family family)
        {
            // ��ͥ������
            if (dataReader["Id"] != DBNull.Value)
                family.Id = Convert.ToInt32(dataReader["Id"]);
            // ��ͥ����
            if (dataReader["Name"] != DBNull.Value)
                family.Name = Convert.ToString(dataReader["Name"]);
            // ����
            if (dataReader["Owner"] != DBNull.Value)
                family.Owner = Convert.ToString(dataReader["Owner"]);
            // ��ͥ����
            if (dataReader["FamilyType"] != DBNull.Value)
                family.FamilyType = Convert.ToInt32(dataReader["FamilyType"]);
            // ס������
            if (dataReader["HousingTypes"] != DBNull.Value)
                family.HousingTypes = Convert.ToInt32(dataReader["HousingTypes"]);
            // ��ͥ������
            if (dataReader["Total"] != DBNull.Value)
                family.Total = Convert.ToInt32(dataReader["Total"]);
            // ����������
            if (dataReader["Old"] != DBNull.Value)
                family.Old = Convert.ToInt32(dataReader["Old"]);
            // ����ҽ��
            if (dataReader["ResponsibleDoctor"] != DBNull.Value)
                family.ResponsibleDoctor = Convert.ToString(dataReader["ResponsibleDoctor"]);
            // ��������
            if (dataReader["CreateDate"] != DBNull.Value)
                family.CreateDate = Convert.ToDateTime(dataReader["CreateDate"]);
        }


        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  �������ݷ�������󷽷����壬��SqlServer/Oracle/OleDb������ʵ�־��巽����  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>
        /// ����ͥ��Family�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="family">��ͥ��Family��ʵ������</param>
        public abstract int Insert(Family family);


        /// <summary>
        /// ����ͥ��Family�����ݣ�������������ͥ�����ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="family">��ͥ��Family��ʵ������</param>
        public abstract int Update(Family family);


        /// <summary>
        /// ���ݼ�ͥ��Family������������ͥ�����ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">��ͥ��Family������������ͥ�����ţ�Id����</param>
        public abstract int Delete(int id);


        /// <summary>
        /// ���ݼ�ͥ��Family������������ͥ�����ţ�Id���������ݿ��л�ȡ��ͥ��Family����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�����¼�ͥ��Family����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">��ͥ��Family������������ͥ�����ţ�Id����</param>
        public abstract Family GetDataById(int id);


        /// <summary>
        /// �����ݿ��ж�ȡ���������м�ͥ��Family��List�б�
        /// </summary>
        public abstract List<Family> GetAllList();


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ��ļ�ͥ��Family�����б���ҳ��Ϣ��
        /// �÷�������ȡ�ļ�ͥ��Family���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
        /// </summary>
        public abstract PageData GetPageList(int pageSize, int curPage);


        #endregion �����ʽ�µ�Ĭ�ϴ���

        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ˵������������Ĵ���Ϊ��ƿ�����Ա����д����ҪΪ��չ�����ݷ�����Ĺ��ܣ�������ı��������Լ�������ݷ��ʷ�����  
        //  ע�⣺Ϊ�˱�֤����Ŀ�Ķ����ݿ�֧������չ�ԣ������еķ���ͨ��Ϊ���󷽷�������ʵ���ɱ��������ͨ��������д��ɡ�  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l










    }
}
