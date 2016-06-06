using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// �������ƣ�Ѫ�����������ʵ���ࣨ����ʵ��㣩
    /// ����˵����������Ϊ�������壬��ҵ���߼��㡢���ݷ��ʲ���á�
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 16:55:49
    /// </summary>
    [Serializable]
    public class BloodOxygen
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬��Ҫ���ڶ������ı������ԡ��벻Ҫֱ���޸ĸ������е��κδ��룬  
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>[����]���</summary>
        private int? id;
        /// <summary>[����]�������</summary>
        private DateTime? checkdate;
        /// <summary>[����]�����</summary>
        private string examNo;
        /// <summary>[����]����</summary>
        private string checkID;
        /// <summary>[����]����</summary>
        private string name;
        /// <summary>[����]�Ա�</summary>
        private T_Sex sex;
        /// <summary>[����]����</summary>
        private int? age;
        /// <summary>[����]����ҽ��</summary>
        private string doctor;
        /// <summary>[����]�豸��</summary>
        private string deviceID;
        /// <summary>[����]�汾��</summary>
        private string version;
        /// <summary>[����]�����ֶ�</summary>
        private string reserve;
        /// <summary>[����]�����</summary>
        private T_Check_Flag check_flag;
        /// <summary>[����]ҽԺ</summary>
        private string hosname;
        /// <summary>[����]���ҽ��</summary>
        private string auditdoctor;
        /// <summary>[����]�������</summary>
        private DateTime? auditdate;
        /// <summary>[����]״̬</summary>
        private T_Status status;
        /// <summary>[����]�ĵ����</summary>
        private string str1;
        /// <summary>[����]����</summary>
        private string str2;
        /// <summary>[����]���֤��</summary>
        private string str3;
        /// <summary>[����]����</summary>
        private string str4;
        /// <summary>[����]����</summary>
        private string str5;
        /// <summary>[����]����</summary>
        private string str6;
        /// <summary>[����]����</summary>
        private string str7;
        /// <summary>[����]����</summary>
        private string str8;
        /// <summary>[����]����</summary>
        private string str9;
        /// <summary>[����]����</summary>
        private string str10;
        /// <summary>[����]Ѫ�����</summary>
        private string t3001005_ename;
        /// <summary>[����]Ѫ��ȫ��</summary>
        private string t3001005_cname;
        /// <summary>[����]Ѫ��UNIT</summary>
        private string t3001005_unit;
        /// <summary>[����]Ѫ������</summary>
        private int? t3001005_srange;
        /// <summary>[����]Ѫ������</summary>
        private int? t3001005_lrange;
        /// <summary>[����]Ѫ��ֵ</summary>
        private int? t3001005_value;
        /// <summary>[����]���ʼ��</summary>
        private string t3001009_ename;
        /// <summary>[����]����ȫ��</summary>
        private string t3001009_cname;
        /// <summary>[����]UNIT(BPM)</summary>
        private string t3001009_unit;
        /// <summary>[����]��������</summary>
        private int? t3001009_srange;
        /// <summary>[����]��������</summary>
        private int? t3001009_lrange;
        /// <summary>[����]����ֵ</summary>
        private int? t3001009_value;


        /// <summary>[����]���</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[����]�������</summary>
        public DateTime? Checkdate
        {
            get { return checkdate; }
            set { checkdate = value; }
        }
        /// <summary>[����]�����</summary>
        public string ExamNo
        {
            get { return examNo; }
            set { examNo = value; }
        }
        /// <summary>[����]����</summary>
        public string CheckID
        {
            get { return checkID; }
            set { checkID = value; }
        }
        /// <summary>[����]����</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>[����]�Ա�</summary>
        public T_Sex Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        /// <summary>[����]����</summary>
        public int? Age
        {
            get { return age; }
            set { age = value; }
        }
        /// <summary>[����]����ҽ��</summary>
        public string Doctor
        {
            get { return doctor; }
            set { doctor = value; }
        }
        /// <summary>[����]�豸��</summary>
        public string DeviceID
        {
            get { return deviceID; }
            set { deviceID = value; }
        }
        /// <summary>[����]�汾��</summary>
        public string Version
        {
            get { return version; }
            set { version = value; }
        }
        /// <summary>[����]�����ֶ�</summary>
        public string Reserve
        {
            get { return reserve; }
            set { reserve = value; }
        }
        /// <summary>[����]�����</summary>
        public T_Check_Flag Check_flag
        {
            get { return check_flag; }
            set { check_flag = value; }
        }
        /// <summary>[����]ҽԺ</summary>
        public string Hosname
        {
            get { return hosname; }
            set { hosname = value; }
        }
        /// <summary>[����]���ҽ��</summary>
        public string Auditdoctor
        {
            get { return auditdoctor; }
            set { auditdoctor = value; }
        }
        /// <summary>[����]�������</summary>
        public DateTime? Auditdate
        {
            get { return auditdate; }
            set { auditdate = value; }
        }
        /// <summary>[����]״̬</summary>
        public T_Status Status
        {
            get { return status; }
            set { status = value; }
        }
        /// <summary>[����]�ĵ����</summary>
        public string Str1
        {
            get { return str1; }
            set { str1 = value; }
        }
        /// <summary>[����]����</summary>
        public string Str2
        {
            get { return str2; }
            set { str2 = value; }
        }
        /// <summary>[����]���֤��</summary>
        public string Str3
        {
            get { return str3; }
            set { str3 = value; }
        }
        /// <summary>[����]����</summary>
        public string Str4
        {
            get { return str4; }
            set { str4 = value; }
        }
        /// <summary>[����]����</summary>
        public string Str5
        {
            get { return str5; }
            set { str5 = value; }
        }
        /// <summary>[����]����</summary>
        public string Str6
        {
            get { return str6; }
            set { str6 = value; }
        }
        /// <summary>[����]����</summary>
        public string Str7
        {
            get { return str7; }
            set { str7 = value; }
        }
        /// <summary>[����]����</summary>
        public string Str8
        {
            get { return str8; }
            set { str8 = value; }
        }
        /// <summary>[����]����</summary>
        public string Str9
        {
            get { return str9; }
            set { str9 = value; }
        }
        /// <summary>[����]����</summary>
        public string Str10
        {
            get { return str10; }
            set { str10 = value; }
        }
        /// <summary>[����]Ѫ�����</summary>
        public string T3001005_ename
        {
            get { return t3001005_ename; }
            set { t3001005_ename = value; }
        }
        /// <summary>[����]Ѫ��ȫ��</summary>
        public string T3001005_cname
        {
            get { return t3001005_cname; }
            set { t3001005_cname = value; }
        }
        /// <summary>[����]Ѫ��UNIT</summary>
        public string T3001005_unit
        {
            get { return t3001005_unit; }
            set { t3001005_unit = value; }
        }
        /// <summary>[����]Ѫ������</summary>
        public int? T3001005_srange
        {
            get { return t3001005_srange; }
            set { t3001005_srange = value; }
        }
        /// <summary>[����]Ѫ������</summary>
        public int? T3001005_lrange
        {
            get { return t3001005_lrange; }
            set { t3001005_lrange = value; }
        }
        /// <summary>[����]Ѫ��ֵ</summary>
        public int? T3001005_value
        {
            get { return t3001005_value; }
            set { t3001005_value = value; }
        }
        /// <summary>[����]���ʼ��</summary>
        public string T3001009_ename
        {
            get { return t3001009_ename; }
            set { t3001009_ename = value; }
        }
        /// <summary>[����]����ȫ��</summary>
        public string T3001009_cname
        {
            get { return t3001009_cname; }
            set { t3001009_cname = value; }
        }
        /// <summary>[����]UNIT(BPM)</summary>
        public string T3001009_unit
        {
            get { return t3001009_unit; }
            set { t3001009_unit = value; }
        }
        /// <summary>[����]��������</summary>
        public int? T3001009_srange
        {
            get { return t3001009_srange; }
            set { t3001009_srange = value; }
        }
        /// <summary>[����]��������</summary>
        public int? T3001009_lrange
        {
            get { return t3001009_lrange; }
            set { t3001009_lrange = value; }
        }
        /// <summary>[����]����ֵ</summary>
        public int? T3001009_value
        {
            get { return t3001009_value; }
            set { t3001009_value = value; }
        }

        /// <summary>����д��ToString��������������Ϊ�������һ������ʱ�������ݿؼ��п���ֱ�Ӱ󶨲���ʾ������������ơ�</summary>
        public override string ToString()
        {
            return ExamNo;
        }

        #endregion �����ʽ�µ�Ĭ�ϴ���
    }
}
