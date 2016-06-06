using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// �������ƣ���������ʵ���ࣨ����ʵ��㣩
    /// ����˵����������Ϊ�������壬��ҵ���߼��㡢���ݷ��ʲ���á�
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 16:41:14
    /// </summary>
    [Serializable]
    public class Resident
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬��Ҫ���ڶ������ı������ԡ��벻Ҫֱ���޸ĸ������е��κδ��룬  
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>[����]�Զ����</summary>
        private int? id;
        /// <summary>[����]�����</summary>
        private string residentId;
        /// <summary>[����]����</summary>
        private string name;
        /// <summary>[����]���֤��</summary>
        private string idNumber;
        /// <summary>[����]�Ա�</summary>
        private int? sex;
        /// <summary>[����]��ϵ�绰</summary>
        private string phone;
        /// <summary>[����]��������</summary>
        private DateTime? dateOfBirth;
        /// <summary>[����]����</summary>
        private string nation;
        /// <summary>[����]��ϵ������</summary>
        private string contactName;
        /// <summary>[����]��ϵ�˵绰</summary>
        private string contactPhone;
        /// <summary>[����]�Ļ��̶�</summary>
        private int? education;
        /// <summary>[����]Ѫ��</summary>
        private int? bloodType;
        /// <summary>[����]ְҵ</summary>
        private string professional;
        /// <summary>[����]������λ</summary>
        private string workUnits;
        /// <summary>[����]ҽ�Ʒ���֧����ʽ</summary>
        private int? payment;
        /// <summary>[����]��ͥ������</summary>
        private Family familyId;
        /// <summary>[����]����״��</summary>
        private int? maritalStatus;
        /// <summary>[����]��Ů��</summary>
        private int? children;
        /// <summary>[����]��������</summary>
        private string fathersName;
        /// <summary>[����]ĸ������</summary>
        private string motherName;
        /// <summary>[����]�໤������</summary>
        private string guardiansName;
        /// <summary>[����]�໤�˵绰</summary>
        private string guardianPhone;
        /// <summary>[����]��Ⱥ����</summary>
        private int? crowdType;
        /// <summary>[����]��ס����</summary>
        private int? residentialType;
        /// <summary>[����]��ס����</summary>
        private int? permanentType;
        /// <summary>[����]�������ڵ�</summary>
        private string registered;
        /// <summary>[����]������ַ</summary>
        private string registeredAddress;
        /// <summary>[����]�־�ס���ڵ�</summary>
        private string live;
        /// <summary>[����]�־�ס��ַ</summary>
        private string liveAddress;
        /// <summary>[����]��������</summary>
        private Institutions inputtingInstitutions;
        /// <summary>[����]������</summary>
        private string inputtingPerson;
        /// <summary>[����]����ʱ��</summary>
        private DateTime? inputtingTime;
        /// <summary>[����]����ҽ��</summary>
        private string responsibleDoctor;
        /// <summary>[����]����״̬</summary>
        private int? managementStatus;
        /// <summary>[����]����ʱ��</summary>
        private DateTime? enableTime;
        /// <summary>[����]�Ƿ�����ע��Ⱥ</summary>
        private bool? focusOn;
        /// <summary>[����]RH����</summary>
        private bool? rHNegative;
        /// <summary>[����]��ע</summary>
        private string remarks;


        /// <summary>[����]�Զ����</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[����]�����</summary>
        public string ResidentId
        {
            get { return residentId; }
            set { residentId = value; }
        }
        /// <summary>[����]����</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>[����]���֤��</summary>
        public string IdNumber
        {
            get { return idNumber; }
            set { idNumber = value; }
        }
        /// <summary>[����]�Ա�</summary>
        public int? Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        /// <summary>[����]��ϵ�绰</summary>
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        /// <summary>[����]��������</summary>
        public DateTime? DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        /// <summary>[����]����</summary>
        public string Nation
        {
            get { return nation; }
            set { nation = value; }
        }
        /// <summary>[����]��ϵ������</summary>
        public string ContactName
        {
            get { return contactName; }
            set { contactName = value; }
        }
        /// <summary>[����]��ϵ�˵绰</summary>
        public string ContactPhone
        {
            get { return contactPhone; }
            set { contactPhone = value; }
        }
        /// <summary>[����]�Ļ��̶�</summary>
        public int? Education
        {
            get { return education; }
            set { education = value; }
        }
        /// <summary>[����]Ѫ��</summary>
        public int? BloodType
        {
            get { return bloodType; }
            set { bloodType = value; }
        }
        /// <summary>[����]ְҵ</summary>
        public string Professional
        {
            get { return professional; }
            set { professional = value; }
        }
        /// <summary>[����]������λ</summary>
        public string WorkUnits
        {
            get { return workUnits; }
            set { workUnits = value; }
        }
        /// <summary>[����]ҽ�Ʒ���֧����ʽ</summary>
        public int? Payment
        {
            get { return payment; }
            set { payment = value; }
        }
        /// <summary>[����]��ͥ������</summary>
        public Family FamilyId
        {
            get { return familyId; }
            set { familyId = value; }
        }
        /// <summary>[����]����״��</summary>
        public int? MaritalStatus
        {
            get { return maritalStatus; }
            set { maritalStatus = value; }
        }
        /// <summary>[����]��Ů��</summary>
        public int? Children
        {
            get { return children; }
            set { children = value; }
        }
        /// <summary>[����]��������</summary>
        public string FathersName
        {
            get { return fathersName; }
            set { fathersName = value; }
        }
        /// <summary>[����]ĸ������</summary>
        public string MotherName
        {
            get { return motherName; }
            set { motherName = value; }
        }
        /// <summary>[����]�໤������</summary>
        public string GuardiansName
        {
            get { return guardiansName; }
            set { guardiansName = value; }
        }
        /// <summary>[����]�໤�˵绰</summary>
        public string GuardianPhone
        {
            get { return guardianPhone; }
            set { guardianPhone = value; }
        }
        /// <summary>[����]��Ⱥ����</summary>
        public int? CrowdType
        {
            get { return crowdType; }
            set { crowdType = value; }
        }
        /// <summary>[����]��ס����</summary>
        public int? ResidentialType
        {
            get { return residentialType; }
            set { residentialType = value; }
        }
        /// <summary>[����]��ס����</summary>
        public int? PermanentType
        {
            get { return permanentType; }
            set { permanentType = value; }
        }
        /// <summary>[����]�������ڵ�</summary>
        public string Registered
        {
            get { return registered; }
            set { registered = value; }
        }
        /// <summary>[����]������ַ</summary>
        public string RegisteredAddress
        {
            get { return registeredAddress; }
            set { registeredAddress = value; }
        }
        /// <summary>[����]�־�ס���ڵ�</summary>
        public string Live
        {
            get { return live; }
            set { live = value; }
        }
        /// <summary>[����]�־�ס��ַ</summary>
        public string LiveAddress
        {
            get { return liveAddress; }
            set { liveAddress = value; }
        }
        /// <summary>[����]��������</summary>
        public Institutions InputtingInstitutions
        {
            get { return inputtingInstitutions; }
            set { inputtingInstitutions = value; }
        }
        /// <summary>[����]������</summary>
        public string InputtingPerson
        {
            get { return inputtingPerson; }
            set { inputtingPerson = value; }
        }
        /// <summary>[����]����ʱ��</summary>
        public DateTime? InputtingTime
        {
            get { return inputtingTime; }
            set { inputtingTime = value; }
        }
        /// <summary>[����]����ҽ��</summary>
        public string ResponsibleDoctor
        {
            get { return responsibleDoctor; }
            set { responsibleDoctor = value; }
        }
        /// <summary>[����]����״̬</summary>
        public int? ManagementStatus
        {
            get { return managementStatus; }
            set { managementStatus = value; }
        }
        /// <summary>[����]����ʱ��</summary>
        public DateTime? EnableTime
        {
            get { return enableTime; }
            set { enableTime = value; }
        }
        /// <summary>[����]�Ƿ�����ע��Ⱥ</summary>
        public bool? FocusOn
        {
            get { return focusOn; }
            set { focusOn = value; }
        }
        /// <summary>[����]RH����</summary>
        public bool? RHNegative
        {
            get { return rHNegative; }
            set { rHNegative = value; }
        }
        /// <summary>[����]��ע</summary>
        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }

        /// <summary>����д��ToString��������������Ϊ�������һ������ʱ�������ݿؼ��п���ֱ�Ӱ󶨲���ʾ������������ơ�</summary>
        public override string ToString()
        {
            return Name;
        }

        #endregion �����ʽ�µ�Ĭ�ϴ���
    }
}
