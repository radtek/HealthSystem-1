using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// �������ƣ�Ѫѹ���������ʵ���ࣨ����ʵ��㣩
    /// ����˵����������Ϊ�������壬��ҵ���߼��㡢���ݷ��ʲ���á�
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 16:56:45
    /// </summary>
    [Serializable]
    public class Pressure
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
        /// <summary>[����]����־</summary>
        private T_Check_Flag check_flag;
        /// <summary>[����]ҽԺ</summary>
        private string hosname;
        /// <summary>[����]���ҽ��</summary>
        private string auditdoctor;
        /// <summary>[����]�������</summary>
        private DateTime? auditdate;
        /// <summary>[����]״̬</summary>
        private T_Status status;
        /// <summary>[����]��Ա����</summary>
        private string str1;
        /// <summary>[����]Ѫѹ��λ</summary>
        private string str2;
        /// <summary>[����]���֤��</summary>
        private string str3;
        /// <summary>[����]Ѫѹ����</summary>
        private string str4;
        /// <summary>[����]���۽���</summary>
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
        /// <summary>[����]����ѹ���</summary>
        private string t3001002_ename;
        /// <summary>[����]����ѹȫ��</summary>
        private string t3001002_cname;
        /// <summary>[����]����ѹUNIT</summary>
        private string t3001002_unit;
        /// <summary>[����]����ѹ����</summary>
        private int? t3001002_srange;
        /// <summary>[����]����ѹ����</summary>
        private int? t3001002_lrange;
        /// <summary>[����]����ѹֵ</summary>
        private int? t3001002_value;
        /// <summary>[����]����ѹ���</summary>
        private string t3001003_ename;
        /// <summary>[����]����ѹȫ��</summary>
        private string t3001003_cname;
        /// <summary>[����]����ѹUNIT</summary>
        private string t3001003_unit;
        /// <summary>[����]����ѹ����</summary>
        private int? t3001003_srange;
        /// <summary>[����]����ѹ����</summary>
        private int? t3001003_lrange;
        /// <summary>[����]����ѹֵ</summary>
        private int? t3001003_value;
        /// <summary>[����]ƽ��ѹ���</summary>
        private string t3001004_ename;
        /// <summary>[����]ƽ��ѹȫ��</summary>
        private string t3001004_cname;
        /// <summary>[����]ƽ��ѹUNIT</summary>
        private string t3001004_unit;
        /// <summary>[����]ƽ��ѹ����</summary>
        private int? t3001004_srange;
        /// <summary>[����]ƽ��ѹ����</summary>
        private int? t3001004_lrange;
        /// <summary>[����]ƽ��ѹֵ</summary>
        private int? t3001004_value;
        /// <summary>[����]���ʼ��</summary>
        private string t3001008_ename;
        /// <summary>[����]����ȫ��</summary>
        private string t3001008_cname;
        /// <summary>[����]����UNIT</summary>
        private string t3001008_unit;
        /// <summary>[����]��������</summary>
        private int? t3001008_srange;
        /// <summary>[����]��������</summary>
        private int? t3001008_lrange;
        /// <summary>[����]����ֵ</summary>
        private int? t3001008_value;


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
        /// <summary>[����]����־</summary>
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
        /// <summary>[����]��Ա����</summary>
        public string Str1
        {
            get { return str1; }
            set { str1 = value; }
        }
        /// <summary>[����]Ѫѹ��λ</summary>
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
        /// <summary>[����]Ѫѹ����</summary>
        public string Str4
        {
            get { return str4; }
            set { str4 = value; }
        }
        /// <summary>[����]���۽���</summary>
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
        /// <summary>[����]����ѹ���</summary>
        public string T3001002_ename
        {
            get { return t3001002_ename; }
            set { t3001002_ename = value; }
        }
        /// <summary>[����]����ѹȫ��</summary>
        public string T3001002_cname
        {
            get { return t3001002_cname; }
            set { t3001002_cname = value; }
        }
        /// <summary>[����]����ѹUNIT</summary>
        public string T3001002_unit
        {
            get { return t3001002_unit; }
            set { t3001002_unit = value; }
        }
        /// <summary>[����]����ѹ����</summary>
        public int? T3001002_srange
        {
            get { return t3001002_srange; }
            set { t3001002_srange = value; }
        }
        /// <summary>[����]����ѹ����</summary>
        public int? T3001002_lrange
        {
            get { return t3001002_lrange; }
            set { t3001002_lrange = value; }
        }
        /// <summary>[����]����ѹֵ</summary>
        public int? T3001002_value
        {
            get { return t3001002_value; }
            set { t3001002_value = value; }
        }
        /// <summary>[����]����ѹ���</summary>
        public string T3001003_ename
        {
            get { return t3001003_ename; }
            set { t3001003_ename = value; }
        }
        /// <summary>[����]����ѹȫ��</summary>
        public string T3001003_cname
        {
            get { return t3001003_cname; }
            set { t3001003_cname = value; }
        }
        /// <summary>[����]����ѹUNIT</summary>
        public string T3001003_unit
        {
            get { return t3001003_unit; }
            set { t3001003_unit = value; }
        }
        /// <summary>[����]����ѹ����</summary>
        public int? T3001003_srange
        {
            get { return t3001003_srange; }
            set { t3001003_srange = value; }
        }
        /// <summary>[����]����ѹ����</summary>
        public int? T3001003_lrange
        {
            get { return t3001003_lrange; }
            set { t3001003_lrange = value; }
        }
        /// <summary>[����]����ѹֵ</summary>
        public int? T3001003_value
        {
            get { return t3001003_value; }
            set { t3001003_value = value; }
        }
        /// <summary>[����]ƽ��ѹ���</summary>
        public string T3001004_ename
        {
            get { return t3001004_ename; }
            set { t3001004_ename = value; }
        }
        /// <summary>[����]ƽ��ѹȫ��</summary>
        public string T3001004_cname
        {
            get { return t3001004_cname; }
            set { t3001004_cname = value; }
        }
        /// <summary>[����]ƽ��ѹUNIT</summary>
        public string T3001004_unit
        {
            get { return t3001004_unit; }
            set { t3001004_unit = value; }
        }
        /// <summary>[����]ƽ��ѹ����</summary>
        public int? T3001004_srange
        {
            get { return t3001004_srange; }
            set { t3001004_srange = value; }
        }
        /// <summary>[����]ƽ��ѹ����</summary>
        public int? T3001004_lrange
        {
            get { return t3001004_lrange; }
            set { t3001004_lrange = value; }
        }
        /// <summary>[����]ƽ��ѹֵ</summary>
        public int? T3001004_value
        {
            get { return t3001004_value; }
            set { t3001004_value = value; }
        }
        /// <summary>[����]���ʼ��</summary>
        public string T3001008_ename
        {
            get { return t3001008_ename; }
            set { t3001008_ename = value; }
        }
        /// <summary>[����]����ȫ��</summary>
        public string T3001008_cname
        {
            get { return t3001008_cname; }
            set { t3001008_cname = value; }
        }
        /// <summary>[����]����UNIT</summary>
        public string T3001008_unit
        {
            get { return t3001008_unit; }
            set { t3001008_unit = value; }
        }
        /// <summary>[����]��������</summary>
        public int? T3001008_srange
        {
            get { return t3001008_srange; }
            set { t3001008_srange = value; }
        }
        /// <summary>[����]��������</summary>
        public int? T3001008_lrange
        {
            get { return t3001008_lrange; }
            set { t3001008_lrange = value; }
        }
        /// <summary>[����]����ֵ</summary>
        public int? T3001008_value
        {
            get { return t3001008_value; }
            set { t3001008_value = value; }
        }

        /// <summary>����д��ToString��������������Ϊ�������һ������ʱ�������ݿؼ��п���ֱ�Ӱ󶨲���ʾ������������ơ�</summary>
        public override string ToString()
        {
            return ExamNo;
        }

        #endregion �����ʽ�µ�Ĭ�ϴ���
    }
}
