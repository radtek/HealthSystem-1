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
    /// 对象名称：居民疾病信息业务逻辑类（业务逻辑层）
    /// 对象说明：与Resident 居民类相关联，此类为居民类的延展扩展类（疾病信息）。
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-7 17:24:34
    /// </summary>
    public class ResidentDiseaseInfoBLL
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
        internal static DAL.Common.ResidentDiseaseInfoDAL DataAccess
        {
            get
            {
                return DAL.Common.ResidentDiseaseInfoDAL.Instance;
            }
        }


        /// <summary>
        /// 对居民疾病信息（ResidentDiseaseInfo）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="residentDiseaseInfo">居民疾病信息（ResidentDiseaseInfo）实例对象</param>
        public static void CheckValid(ResidentDiseaseInfo residentDiseaseInfo)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(residentDiseaseInfo.Id))
                throw new CustomException("“居民内部编号”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(residentDiseaseInfo.Id , 50))
                throw new CustomException("“居民内部编号”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(residentDiseaseInfo.HODA , 50))
                throw new CustomException("“药物过敏史”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(residentDiseaseInfo.EH , 50))
                throw new CustomException("“暴露史”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(residentDiseaseInfo.HBP , 50))
                throw new CustomException("“高血压”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(residentDiseaseInfo.GDM , 50))
                throw new CustomException("“糖尿病”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(residentDiseaseInfo.CH , 50))
                throw new CustomException("“冠心病”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(residentDiseaseInfo.COP , 50))
                throw new CustomException("“慢性阻塞性肺疾病”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(residentDiseaseInfo.MTC , 50))
                throw new CustomException("“恶性肿瘤”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(residentDiseaseInfo.Stroke , 50))
                throw new CustomException("“脑卒中”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(residentDiseaseInfo.SMI , 50))
                throw new CustomException("“重性精神”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(residentDiseaseInfo.TB , 50))
                throw new CustomException("“结核病”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(residentDiseaseInfo.Hepatitis , 50))
                throw new CustomException("“肝炎”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(residentDiseaseInfo.OLID , 50))
                throw new CustomException("“其他法定传染病”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(residentDiseaseInfo.OD , 50))
                throw new CustomException("“职业病”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(residentDiseaseInfo.Other , 50))
                throw new CustomException("“其他”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(residentDiseaseInfo.HistoryOfFather , 50))
                throw new CustomException("“父亲病史”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(residentDiseaseInfo.HistoryOfMother , 50))
                throw new CustomException("“母亲病史”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(residentDiseaseInfo.HistoryOfBrothers , 50))
                throw new CustomException("“兄弟姐妹病史”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(residentDiseaseInfo.HistoryOfChildren , 50))
                throw new CustomException("“子女病史”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(residentDiseaseInfo.GeneticHistory , 50))
                throw new CustomException("“遗传病史”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(residentDiseaseInfo.Disability , 50))
                throw new CustomException("“残疾情况”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(residentDiseaseInfo.Remarks , 50))
                throw new CustomException("“备注”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将居民疾病信息（ResidentDiseaseInfo）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="residentDiseaseInfo">居民疾病信息（ResidentDiseaseInfo）实例对象</param>
        public static int Insert(ResidentDiseaseInfo residentDiseaseInfo)
        {
            CheckValid(residentDiseaseInfo);
            return DataAccess.Insert(residentDiseaseInfo);
        }


        /// <summary>
        /// 将居民疾病信息（ResidentDiseaseInfo）数据，根据主键“居民内部编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="residentDiseaseInfo">居民疾病信息（ResidentDiseaseInfo）实例对象</param>
        public static int Update(ResidentDiseaseInfo residentDiseaseInfo)
        {
            CheckValid(residentDiseaseInfo);
            return DataAccess.Update(residentDiseaseInfo);
        }


        /// <summary>
        /// 根据居民疾病信息（ResidentDiseaseInfo）的主键“居民内部编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">居民疾病信息（ResidentDiseaseInfo）的主键“居民内部编号（Id）”</param>
        public static int Delete(string id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// 根据居民疾病信息（ResidentDiseaseInfo）的主键“居民内部编号（Id）”从数据库中获取居民疾病信息（ResidentDiseaseInfo）的实例。
        /// 成功从数据库中取得记录返回新居民疾病信息（ResidentDiseaseInfo）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">居民疾病信息（ResidentDiseaseInfo）的主键“居民内部编号（Id）”</param>
        public static ResidentDiseaseInfo GetDataById(string id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 从数据库中读取并返回所有居民疾病信息（ResidentDiseaseInfo）List列表。
        /// </summary>
        public static List<ResidentDiseaseInfo> GetAllList()
        {
            return DataAccess.GetAllList();
        }


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的居民疾病信息（ResidentDiseaseInfo）的列表及分页信息。
        /// 该方法所获取的居民疾病信息（ResidentDiseaseInfo）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
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
