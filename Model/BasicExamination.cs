using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// 对象名称：基础体检表数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 16:58:59
    /// </summary>
    [Serializable]
    public class BasicExamination
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编号</summary>
        private int? id;
        /// <summary>[变量]居民号</summary>
        private string residentId;
        /// <summary>[变量]姓名</summary>
        private string theName;
        /// <summary>[变量]体检编号</summary>
        private string checkID;
        /// <summary>[变量]体检日期</summary>
        private string checkDate;
        /// <summary>[变量]体检医生</summary>
        private string doctor;
        /// <summary>[变量]症状</summary>
        private T_Symptoms symptoms;
        /// <summary>[变量]体温</summary>
        private decimal? temperature;
        /// <summary>[变量]脉率</summary>
        private decimal? bPM;
        /// <summary>[变量]呼吸频率</summary>
        private decimal? rR;
        /// <summary>[变量]血压</summary>
        private decimal? bP;
        /// <summary>[变量]身高</summary>
        private decimal? height;
        /// <summary>[变量]体重</summary>
        private decimal? weight;
        /// <summary>[变量]腰围</summary>
        private decimal? waist;
        /// <summary>[变量]体质指数</summary>
        private decimal? bMI;
        /// <summary>[变量]体育锻炼</summary>
        private string physicalExercise;
        /// <summary>[变量]饮食习惯</summary>
        private T_EatingHabits eatingHabits;
        /// <summary>[变量]吸烟情况</summary>
        private string smoking;
        /// <summary>[变量]饮酒情况</summary>
        private string drinking;
        /// <summary>[变量]职业暴露情况</summary>
        private string occupationalExposure;


        /// <summary>[属性]编号</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]居民号</summary>
        public string ResidentId
        {
            get { return residentId; }
            set { residentId = value; }
        }
        /// <summary>[属性]姓名</summary>
        public string TheName
        {
            get { return theName; }
            set { theName = value; }
        }
        /// <summary>[属性]体检编号</summary>
        public string CheckID
        {
            get { return checkID; }
            set { checkID = value; }
        }
        /// <summary>[属性]体检日期</summary>
        public string CheckDate
        {
            get { return checkDate; }
            set { checkDate = value; }
        }
        /// <summary>[属性]体检医生</summary>
        public string Doctor
        {
            get { return doctor; }
            set { doctor = value; }
        }
        /// <summary>[属性]症状</summary>
        public T_Symptoms Symptoms
        {
            get { return symptoms; }
            set { symptoms = value; }
        }
        /// <summary>[属性]体温</summary>
        public decimal? Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }
        /// <summary>[属性]脉率</summary>
        public decimal? BPM
        {
            get { return bPM; }
            set { bPM = value; }
        }
        /// <summary>[属性]呼吸频率</summary>
        public decimal? RR
        {
            get { return rR; }
            set { rR = value; }
        }
        /// <summary>[属性]血压</summary>
        public decimal? BP
        {
            get { return bP; }
            set { bP = value; }
        }
        /// <summary>[属性]身高</summary>
        public decimal? Height
        {
            get { return height; }
            set { height = value; }
        }
        /// <summary>[属性]体重</summary>
        public decimal? Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        /// <summary>[属性]腰围</summary>
        public decimal? Waist
        {
            get { return waist; }
            set { waist = value; }
        }
        /// <summary>[属性]体质指数</summary>
        public decimal? BMI
        {
            get { return bMI; }
            set { bMI = value; }
        }
        /// <summary>[属性]体育锻炼</summary>
        public string PhysicalExercise
        {
            get { return physicalExercise; }
            set { physicalExercise = value; }
        }
        /// <summary>[属性]饮食习惯</summary>
        public T_EatingHabits EatingHabits
        {
            get { return eatingHabits; }
            set { eatingHabits = value; }
        }
        /// <summary>[属性]吸烟情况</summary>
        public string Smoking
        {
            get { return smoking; }
            set { smoking = value; }
        }
        /// <summary>[属性]饮酒情况</summary>
        public string Drinking
        {
            get { return drinking; }
            set { drinking = value; }
        }
        /// <summary>[属性]职业暴露情况</summary>
        public string OccupationalExposure
        {
            get { return occupationalExposure; }
            set { occupationalExposure = value; }
        }

        /// <summary>已重写的ToString方法，当该类作为其它类的一个属性时，在数据控件中可以直接绑定并显示其有意义的名称。</summary>
        public override string ToString()
        {
            return CheckID;
        }

        #endregion 多层框架式下的默认代码
    }
}
