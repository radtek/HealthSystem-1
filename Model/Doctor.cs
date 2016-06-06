using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// 对象名称：社区医生数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016/4/28 13:59:21
    /// </summary>
    [Serializable]
    public class Doctor
    {
        #region 多层框架下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]自动编号</summary>
        private int? id;
        /// <summary>[变量]医生编号</summary>
        private string doctorId;
        /// <summary>[变量]姓名</summary>
        private string name;
        /// <summary>[变量]门诊号</summary>
        private string examNo;
        /// <summary>[变量]密码</summary>
        private string pwd;
        /// <summary>[变量]所在机构</summary>
        private Institutions institution;
        /// <summary>[变量]备注</summary>
        private string remarks;


        /// <summary>[属性]自动编号</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]医生编号</summary>
        public string DoctorId
        {
            get { return doctorId; }
            set { doctorId = value; }
        }
        /// <summary>[属性]姓名</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>[属性]门诊号</summary>
        public string ExamNo
        {
            get { return examNo; }
            set { examNo = value; }
        }
        /// <summary>[属性]密码</summary>
        public string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }
        /// <summary>[属性]所在机构</summary>
        public Institutions Institution
        {
            get { return institution; }
            set { institution = value; }
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

        #endregion 多层框架下的默认代码
    }
}
