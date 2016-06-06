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
    /// 对象名称：体温检测类业务逻辑类（业务逻辑层）
    /// 对象说明：体温检测实体类,用于记录终端采集到的人体体温数据.
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 16:57:39
    /// </summary>
    public class TemperatureBLL
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
        internal static DAL.Common.TemperatureDAL DataAccess
        {
            get
            {
                return DAL.Common.TemperatureDAL.Instance;
            }
        }


        /// <summary>
        /// 对体温检测类（Temperature）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="temperature">体温检测类（Temperature）实例对象</param>
        public static void CheckValid(Temperature temperature)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(temperature.Checkdate))
                throw new CustomException("“检查日期”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(temperature.ExamNo))
                throw new CustomException("“门诊号”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(temperature.CheckID))
                throw new CustomException("“检查号”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(temperature.Name))
                throw new CustomException("“姓名”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(temperature.Check_flag))
                throw new CustomException("“检查标志”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(temperature.Status))
                throw new CustomException("“状态”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(temperature.ExamNo , 50))
                throw new CustomException("“门诊号”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(temperature.CheckID , 50))
                throw new CustomException("“检查号”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(temperature.Name , 50))
                throw new CustomException("“姓名”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(temperature.Sex.ToString() , 50))
                throw new CustomException("“性别”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(temperature.Doctor , 50))
                throw new CustomException("“开单医生”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(temperature.DeviceID , 50))
                throw new CustomException("“设备号”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(temperature.Version , 50))
                throw new CustomException("“版本号”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(temperature.Reserve , 50))
                throw new CustomException("“保留字段”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(temperature.Hosname , 50))
                throw new CustomException("“医院”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(temperature.Auditdoctor , 50))
                throw new CustomException("“审核医生”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(temperature.Str1 , 50))
                throw new CustomException("“冗余”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(temperature.Str2 , 50))
                throw new CustomException("“冗余”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(temperature.Str3 , 50))
                throw new CustomException("“身份证号”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(temperature.Str4 , 50))
                throw new CustomException("“冗余”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(temperature.Str5 , 50))
                throw new CustomException("“冗余”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(temperature.Str6 , 50))
                throw new CustomException("“冗余”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(temperature.Str7 , 50))
                throw new CustomException("“冗余”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(temperature.Str8 , 50))
                throw new CustomException("“冗余”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(temperature.Str9 , 50))
                throw new CustomException("“冗余”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(temperature.Str10 , 50))
                throw new CustomException("“冗余”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(temperature.T3001007_ename , 50))
                throw new CustomException("“体温简称”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(temperature.T3001007_cname , 50))
                throw new CustomException("“体温全称”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(temperature.T3001007_unit , 50))
                throw new CustomException("“体温UNIT”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将体温检测类（Temperature）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="temperature">体温检测类（Temperature）实例对象</param>
        public static int Insert(Temperature temperature)
        {
            CheckValid(temperature);
            return DataAccess.Insert(temperature);
        }


        /// <summary>
        /// 将体温检测类（Temperature）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="temperature">体温检测类（Temperature）实例对象</param>
        public static int Update(Temperature temperature)
        {
            CheckValid(temperature);
            return DataAccess.Update(temperature);
        }


        /// <summary>
        /// 根据体温检测类（Temperature）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">体温检测类（Temperature）的主键“编号（Id）”</param>
        public static int Delete(int id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// 根据体温检测类（Temperature）的主键“编号（Id）”从数据库中获取体温检测类（Temperature）的实例。
        /// 成功从数据库中取得记录返回新体温检测类（Temperature）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">体温检测类（Temperature）的主键“编号（Id）”</param>
        public static Temperature GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据体温检测类（Temperature）的主键“编号（Id）”从数据库中获取体温检测类（Temperature）的实例。
        /// 成功从数据库中取得记录返回新体温检测类（Temperature）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">体温检测类（Temperature）的主键“编号（Id）”</param>
        public static Temperature GetDataById(string id)
        {
            if(!DataValid.IsInt(id))
                throw new CustomException("系统传入参数类型错误，请您通过系统提供的按钮或链接，来访问相关功能模块。", ExceptionType.Error,
                    "详细信息：通常造成该错误的原因为，您尝试通过直接输入地址来访问系统的相关功能模块而造成。请您单击“确定”按钮返回上一页面，如多次重试后仍出现此错误，请您与系统管理员联系。");

            return DataAccess.GetDataById(Convert.ToInt32(id));
        }


        /// <summary>
        /// 从数据库中读取并返回所有体温检测类（Temperature）List列表。
        /// </summary>
        public static List<Temperature> GetAllList()
        {
            return DataAccess.GetAllList();
        }


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的体温检测类（Temperature）的列表及分页信息。
        /// 该方法所获取的体温检测类（Temperature）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
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
