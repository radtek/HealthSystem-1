using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using Zhbit.HealthSystem.Model;
using Zhbit.HealthSystem.SFL;

namespace Zhbit.HealthSystem.DAL.SqlServer
{
    /// <summary>
    /// 对象名称：管理机构SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“管理机构类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“管理机构类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-7 17:24:34
    /// </summary>
    public class InstitutionsDAL:DAL.Common.InstitutionsDAL
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将管理机构（Institutions）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="institutions">管理机构（Institutions）实例对象</param>
        public override int Insert(Institutions institutions)
        {
            string sqlText = "INSERT INTO [Institutions]"
                           + "([Name],[IType],[IAddress],[Phone],[Head],[SuperiorDepartments],[Remarks])"
                           + "VALUES"
                           + "(@Name,@IType,@IAddress,@Phone,@Head,@SuperiorDepartments,@Remarks)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Name"                , SqlDbType.NVarChar , 50){ Value = institutions.Name                },
                new SqlParameter("@IType"               , SqlDbType.NVarChar , 50){ Value = institutions.IType               },
                new SqlParameter("@IAddress"            , SqlDbType.NVarChar , 50){ Value = institutions.IAddress            },
                new SqlParameter("@Phone"               , SqlDbType.NVarChar , 50){ Value = institutions.Phone               },
                new SqlParameter("@Head"                , SqlDbType.NVarChar , 50){ Value = institutions.Head                },
                new SqlParameter("@SuperiorDepartments" , SqlDbType.Int      , 4 ){ Value = institutions.SuperiorDepartments },
                new SqlParameter("@Remarks"             , SqlDbType.NVarChar , 50){ Value = institutions.Remarks             }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将管理机构（Institutions）数据，根据主键“机构编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="institutions">管理机构（Institutions）实例对象</param>
        public override int Update(Institutions institutions)
        {
            string sqlText = "UPDATE [Institutions] SET "
                           + "[Name]=@Name,[IType]=@IType,[IAddress]=@IAddress,[Phone]=@Phone,[Head]=@Head,[SuperiorDepartments]=@SuperiorDepartments,"
                           + "[Remarks]=@Remarks "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Name"                , SqlDbType.NVarChar , 50){ Value = institutions.Name                },
                new SqlParameter("@IType"               , SqlDbType.NVarChar , 50){ Value = institutions.IType               },
                new SqlParameter("@IAddress"            , SqlDbType.NVarChar , 50){ Value = institutions.IAddress            },
                new SqlParameter("@Phone"               , SqlDbType.NVarChar , 50){ Value = institutions.Phone               },
                new SqlParameter("@Head"                , SqlDbType.NVarChar , 50){ Value = institutions.Head                },
                new SqlParameter("@SuperiorDepartments" , SqlDbType.Int      , 4 ){ Value = institutions.SuperiorDepartments },
                new SqlParameter("@Remarks"             , SqlDbType.NVarChar , 50){ Value = institutions.Remarks             },
                new SqlParameter("@Id"                  , SqlDbType.Int      , 4 ){ Value = institutions.Id                  }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据管理机构（Institutions）的主键“机构编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">管理机构（Institutions）的主键“机构编号（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [Institutions] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据管理机构（Institutions）的主键“机构编号（Id）”从数据库中获取管理机构（Institutions）的实例。
        /// 成功从数据库中取得记录返回新管理机构（Institutions）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">管理机构（Institutions）的主键“机构编号（Id）”</param>
        public override Institutions GetDataById(int id)
        {
            Institutions institutions = null;
            string sqlText = "SELECT [Id],[Name],[IType],[IAddress],[Phone],[Head],[SuperiorDepartments],[Remarks] "
                           + "FROM [Institutions] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                institutions = new Institutions();
                ReadInstitutionsAllData(sqlDataReader,institutions);
            }
            sqlDataReader.Close();
            return institutions;
        }


        /// <summary>
        /// 从数据库中读取并返回所有管理机构（Institutions）List列表。
        /// </summary>
        public override List<Institutions> GetAllList()
        {
            string sqlText = "SELECT [Id],[Name],[IType],[IAddress],[Phone],[Head],[SuperiorDepartments],[Remarks] "
                           + "FROM [Institutions]";
            List<Institutions> list = new List<Institutions>();
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, null);
            while (sqlDataReader.Read())
            {
                Institutions institutions = new Institutions();
                ReadInstitutionsAllData(sqlDataReader, institutions);
                list.Add(institutions);
            }
            sqlDataReader.Close();
            return list;
        }


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的管理机构（Institutions）的列表及分页信息。
        /// 该方法所获取的管理机构（Institutions）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public override PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "SELECT [Id],[Name],[IType],[IAddress],[Phone],[Head],[SuperiorDepartments],[Remarks] "
                           + "FROM [Institutions]";
            List<Institutions> list = new List<Institutions>();
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, null);

            PageData pageData = new PageData();
            pageData.PageSize = pageSize;
            pageData.CurPage = curPage;
            pageData.RecordCount = 0;
            pageData.PageCount = 1;

            int first = (curPage - 1) * pageSize + 1;
            int last = curPage * pageSize;

            while (sqlDataReader.Read())
            {
                pageData.RecordCount++;
                if (pageData.RecordCount >= first && last >= pageData.RecordCount)
                {
                    Institutions institutions = new Institutions();
                    ReadInstitutionsPageData(sqlDataReader, institutions);
                    list.Add(institutions);
                }
            }
            sqlDataReader.Close();

            if(pageData.RecordCount>0)
                pageData.PageCount = Convert.ToInt32(Math.Ceiling((double)pageData.RecordCount / (double)pageSize));

            pageData.PageList = list;
            return pageData;
        }

        #endregion 多层框架式下的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，请先在本类的父类中对相关抽象方法进行定义，再在本类中进行具体实现。
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
