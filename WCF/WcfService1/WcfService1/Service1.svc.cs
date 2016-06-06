using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace WcfService1
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Service1”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 Service1.svc 或 Service1.svc.cs，然后开始调试。
    public class Service1 : IService1
    {



        public bool SendPressure(string sxml)
        {
            BasicInfo basic = new BasicInfo();
            Pressure pre = new Pressure();
            basic = XMLHelper.XmlToBasicInfo(XMLHelper.SelectXml(sxml, "/insert/baseInfo"));
            pre = XMLHelper.XmlToPressure(XMLHelper.SelectXml(sxml, "/insert/Pressure"));
            if (basic.HasData && pre.HasData)
                return true;
            else
                return false;
        }

        public bool SendBloodOxygen(string sxml)
        {
            BasicInfo basic = new BasicInfo();
            BloodOxygen blo = new BloodOxygen();
            basic = XMLHelper.XmlToBasicInfo(XMLHelper.SelectXml(sxml, "/insert/baseInfo"));
            blo = XMLHelper.XmlToBloodOxygen(XMLHelper.SelectXml(sxml, "/insert/CSBoard"));
            if (basic.HasData && blo.HasData)
                return true;
            else
                return false;
        }
        public bool SendTemperature(string sxml)
        {
            BasicInfo basic = new BasicInfo();
            Temperature pre = new Temperature();
            basic = XMLHelper.XmlToBasicInfo(XMLHelper.SelectXml(sxml, "/insert/baseInfo"));
            pre = XMLHelper.XmlToTemperature(XMLHelper.SelectXml(sxml, "/insert/TempValue"));
            if (basic.HasData && pre.HasData)
                return true;
            else
                return false;
        }

        public string ValidateId(string id, string password)
        {
            string sql = "select * from Doctor where DoctorId=" + id + " and Pwd=" + password;
            DataSet ds = new DataSet();
            ds = DBHelper.Query(sql, DBHelper.ConnectionString);
            if (ds.Tables[0].Rows.Count != 0)
            {
                string name = ds.Tables[0].Rows[0][2].ToString();
                string examNo = ds.Tables[0].Rows[0][3].ToString();
                string institution = ds.Tables[0].Rows[0][5].ToString();
                string pwd = ds.Tables[0].Rows[0][4].ToString();
                string remarks = ds.Tables[0].Rows[0][6].ToString();
                //string result = String.Format(@"<?xml version='1.0' encoding='utf-8'?><doctors><doctor><name>{0}</name><examNo>{1}</examNo><Institution>{2}</Institution><Pwd>{3}</Pwd><Remarks>{4}</Remarks></doctor></doctors>", name, examNo, institution, pwd, remarks);
                //return result;
                XmlDocument xmldoc = new XmlDocument();
                XmlDeclaration xd = xmldoc.CreateXmlDeclaration("1.0", "utf-8", null);
                xmldoc.AppendChild(xd);
                XmlElement root = xmldoc.CreateElement("doctors");
                xmldoc.AppendChild(root);
                XmlElement ele = xmldoc.CreateElement("doctor");
                root.AppendChild(ele);
                XmlElement elename = xmldoc.CreateElement("name");
                elename.InnerText = name;
                ele.AppendChild(elename);
                XmlElement eleexa = xmldoc.CreateElement("examNo");
                eleexa.InnerText = examNo;
                ele.AppendChild(eleexa);
                XmlElement eleins = xmldoc.CreateElement("Institution");
                eleins.InnerText = institution;
                ele.AppendChild(eleins);
                XmlElement elepwd = xmldoc.CreateElement("Pwd");
                elepwd.InnerText = pwd;
                ele.AppendChild(elepwd);
                XmlElement elerem = xmldoc.CreateElement("Remarks");
                elerem.InnerText = remarks;
                ele.AppendChild(elerem);
                return xmldoc.OuterXml;
            }
            else
            {
                return "false";
            }
        }

        public string SearchResident(string name)
        {
            string sql = "select ResidentId,Name,IdNumber,Sex,InputtingInstitutions,DateOfBirth,Remarks from Resident where Name like '%" + name + "%'";
            DataSet ds = new DataSet();
            ds = DBHelper.Query(sql, DBHelper.ConnectionString);
            if (ds.Tables[0].Rows.Count != 0)
            {
                int count = ds.Tables[0].Rows.Count;
                XmlDocument xmldoc = new XmlDocument();
                XmlDeclaration xd = xmldoc.CreateXmlDeclaration("1.0", "utf-8", null);
                xmldoc.AppendChild(xd);
                XmlElement root = xmldoc.CreateElement("Residents");
                xmldoc.AppendChild(root);

                for (int i = 0; i < count; i++)
                {
                    string id = ds.Tables[0].Rows[i][0].ToString();
                    string Name = ds.Tables[0].Rows[i][1].ToString();
                    string IdNumber = ds.Tables[0].Rows[i][2].ToString();
                    string Sex = ds.Tables[0].Rows[i][3].ToString();
                    string institutions = ds.Tables[0].Rows[i][4].ToString();
                    string DateOfBirth = ds.Tables[0].Rows[i][5].ToString();
                    string remarks = ds.Tables[0].Rows[i][6].ToString();
                    string age = null;
                    if (DateOfBirth != "")
                    {
                        age = ((DateTime.Now.Year) - (Convert.ToDateTime(DateOfBirth).Year)).ToString();
                    }
                    XmlElement ele = xmldoc.CreateElement("Resident");
                    root.AppendChild(ele);
                    XmlElement eleid = xmldoc.CreateElement("Id");
                    eleid.InnerText = id;
                    ele.AppendChild(eleid);
                    XmlElement elename = xmldoc.CreateElement("name");
                    elename.InnerText = name;
                    ele.AppendChild(elename);
                    XmlElement elesex = xmldoc.CreateElement("Sex");
                    elesex.InnerText = Sex;
                    ele.AppendChild(elesex);
                    XmlElement eleage = xmldoc.CreateElement("Age");
                    eleage.InnerText = age;
                    ele.AppendChild(eleage);
                    XmlElement eleidnum = xmldoc.CreateElement("IdNumber");
                    eleidnum.InnerText = IdNumber;
                    ele.AppendChild(eleidnum);
                    XmlElement eleint = xmldoc.CreateElement("Institution");
                    eleint.InnerText = institutions;
                    ele.AppendChild(eleint);
                    XmlElement elerem = xmldoc.CreateElement("Remarks");
                    elerem.InnerText = remarks;
                    ele.AppendChild(elerem);
                }

                return xmldoc.OuterXml;
            }
            else
            {
                return null;
            }
        }
    }
}
