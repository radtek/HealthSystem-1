using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class BasicInfo
    {
        public string examNO { get; set; }
        public string checkID { get; set; }
        public string name { get; set; }
        public int? sex { get; set; }
        public int? age { get; set; }
        public string doctor { get; set; }
        public DateTime? checkdate { get; set; }
        public string deviceID { get; set; }
        public string version { get; set; }
        public string reserve { get; set; }
        public int? check_flag { get; set; }
        public string hosname { get; set; }
        public string auditdoctor { get; set; }
        public DateTime? auditdate { get; set; }
        public int? status { get; set; }
        public string str1 { get; set; }
        public string str2 { get; set; }
        public string str3 { get; set; }
        //public string PressureLevel { get; set; }
        public string str4 { get; set; }
        public string str5 { get; set; }
        public string str6 { get; set; }
        public string str7 { get; set; }
        public string str8 { get; set; }
        public string str9 { get; set; }
        public string str10 { get; set; }
        public bool HasData = false;
    }
}