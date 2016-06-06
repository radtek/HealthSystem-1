using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// 对象名称：居民数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 16:41:14
    /// </summary>
    [Serializable]
    public class Resident
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]自动编号</summary>
        private int? id;
        /// <summary>[变量]居民号</summary>
        private string residentId;
        /// <summary>[变量]姓名</summary>
        private string name;
        /// <summary>[变量]身份证号</summary>
        private string idNumber;
        /// <summary>[变量]性别</summary>
        private int? sex;
        /// <summary>[变量]联系电话</summary>
        private string phone;
        /// <summary>[变量]出生日期</summary>
        private DateTime? dateOfBirth;
        /// <summary>[变量]民族</summary>
        private string nation;
        /// <summary>[变量]联系人姓名</summary>
        private string contactName;
        /// <summary>[变量]联系人电话</summary>
        private string contactPhone;
        /// <summary>[变量]文化程度</summary>
        private int? education;
        /// <summary>[变量]血型</summary>
        private int? bloodType;
        /// <summary>[变量]职业</summary>
        private string professional;
        /// <summary>[变量]工作单位</summary>
        private string workUnits;
        /// <summary>[变量]医疗费用支付方式</summary>
        private int? payment;
        /// <summary>[变量]家庭档案号</summary>
        private Family familyId;
        /// <summary>[变量]婚姻状况</summary>
        private int? maritalStatus;
        /// <summary>[变量]子女数</summary>
        private int? children;
        /// <summary>[变量]父亲姓名</summary>
        private string fathersName;
        /// <summary>[变量]母亲姓名</summary>
        private string motherName;
        /// <summary>[变量]监护人姓名</summary>
        private string guardiansName;
        /// <summary>[变量]监护人电话</summary>
        private string guardianPhone;
        /// <summary>[变量]人群类型</summary>
        private int? crowdType;
        /// <summary>[变量]居住类型</summary>
        private int? residentialType;
        /// <summary>[变量]常住类型</summary>
        private int? permanentType;
        /// <summary>[变量]户籍所在地</summary>
        private string registered;
        /// <summary>[变量]户籍地址</summary>
        private string registeredAddress;
        /// <summary>[变量]现居住所在地</summary>
        private string live;
        /// <summary>[变量]现居住地址</summary>
        private string liveAddress;
        /// <summary>[变量]建档机构</summary>
        private Institutions inputtingInstitutions;
        /// <summary>[变量]建档人</summary>
        private string inputtingPerson;
        /// <summary>[变量]建档时间</summary>
        private DateTime? inputtingTime;
        /// <summary>[变量]责任医生</summary>
        private string responsibleDoctor;
        /// <summary>[变量]管理状态</summary>
        private int? managementStatus;
        /// <summary>[变量]启用时间</summary>
        private DateTime? enableTime;
        /// <summary>[变量]是否社会关注人群</summary>
        private bool? focusOn;
        /// <summary>[变量]RH阴性</summary>
        private bool? rHNegative;
        /// <summary>[变量]备注</summary>
        private string remarks;


        /// <summary>[属性]自动编号</summary>
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
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>[属性]身份证号</summary>
        public string IdNumber
        {
            get { return idNumber; }
            set { idNumber = value; }
        }
        /// <summary>[属性]性别</summary>
        public int? Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        /// <summary>[属性]联系电话</summary>
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        /// <summary>[属性]出生日期</summary>
        public DateTime? DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        /// <summary>[属性]民族</summary>
        public string Nation
        {
            get { return nation; }
            set { nation = value; }
        }
        /// <summary>[属性]联系人姓名</summary>
        public string ContactName
        {
            get { return contactName; }
            set { contactName = value; }
        }
        /// <summary>[属性]联系人电话</summary>
        public string ContactPhone
        {
            get { return contactPhone; }
            set { contactPhone = value; }
        }
        /// <summary>[属性]文化程度</summary>
        public int? Education
        {
            get { return education; }
            set { education = value; }
        }
        /// <summary>[属性]血型</summary>
        public int? BloodType
        {
            get { return bloodType; }
            set { bloodType = value; }
        }
        /// <summary>[属性]职业</summary>
        public string Professional
        {
            get { return professional; }
            set { professional = value; }
        }
        /// <summary>[属性]工作单位</summary>
        public string WorkUnits
        {
            get { return workUnits; }
            set { workUnits = value; }
        }
        /// <summary>[属性]医疗费用支付方式</summary>
        public int? Payment
        {
            get { return payment; }
            set { payment = value; }
        }
        /// <summary>[属性]家庭档案号</summary>
        public Family FamilyId
        {
            get { return familyId; }
            set { familyId = value; }
        }
        /// <summary>[属性]婚姻状况</summary>
        public int? MaritalStatus
        {
            get { return maritalStatus; }
            set { maritalStatus = value; }
        }
        /// <summary>[属性]子女数</summary>
        public int? Children
        {
            get { return children; }
            set { children = value; }
        }
        /// <summary>[属性]父亲姓名</summary>
        public string FathersName
        {
            get { return fathersName; }
            set { fathersName = value; }
        }
        /// <summary>[属性]母亲姓名</summary>
        public string MotherName
        {
            get { return motherName; }
            set { motherName = value; }
        }
        /// <summary>[属性]监护人姓名</summary>
        public string GuardiansName
        {
            get { return guardiansName; }
            set { guardiansName = value; }
        }
        /// <summary>[属性]监护人电话</summary>
        public string GuardianPhone
        {
            get { return guardianPhone; }
            set { guardianPhone = value; }
        }
        /// <summary>[属性]人群类型</summary>
        public int? CrowdType
        {
            get { return crowdType; }
            set { crowdType = value; }
        }
        /// <summary>[属性]居住类型</summary>
        public int? ResidentialType
        {
            get { return residentialType; }
            set { residentialType = value; }
        }
        /// <summary>[属性]常住类型</summary>
        public int? PermanentType
        {
            get { return permanentType; }
            set { permanentType = value; }
        }
        /// <summary>[属性]户籍所在地</summary>
        public string Registered
        {
            get { return registered; }
            set { registered = value; }
        }
        /// <summary>[属性]户籍地址</summary>
        public string RegisteredAddress
        {
            get { return registeredAddress; }
            set { registeredAddress = value; }
        }
        /// <summary>[属性]现居住所在地</summary>
        public string Live
        {
            get { return live; }
            set { live = value; }
        }
        /// <summary>[属性]现居住地址</summary>
        public string LiveAddress
        {
            get { return liveAddress; }
            set { liveAddress = value; }
        }
        /// <summary>[属性]建档机构</summary>
        public Institutions InputtingInstitutions
        {
            get { return inputtingInstitutions; }
            set { inputtingInstitutions = value; }
        }
        /// <summary>[属性]建档人</summary>
        public string InputtingPerson
        {
            get { return inputtingPerson; }
            set { inputtingPerson = value; }
        }
        /// <summary>[属性]建档时间</summary>
        public DateTime? InputtingTime
        {
            get { return inputtingTime; }
            set { inputtingTime = value; }
        }
        /// <summary>[属性]责任医生</summary>
        public string ResponsibleDoctor
        {
            get { return responsibleDoctor; }
            set { responsibleDoctor = value; }
        }
        /// <summary>[属性]管理状态</summary>
        public int? ManagementStatus
        {
            get { return managementStatus; }
            set { managementStatus = value; }
        }
        /// <summary>[属性]启用时间</summary>
        public DateTime? EnableTime
        {
            get { return enableTime; }
            set { enableTime = value; }
        }
        /// <summary>[属性]是否社会关注人群</summary>
        public bool? FocusOn
        {
            get { return focusOn; }
            set { focusOn = value; }
        }
        /// <summary>[属性]RH阴性</summary>
        public bool? RHNegative
        {
            get { return rHNegative; }
            set { rHNegative = value; }
        }
        /// <summary>[属性]备注</summary>
        public string Remarks
        {
            get { return remarks; }
            set { remarks = value; }
        }

        /// <summary>已重写的ToString方法，当该类作为其它类的一个属性时，在数据控件中可以直接绑定并显示其有意义的名称。</summary>
        public override string ToString()
        {
            return Name;
        }

        #endregion 多层框架式下的默认代码
    }
}
