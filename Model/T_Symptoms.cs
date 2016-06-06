using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// 对象名称：症状数据转换类（数据实体层）
    /// 对象说明：该类作为一个数据转换类，主要用于数据存储为编号但界面需要显示文字的转换。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 17:08:57
    /// </summary>
    [Serializable]
    public class T_Symptoms
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
        private T_Symptoms()
        {
        }

        public static readonly T_Symptoms Empty = new T_Symptoms();

        public static readonly T_Symptoms a = new T_Symptoms()
        {
            id = 0,
            name = "无"
        };

        public static readonly T_Symptoms b = new T_Symptoms()
        {
            id = 1,
            name = "头痛"
        };

        public static readonly T_Symptoms c = new T_Symptoms()
        {
            id = 2,
            name = "头晕"
        };

        public static readonly T_Symptoms d = new T_Symptoms()
        {
            id = 3,
            name = "心悸"
        };

        public static readonly T_Symptoms e = new T_Symptoms()
        {
            id = 4,
            name = "胸闷"
        };

        public static readonly T_Symptoms f = new T_Symptoms()
        {
            id = 5,
            name = "胸痛"
        };

        public static readonly T_Symptoms g = new T_Symptoms()
        {
            id = 6,
            name = "慢性咳嗽"
        };

        public static readonly T_Symptoms h = new T_Symptoms()
        {
            id = 7,
            name = "咳痰"
        };

        public static readonly T_Symptoms i = new T_Symptoms()
        {
            id = 8,
            name = "呼吸困难"
        };

        public static readonly T_Symptoms j = new T_Symptoms()
        {
            id = 9,
            name = "多饮"
        };

        public static readonly T_Symptoms k = new T_Symptoms()
        {
            id = 10,
            name = "多尿"
        };

        public static readonly T_Symptoms l = new T_Symptoms()
        {
            id = 11,
            name = "体重下降"
        };

        public static readonly T_Symptoms m = new T_Symptoms()
        {
            id = 12,
            name = "乏力"
        };

        public static readonly T_Symptoms n = new T_Symptoms()
        {
            id = 13,
            name = "关节肿痛"
        };

        public static readonly T_Symptoms o = new T_Symptoms()
        {
            id = 14,
            name = "视力模糊"
        };

        public static readonly T_Symptoms p = new T_Symptoms()
        {
            id = 15,
            name = "手脚麻木"
        };

        public static readonly T_Symptoms q = new T_Symptoms()
        {
            id = 16,
            name = "尿急"
        };

        public static readonly T_Symptoms r = new T_Symptoms()
        {
            id = 17,
            name = "尿痛"
        };

        public static readonly T_Symptoms x = new T_Symptoms()
        {
            id = 18,
            name = "便秘"
        };

        public static readonly T_Symptoms t = new T_Symptoms()
        {
            id = 19,
            name = "腹泻"
        };

        public static readonly T_Symptoms u = new T_Symptoms()
        {
            id = 20,
            name = "恶心呕吐"
        };

        public static readonly T_Symptoms v = new T_Symptoms()
        {
            id = 21,
            name = "眼花"
        };

        public static readonly T_Symptoms w = new T_Symptoms()
        {
            id = 22,
            name = "耳鸣"
        };

        public static readonly T_Symptoms y = new T_Symptoms()
        {
            id = 23,
            name = "乳房胀痛"
        };

        public static readonly T_Symptoms z = new T_Symptoms()
        {
            id = 24,
            name = "其他"
        };

        /// <summary>所有“症状”对象列表。</summary>
        public static readonly List<T_Symptoms> AllList = new List<T_Symptoms>
        {
            T_Symptoms.a,
            T_Symptoms.b,
            T_Symptoms.c,
            T_Symptoms.d,
            T_Symptoms.e,
            T_Symptoms.f,
            T_Symptoms.g,
            T_Symptoms.h,
            T_Symptoms.i,
            T_Symptoms.j,
            T_Symptoms.k,
            T_Symptoms.l,
            T_Symptoms.m,
            T_Symptoms.n,
            T_Symptoms.o,
            T_Symptoms.p,
            T_Symptoms.q,
            T_Symptoms.r,
            T_Symptoms.x,
            T_Symptoms.t,
            T_Symptoms.u,
            T_Symptoms.v,
            T_Symptoms.w,
            T_Symptoms.y,
            T_Symptoms.z
        };

        /// <summary>根据“症状”编号，返回一个“症状”对象。</summary>
        public static T_Symptoms GetDataById(int id)
        {
            foreach (T_Symptoms tmpT_Symptoms in AllList)
            {
                if (tmpT_Symptoms.Id == id)
                    return tmpT_Symptoms;
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
