using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Zhbit.HealthSystem.Model
{
    /// <summary>
    /// 对象名称：血管疾病数据转换类（数据实体层）
    /// 对象说明：该类作为一个数据转换类，主要用于数据存储为编号但界面需要显示文字的转换。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 17:10:27
    /// </summary>
    [Serializable]
    public class T_VascularDisease
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
        private T_VascularDisease()
        {
        }

        public static readonly T_VascularDisease Empty = new T_VascularDisease();

        public static readonly T_VascularDisease a = new T_VascularDisease()
        {
            id = 0,
            name = "未发现"
        };

        public static readonly T_VascularDisease b = new T_VascularDisease()
        {
            id = 1,
            name = "夹层动脉瘤"
        };

        public static readonly T_VascularDisease c = new T_VascularDisease()
        {
            id = 2,
            name = "动脉闭塞性疾病"
        };

        public static readonly T_VascularDisease d = new T_VascularDisease()
        {
            id = 3,
            name = "其他"
        };

        /// <summary>所有“血管疾病”对象列表。</summary>
        public static readonly List<T_VascularDisease> AllList = new List<T_VascularDisease>
        {
            T_VascularDisease.a,
            T_VascularDisease.b,
            T_VascularDisease.c,
            T_VascularDisease.d
        };

        /// <summary>根据“血管疾病”编号，返回一个“血管疾病”对象。</summary>
        public static T_VascularDisease GetDataById(int id)
        {
            foreach (T_VascularDisease tmpT_VascularDisease in AllList)
            {
                if (tmpT_VascularDisease.Id == id)
                    return tmpT_VascularDisease;
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
