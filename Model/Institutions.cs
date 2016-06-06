using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// 对象名称：管理机构数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-7 17:24:34
    /// </summary>
    [Serializable]
    public class Institutions
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]机构编号</summary>
        private int? id;
        /// <summary>[变量]机构名称</summary>
        private string name;
        /// <summary>[变量]机构类型</summary>
        private string iType;
        /// <summary>[变量]机构地址</summary>
        private string iAddress;
        /// <summary>[变量]联系电话</summary>
        private string phone;
        /// <summary>[变量]负责人</summary>
        private string head;
        /// <summary>[变量]上级部门</summary>
        private int? superiorDepartments;
        /// <summary>[变量]备注</summary>
        private string remarks;


        /// <summary>[属性]机构编号</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]机构名称</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>[属性]机构类型</summary>
        public string IType
        {
            get { return iType; }
            set { iType = value; }
        }
        /// <summary>[属性]机构地址</summary>
        public string IAddress
        {
            get { return iAddress; }
            set { iAddress = value; }
        }
        /// <summary>[属性]联系电话</summary>
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        /// <summary>[属性]负责人</summary>
        public string Head
        {
            get { return head; }
            set { head = value; }
        }
        /// <summary>[属性]上级部门</summary>
        public int? SuperiorDepartments
        {
            get { return superiorDepartments; }
            set { superiorDepartments = value; }
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
