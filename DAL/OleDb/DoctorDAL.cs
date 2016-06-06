using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Collections.Generic;
using Zhbit.HealthSystem.Model;
using Zhbit.HealthSystem.SFL;

namespace Zhbit.HealthSystem.DAL.OleDb
{
    /// <summary>
    /// 对象名称：社区医生OleDb数据访问子类（数据访问层）
    /// 对象说明：提供“社区医生类（业务逻辑层）”针对OleDb的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“社区医生类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016/4/28 13:59:21
    /// </summary>
    public class DoctorDAL:DAL.Common.DoctorDAL
    {
        #region 多层框架下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架所自动生成，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将社区医生（Doctor）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="doctor">社区医生（Doctor）实例对象</param>
        public override int Insert(Doctor doctor)
        {
            string sqlText = "INSERT INTO [Doctor]"
                           + "([DoctorId],[Name],[ExamNo],[Pwd],[InstitutionId],[Remarks])"
                           + "VALUES"
                           + "(@DoctorId,@Name,@ExamNo,@Pwd,@InstitutionId,@Remarks)";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@DoctorId"      , OleDbType.VarWChar , 50){ Value = doctor.DoctorId    },
                new OleDbParameter("@Name"          , OleDbType.VarWChar , 50){ Value = doctor.Name        },
                new OleDbParameter("@ExamNo"        , OleDbType.VarWChar , 50){ Value = doctor.ExamNo      },
                new OleDbParameter("@Pwd"           , OleDbType.VarWChar , 50){ Value = doctor.Pwd         },
                new OleDbParameter("@InstitutionId" , OleDbType.Integer  , 4 ){ Value = doctor.Institution },
                new OleDbParameter("@Remarks"       , OleDbType.VarWChar , 50){ Value = doctor.Remarks     }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将社区医生（Doctor）数据，根据主键“自动编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="doctor">社区医生（Doctor）实例对象</param>
        public override int Update(Doctor doctor)
        {
            string sqlText = "UPDATE [Doctor] SET "
                           + "[DoctorId]=@DoctorId,[Name]=@Name,[ExamNo]=@ExamNo,[Pwd]=@Pwd,[InstitutionId]=@InstitutionId,[Remarks]=@Remarks "
                           + "WHERE [Id]=@Id";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@DoctorId"      , OleDbType.VarWChar , 50){ Value = doctor.DoctorId    },
                new OleDbParameter("@Name"          , OleDbType.VarWChar , 50){ Value = doctor.Name        },
                new OleDbParameter("@ExamNo"        , OleDbType.VarWChar , 50){ Value = doctor.ExamNo      },
                new OleDbParameter("@Pwd"           , OleDbType.VarWChar , 50){ Value = doctor.Pwd         },
                new OleDbParameter("@InstitutionId" , OleDbType.Integer  , 4 ){ Value = doctor.Institution },
                new OleDbParameter("@Remarks"       , OleDbType.VarWChar , 50){ Value = doctor.Remarks     },
                new OleDbParameter("@Id"            , OleDbType.Integer  , 4 ){ Value = doctor.Id          }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据社区医生（Doctor）的主键“自动编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">社区医生（Doctor）的主键“自动编号（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [Doctor] "
                           + "WHERE [Id]=@Id";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id" , OleDbType.Integer , 4){ Value = id }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据社区医生（Doctor）的主键“自动编号（Id）”从数据库中获取社区医生（Doctor）的实例。
        /// 成功从数据库中取得记录返回新社区医生（Doctor）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">社区医生（Doctor）的主键“自动编号（Id）”</param>
        public override Doctor GetDataById(int id)
        {
            Doctor doctor = null;
            string sqlText = "SELECT [Id],[DoctorId],[Name],[ExamNo],[Pwd],[InstitutionId],[Remarks] "
                           + "FROM [Doctor] "
                           + "WHERE [Id]=@Id";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id" , OleDbType.Integer , 4){ Value = id }
            };

            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, parameters);
            if (oleDbDataReader.Read())
            {
                doctor = new Doctor();
                ReadDoctorAllData(oleDbDataReader,doctor);
            }
            oleDbDataReader.Close();
            return doctor;
        }


        /// <summary>
        ///  根据社区医生（Doctor）的“医生编号（DoctorId）”从数据库中获取社区医生（Doctor）的实例。
        /// 成功从数据库中取得记录返回新社区医生（Doctor）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="doctorid">社区医生（Doctor）的“医生编号（DoctorId）”</param>
        /// <returns></returns>
        public override Doctor GetDataByDoctorId(string doctorid)
        {
            Doctor doctor = null;
            string sqlText = "SELECT [Id],[DoctorId],[Name],[ExamNo],[Pwd],[InstitutionId],[Remarks] "
                           + "FROM [Doctor] "
                           + "WHERE [DoctorId]=@DoctorId";
            OleDbParameter[] parameters =
            {
                new OleDbParameter("@DoctorId" , OleDbType.VarWChar , 50){ Value = doctorid }
            };

            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, parameters);
            if (oleDbDataReader.Read())
            {
                doctor = new Doctor();
                ReadDoctorAllData(oleDbDataReader, doctor);
            }
            oleDbDataReader.Close();
            return doctor;
        }
        /// <summary>
        /// 从数据库中读取并返回所有社区医生（Doctor）List列表。
        /// </summary>
        public override List<Doctor> GetAllList()
        {
            string sqlText = "SELECT [Id],[DoctorId],[Name],[ExamNo],[Pwd],[InstitutionId],[Remarks] "
                           + "FROM [Doctor]";
            List<Doctor> list = new List<Doctor>();
            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, null);
            while (oleDbDataReader.Read())
            {
                Doctor doctor = new Doctor();
                ReadDoctorAllData(oleDbDataReader, doctor);
                list.Add(doctor);
            }
            oleDbDataReader.Close();
            return list;
        }


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的社区医生（Doctor）的列表及分页信息。
        /// 该方法所获取的社区医生（Doctor）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public override PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "SELECT [Id],[DoctorId],[Name],[ExamNo],[Pwd],[InstitutionId],[Remarks] "
                           + "FROM [Doctor]";
            List<Doctor> list = new List<Doctor>();
            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, null);

            PageData pageData = new PageData();
            pageData.PageSize = pageSize;
            pageData.CurPage = curPage;
            pageData.RecordCount = 0;
            pageData.PageCount = 1;

            int first = (curPage - 1) * pageSize + 1;
            int last = curPage * pageSize;

            while (oleDbDataReader.Read())
            {
                pageData.RecordCount++;
                if (pageData.RecordCount >= first && last >= pageData.RecordCount)
                {
                    Doctor doctor = new Doctor();
                    ReadDoctorPageData(oleDbDataReader, doctor);
                    list.Add(doctor);
                }
            }
            oleDbDataReader.Close();

            if(pageData.RecordCount>0)
                pageData.PageCount = Convert.ToInt32(Math.Ceiling((double)pageData.RecordCount / (double)pageSize));

            pageData.PageList = list;
            return pageData;
        }

        #endregion 多层框架下的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，请先在本类的父类中对相关抽象方法进行定义，再在本类中进行具体实现。
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
