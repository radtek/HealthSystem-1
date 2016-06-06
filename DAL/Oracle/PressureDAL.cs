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
    /// 对象名称：血压检测类Oracle数据访问子类（数据访问层）
    /// 对象说明：提供“血压检测类类（业务逻辑层）”针对Oracle的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“血压检测类类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 16:56:45
    /// </summary>
    public class PressureDAL:DAL.Common.PressureDAL
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将血压检测类（Pressure）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pressure">血压检测类（Pressure）实例对象</param>
        public override int Insert(Pressure pressure)
        {
            string sqlText = "INSERT INTO \"Pressure\""
                           + "(\"Checkdate\",\"ExamNo\",\"CheckID\",\"Name\",\"SexId\",\"Age\",\"Doctor\",\"DeviceID\",\"Version\",\"Reserve\",\"Check_flagId\",\"Hosname\",\"Auditdoctor\",\"Auditdate\","
                           + "\"StatusId\",\"Str1\",\"Str2\",\"Str3\",\"Str4\",\"Str5\",\"Str6\",\"Str7\",\"Str8\",\"Str9\",\"Str10\",\"T3001002_ename\",\"T3001002_cname\",\"T3001002_unit\",\"T3001002_srange\","
                           + "\"T3001002_lrange\",\"T3001002_value\",\"T3001003_ename\",\"T3001003_cname\",\"T3001003_unit\",\"T3001003_srange\",\"T3001003_lrange\",\"T3001003_value\","
                           + "\"T3001004_ename\",\"T3001004_cname\",\"T3001004_unit\",\"T3001004_srange\",\"T3001004_lrange\",\"T3001004_value\",\"T3001008_ename\",\"T3001008_cname\","
                           + "\"T3001008_unit\",\"T3001008_srange\",\"T3001008_lrange\",\"T3001008_value\")"
                           + "VALUES"
                           + "(:Checkdate,:ExamNo,:CheckID,:Name,:SexId,:Age,:Doctor,:DeviceID,:Version,:Reserve,:Check_flagId,:Hosname,:Auditdoctor,:Auditdate,"
                           + ":StatusId,:Str1,:Str2,:Str3,:Str4,:Str5,:Str6,:Str7,:Str8,:Str9,:Str10,:T3001002_ename,:T3001002_cname,:T3001002_unit,:T3001002_srange,"
                           + ":T3001002_lrange,:T3001002_value,:T3001003_ename,:T3001003_cname,:T3001003_unit,:T3001003_srange,:T3001003_lrange,:T3001003_value,"
                           + ":T3001004_ename,:T3001004_cname,:T3001004_unit,:T3001004_srange,:T3001004_lrange,:T3001004_value,:T3001008_ename,:T3001008_cname,"
                           + ":T3001008_unit,:T3001008_srange,:T3001008_lrange,:T3001008_value)";
            OracleParameter[] parameters = 
            {
                new OracleParameter(":Checkdate"       , OracleType.DateTime , 8 ){ Value = pressure.Checkdate       },
                new OracleParameter(":ExamNo"          , OracleType.NVarChar , 50){ Value = pressure.ExamNo          },
                new OracleParameter(":CheckID"         , OracleType.NVarChar , 50){ Value = pressure.CheckID         },
                new OracleParameter(":Name"            , OracleType.NVarChar , 50){ Value = pressure.Name            },
                new OracleParameter(":SexId"           , OracleType.NVarChar , 50){ Value = pressure.Sex             },
                new OracleParameter(":Age"             , OracleType.Int32    , 4 ){ Value = pressure.Age             },
                new OracleParameter(":Doctor"          , OracleType.NVarChar , 50){ Value = pressure.Doctor          },
                new OracleParameter(":DeviceID"        , OracleType.NVarChar , 50){ Value = pressure.DeviceID        },
                new OracleParameter(":Version"         , OracleType.NVarChar , 50){ Value = pressure.Version         },
                new OracleParameter(":Reserve"         , OracleType.NVarChar , 50){ Value = pressure.Reserve         },
                new OracleParameter(":Check_flagId"    , OracleType.Int32    , 4 ){ Value = pressure.Check_flag      },
                new OracleParameter(":Hosname"         , OracleType.NVarChar , 50){ Value = pressure.Hosname         },
                new OracleParameter(":Auditdoctor"     , OracleType.NVarChar , 50){ Value = pressure.Auditdoctor     },
                new OracleParameter(":Auditdate"       , OracleType.DateTime , 8 ){ Value = pressure.Auditdate       },
                new OracleParameter(":StatusId"        , OracleType.Int32    , 4 ){ Value = pressure.Status          },
                new OracleParameter(":Str1"            , OracleType.NVarChar , 50){ Value = pressure.Str1            },
                new OracleParameter(":Str2"            , OracleType.NVarChar , 50){ Value = pressure.Str2            },
                new OracleParameter(":Str3"            , OracleType.NVarChar , 50){ Value = pressure.Str3            },
                new OracleParameter(":Str4"            , OracleType.NVarChar , 50){ Value = pressure.Str4            },
                new OracleParameter(":Str5"            , OracleType.NVarChar , 50){ Value = pressure.Str5            },
                new OracleParameter(":Str6"            , OracleType.NVarChar , 50){ Value = pressure.Str6            },
                new OracleParameter(":Str7"            , OracleType.NVarChar , 50){ Value = pressure.Str7            },
                new OracleParameter(":Str8"            , OracleType.NVarChar , 50){ Value = pressure.Str8            },
                new OracleParameter(":Str9"            , OracleType.NVarChar , 50){ Value = pressure.Str9            },
                new OracleParameter(":Str10"           , OracleType.NVarChar , 50){ Value = pressure.Str10           },
                new OracleParameter(":T3001002_ename"  , OracleType.NVarChar , 50){ Value = pressure.T3001002_ename  },
                new OracleParameter(":T3001002_cname"  , OracleType.NVarChar , 50){ Value = pressure.T3001002_cname  },
                new OracleParameter(":T3001002_unit"   , OracleType.NVarChar , 50){ Value = pressure.T3001002_unit   },
                new OracleParameter(":T3001002_srange" , OracleType.Int32    , 4 ){ Value = pressure.T3001002_srange },
                new OracleParameter(":T3001002_lrange" , OracleType.Int32    , 4 ){ Value = pressure.T3001002_lrange },
                new OracleParameter(":T3001002_value"  , OracleType.Int32    , 4 ){ Value = pressure.T3001002_value  },
                new OracleParameter(":T3001003_ename"  , OracleType.NVarChar , 50){ Value = pressure.T3001003_ename  },
                new OracleParameter(":T3001003_cname"  , OracleType.NVarChar , 50){ Value = pressure.T3001003_cname  },
                new OracleParameter(":T3001003_unit"   , OracleType.NVarChar , 50){ Value = pressure.T3001003_unit   },
                new OracleParameter(":T3001003_srange" , OracleType.Int32    , 4 ){ Value = pressure.T3001003_srange },
                new OracleParameter(":T3001003_lrange" , OracleType.Int32    , 4 ){ Value = pressure.T3001003_lrange },
                new OracleParameter(":T3001003_value"  , OracleType.Int32    , 4 ){ Value = pressure.T3001003_value  },
                new OracleParameter(":T3001004_ename"  , OracleType.NVarChar , 50){ Value = pressure.T3001004_ename  },
                new OracleParameter(":T3001004_cname"  , OracleType.NVarChar , 50){ Value = pressure.T3001004_cname  },
                new OracleParameter(":T3001004_unit"   , OracleType.NVarChar , 50){ Value = pressure.T3001004_unit   },
                new OracleParameter(":T3001004_srange" , OracleType.Int32    , 4 ){ Value = pressure.T3001004_srange },
                new OracleParameter(":T3001004_lrange" , OracleType.Int32    , 4 ){ Value = pressure.T3001004_lrange },
                new OracleParameter(":T3001004_value"  , OracleType.Int32    , 4 ){ Value = pressure.T3001004_value  },
                new OracleParameter(":T3001008_ename"  , OracleType.NVarChar , 50){ Value = pressure.T3001008_ename  },
                new OracleParameter(":T3001008_cname"  , OracleType.NVarChar , 50){ Value = pressure.T3001008_cname  },
                new OracleParameter(":T3001008_unit"   , OracleType.NVarChar , 50){ Value = pressure.T3001008_unit   },
                new OracleParameter(":T3001008_srange" , OracleType.Int32    , 4 ){ Value = pressure.T3001008_srange },
                new OracleParameter(":T3001008_lrange" , OracleType.Int32    , 4 ){ Value = pressure.T3001008_lrange },
                new OracleParameter(":T3001008_value"  , OracleType.Int32    , 4 ){ Value = pressure.T3001008_value  }
            };
            return SFL.OracleHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将血压检测类（Pressure）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pressure">血压检测类（Pressure）实例对象</param>
        public override int Update(Pressure pressure)
        {
            string sqlText = "UPDATE \"Pressure\" SET "
                           + "\"Checkdate\"=:Checkdate,\"ExamNo\"=:ExamNo,\"CheckID\"=:CheckID,\"Name\"=:Name,\"SexId\"=:SexId,\"Age\"=:Age,\"Doctor\"=:Doctor,"
                           + "\"DeviceID\"=:DeviceID,\"Version\"=:Version,\"Reserve\"=:Reserve,\"Check_flagId\"=:Check_flagId,\"Hosname\"=:Hosname,\"Auditdoctor\"=:Auditdoctor,"
                           + "\"Auditdate\"=:Auditdate,\"StatusId\"=:StatusId,\"Str1\"=:Str1,\"Str2\"=:Str2,\"Str3\"=:Str3,\"Str4\"=:Str4,\"Str5\"=:Str5,\"Str6\"=:Str6,\"Str7\"=:Str7,\"Str8\"=:Str8,\"Str9\"=:Str9,"
                           + "\"Str10\"=:Str10,\"T3001002_ename\"=:T3001002_ename,\"T3001002_cname\"=:T3001002_cname,\"T3001002_unit\"=:T3001002_unit,"
                           + "\"T3001002_srange\"=:T3001002_srange,\"T3001002_lrange\"=:T3001002_lrange,\"T3001002_value\"=:T3001002_value,\"T3001003_ename\"=:T3001003_ename,"
                           + "\"T3001003_cname\"=:T3001003_cname,\"T3001003_unit\"=:T3001003_unit,\"T3001003_srange\"=:T3001003_srange,\"T3001003_lrange\"=:T3001003_lrange,"
                           + "\"T3001003_value\"=:T3001003_value,\"T3001004_ename\"=:T3001004_ename,\"T3001004_cname\"=:T3001004_cname,\"T3001004_unit\"=:T3001004_unit,"
                           + "\"T3001004_srange\"=:T3001004_srange,\"T3001004_lrange\"=:T3001004_lrange,\"T3001004_value\"=:T3001004_value,\"T3001008_ename\"=:T3001008_ename,"
                           + "\"T3001008_cname\"=:T3001008_cname,\"T3001008_unit\"=:T3001008_unit,\"T3001008_srange\"=:T3001008_srange,\"T3001008_lrange\"=:T3001008_lrange,"
                           + "\"T3001008_value\"=:T3001008_value "
                           + "WHERE \"Id\"=:Id";
            OracleParameter[] parameters = 
            {
                new OracleParameter(":Checkdate"       , OracleType.DateTime , 8 ){ Value = pressure.Checkdate       },
                new OracleParameter(":ExamNo"          , OracleType.NVarChar , 50){ Value = pressure.ExamNo          },
                new OracleParameter(":CheckID"         , OracleType.NVarChar , 50){ Value = pressure.CheckID         },
                new OracleParameter(":Name"            , OracleType.NVarChar , 50){ Value = pressure.Name            },
                new OracleParameter(":SexId"           , OracleType.NVarChar , 50){ Value = pressure.Sex             },
                new OracleParameter(":Age"             , OracleType.Int32    , 4 ){ Value = pressure.Age             },
                new OracleParameter(":Doctor"          , OracleType.NVarChar , 50){ Value = pressure.Doctor          },
                new OracleParameter(":DeviceID"        , OracleType.NVarChar , 50){ Value = pressure.DeviceID        },
                new OracleParameter(":Version"         , OracleType.NVarChar , 50){ Value = pressure.Version         },
                new OracleParameter(":Reserve"         , OracleType.NVarChar , 50){ Value = pressure.Reserve         },
                new OracleParameter(":Check_flagId"    , OracleType.Int32    , 4 ){ Value = pressure.Check_flag      },
                new OracleParameter(":Hosname"         , OracleType.NVarChar , 50){ Value = pressure.Hosname         },
                new OracleParameter(":Auditdoctor"     , OracleType.NVarChar , 50){ Value = pressure.Auditdoctor     },
                new OracleParameter(":Auditdate"       , OracleType.DateTime , 8 ){ Value = pressure.Auditdate       },
                new OracleParameter(":StatusId"        , OracleType.Int32    , 4 ){ Value = pressure.Status          },
                new OracleParameter(":Str1"            , OracleType.NVarChar , 50){ Value = pressure.Str1            },
                new OracleParameter(":Str2"            , OracleType.NVarChar , 50){ Value = pressure.Str2            },
                new OracleParameter(":Str3"            , OracleType.NVarChar , 50){ Value = pressure.Str3            },
                new OracleParameter(":Str4"            , OracleType.NVarChar , 50){ Value = pressure.Str4            },
                new OracleParameter(":Str5"            , OracleType.NVarChar , 50){ Value = pressure.Str5            },
                new OracleParameter(":Str6"            , OracleType.NVarChar , 50){ Value = pressure.Str6            },
                new OracleParameter(":Str7"            , OracleType.NVarChar , 50){ Value = pressure.Str7            },
                new OracleParameter(":Str8"            , OracleType.NVarChar , 50){ Value = pressure.Str8            },
                new OracleParameter(":Str9"            , OracleType.NVarChar , 50){ Value = pressure.Str9            },
                new OracleParameter(":Str10"           , OracleType.NVarChar , 50){ Value = pressure.Str10           },
                new OracleParameter(":T3001002_ename"  , OracleType.NVarChar , 50){ Value = pressure.T3001002_ename  },
                new OracleParameter(":T3001002_cname"  , OracleType.NVarChar , 50){ Value = pressure.T3001002_cname  },
                new OracleParameter(":T3001002_unit"   , OracleType.NVarChar , 50){ Value = pressure.T3001002_unit   },
                new OracleParameter(":T3001002_srange" , OracleType.Int32    , 4 ){ Value = pressure.T3001002_srange },
                new OracleParameter(":T3001002_lrange" , OracleType.Int32    , 4 ){ Value = pressure.T3001002_lrange },
                new OracleParameter(":T3001002_value"  , OracleType.Int32    , 4 ){ Value = pressure.T3001002_value  },
                new OracleParameter(":T3001003_ename"  , OracleType.NVarChar , 50){ Value = pressure.T3001003_ename  },
                new OracleParameter(":T3001003_cname"  , OracleType.NVarChar , 50){ Value = pressure.T3001003_cname  },
                new OracleParameter(":T3001003_unit"   , OracleType.NVarChar , 50){ Value = pressure.T3001003_unit   },
                new OracleParameter(":T3001003_srange" , OracleType.Int32    , 4 ){ Value = pressure.T3001003_srange },
                new OracleParameter(":T3001003_lrange" , OracleType.Int32    , 4 ){ Value = pressure.T3001003_lrange },
                new OracleParameter(":T3001003_value"  , OracleType.Int32    , 4 ){ Value = pressure.T3001003_value  },
                new OracleParameter(":T3001004_ename"  , OracleType.NVarChar , 50){ Value = pressure.T3001004_ename  },
                new OracleParameter(":T3001004_cname"  , OracleType.NVarChar , 50){ Value = pressure.T3001004_cname  },
                new OracleParameter(":T3001004_unit"   , OracleType.NVarChar , 50){ Value = pressure.T3001004_unit   },
                new OracleParameter(":T3001004_srange" , OracleType.Int32    , 4 ){ Value = pressure.T3001004_srange },
                new OracleParameter(":T3001004_lrange" , OracleType.Int32    , 4 ){ Value = pressure.T3001004_lrange },
                new OracleParameter(":T3001004_value"  , OracleType.Int32    , 4 ){ Value = pressure.T3001004_value  },
                new OracleParameter(":T3001008_ename"  , OracleType.NVarChar , 50){ Value = pressure.T3001008_ename  },
                new OracleParameter(":T3001008_cname"  , OracleType.NVarChar , 50){ Value = pressure.T3001008_cname  },
                new OracleParameter(":T3001008_unit"   , OracleType.NVarChar , 50){ Value = pressure.T3001008_unit   },
                new OracleParameter(":T3001008_srange" , OracleType.Int32    , 4 ){ Value = pressure.T3001008_srange },
                new OracleParameter(":T3001008_lrange" , OracleType.Int32    , 4 ){ Value = pressure.T3001008_lrange },
                new OracleParameter(":T3001008_value"  , OracleType.Int32    , 4 ){ Value = pressure.T3001008_value  },
                new OracleParameter(":Id"              , OracleType.Int32    , 4 ){ Value = pressure.Id              }
            };
            return SFL.OracleHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据血压检测类（Pressure）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">血压检测类（Pressure）的主键“编号（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM \"Pressure\"" 
                           + "WHERE \"Id\"=:Id";
            OracleParameter[] parameters = 
            {
                new OracleParameter(":Id" , OracleType.Int32 , 4){ Value = id }
            };
            return SFL.OracleHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据血压检测类（Pressure）的主键“编号（Id）”从数据库中获取血压检测类（Pressure）的实例。
        /// 成功从数据库中取得记录返回新血压检测类（Pressure）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">血压检测类（Pressure）的主键“编号（Id）”</param>
        public override Pressure GetDataById(int id)
        {
            Pressure pressure = null;
            string sqlText = "SELECT \"Id\",\"Checkdate\",\"ExamNo\",\"CheckID\",\"Name\",\"SexId\",\"Age\",\"Doctor\",\"DeviceID\",\"Version\",\"Reserve\",\"Check_flagId\",\"Hosname\",\"Auditdoctor\",\"Auditdate\","
                           + "\"StatusId\",\"Str1\",\"Str2\",\"Str3\",\"Str4\",\"Str5\",\"Str6\",\"Str7\",\"Str8\",\"Str9\",\"Str10\",\"T3001002_ename\",\"T3001002_cname\",\"T3001002_unit\",\"T3001002_srange\","
                           + "\"T3001002_lrange\",\"T3001002_value\",\"T3001003_ename\",\"T3001003_cname\",\"T3001003_unit\",\"T3001003_srange\",\"T3001003_lrange\",\"T3001003_value\","
                           + "\"T3001004_ename\",\"T3001004_cname\",\"T3001004_unit\",\"T3001004_srange\",\"T3001004_lrange\",\"T3001004_value\",\"T3001008_ename\",\"T3001008_cname\","
                           + "\"T3001008_unit\",\"T3001008_srange\",\"T3001008_lrange\",\"T3001008_value\" "
                           + "FROM \"Pressure\" "
                           + "WHERE \"Id\"=:Id";
            OracleParameter[] parameters = 
            {
                new OracleParameter(":Id" , OracleType.Int32 , 4){ Value = id }
            };

            OracleDataReader oracleDataReader = SFL.OracleHelper.ExecuteReader(sqlText, parameters);
            if (oracleDataReader.Read())
            {
                pressure = new Pressure();
                ReadPressureAllData(oracleDataReader,pressure);
            }
            oracleDataReader.Close();
            return pressure;
        }


        /// <summary>
        /// 从数据库中读取并返回所有血压检测类（Pressure）List列表。
        /// </summary>
        public override List<Pressure> GetAllList()
        {
            string sqlText = "SELECT \"Id\",\"Checkdate\",\"ExamNo\",\"CheckID\",\"Name\",\"SexId\",\"Age\",\"Doctor\",\"DeviceID\",\"Version\",\"Reserve\",\"Check_flagId\",\"Hosname\",\"Auditdoctor\",\"Auditdate\","
                           + "\"StatusId\",\"Str1\",\"Str2\",\"Str3\",\"Str4\",\"Str5\",\"Str6\",\"Str7\",\"Str8\",\"Str9\",\"Str10\",\"T3001002_ename\",\"T3001002_cname\",\"T3001002_unit\",\"T3001002_srange\","
                           + "\"T3001002_lrange\",\"T3001002_value\",\"T3001003_ename\",\"T3001003_cname\",\"T3001003_unit\",\"T3001003_srange\",\"T3001003_lrange\",\"T3001003_value\","
                           + "\"T3001004_ename\",\"T3001004_cname\",\"T3001004_unit\",\"T3001004_srange\",\"T3001004_lrange\",\"T3001004_value\",\"T3001008_ename\",\"T3001008_cname\","
                           + "\"T3001008_unit\",\"T3001008_srange\",\"T3001008_lrange\",\"T3001008_value\" "
                           + "FROM \"Pressure\"";
            List<Pressure> list = new List<Pressure>();
            OracleDataReader oracleDataReader = SFL.OracleHelper.ExecuteReader(sqlText, null);
            while (oracleDataReader.Read())
            {
                Pressure pressure = new Pressure();
                ReadPressureAllData(oracleDataReader, pressure);
                list.Add(pressure);
            }
            oracleDataReader.Close();
            return list;
        }


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的血压检测类（Pressure）的列表及分页信息。
        /// 该方法所获取的血压检测类（Pressure）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public override PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "SELECT \"Id\",\"Checkdate\",\"ExamNo\",\"CheckID\",\"Name\",\"SexId\",\"Doctor\",\"Check_flagId\",\"Hosname\",\"StatusId\" "
                           + "FROM \"Pressure\"";
            List<Pressure> list = new List<Pressure>();
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
                    Pressure pressure = new Pressure();
                    ReadPressurePageData(oracleDataReader, pressure);
                    list.Add(pressure);
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
