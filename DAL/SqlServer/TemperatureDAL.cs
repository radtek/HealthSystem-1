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
    /// 对象名称：体温检测类SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“体温检测类类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“体温检测类类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 16:57:39
    /// </summary>
    public class TemperatureDAL:DAL.Common.TemperatureDAL
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将体温检测类（Temperature）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="temperature">体温检测类（Temperature）实例对象</param>
        public override int Insert(Temperature temperature)
        {
            string sqlText = "INSERT INTO [Temperature]"
                           + "([Checkdate],[ExamNo],[CheckID],[Name],[SexId],[Age],[Doctor],[DeviceID],[Version],[Reserve],[Check_flagId],[Hosname],[Auditdoctor],[Auditdate],"
                           + "[StatusId],[Str1],[Str2],[Str3],[Str4],[Str5],[Str6],[Str7],[Str8],[Str9],[Str10],[T3001007_ename],[T3001007_cname],[T3001007_unit],[T3001007_srange],"
                           + "[T3001007_lrange],[T3001007_value])"
                           + "VALUES"
                           + "(@Checkdate,@ExamNo,@CheckID,@Name,@SexId,@Age,@Doctor,@DeviceID,@Version,@Reserve,@Check_flagId,@Hosname,@Auditdoctor,@Auditdate,"
                           + "@StatusId,@Str1,@Str2,@Str3,@Str4,@Str5,@Str6,@Str7,@Str8,@Str9,@Str10,@T3001007_ename,@T3001007_cname,@T3001007_unit,@T3001007_srange,"
                           + "@T3001007_lrange,@T3001007_value)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Checkdate"       , SqlDbType.DateTime , 8 ){ Value = temperature.Checkdate       },
                new SqlParameter("@ExamNo"          , SqlDbType.NVarChar , 50){ Value = temperature.ExamNo          },
                new SqlParameter("@CheckID"         , SqlDbType.NVarChar , 50){ Value = temperature.CheckID         },
                new SqlParameter("@Name"            , SqlDbType.NVarChar , 50){ Value = temperature.Name            },
                new SqlParameter("@SexId"           , SqlDbType.NVarChar , 50){ Value = temperature.Sex             },
                new SqlParameter("@Age"             , SqlDbType.Int      , 4 ){ Value = temperature.Age             },
                new SqlParameter("@Doctor"          , SqlDbType.NVarChar , 50){ Value = temperature.Doctor          },
                new SqlParameter("@DeviceID"        , SqlDbType.NVarChar , 50){ Value = temperature.DeviceID        },
                new SqlParameter("@Version"         , SqlDbType.NVarChar , 50){ Value = temperature.Version         },
                new SqlParameter("@Reserve"         , SqlDbType.NVarChar , 50){ Value = temperature.Reserve         },
                new SqlParameter("@Check_flagId"    , SqlDbType.Int      , 4 ){ Value = temperature.Check_flag      },
                new SqlParameter("@Hosname"         , SqlDbType.NVarChar , 50){ Value = temperature.Hosname         },
                new SqlParameter("@Auditdoctor"     , SqlDbType.NVarChar , 50){ Value = temperature.Auditdoctor     },
                new SqlParameter("@Auditdate"       , SqlDbType.DateTime , 8 ){ Value = temperature.Auditdate       },
                new SqlParameter("@StatusId"        , SqlDbType.Int      , 4 ){ Value = temperature.Status          },
                new SqlParameter("@Str1"            , SqlDbType.NVarChar , 50){ Value = temperature.Str1            },
                new SqlParameter("@Str2"            , SqlDbType.NVarChar , 50){ Value = temperature.Str2            },
                new SqlParameter("@Str3"            , SqlDbType.NVarChar , 50){ Value = temperature.Str3            },
                new SqlParameter("@Str4"            , SqlDbType.NVarChar , 50){ Value = temperature.Str4            },
                new SqlParameter("@Str5"            , SqlDbType.NVarChar , 50){ Value = temperature.Str5            },
                new SqlParameter("@Str6"            , SqlDbType.NVarChar , 50){ Value = temperature.Str6            },
                new SqlParameter("@Str7"            , SqlDbType.NVarChar , 50){ Value = temperature.Str7            },
                new SqlParameter("@Str8"            , SqlDbType.NVarChar , 50){ Value = temperature.Str8            },
                new SqlParameter("@Str9"            , SqlDbType.NVarChar , 50){ Value = temperature.Str9            },
                new SqlParameter("@Str10"           , SqlDbType.NVarChar , 50){ Value = temperature.Str10           },
                new SqlParameter("@T3001007_ename"  , SqlDbType.NVarChar , 50){ Value = temperature.T3001007_ename  },
                new SqlParameter("@T3001007_cname"  , SqlDbType.NVarChar , 50){ Value = temperature.T3001007_cname  },
                new SqlParameter("@T3001007_unit"   , SqlDbType.NVarChar , 50){ Value = temperature.T3001007_unit   },
                new SqlParameter("@T3001007_srange" , SqlDbType.Int      , 4 ){ Value = temperature.T3001007_srange },
                new SqlParameter("@T3001007_lrange" , SqlDbType.Int      , 4 ){ Value = temperature.T3001007_lrange },
                new SqlParameter("@T3001007_value"  , SqlDbType.Int      , 4 ){ Value = temperature.T3001007_value  }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将体温检测类（Temperature）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="temperature">体温检测类（Temperature）实例对象</param>
        public override int Update(Temperature temperature)
        {
            string sqlText = "UPDATE [Temperature] SET "
                           + "[Checkdate]=@Checkdate,[ExamNo]=@ExamNo,[CheckID]=@CheckID,[Name]=@Name,[SexId]=@SexId,[Age]=@Age,[Doctor]=@Doctor,"
                           + "[DeviceID]=@DeviceID,[Version]=@Version,[Reserve]=@Reserve,[Check_flagId]=@Check_flagId,[Hosname]=@Hosname,[Auditdoctor]=@Auditdoctor,"
                           + "[Auditdate]=@Auditdate,[StatusId]=@StatusId,[Str1]=@Str1,[Str2]=@Str2,[Str3]=@Str3,[Str4]=@Str4,[Str5]=@Str5,[Str6]=@Str6,[Str7]=@Str7,[Str8]=@Str8,[Str9]=@Str9,"
                           + "[Str10]=@Str10,[T3001007_ename]=@T3001007_ename,[T3001007_cname]=@T3001007_cname,[T3001007_unit]=@T3001007_unit,"
                           + "[T3001007_srange]=@T3001007_srange,[T3001007_lrange]=@T3001007_lrange,[T3001007_value]=@T3001007_value "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Checkdate"       , SqlDbType.DateTime , 8 ){ Value = temperature.Checkdate       },
                new SqlParameter("@ExamNo"          , SqlDbType.NVarChar , 50){ Value = temperature.ExamNo          },
                new SqlParameter("@CheckID"         , SqlDbType.NVarChar , 50){ Value = temperature.CheckID         },
                new SqlParameter("@Name"            , SqlDbType.NVarChar , 50){ Value = temperature.Name            },
                new SqlParameter("@SexId"           , SqlDbType.NVarChar , 50){ Value = temperature.Sex             },
                new SqlParameter("@Age"             , SqlDbType.Int      , 4 ){ Value = temperature.Age             },
                new SqlParameter("@Doctor"          , SqlDbType.NVarChar , 50){ Value = temperature.Doctor          },
                new SqlParameter("@DeviceID"        , SqlDbType.NVarChar , 50){ Value = temperature.DeviceID        },
                new SqlParameter("@Version"         , SqlDbType.NVarChar , 50){ Value = temperature.Version         },
                new SqlParameter("@Reserve"         , SqlDbType.NVarChar , 50){ Value = temperature.Reserve         },
                new SqlParameter("@Check_flagId"    , SqlDbType.Int      , 4 ){ Value = temperature.Check_flag      },
                new SqlParameter("@Hosname"         , SqlDbType.NVarChar , 50){ Value = temperature.Hosname         },
                new SqlParameter("@Auditdoctor"     , SqlDbType.NVarChar , 50){ Value = temperature.Auditdoctor     },
                new SqlParameter("@Auditdate"       , SqlDbType.DateTime , 8 ){ Value = temperature.Auditdate       },
                new SqlParameter("@StatusId"        , SqlDbType.Int      , 4 ){ Value = temperature.Status          },
                new SqlParameter("@Str1"            , SqlDbType.NVarChar , 50){ Value = temperature.Str1            },
                new SqlParameter("@Str2"            , SqlDbType.NVarChar , 50){ Value = temperature.Str2            },
                new SqlParameter("@Str3"            , SqlDbType.NVarChar , 50){ Value = temperature.Str3            },
                new SqlParameter("@Str4"            , SqlDbType.NVarChar , 50){ Value = temperature.Str4            },
                new SqlParameter("@Str5"            , SqlDbType.NVarChar , 50){ Value = temperature.Str5            },
                new SqlParameter("@Str6"            , SqlDbType.NVarChar , 50){ Value = temperature.Str6            },
                new SqlParameter("@Str7"            , SqlDbType.NVarChar , 50){ Value = temperature.Str7            },
                new SqlParameter("@Str8"            , SqlDbType.NVarChar , 50){ Value = temperature.Str8            },
                new SqlParameter("@Str9"            , SqlDbType.NVarChar , 50){ Value = temperature.Str9            },
                new SqlParameter("@Str10"           , SqlDbType.NVarChar , 50){ Value = temperature.Str10           },
                new SqlParameter("@T3001007_ename"  , SqlDbType.NVarChar , 50){ Value = temperature.T3001007_ename  },
                new SqlParameter("@T3001007_cname"  , SqlDbType.NVarChar , 50){ Value = temperature.T3001007_cname  },
                new SqlParameter("@T3001007_unit"   , SqlDbType.NVarChar , 50){ Value = temperature.T3001007_unit   },
                new SqlParameter("@T3001007_srange" , SqlDbType.Int      , 4 ){ Value = temperature.T3001007_srange },
                new SqlParameter("@T3001007_lrange" , SqlDbType.Int      , 4 ){ Value = temperature.T3001007_lrange },
                new SqlParameter("@T3001007_value"  , SqlDbType.Int      , 4 ){ Value = temperature.T3001007_value  },
                new SqlParameter("@Id"              , SqlDbType.Int      , 4 ){ Value = temperature.Id              }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据体温检测类（Temperature）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">体温检测类（Temperature）的主键“编号（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [Temperature] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据体温检测类（Temperature）的主键“编号（Id）”从数据库中获取体温检测类（Temperature）的实例。
        /// 成功从数据库中取得记录返回新体温检测类（Temperature）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">体温检测类（Temperature）的主键“编号（Id）”</param>
        public override Temperature GetDataById(int id)
        {
            Temperature temperature = null;
            string sqlText = "SELECT [Id],[Checkdate],[ExamNo],[CheckID],[Name],[SexId],[Age],[Doctor],[DeviceID],[Version],[Reserve],[Check_flagId],[Hosname],[Auditdoctor],[Auditdate],"
                           + "[StatusId],[Str1],[Str2],[Str3],[Str4],[Str5],[Str6],[Str7],[Str8],[Str9],[Str10],[T3001007_ename],[T3001007_cname],[T3001007_unit],[T3001007_srange],"
                           + "[T3001007_lrange],[T3001007_value] "
                           + "FROM [Temperature] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                temperature = new Temperature();
                ReadTemperatureAllData(sqlDataReader,temperature);
            }
            sqlDataReader.Close();
            return temperature;
        }


        /// <summary>
        /// 从数据库中读取并返回所有体温检测类（Temperature）List列表。
        /// </summary>
        public override List<Temperature> GetAllList()
        {
            string sqlText = "SELECT [Id],[Checkdate],[ExamNo],[CheckID],[Name],[SexId],[Age],[Doctor],[DeviceID],[Version],[Reserve],[Check_flagId],[Hosname],[Auditdoctor],[Auditdate],"
                           + "[StatusId],[Str1],[Str2],[Str3],[Str4],[Str5],[Str6],[Str7],[Str8],[Str9],[Str10],[T3001007_ename],[T3001007_cname],[T3001007_unit],[T3001007_srange],"
                           + "[T3001007_lrange],[T3001007_value] "
                           + "FROM [Temperature]";
            List<Temperature> list = new List<Temperature>();
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, null);
            while (sqlDataReader.Read())
            {
                Temperature temperature = new Temperature();
                ReadTemperatureAllData(sqlDataReader, temperature);
                list.Add(temperature);
            }
            sqlDataReader.Close();
            return list;
        }


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的体温检测类（Temperature）的列表及分页信息。
        /// 该方法所获取的体温检测类（Temperature）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public override PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "SELECT [Id],[Checkdate],[ExamNo],[CheckID],[Name],[SexId],[Doctor],[Check_flagId],[Hosname],[StatusId] "
                           + "FROM [Temperature]";
            List<Temperature> list = new List<Temperature>();
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
                    Temperature temperature = new Temperature();
                    ReadTemperaturePageData(sqlDataReader, temperature);
                    list.Add(temperature);
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
