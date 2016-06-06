using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// �������ƣ���ͥ����ʵ���ࣨ����ʵ��㣩
    /// ����˵����������Ϊ�������壬��ҵ���߼��㡢���ݷ��ʲ���á�
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:18:21
    /// </summary>
    [Serializable]
    public class Family
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬��Ҫ���ڶ������ı������ԡ��벻Ҫֱ���޸ĸ������е��κδ��룬  
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>[����]��ͥ������</summary>
        private int? id;
        /// <summary>[����]��ͥ����</summary>
        private string name;
        /// <summary>[����]����</summary>
        private string owner;
        /// <summary>[����]��ͥ����</summary>
        private int? familyType;
        /// <summary>[����]ס������</summary>
        private int? housingTypes;
        /// <summary>[����]��ͥ������</summary>
        private int? total;
        /// <summary>[����]����������</summary>
        private int? old;
        /// <summary>[����]����ҽ��</summary>
        private string responsibleDoctor;
        /// <summary>[����]��������</summary>
        private DateTime? createDate;
        /// <summary>[����]�������</summary>
        private Institutions manageInstitutions;
        /// <summary>[����]��ע</summary>
        private string remark;


        /// <summary>[����]��ͥ������</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[����]��ͥ����</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>[����]����</summary>
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        /// <summary>[����]��ͥ����</summary>
        public int? FamilyType
        {
            get { return familyType; }
            set { familyType = value; }
        }
        /// <summary>[����]ס������</summary>
        public int? HousingTypes
        {
            get { return housingTypes; }
            set { housingTypes = value; }
        }
        /// <summary>[����]��ͥ������</summary>
        public int? Total
        {
            get { return total; }
            set { total = value; }
        }
        /// <summary>[����]����������</summary>
        public int? Old
        {
            get { return old; }
            set { old = value; }
        }
        /// <summary>[����]����ҽ��</summary>
        public string ResponsibleDoctor
        {
            get { return responsibleDoctor; }
            set { responsibleDoctor = value; }
        }
        /// <summary>[����]��������</summary>
        public DateTime? CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }
        /// <summary>[����]�������</summary>
        public Institutions ManageInstitutions
        {
            get { return manageInstitutions; }
            set { manageInstitutions = value; }
        }
        /// <summary>[����]��ע</summary>
        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }

        /// <summary>����д��ToString��������������Ϊ�������һ������ʱ�������ݿؼ��п���ֱ�Ӱ󶨲���ʾ������������ơ�</summary>
        public override string ToString()
        {
            return Name;
        }

        #endregion �����ʽ�µ�Ĭ�ϴ���
    }
}
