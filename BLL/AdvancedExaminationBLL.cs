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
    /// 对象名称：高级体检表业务逻辑类（业务逻辑层）
    /// 对象说明：体检表二：高级体检表
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 17:12:40
    /// </summary>
    public class AdvancedExaminationBLL
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
        internal static DAL.Common.AdvancedExaminationDAL DataAccess
        {
            get
            {
                return DAL.Common.AdvancedExaminationDAL.Instance;
            }
        }


        /// <summary>
        /// 对高级体检表（AdvancedExamination）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="advancedExamination">高级体检表（AdvancedExamination）实例对象</param>
        public static void CheckValid(AdvancedExamination advancedExamination)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(advancedExamination.Id))
                throw new CustomException("“检查编号”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(advancedExamination.Oral , 50))
                throw new CustomException("“口腔”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(advancedExamination.Hearing , 50))
                throw new CustomException("“听力”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(advancedExamination.FMA , 50))
                throw new CustomException("“运动功能”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(advancedExamination.Fundus , 50))
                throw new CustomException("“眼底”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(advancedExamination.Skin , 50))
                throw new CustomException("“皮肤”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(advancedExamination.Sclera , 50))
                throw new CustomException("“巩膜”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(advancedExamination.LN , 50))
                throw new CustomException("“淋巴结”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(advancedExamination.Lung , 50))
                throw new CustomException("“肺功能”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(advancedExamination.Heart , 50))
                throw new CustomException("“心脏”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(advancedExamination.Abdomen , 50))
                throw new CustomException("“腹部”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(advancedExamination.LowerExtremityEdema , 50))
                throw new CustomException("“下肢水肿”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(advancedExamination.DPAP , 50))
                throw new CustomException("“足背动脉搏动”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(advancedExamination.Dre , 50))
                throw new CustomException("“肛门指诊”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(advancedExamination.FBG , 50))
                throw new CustomException("“空腹血糖”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(advancedExamination.U_MTB , 50))
                throw new CustomException("“尿微量蛋白”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(advancedExamination.GHb , 50))
                throw new CustomException("“糖化血红蛋白”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(advancedExamination.HBsAG , 50))
                throw new CustomException("“乙型肝炎表面抗原”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(advancedExamination.ECG , 50))
                throw new CustomException("“心电图”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(advancedExamination.XRay , 50))
                throw new CustomException("“胸部Ｘ线片”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(advancedExamination.BUltrasonic , 50))
                throw new CustomException("“B超”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(advancedExamination.CervicalSmear , 50))
                throw new CustomException("“宫颈涂片”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(advancedExamination.Other , 50))
                throw new CustomException("“其他”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(advancedExamination.Physical , 50))
                throw new CustomException("“体质”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(advancedExamination.Guidance , 50))
                throw new CustomException("“保健指导意见”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将高级体检表（AdvancedExamination）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="advancedExamination">高级体检表（AdvancedExamination）实例对象</param>
        public static int Insert(AdvancedExamination advancedExamination)
        {
            CheckValid(advancedExamination);
            return DataAccess.Insert(advancedExamination);
        }


        /// <summary>
        /// 将高级体检表（AdvancedExamination）数据，根据主键“检查编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="advancedExamination">高级体检表（AdvancedExamination）实例对象</param>
        public static int Update(AdvancedExamination advancedExamination)
        {
            CheckValid(advancedExamination);
            return DataAccess.Update(advancedExamination);
        }


        /// <summary>
        /// 根据高级体检表（AdvancedExamination）的主键“检查编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">高级体检表（AdvancedExamination）的主键“检查编号（Id）”</param>
        public static int Delete(int id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// 根据高级体检表（AdvancedExamination）的主键“检查编号（Id）”从数据库中获取高级体检表（AdvancedExamination）的实例。
        /// 成功从数据库中取得记录返回新高级体检表（AdvancedExamination）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">高级体检表（AdvancedExamination）的主键“检查编号（Id）”</param>
        public static AdvancedExamination GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据高级体检表（AdvancedExamination）的主键“检查编号（Id）”从数据库中获取高级体检表（AdvancedExamination）的实例。
        /// 成功从数据库中取得记录返回新高级体检表（AdvancedExamination）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">高级体检表（AdvancedExamination）的主键“检查编号（Id）”</param>
        public static AdvancedExamination GetDataById(string id)
        {
            if(!DataValid.IsInt(id))
                throw new CustomException("系统传入参数类型错误，请您通过系统提供的按钮或链接，来访问相关功能模块。", ExceptionType.Error,
                    "详细信息：通常造成该错误的原因为，您尝试通过直接输入地址来访问系统的相关功能模块而造成。请您单击“确定”按钮返回上一页面，如多次重试后仍出现此错误，请您与系统管理员联系。");

            return DataAccess.GetDataById(Convert.ToInt32(id));
        }


        /// <summary>
        /// 从数据库中读取并返回所有高级体检表（AdvancedExamination）List列表。
        /// </summary>
        public static List<AdvancedExamination> GetAllList()
        {
            return DataAccess.GetAllList();
        }


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的高级体检表（AdvancedExamination）的列表及分页信息。
        /// 该方法所获取的高级体检表（AdvancedExamination）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
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
