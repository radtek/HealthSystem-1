using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// 对象名称：检查标志数据转换类（数据实体层）
    /// 对象说明：该类作为一个数据转换类，主要用于数据存储为编号但界面需要显示文字的转换。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 16:58:36
    /// </summary>
    [Serializable]
    public class T_Check_Flag
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编号</summary>
        private int? id;
        /// <summary>[变量]名称</summary>
        private string value;


        /// <summary>[属性]编号</summary>
        public int? Id
        {
            get { return id; }
        }
        /// <summary>[属性]名称</summary>
        public string Value
        {
            get { return value; }
        }


        /// <summary>实例化对象方法。私有仅供内部访问</summary>
        private T_Check_Flag()
        {
        }

        public static readonly T_Check_Flag Empty = new T_Check_Flag();

        public static readonly T_Check_Flag None = new T_Check_Flag()
        {
            id = 0,
            value = "未检查"
        };

        public static readonly T_Check_Flag Valid = new T_Check_Flag()
        {
            id = 1,
            value = "当前有效数据"
        };

        public static readonly T_Check_Flag Complete  = new T_Check_Flag()
        {
            id = 2,
            value = "已完成检查"
        };

        public static readonly T_Check_Flag Cancel = new T_Check_Flag()
        {
            id = 3,
            value = "注销"
        };

        /// <summary>所有“检查标志”对象列表。</summary>
        public static readonly List<T_Check_Flag> AllList = new List<T_Check_Flag>
        {
            T_Check_Flag.None,
            T_Check_Flag.Valid,
            T_Check_Flag.Complete ,
            T_Check_Flag.Cancel
        };

        /// <summary>根据“检查标志”编号，返回一个“检查标志”对象。</summary>
        public static T_Check_Flag GetDataById(int id)
        {
            foreach (T_Check_Flag tmpT_Check_Flag in AllList)
            {
                if (tmpT_Check_Flag.Id == id)
                    return tmpT_Check_Flag;
            }
            return null;
        }

        /// <summary>已重写的ToString方法，当该类作为其它类的一个属性时，在数据控件中可以直接绑定并显示其有意义的名称。</summary>
        public override string ToString()
        {
            return Value;
        }

        #endregion 多层框架式下的默认代码
    }
}
