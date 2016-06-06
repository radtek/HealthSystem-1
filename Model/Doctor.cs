using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// �������ƣ�����ҽ������ʵ���ࣨ����ʵ��㣩
    /// ����˵����������Ϊ�������壬��ҵ���߼��㡢���ݷ��ʲ���á�
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016/4/28 13:59:21
    /// </summary>
    [Serializable]
    public class Doctor
    {
        #region ������µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ��������Զ����ɣ���Ҫ���ڶ������ı������ԡ��벻Ҫֱ���޸ĸ������е��κδ��룬  
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö�����������ɸ������еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>[����]�Զ����</summary>
        private int? id;
        /// <summary>[����]ҽ�����</summary>
        private string doctorId;
        /// <summary>[����]����</summary>
        private string name;
        /// <summary>[����]�����</summary>
        private string examNo;
        /// <summary>[����]����</summary>
        private string pwd;
        /// <summary>[����]���ڻ���</summary>
        private Institutions institution;
        /// <summary>[����]��ע</summary>
        private string remarks;


        /// <summary>[����]�Զ����</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[����]ҽ�����</summary>
        public string DoctorId
        {
            get { return doctorId; }
            set { doctorId = value; }
        }
        /// <summary>[����]����</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>[����]�����</summary>
        public string ExamNo
        {
            get { return examNo; }
            set { examNo = value; }
        }
        /// <summary>[����]����</summary>
        public string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }
        /// <summary>[����]���ڻ���</summary>
        public Institutions Institution
        {
            get { return institution; }
            set { institution = value; }
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

        #endregion ������µ�Ĭ�ϴ���
    }
}
