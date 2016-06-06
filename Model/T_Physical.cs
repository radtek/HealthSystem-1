using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// 对象名称：体质数据转换类（数据实体层）
    /// 对象说明：该类作为一个数据转换类，主要用于数据存储为编号但界面需要显示文字的转换。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 17:09:57
    /// </summary>
    [Serializable]
    public class T_Physical
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编号</summary>
        private int? id;
        /// <summary>[变量]名称</summary>
        private string name;


        /// <summary>[属性]编号</summary>
        public int? Id
        {
            get { return id; }
        }
        /// <summary>[属性]名称</summary>
        public string Name
        {
            get { return name; }
        }


        /// <summary>实例化对象方法。私有仅供内部访问</summary>
        private T_Physical()
        {
        }

        public static readonly T_Physical Empty = new T_Physical();

        public static readonly T_Physical a = new T_Physical()
        {
            id = 1,
            name = "气虚质"
        };

        public static readonly T_Physical b = new T_Physical()
        {
            id = 2,
            name = "阳虚质"
        };

        public static readonly T_Physical c = new T_Physical()
        {
            id = 3,
            name = "阴虚质"
        };

        public static readonly T_Physical d = new T_Physical()
        {
            id = 4,
            name = "痰湿质"
        };

        public static readonly T_Physical e = new T_Physical()
        {
            id = 5,
            name = "湿热质"
        };

        public static readonly T_Physical f = new T_Physical()
        {
            id = 6,
            name = "血瘀质"
        };

        public static readonly T_Physical g = new T_Physical()
        {
            id = 7,
            name = "气郁质"
        };

        public static readonly T_Physical h = new T_Physical()
        {
            id = 8,
            name = "平和质"
        };

        /// <summary>所有“体质”对象列表。</summary>
        public static readonly List<T_Physical> AllList = new List<T_Physical>
        {
            T_Physical.a,
            T_Physical.b,
            T_Physical.c,
            T_Physical.d,
            T_Physical.e,
            T_Physical.f,
            T_Physical.g,
            T_Physical.h
        };

        /// <summary>根据“体质”编号，返回一个“体质”对象。</summary>
        public static T_Physical GetDataById(int id)
        {
            foreach (T_Physical tmpT_Physical in AllList)
            {
                if (tmpT_Physical.Id == id)
                    return tmpT_Physical;
            }
            return null;
        }

        /// <summary>已重写的ToString方法，当该类作为其它类的一个属性时，在数据控件中可以直接绑定并显示其有意义的名称。</summary>
        public override string ToString()
        {
            return Name;
        }

        #endregion 多层框架式下的默认代码
    }
}
