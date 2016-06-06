using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// 对象名称：家庭数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 17:18:21
    /// </summary>
    [Serializable]
    public class Family
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]家庭档案号</summary>
        private int? id;
        /// <summary>[变量]家庭名称</summary>
        private string name;
        /// <summary>[变量]户主</summary>
        private string owner;
        /// <summary>[变量]家庭类型</summary>
        private int? familyType;
        /// <summary>[变量]住房类型</summary>
        private int? housingTypes;
        /// <summary>[变量]家庭总人数</summary>
        private int? total;
        /// <summary>[变量]负责老人数</summary>
        private int? old;
        /// <summary>[变量]责任医生</summary>
        private string responsibleDoctor;
        /// <summary>[变量]创建日期</summary>
        private DateTime? createDate;
        /// <summary>[变量]管理机构</summary>
        private Institutions manageInstitutions;
        /// <summary>[变量]备注</summary>
        private string remark;


        /// <summary>[属性]家庭档案号</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]家庭名称</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>[属性]户主</summary>
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        /// <summary>[属性]家庭类型</summary>
        public int? FamilyType
        {
            get { return familyType; }
            set { familyType = value; }
        }
        /// <summary>[属性]住房类型</summary>
        public int? HousingTypes
        {
            get { return housingTypes; }
            set { housingTypes = value; }
        }
        /// <summary>[属性]家庭总人数</summary>
        public int? Total
        {
            get { return total; }
            set { total = value; }
        }
        /// <summary>[属性]负责老人数</summary>
        public int? Old
        {
            get { return old; }
            set { old = value; }
        }
        /// <summary>[属性]责任医生</summary>
        public string ResponsibleDoctor
        {
            get { return responsibleDoctor; }
            set { responsibleDoctor = value; }
        }
        /// <summary>[属性]创建日期</summary>
        public DateTime? CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }
        /// <summary>[属性]管理机构</summary>
        public Institutions ManageInstitutions
        {
            get { return manageInstitutions; }
            set { manageInstitutions = value; }
        }
        /// <summary>[属性]备注</summary>
        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }

        /// <summary>已重写的ToString方法，当该类作为其它类的一个属性时，在数据控件中可以直接绑定并显示其有意义的名称。</summary>
        public override string ToString()
        {
            return Name;
        }

        #endregion 多层框架式下的默认代码
    }
}
