using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.OracleClient;
using System.Collections.Generic;
using Zhbit.HealthSystem.Model;
using Zhbit.HealthSystem.SFL;

namespace Zhbit.HealthSystem.DAL.Oracle
{
    /// <summary>
    /// 对象名称：管理员Oracle数据访问子类（数据访问层）
    /// 对象说明：提供“管理员类（业务逻辑层）”针对Oracle的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“管理员类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-7 17:24:34
    /// </summary>
    public class ManagerDAL:DAL.Common.ManagerDAL
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将管理员（Manager）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="manager">管理员（Manager）实例对象</param>
        public override int Insert(Manager manager)
        {
            string sqlText = "INSERT INTO \"Manager\""
                           + "(\"Name\",\"LoginName\",\"Password\",\"Type\",\"Role\",\"Note\")"
                           + "VALUES"
                           + "(:Name,:LoginName,:Password,:Type,:Role,:Note)";
            OracleParameter[] parameters = 
            {
                new OracleParameter(":Name"      , OracleType.NVarChar , 50){ Value = manager.Name      },
                new OracleParameter(":LoginName" , OracleType.NVarChar , 50){ Value = manager.LoginName },
                new OracleParameter(":Password"  , OracleType.NVarChar , 50){ Value = manager.Password  },
                new OracleParameter(":Type"      , OracleType.NVarChar , 50){ Value = manager.Type      },
                new OracleParameter(":Role"      , OracleType.NVarChar , 50){ Value = manager.Role      },
                new OracleParameter(":Note"      , OracleType.NVarChar , 50){ Value = manager.Note      }
            };
            return SFL.OracleHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将管理员（Manager）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="manager">管理员（Manager）实例对象</param>
        public override int Update(Manager manager)
        {
            string sqlText = "UPDATE \"Manager\" SET "
                           + "\"Name\"=:Name,\"LoginName\"=:LoginName,\"Password\"=:Password,\"Type\"=:Type,\"Role\"=:Role,\"Note\"=:Note "
                           + "WHERE \"Id\"=:Id";
            OracleParameter[] parameters = 
            {
                new OracleParameter(":Name"      , OracleType.NVarChar , 50){ Value = manager.Name      },
                new OracleParameter(":LoginName" , OracleType.NVarChar , 50){ Value = manager.LoginName },
                new OracleParameter(":Password"  , OracleType.NVarChar , 50){ Value = manager.Password  },
                new OracleParameter(":Type"      , OracleType.NVarChar , 50){ Value = manager.Type      },
                new OracleParameter(":Role"      , OracleType.NVarChar , 50){ Value = manager.Role      },
                new OracleParameter(":Note"      , OracleType.NVarChar , 50){ Value = manager.Note      },
                new OracleParameter(":Id"        , OracleType.Int32    , 4 ){ Value = manager.Id        }
            };
            return SFL.OracleHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据管理员（Manager）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">管理员（Manager）的主键“编号（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM \"Manager\"" 
                           + "WHERE \"Id\"=:Id";
            OracleParameter[] parameters = 
            {
                new OracleParameter(":Id" , OracleType.Int32 , 4){ Value = id }
            };
            return SFL.OracleHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据管理员（Manager）的主键“编号（Id）”从数据库中获取管理员（Manager）的实例。
        /// 成功从数据库中取得记录返回新管理员（Manager）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">管理员（Manager）的主键“编号（Id）”</param>
        public override Manager GetDataById(int id)
        {
            Manager manager = null;
            string sqlText = "SELECT \"Id\",\"Name\",\"LoginName\",\"Password\",\"Type\",\"Role\",\"Note\" "
                           + "FROM \"Manager\" "
                           + "WHERE \"Id\"=:Id";
            OracleParameter[] parameters = 
            {
                new OracleParameter(":Id" , OracleType.Int32 , 4){ Value = id }
            };

            OracleDataReader oracleDataReader = SFL.OracleHelper.ExecuteReader(sqlText, parameters);
            if (oracleDataReader.Read())
            {
                manager = new Manager();
                ReadManagerAllData(oracleDataReader,manager);
            }
            oracleDataReader.Close();
            return manager;
        }

        /// <summary>
        /// 根据管理员（Manager）的登录名“（LoginName）”从数据库中获取管理员（Manager）的实例。
        /// 成功从数据库中取得记录返回新管理员（Manager）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="LoginName">管理员（Manager）的登录名“（LoginName）</param>
        /// <returns></returns>
        public override Manager GetDataByLoginName(string LoginName)
        {
            Manager manager = null;
            string sqlText = "SELECT \"Id\",\"Name\",\"LoginName\",\"Password\",\"Type\",\"Role\",\"Note\" "
                           + "FROM \"Manager\" "
                           + "WHERE \"LoginName\"=:LoginName";
            OracleParameter[] parameters =
            {
                new OracleParameter(":LoginName" , OracleType.NVarChar , 50){ Value = LoginName }
            };

            OracleDataReader oracleDataReader = SFL.OracleHelper.ExecuteReader(sqlText, parameters);
            if (oracleDataReader.Read())
            {
                manager = new Manager();
                ReadManagerAllData(oracleDataReader, manager);
            }
            oracleDataReader.Close();
            return manager;
        }
        /// <summary>
        /// 从数据库中读取并返回所有管理员（Manager）List列表。
        /// </summary>
        public override List<Manager> GetAllList()
        {
            string sqlText = "SELECT \"Id\",\"Name\",\"LoginName\",\"Password\",\"Type\",\"Role\",\"Note\" "
                           + "FROM \"Manager\"";
            List<Manager> list = new List<Manager>();
            OracleDataReader oracleDataReader = SFL.OracleHelper.ExecuteReader(sqlText, null);
            while (oracleDataReader.Read())
            {
                Manager manager = new Manager();
                ReadManagerAllData(oracleDataReader, manager);
                list.Add(manager);
            }
            oracleDataReader.Close();
            return list;
        }


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的管理员（Manager）的列表及分页信息。
        /// 该方法所获取的管理员（Manager）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public override PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "SELECT \"Id\",\"Name\",\"LoginName\",\"Password\",\"Type\",\"Role\",\"Note\" "
                           + "FROM \"Manager\"";
            List<Manager> list = new List<Manager>();
            OracleDataReader oracleDataReader = SFL.OracleHelper.ExecuteReader(sqlText, null);

            PageData pageData = new PageData();
            pageData.PageSize = pageSize;
            pageData.CurPage = curPage;
            pageData.RecordCount = 0;
            pageData.PageCount = 1;

            int first = (curPage - 1) * pageSize + 1;
            int last = curPage * pageSize;

            while (oracleDataReader.Read())
            {
                pageData.RecordCount++;
                if (pageData.RecordCount >= first && last >= pageData.RecordCount)
                {
                    Manager manager = new Manager();
                    ReadManagerPageData(oracleDataReader, manager);
                    list.Add(manager);
                }
            }
            oracleDataReader.Close();

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
