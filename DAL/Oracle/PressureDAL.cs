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
    /// �������ƣ�Ѫѹ�����Oracle���ݷ������ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ��Ѫѹ������ࣨҵ���߼��㣩�����Oracle�ġ���ɾ�Ĳ顱�ȸ������ݷ��ʷ������̳�ͨ�����ݷ��ʸ��ࡣ
    /// ����˵����ͨ������Ҫֱ��ʵ�������࣬��ʹ�á�Ѫѹ������ࣨҵ���߼��㣩���е�DataAccess���������ñ�����ʵ�ֵķ�����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 16:56:45
    /// </summary>
    public class PressureDAL:DAL.Common.PressureDAL
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬ʵ���˸����ж���ĳ��󷽷����벻Ҫֱ���޸ĸ������е��κδ��룬   
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>
        /// ��Ѫѹ����ࣨPressure�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="pressure">Ѫѹ����ࣨPressure��ʵ������</param>
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
        /// ��Ѫѹ����ࣨPressure�����ݣ�������������ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="pressure">Ѫѹ����ࣨPressure��ʵ������</param>
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
        /// ����Ѫѹ����ࣨPressure������������ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">Ѫѹ����ࣨPressure������������ţ�Id����</param>
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
        /// ����Ѫѹ����ࣨPressure������������ţ�Id���������ݿ��л�ȡѪѹ����ࣨPressure����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼������Ѫѹ����ࣨPressure����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">Ѫѹ����ࣨPressure������������ţ�Id����</param>
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
        /// �����ݿ��ж�ȡ����������Ѫѹ����ࣨPressure��List�б�
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
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ���Ѫѹ����ࣨPressure�����б���ҳ��Ϣ��
        /// �÷�������ȡ��Ѫѹ����ࣨPressure���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
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

        #endregion �����ʽ�µ�Ĭ�ϴ���

        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ˵������������Ĵ���Ϊ��ƿ�����Ա����д����ҪΪ��չ�����ݷ�����Ĺ��ܣ�������ı��������Լ�������ݷ��ʷ�����  
        //  ע�⣺Ϊ�˱�֤����Ŀ�Ķ����ݿ�֧������չ�ԣ������ڱ���ĸ����ж���س��󷽷����ж��壬���ڱ����н��о���ʵ�֡�
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l










    }
}
