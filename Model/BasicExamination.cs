using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// �������ƣ�������������ʵ���ࣨ����ʵ��㣩
    /// ����˵����������Ϊ�������壬��ҵ���߼��㡢���ݷ��ʲ���á�
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 16:58:59
    /// </summary>
    [Serializable]
    public class BasicExamination
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬��Ҫ���ڶ������ı������ԡ��벻Ҫֱ���޸ĸ������е��κδ��룬  
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>[����]���</summary>
        private int? id;
        /// <summary>[����]�����</summary>
        private string residentId;
        /// <summary>[����]����</summary>
        private string theName;
        /// <summary>[����]�����</summary>
        private string checkID;
        /// <summary>[����]�������</summary>
        private string checkDate;
        /// <summary>[����]���ҽ��</summary>
        private string doctor;
        /// <summary>[����]֢״</summary>
        private T_Symptoms symptoms;
        /// <summary>[����]����</summary>
        private decimal? temperature;
        /// <summary>[����]����</summary>
        private decimal? bPM;
        /// <summary>[����]����Ƶ��</summary>
        private decimal? rR;
        /// <summary>[����]Ѫѹ</summary>
        private decimal? bP;
        /// <summary>[����]���</summary>
        private decimal? height;
        /// <summary>[����]����</summary>
        private decimal? weight;
        /// <summary>[����]��Χ</summary>
        private decimal? waist;
        /// <summary>[����]����ָ��</summary>
        private decimal? bMI;
        /// <summary>[����]��������</summary>
        private string physicalExercise;
        /// <summary>[����]��ʳϰ��</summary>
        private T_EatingHabits eatingHabits;
        /// <summary>[����]�������</summary>
        private string smoking;
        /// <summary>[����]�������</summary>
        private string drinking;
        /// <summary>[����]ְҵ��¶���</summary>
        private string occupationalExposure;


        /// <summary>[����]���</summary>
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
        public string TheName
        {
            get { return theName; }
            set { theName = value; }
        }
        /// <summary>[����]�����</summary>
        public string CheckID
        {
            get { return checkID; }
            set { checkID = value; }
        }
        /// <summary>[����]�������</summary>
        public string CheckDate
        {
            get { return checkDate; }
            set { checkDate = value; }
        }
        /// <summary>[����]���ҽ��</summary>
        public string Doctor
        {
            get { return doctor; }
            set { doctor = value; }
        }
        /// <summary>[����]֢״</summary>
        public T_Symptoms Symptoms
        {
            get { return symptoms; }
            set { symptoms = value; }
        }
        /// <summary>[����]����</summary>
        public decimal? Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }
        /// <summary>[����]����</summary>
        public decimal? BPM
        {
            get { return bPM; }
            set { bPM = value; }
        }
        /// <summary>[����]����Ƶ��</summary>
        public decimal? RR
        {
            get { return rR; }
            set { rR = value; }
        }
        /// <summary>[����]Ѫѹ</summary>
        public decimal? BP
        {
            get { return bP; }
            set { bP = value; }
        }
        /// <summary>[����]���</summary>
        public decimal? Height
        {
            get { return height; }
            set { height = value; }
        }
        /// <summary>[����]����</summary>
        public decimal? Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        /// <summary>[����]��Χ</summary>
        public decimal? Waist
        {
            get { return waist; }
            set { waist = value; }
        }
        /// <summary>[����]����ָ��</summary>
        public decimal? BMI
        {
            get { return bMI; }
            set { bMI = value; }
        }
        /// <summary>[����]��������</summary>
        public string PhysicalExercise
        {
            get { return physicalExercise; }
            set { physicalExercise = value; }
        }
        /// <summary>[����]��ʳϰ��</summary>
        public T_EatingHabits EatingHabits
        {
            get { return eatingHabits; }
            set { eatingHabits = value; }
        }
        /// <summary>[����]�������</summary>
        public string Smoking
        {
            get { return smoking; }
            set { smoking = value; }
        }
        /// <summary>[����]�������</summary>
        public string Drinking
        {
            get { return drinking; }
            set { drinking = value; }
        }
        /// <summary>[����]ְҵ��¶���</summary>
        public string OccupationalExposure
        {
            get { return occupationalExposure; }
            set { occupationalExposure = value; }
        }

        /// <summary>����д��ToString��������������Ϊ�������һ������ʱ�������ݿؼ��п���ֱ�Ӱ󶨲���ʾ������������ơ�</summary>
        public override string ToString()
        {
            return CheckID;
        }

        #endregion �����ʽ�µ�Ĭ�ϴ���
    }
}
