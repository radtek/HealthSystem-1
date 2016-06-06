using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using Zhbit.HealthSystem.Model;
using Zhbit.HealthSystem.SFL;

namespace Zhbit.HealthSystem.DAL.Common
{
    /// <summary>
    /// 对象名称：社区医生通用数据访问父类（数据访问层）
    /// 对象说明：提供“社区医生类（业务逻辑层）”对SqlServer,Oracle,OleDb等数据库进行访问的相关方法，以及部分通用方法供其子类进行调用。
    /// 调用说明：本类为抽象类无法进行实例化，通常可以使用“社区医生类（业务逻辑层）”中的DataAccess属性来调用本类中所定义数据访问方法。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016/4/28 13:59:21
    /// </summary>
    public abstract class DoctorDAL
    {
        #region 多层框架下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架所自动生成，提供该类数据访问的基本方法。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        //警告：仅用于缓存“社区医生（DoctorDAL）数据访问类”的单件实例，永远不要直接访问该变量。
        private static DoctorDAL doctorDAL;


        /// <summary>
        /// 获取“社区医生（DoctorDAL）数据访问类”的实例，该属性通过判断应用程序配置文件中数据库类型“DataBaseType”的值，
        /// 创建一个用于对指定类型数据库进行访问的“社区医生（DoctorDAL）数据访问类”（SqlServer/Oracle/OleDb）”单件实例。
        /// </summary>
        public static DoctorDAL Instance
        {
            get
            {
                if (doctorDAL == null)
                {
                    switch (System.Configuration.ConfigurationManager.AppSettings["DataBaseType"])
                    {
                        case "SqlServer":
                            doctorDAL = new SqlServer.DoctorDAL();
                            break;

                        case "Oracle":
                            doctorDAL = new Oracle.DoctorDAL();
                            break;

                        case "OleDb":
                            doctorDAL = new OleDb.DoctorDAL();
                            break;

                        default:
                            doctorDAL = new SqlServer.DoctorDAL();
                            break;
                    }
                }
                return doctorDAL;
            }
        }


        /// <summary>
        /// 从DataReader中读取数据，并为Doctor对象的所有属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="doctor">社区医生（Doctor）实例对象</param>
        protected void ReadDoctorAllData(IDataReader dataReader, Doctor doctor)
        {
            // 自动编号
            if (dataReader["Id"] != DBNull.Value)
                doctor.Id = Convert.ToInt32(dataReader["Id"]);
            // 医生编号
            if (dataReader["DoctorId"] != DBNull.Value)
                doctor.DoctorId = Convert.ToString(dataReader["DoctorId"]);
            // 姓名
            if (dataReader["Name"] != DBNull.Value)
                doctor.Name = Convert.ToString(dataReader["Name"]);
            // 门诊号
            if (dataReader["ExamNo"] != DBNull.Value)
                doctor.ExamNo = Convert.ToString(dataReader["ExamNo"]);
            // 密码
            if (dataReader["Pwd"] != DBNull.Value)
                doctor.Pwd = Convert.ToString(dataReader["Pwd"]);
            // 所在机构
            if (dataReader["InstitutionId"] != DBNull.Value)
                doctor.Institution = InstitutionsDAL.Instance.GetDataById(Convert.ToInt32(dataReader["InstitutionId"]));
            // 备注
            if (dataReader["Remarks"] != DBNull.Value)
                doctor.Remarks = Convert.ToString(dataReader["Remarks"]);
        }


        /// <summary>
        /// 从DataReader中读取数据，并为Doctor对象需要进行显示的属性赋值。该方法主要由该类的子类调用。
        /// </summary>
        /// <param name="sqlDataReader">IDataReader</param>
        /// <param name="doctor">社区医生（Doctor）实例对象</param>
        protected void ReadDoctorPageData(IDataReader dataReader, Doctor doctor)
        {
            // 自动编号
            if (dataReader["Id"] != DBNull.Value)
                doctor.Id = Convert.ToInt32(dataReader["Id"]);
            // 医生编号
            if (dataReader["DoctorId"] != DBNull.Value)
                doctor.DoctorId = Convert.ToString(dataReader["DoctorId"]);
            // 姓名
            if (dataReader["Name"] != DBNull.Value)
                doctor.Name = Convert.ToString(dataReader["Name"]);
            // 门诊号
            if (dataReader["ExamNo"] != DBNull.Value)
                doctor.ExamNo = Convert.ToString(dataReader["ExamNo"]);
            // 密码
            if (dataReader["Pwd"] != DBNull.Value)
                doctor.Pwd = Convert.ToString(dataReader["Pwd"]);
            // 所在机构
            if (dataReader["InstitutionId"] != DBNull.Value)
                doctor.Institution = InstitutionsDAL.Instance.GetDataById(Convert.ToInt32(dataReader["InstitutionId"]));
            // 备注
            if (dataReader["Remarks"] != DBNull.Value)
                doctor.Remarks = Convert.ToString(dataReader["Remarks"]);
        }


        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  公共数据访问类抽象方法定义，在SqlServer/Oracle/OleDb子类中实现具体方法。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将社区医生（Doctor）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="doctor">社区医生（Doctor）实例对象</param>
        public abstract int Insert(Doctor doctor);


        /// <summary>
        /// 将社区医生（Doctor）数据，根据主键“自动编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="doctor">社区医生（Doctor）实例对象</param>
        public abstract int Update(Doctor doctor);


        /// <summary>
        /// 根据社区医生（Doctor）的主键“自动编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">社区医生（Doctor）的主键“自动编号（Id）”</param>
        public abstract int Delete(int id);


        /// <summary>
        /// 根据社区医生（Doctor）的主键“自动编号（Id）”从数据库中获取社区医生（Doctor）的实例。
        /// 成功从数据库中取得记录返回新社区医生（Doctor）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">社区医生（Doctor）的主键“自动编号（Id）”</param>
        public abstract Doctor GetDataById(int id);


        /// <summary>
        ///  根据社区医生（Doctor）的“医生编号（DoctorId）”从数据库中获取社区医生（Doctor）的实例。
        /// 成功从数据库中取得记录返回新社区医生（Doctor）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="doctorid">社区医生（Doctor）的“医生编号（DoctorId）”</param>
        /// <returns></returns>
        public abstract Doctor GetDataByDoctorId(string doctorid);
      

        /// <summary>
        /// 从数据库中读取并返回所有社区医生（Doctor）List列表。
        /// </summary>
        public abstract List<Doctor> GetAllList();


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的社区医生（Doctor）的列表及分页信息。
        /// 该方法所获取的社区医生（Doctor）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public abstract PageData GetPageList(int pageSize, int curPage);


        #endregion 多层框架下的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，本类中的方法通常为抽象方法，具体实现由本类的子类通过方法重写完成。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
