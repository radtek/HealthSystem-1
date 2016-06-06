using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using Zhbit.HealthSystem.Model;
using Zhbit.HealthSystem.DAL;
using Zhbit.HealthSystem.SFL;

namespace Zhbit.HealthSystem.BLL
{
    /// <summary>
    /// 对象名称：居民业务逻辑类（业务逻辑层）
    /// 对象说明：社区中的基础人员组成，本系统服务受众主体之一．
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 16:41:14
    /// </summary>
    public class ResidentBLL
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，主要提供该类的基本业务逻辑。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 返回与本类相关联的数据访问类。通常本类需要访问自身关联的数据访问类，与数据库进行交互时，应优先使用该属性，
        /// 本类调用业务逻辑层其它业务逻辑类时，应当优先使用其它类中公开的方法，而不优先使用其它类中的DataAccess属性。
        /// </summary>
        internal static DAL.Common.ResidentDAL DataAccess
        {
            get
            {
                return DAL.Common.ResidentDAL.Instance;
            }
        }


        /// <summary>
        /// 对居民（Resident）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="resident">居民（Resident）实例对象</param>
        public static void CheckValid(Resident resident)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(resident.ResidentId))
                throw new CustomException("“居民号”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(resident.Name))
                throw new CustomException("“姓名”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(resident.IdNumber))
                throw new CustomException("“身份证号”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(resident.ResidentId , 50))
                throw new CustomException("“居民号”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(resident.Name , 50))
                throw new CustomException("“姓名”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(resident.Phone , 20))
                throw new CustomException("“联系电话”长度不能超过 20 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(resident.Nation , 20))
                throw new CustomException("“民族”长度不能超过 20 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(resident.ContactName , 50))
                throw new CustomException("“联系人姓名”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(resident.ContactPhone , 20))
                throw new CustomException("“联系人电话”长度不能超过 20 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(resident.Professional , 50))
                throw new CustomException("“职业”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(resident.WorkUnits , 50))
                throw new CustomException("“工作单位”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(resident.FathersName , 50))
                throw new CustomException("“父亲姓名”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(resident.MotherName , 50))
                throw new CustomException("“母亲姓名”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(resident.GuardiansName , 50))
                throw new CustomException("“监护人姓名”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(resident.GuardianPhone , 50))
                throw new CustomException("“监护人电话”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(resident.Registered , 50))
                throw new CustomException("“户籍所在地”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(resident.RegisteredAddress , 50))
                throw new CustomException("“户籍地址”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(resident.Live , 50))
                throw new CustomException("“现居住所在地”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(resident.LiveAddress , 50))
                throw new CustomException("“现居住地址”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(resident.InputtingPerson , 50))
                throw new CustomException("“建档人”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(resident.ResponsibleDoctor , 50))
                throw new CustomException("“责任医生”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(resident.Remarks , 200))
                throw new CustomException("“备注”长度不能超过 200 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将居民（Resident）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="resident">居民（Resident）实例对象</param>
        public static int Insert(Resident resident)
        {
            CheckValid(resident);
            return DataAccess.Insert(resident);
        }


        /// <summary>
        /// 将居民（Resident）数据，根据主键“自动编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="resident">居民（Resident）实例对象</param>
        public static int Update(Resident resident)
        {
            CheckValid(resident);
            return DataAccess.Update(resident);
        }


        /// <summary>
        /// 根据居民（Resident）的主键“自动编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">居民（Resident）的主键“自动编号（Id）”</param>
        public static int Delete(int id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// 根据居民（Resident）的主键“自动编号（Id）”从数据库中获取居民（Resident）的实例。
        /// 成功从数据库中取得记录返回新居民（Resident）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">居民（Resident）的主键“自动编号（Id）”</param>
        public static Resident GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据居民（Resident）的主键“自动编号（Id）”从数据库中获取居民（Resident）的实例。
        /// 成功从数据库中取得记录返回新居民（Resident）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">居民（Resident）的主键“自动编号（Id）”</param>
        public static Resident GetDataById(string id)
        {
            if(!DataValid.IsInt(id))
                throw new CustomException("系统传入参数类型错误，请您通过系统提供的按钮或链接，来访问相关功能模块。", ExceptionType.Error,
                    "详细信息：通常造成该错误的原因为，您尝试通过直接输入地址来访问系统的相关功能模块而造成。请您单击“确定”按钮返回上一页面，如多次重试后仍出现此错误，请您与系统管理员联系。");

            return DataAccess.GetDataById(Convert.ToInt32(id));
        }


        /// <summary>
        /// 从数据库中读取并返回所有居民（Resident）List列表。
        /// </summary>
        public static List<Resident> GetAllList()
        {
            return DataAccess.GetAllList();
        }


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的居民（Resident）的列表及分页信息。
        /// 该方法所获取的居民（Resident）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public static PageData GetPageList(int pageSize, int curPage)
        {
            return DataAccess.GetPageList(pageSize,curPage);
        }


        #endregion 多层框架式下的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该业务逻辑类的功能，而定义的变量、属性及相关业务逻辑处理方法。  
        //  注意：用户界面层应当只需调用本层便可完成所有操作，本类对关联的数据访问类调用，应当只通过类中的DataAccess属性实现。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
