using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// 对象名称：血压检测类数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 16:56:45
    /// </summary>
    [Serializable]
    public class Pressure
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编号</summary>
        private int? id;
        /// <summary>[变量]检测日期</summary>
        private DateTime? checkdate;
        /// <summary>[变量]门诊号</summary>
        private string examNo;
        /// <summary>[变量]检查号</summary>
        private string checkID;
        /// <summary>[变量]姓名</summary>
        private string name;
        /// <summary>[变量]性别</summary>
        private T_Sex sex;
        /// <summary>[变量]年龄</summary>
        private int? age;
        /// <summary>[变量]开单医生</summary>
        private string doctor;
        /// <summary>[变量]设备号</summary>
        private string deviceID;
        /// <summary>[变量]版本号</summary>
        private string version;
        /// <summary>[变量]保留字段</summary>
        private string reserve;
        /// <summary>[变量]检查标志</summary>
        private T_Check_Flag check_flag;
        /// <summary>[变量]医院</summary>
        private string hosname;
        /// <summary>[变量]审核医生</summary>
        private string auditdoctor;
        /// <summary>[变量]审核日期</summary>
        private DateTime? auditdate;
        /// <summary>[变量]状态</summary>
        private T_Status status;
        /// <summary>[变量]人员类型</summary>
        private string str1;
        /// <summary>[变量]血压单位</summary>
        private string str2;
        /// <summary>[变量]身份证号</summary>
        private string str3;
        /// <summary>[变量]血压级别</summary>
        private string str4;
        /// <summary>[变量]结论建议</summary>
        private string str5;
        /// <summary>[变量]冗余</summary>
        private string str6;
        /// <summary>[变量]冗余</summary>
        private string str7;
        /// <summary>[变量]冗余</summary>
        private string str8;
        /// <summary>[变量]冗余</summary>
        private string str9;
        /// <summary>[变量]冗余</summary>
        private string str10;
        /// <summary>[变量]收缩压简称</summary>
        private string t3001002_ename;
        /// <summary>[变量]收缩压全称</summary>
        private string t3001002_cname;
        /// <summary>[变量]收缩压UNIT</summary>
        private string t3001002_unit;
        /// <summary>[变量]收缩压上限</summary>
        private int? t3001002_srange;
        /// <summary>[变量]收缩压下限</summary>
        private int? t3001002_lrange;
        /// <summary>[变量]收缩压值</summary>
        private int? t3001002_value;
        /// <summary>[变量]舒张压简称</summary>
        private string t3001003_ename;
        /// <summary>[变量]舒张压全称</summary>
        private string t3001003_cname;
        /// <summary>[变量]舒张压UNIT</summary>
        private string t3001003_unit;
        /// <summary>[变量]舒张压上限</summary>
        private int? t3001003_srange;
        /// <summary>[变量]舒张压下限</summary>
        private int? t3001003_lrange;
        /// <summary>[变量]舒张压值</summary>
        private int? t3001003_value;
        /// <summary>[变量]平均压简称</summary>
        private string t3001004_ename;
        /// <summary>[变量]平均压全称</summary>
        private string t3001004_cname;
        /// <summary>[变量]平均压UNIT</summary>
        private string t3001004_unit;
        /// <summary>[变量]平均压上限</summary>
        private int? t3001004_srange;
        /// <summary>[变量]平均压下限</summary>
        private int? t3001004_lrange;
        /// <summary>[变量]平均压值</summary>
        private int? t3001004_value;
        /// <summary>[变量]脉率简称</summary>
        private string t3001008_ename;
        /// <summary>[变量]脉率全称</summary>
        private string t3001008_cname;
        /// <summary>[变量]脉率UNIT</summary>
        private string t3001008_unit;
        /// <summary>[变量]脉率上限</summary>
        private int? t3001008_srange;
        /// <summary>[变量]脉率下限</summary>
        private int? t3001008_lrange;
        /// <summary>[变量]脉率值</summary>
        private int? t3001008_value;


        /// <summary>[属性]编号</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]检测日期</summary>
        public DateTime? Checkdate
        {
            get { return checkdate; }
            set { checkdate = value; }
        }
        /// <summary>[属性]门诊号</summary>
        public string ExamNo
        {
            get { return examNo; }
            set { examNo = value; }
        }
        /// <summary>[属性]检查号</summary>
        public string CheckID
        {
            get { return checkID; }
            set { checkID = value; }
        }
        /// <summary>[属性]姓名</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>[属性]性别</summary>
        public T_Sex Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        /// <summary>[属性]年龄</summary>
        public int? Age
        {
            get { return age; }
            set { age = value; }
        }
        /// <summary>[属性]开单医生</summary>
        public string Doctor
        {
            get { return doctor; }
            set { doctor = value; }
        }
        /// <summary>[属性]设备号</summary>
        public string DeviceID
        {
            get { return deviceID; }
            set { deviceID = value; }
        }
        /// <summary>[属性]版本号</summary>
        public string Version
        {
            get { return version; }
            set { version = value; }
        }
        /// <summary>[属性]保留字段</summary>
        public string Reserve
        {
            get { return reserve; }
            set { reserve = value; }
        }
        /// <summary>[属性]检查标志</summary>
        public T_Check_Flag Check_flag
        {
            get { return check_flag; }
            set { check_flag = value; }
        }
        /// <summary>[属性]医院</summary>
        public string Hosname
        {
            get { return hosname; }
            set { hosname = value; }
        }
        /// <summary>[属性]审核医生</summary>
        public string Auditdoctor
        {
            get { return auditdoctor; }
            set { auditdoctor = value; }
        }
        /// <summary>[属性]审核日期</summary>
        public DateTime? Auditdate
        {
            get { return auditdate; }
            set { auditdate = value; }
        }
        /// <summary>[属性]状态</summary>
        public T_Status Status
        {
            get { return status; }
            set { status = value; }
        }
        /// <summary>[属性]人员类型</summary>
        public string Str1
        {
            get { return str1; }
            set { str1 = value; }
        }
        /// <summary>[属性]血压单位</summary>
        public string Str2
        {
            get { return str2; }
            set { str2 = value; }
        }
        /// <summary>[属性]身份证号</summary>
        public string Str3
        {
            get { return str3; }
            set { str3 = value; }
        }
        /// <summary>[属性]血压级别</summary>
        public string Str4
        {
            get { return str4; }
            set { str4 = value; }
        }
        /// <summary>[属性]结论建议</summary>
        public string Str5
        {
            get { return str5; }
            set { str5 = value; }
        }
        /// <summary>[属性]冗余</summary>
        public string Str6
        {
            get { return str6; }
            set { str6 = value; }
        }
        /// <summary>[属性]冗余</summary>
        public string Str7
        {
            get { return str7; }
            set { str7 = value; }
        }
        /// <summary>[属性]冗余</summary>
        public string Str8
        {
            get { return str8; }
            set { str8 = value; }
        }
        /// <summary>[属性]冗余</summary>
        public string Str9
        {
            get { return str9; }
            set { str9 = value; }
        }
        /// <summary>[属性]冗余</summary>
        public string Str10
        {
            get { return str10; }
            set { str10 = value; }
        }
        /// <summary>[属性]收缩压简称</summary>
        public string T3001002_ename
        {
            get { return t3001002_ename; }
            set { t3001002_ename = value; }
        }
        /// <summary>[属性]收缩压全称</summary>
        public string T3001002_cname
        {
            get { return t3001002_cname; }
            set { t3001002_cname = value; }
        }
        /// <summary>[属性]收缩压UNIT</summary>
        public string T3001002_unit
        {
            get { return t3001002_unit; }
            set { t3001002_unit = value; }
        }
        /// <summary>[属性]收缩压上限</summary>
        public int? T3001002_srange
        {
            get { return t3001002_srange; }
            set { t3001002_srange = value; }
        }
        /// <summary>[属性]收缩压下限</summary>
        public int? T3001002_lrange
        {
            get { return t3001002_lrange; }
            set { t3001002_lrange = value; }
        }
        /// <summary>[属性]收缩压值</summary>
        public int? T3001002_value
        {
            get { return t3001002_value; }
            set { t3001002_value = value; }
        }
        /// <summary>[属性]舒张压简称</summary>
        public string T3001003_ename
        {
            get { return t3001003_ename; }
            set { t3001003_ename = value; }
        }
        /// <summary>[属性]舒张压全称</summary>
        public string T3001003_cname
        {
            get { return t3001003_cname; }
            set { t3001003_cname = value; }
        }
        /// <summary>[属性]舒张压UNIT</summary>
        public string T3001003_unit
        {
            get { return t3001003_unit; }
            set { t3001003_unit = value; }
        }
        /// <summary>[属性]舒张压上限</summary>
        public int? T3001003_srange
        {
            get { return t3001003_srange; }
            set { t3001003_srange = value; }
        }
        /// <summary>[属性]舒张压下限</summary>
        public int? T3001003_lrange
        {
            get { return t3001003_lrange; }
            set { t3001003_lrange = value; }
        }
        /// <summary>[属性]舒张压值</summary>
        public int? T3001003_value
        {
            get { return t3001003_value; }
            set { t3001003_value = value; }
        }
        /// <summary>[属性]平均压简称</summary>
        public string T3001004_ename
        {
            get { return t3001004_ename; }
            set { t3001004_ename = value; }
        }
        /// <summary>[属性]平均压全称</summary>
        public string T3001004_cname
        {
            get { return t3001004_cname; }
            set { t3001004_cname = value; }
        }
        /// <summary>[属性]平均压UNIT</summary>
        public string T3001004_unit
        {
            get { return t3001004_unit; }
            set { t3001004_unit = value; }
        }
        /// <summary>[属性]平均压上限</summary>
        public int? T3001004_srange
        {
            get { return t3001004_srange; }
            set { t3001004_srange = value; }
        }
        /// <summary>[属性]平均压下限</summary>
        public int? T3001004_lrange
        {
            get { return t3001004_lrange; }
            set { t3001004_lrange = value; }
        }
        /// <summary>[属性]平均压值</summary>
        public int? T3001004_value
        {
            get { return t3001004_value; }
            set { t3001004_value = value; }
        }
        /// <summary>[属性]脉率简称</summary>
        public string T3001008_ename
        {
            get { return t3001008_ename; }
            set { t3001008_ename = value; }
        }
        /// <summary>[属性]脉率全称</summary>
        public string T3001008_cname
        {
            get { return t3001008_cname; }
            set { t3001008_cname = value; }
        }
        /// <summary>[属性]脉率UNIT</summary>
        public string T3001008_unit
        {
            get { return t3001008_unit; }
            set { t3001008_unit = value; }
        }
        /// <summary>[属性]脉率上限</summary>
        public int? T3001008_srange
        {
            get { return t3001008_srange; }
            set { t3001008_srange = value; }
        }
        /// <summary>[属性]脉率下限</summary>
        public int? T3001008_lrange
        {
            get { return t3001008_lrange; }
            set { t3001008_lrange = value; }
        }
        /// <summary>[属性]脉率值</summary>
        public int? T3001008_value
        {
            get { return t3001008_value; }
            set { t3001008_value = value; }
        }

        /// <summary>已重写的ToString方法，当该类作为其它类的一个属性时，在数据控件中可以直接绑定并显示其有意义的名称。</summary>
        public override string ToString()
        {
            return ExamNo;
        }

        #endregion 多层框架式下的默认代码
    }
}
