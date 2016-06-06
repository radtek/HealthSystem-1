using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Web;
using System.Xml;
using System.Configuration;

namespace WcfService1
{
    enum DataName { T3001002, T3001003, T3001004, T3001008, T3001005, T3001009, T3001007 };

    public class XMLHelper
    {
        public static BasicInfo bi { get; set; }

        public static T ReadXml<T>(string sxml)
        {
            var ds = default(T);

            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(sxml)))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(T));
                ds = (T)serializer.ReadObject(ms);
                return ds;
            }
        }


        public static string SelectXml(string xml, string xpath)
        {
            try
            {

                XmlDocument DOC = new XmlDocument();
                DOC.LoadXml(xml);

                XmlElement root = DOC.DocumentElement;

                return root.SelectSingleNode(xpath).OuterXml;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "fail";
        }
        public static BasicInfo XmlToBasicInfo(string sxml)
        {
            string sql = @"insert into Resident(ResidentId,Name,IdNumber,Sex,DateOfBirth) values('{0}','{1}','{2}','{3}','{4}')";
            string sql2 = @"select count(*) from Resident where IdNumber='{0}'";
            BasicInfo basic = new BasicInfo();
            try
            {
                XmlDocument DOC = new XmlDocument();
                DOC.LoadXml(sxml);
                XmlElement root = DOC.DocumentElement;

                basic.examNO = root.SelectSingleNode("/baseInfo/Record/examNo").InnerText;
                basic.doctor = root.SelectSingleNode("/baseInfo/Record/doctor").InnerText;
                basic.deviceID = root.SelectSingleNode("/baseInfo/Record/deviceID").InnerText;
                basic.checkdate = DateTimeTryParse(root.SelectSingleNode("/baseInfo/Record/checkdate").InnerText);
                basic.age = IntTryParse(root.SelectSingleNode("/baseInfo/Record/age").InnerText);
                basic.auditdate = DateTimeTryParse(root.SelectSingleNode("/baseInfo/Record/auditdate").InnerText);
                basic.auditdoctor = root.SelectSingleNode("/baseInfo/Record/auditdoctor").InnerText;
                basic.checkID = root.SelectSingleNode("/baseInfo/Record/checkID").InnerText;
                basic.check_flag = IntTryParse(root.SelectSingleNode("/baseInfo/Record/check_flag").InnerText);
                basic.hosname = root.SelectSingleNode("/baseInfo/Record/hosname").InnerText;
                basic.name = root.SelectSingleNode("/baseInfo/Record/name").InnerText;
                //basic.PressureLevel = root.SelectSingleNode("/baseInfo/Record/str4/PressureLevel").InnerText;
                basic.str4 = root.SelectSingleNode("/baseInfo/Record/str4").InnerText;
                basic.reserve = root.SelectSingleNode("/baseInfo/Record/reserve").InnerText;
                basic.sex = IntTryParse(root.SelectSingleNode("/baseInfo/Record/sex").InnerText);
                basic.status = IntTryParse(root.SelectSingleNode("/baseInfo/Record/status").InnerText);
                basic.str1 = root.SelectSingleNode("/baseInfo/Record/str1").InnerText;
                basic.str10 = root.SelectSingleNode("/baseInfo/Record/str10").InnerText;
                basic.str2 = root.SelectSingleNode("/baseInfo/Record/str2").InnerText;
                basic.str3 = root.SelectSingleNode("/baseInfo/Record/str3").InnerText;
                basic.str5 = root.SelectSingleNode("/baseInfo/Record/str5").InnerText;
                basic.str6 = root.SelectSingleNode("/baseInfo/Record/str6").InnerText;
                basic.str7 = root.SelectSingleNode("/baseInfo/Record/str7").InnerText;
                basic.str8 = root.SelectSingleNode("/baseInfo/Record/str8").InnerText;
                basic.str9 = root.SelectSingleNode("/baseInfo/Record/str9").InnerText;
                basic.version = root.SelectSingleNode("/baseInfo/Record/version").InnerText;
                string s = String.Format(sql2, basic.str3);
                int number = DBHelper.ExecuteScalarSql(s, DBHelper.ConnectionString);

                if (number != 0)
                {
                    Configuration cf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    string temp = ConfigurationManager.AppSettings["residentId"].ToString();
                    string t;
                    fun(Convert.ToInt32(temp)+1, 10, out t);
                  
                    cf.AppSettings.Settings["residentId"].Value = t;
                    cf.Save();
                    string s2 = String.Format(sql, t, basic.name, basic.str3, basic.sex, basic.str10);
                    DBHelper.ExecuteNonQuerySql(s2, DBHelper.ConnectionString);
                }

                basic.HasData = true;
                bi = basic;
                return basic;
            }
            catch (Exception esx)
            {
                return basic;
            }
            finally
            {

            }


        }

        private static void fun(int c, int n, out string temp)
        {
            int max = 100000;
            if (c / n > 0)
            {
                fun(c, n * 10, out temp);
            }
            else
            {
                temp = c.ToString();
                n = max / n;
                for (; n > 0; n = n / 10)
                {
                    temp = "0" + temp;
                }
            }
        }
        public static Pressure XmlToPressure(string sxml)
        {
            string sql = @"insert into Pressure values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}',
                        '{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}',
                        '{29}','{30}','{31}','{32}','{33}','{34}','{35}','{36}','{37}','{38}','{39}','{40}','{41}','{42}','{43}','{44}',
                        '{45}','{46}','{47}',{48})";
            Data[] temp = new Data[4];
            Pressure pressure = new Pressure();
            try
            {
                XmlDocument DOC = new XmlDocument();
                DOC.LoadXml(sxml);
                XmlElement root = DOC.DocumentElement;

                for (int i = 0; i < 4; ++i)
                {

                    Data item = new Data();
                    string cname = "/Pressure" + "/" + ((DataName)i).ToString() + "/CNAME";
                    string ename = "/Pressure" + "/" + ((DataName)i).ToString() + "/ENAME";
                    string lrange = "/Pressure" + "/" + ((DataName)i).ToString() + "/LRANGE";
                    string srange = "/Pressure" + "/" + ((DataName)i).ToString() + "/SRANGE";
                    string unit = "/Pressure" + "/" + ((DataName)i).ToString() + "/UNIT";
                    string value = "/Pressure" + "/" + ((DataName)i).ToString() + "/VALUE";
                    //item.CNAME = no.SelectSingleNode(cname).InnerText;
                    item.CNAME = root.SelectSingleNode(cname).InnerText;
                    item.ENAME = root.SelectSingleNode(ename).InnerText;
                    item.LRANGE = IntTryParse(root.SelectSingleNode(lrange).InnerText);
                    item.SRANGE = IntTryParse(root.SelectSingleNode(srange).InnerText);
                    item.UNIT = root.SelectSingleNode(unit).InnerText;
                    item.VALUE = IntTryParse(root.SelectSingleNode(value).InnerText);
                    pressure.data.Add(item);
                    temp[i] = item;
                }

                string s = String.Format(sql, bi.checkdate, bi.examNO, bi.checkID, bi.name, bi.sex, bi.age, bi.doctor, bi.deviceID, bi.version,
                           bi.reserve, bi.check_flag, bi.hosname, bi.auditdoctor, bi.auditdate, bi.status, bi.str1, bi.str2, bi.str3, bi.str4, bi.str5, bi.str6, bi.str7,
                           bi.str8, bi.str9, bi.str10, temp[0].ENAME, temp[0].CNAME, temp[0].UNIT, temp[0].SRANGE, temp[0].LRANGE, temp[0].VALUE, temp[1].ENAME,
                           temp[1].CNAME, temp[1].UNIT, temp[1].SRANGE, temp[1].LRANGE, temp[1].VALUE, temp[2].ENAME, temp[2].CNAME, temp[2].UNIT, temp[2].SRANGE,
                           temp[2].LRANGE, temp[2].VALUE, temp[3].ENAME, temp[3].CNAME, temp[3].UNIT, temp[3].SRANGE, temp[3].LRANGE, temp[3].VALUE);
                int flag = DBHelper.ExecuteNonQuerySql(s, DBHelper.ConnectionString);
                if (flag > 0)
                {
                    pressure.HasData = true;
                }

                return pressure;
            }
            catch
            {
                return pressure;
            }

        }

        public static BloodOxygen XmlToBloodOxygen(string sxml)
        {
            string sql = @"insert into BloodOxygen values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}',
                        '{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}','{29}','{30}',
                        '{31}','{32}','{33}','{34}','{35}',{36})";
            Data[] temp = new Data[2];
            BloodOxygen bloodoxygen = new BloodOxygen();
            try
            {
                XmlDocument DOC = new XmlDocument();
                DOC.LoadXml(sxml);
                XmlElement root = DOC.DocumentElement;

                for (int i = 4; i < 6; ++i)
                {

                    Data item = new Data();
                    string cname = "/CSBoard" + "/" + ((DataName)i).ToString() + "/CNAME";
                    string ename = "/CSBoard" + "/" + ((DataName)i).ToString() + "/ENAME";
                    string lrange = "/CSBoard" + "/" + ((DataName)i).ToString() + "/LRANGE";
                    string srange = "/CSBoard" + "/" + ((DataName)i).ToString() + "/SRANGE";
                    string unit = "/CSBoard" + "/" + ((DataName)i).ToString() + "/UNIT";
                    string value = "/CSBoard" + "/" + ((DataName)i).ToString() + "/VALUE";
                    //item.CNAME = no.SelectSingleNode(cname).InnerText;
                    item.CNAME = root.SelectSingleNode(cname).InnerText;
                    item.ENAME = root.SelectSingleNode(ename).InnerText;
                    item.LRANGE = IntTryParse(root.SelectSingleNode(lrange).InnerText);
                    item.SRANGE = IntTryParse(root.SelectSingleNode(srange).InnerText);
                    item.UNIT = root.SelectSingleNode(unit).InnerText;
                    item.VALUE = IntTryParse(root.SelectSingleNode(value).InnerText);
                    bloodoxygen.data.Add(item);
                    temp[i - 4] = item;
                }
                string s = String.Format(sql, bi.checkdate, bi.examNO, bi.checkID, bi.name, bi.sex, bi.age, bi.doctor, bi.deviceID, bi.version,
                           bi.reserve, bi.check_flag, bi.hosname, bi.auditdoctor, bi.auditdate, bi.status, bi.str1, bi.str2, bi.str3, bi.str4, bi.str5, bi.str6, bi.str7,
                           bi.str8, bi.str9, bi.str10, temp[0].ENAME, temp[0].CNAME, temp[0].UNIT, temp[0].SRANGE, temp[0].LRANGE, temp[0].VALUE, temp[1].ENAME,
                           temp[1].CNAME, temp[1].UNIT, temp[1].SRANGE, temp[1].LRANGE, temp[1].VALUE);
                int flag = DBHelper.ExecuteNonQuerySql(s, DBHelper.ConnectionString);
                if (flag > 0)
                {
                    bloodoxygen.HasData = true;
                }

                return bloodoxygen;
            }
            catch
            {
                return bloodoxygen;
            }

        }

        public static Temperature XmlToTemperature(string sxml)
        {
            string sql = @"insert into Temperature values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}',
                        '{15}','{16}','{17}','{18}','{19}','{20}','{21}','{22}','{23}','{24}','{25}','{26}','{27}','{28}','{29}','{30}',{31})";
            Temperature temperature = new Temperature();
            try
            {
                XmlDocument DOC = new XmlDocument();
                DOC.LoadXml(sxml);
                XmlElement root = DOC.DocumentElement;

                int i = 6;

                Data item = new Data();
                string cname = "/TempValue" + "/" + ((DataName)i).ToString() + "/CNAME";
                string ename = "/TempValue" + "/" + ((DataName)i).ToString() + "/ENAME";
                string lrange = "/TempValue" + "/" + ((DataName)i).ToString() + "/LRANGE";
                string srange = "/TempValue" + "/" + ((DataName)i).ToString() + "/SRANGE";
                string unit = "/TempValue" + "/" + ((DataName)i).ToString() + "/UNIT";
                string value = "/TempValue" + "/" + ((DataName)i).ToString() + "/VALUE";
                //item.CNAME = no.SelectSingleNode(cname).InnerText;
                item.CNAME = root.SelectSingleNode(cname).InnerText;
                item.ENAME = root.SelectSingleNode(ename).InnerText;
                item.LRANGE = IntTryParse(root.SelectSingleNode(lrange).InnerText);
                item.SRANGE = IntTryParse(root.SelectSingleNode(srange).InnerText);
                item.UNIT = root.SelectSingleNode(unit).InnerText;
                item.VALUE = IntTryParse(root.SelectSingleNode(value).InnerText);
                temperature.data.Add(item);
                string s = String.Format(sql, bi.checkdate, bi.examNO, bi.checkID, bi.name, bi.sex, bi.age, bi.doctor, bi.deviceID, bi.version,
                           bi.reserve, bi.check_flag, bi.hosname, bi.auditdoctor, bi.auditdate, bi.status, bi.str1, bi.str2, bi.str3, bi.str4, bi.str5, bi.str6, bi.str7,
                           bi.str8, bi.str9, bi.str10, item.CNAME, item.ENAME, item.LRANGE, item.SRANGE, item.UNIT, item.VALUE);
                int flag = DBHelper.ExecuteNonQuerySql(s, DBHelper.ConnectionString);
                if (flag > 0)
                {
                    temperature.HasData = true;
                }

                return temperature;
            }
            catch
            {
                return temperature;
            }

        }

        private static DateTime? DateTimeTryParse(string str)
        {
            DateTime time;
            if (DateTime.TryParse(str, out time))
            {
                return time;
            }
            else
            {
                return null;
            }
        }
        private static int? IntTryParse(string str)
        {
            int temp;
            if (int.TryParse(str, out temp))
            {
                return temp;
            }
            else
            {
                return null;
            }
        }

    }
}