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
    /// �������ƣ�Ѫѹ�����OleDb���ݷ������ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ��Ѫѹ������ࣨҵ���߼��㣩�����OleDb�ġ���ɾ�Ĳ顱�ȸ������ݷ��ʷ������̳�ͨ�����ݷ��ʸ��ࡣ
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
            string sqlText = "INSERT INTO [Pressure]"
                           + "([Checkdate],[ExamNo],[CheckID],[Name],[SexId],[Age],[Doctor],[DeviceID],[Version],[Reserve],[Check_flagId],[Hosname],[Auditdoctor],[Auditdate],"
                           + "[StatusId],[Str1],[Str2],[Str3],[Str4],[Str5],[Str6],[Str7],[Str8],[Str9],[Str10],[T3001002_ename],[T3001002_cname],[T3001002_unit],[T3001002_srange],"
                           + "[T3001002_lrange],[T3001002_value],[T3001003_ename],[T3001003_cname],[T3001003_unit],[T3001003_srange],[T3001003_lrange],[T3001003_value],"
                           + "[T3001004_ename],[T3001004_cname],[T3001004_unit],[T3001004_srange],[T3001004_lrange],[T3001004_value],[T3001008_ename],[T3001008_cname],"
                           + "[T3001008_unit],[T3001008_srange],[T3001008_lrange],[T3001008_value])"
                           + "VALUES"
                           + "(@Checkdate,@ExamNo,@CheckID,@Name,@SexId,@Age,@Doctor,@DeviceID,@Version,@Reserve,@Check_flagId,@Hosname,@Auditdoctor,@Auditdate,"
                           + "@StatusId,@Str1,@Str2,@Str3,@Str4,@Str5,@Str6,@Str7,@Str8,@Str9,@Str10,@T3001002_ename,@T3001002_cname,@T3001002_unit,@T3001002_srange,"
                           + "@T3001002_lrange,@T3001002_value,@T3001003_ename,@T3001003_cname,@T3001003_unit,@T3001003_srange,@T3001003_lrange,@T3001003_value,"
                           + "@T3001004_ename,@T3001004_cname,@T3001004_unit,@T3001004_srange,@T3001004_lrange,@T3001004_value,@T3001008_ename,@T3001008_cname,"
                           + "@T3001008_unit,@T3001008_srange,@T3001008_lrange,@T3001008_value)";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Checkdate"       , OleDbType.Date     , 8 ){ Value = pressure.Checkdate       },
                new OleDbParameter("@ExamNo"          , OleDbType.VarWChar , 50){ Value = pressure.ExamNo          },
                new OleDbParameter("@CheckID"         , OleDbType.VarWChar , 50){ Value = pressure.CheckID         },
                new OleDbParameter("@Name"            , OleDbType.VarWChar , 50){ Value = pressure.Name            },
                new OleDbParameter("@SexId"           , OleDbType.VarWChar , 50){ Value = pressure.Sex             },
                new OleDbParameter("@Age"             , OleDbType.Integer  , 4 ){ Value = pressure.Age             },
                new OleDbParameter("@Doctor"          , OleDbType.VarWChar , 50){ Value = pressure.Doctor          },
                new OleDbParameter("@DeviceID"        , OleDbType.VarWChar , 50){ Value = pressure.DeviceID        },
                new OleDbParameter("@Version"         , OleDbType.VarWChar , 50){ Value = pressure.Version         },
                new OleDbParameter("@Reserve"         , OleDbType.VarWChar , 50){ Value = pressure.Reserve         },
                new OleDbParameter("@Check_flagId"    , OleDbType.Integer  , 4 ){ Value = pressure.Check_flag      },
                new OleDbParameter("@Hosname"         , OleDbType.VarWChar , 50){ Value = pressure.Hosname         },
                new OleDbParameter("@Auditdoctor"     , OleDbType.VarWChar , 50){ Value = pressure.Auditdoctor     },
                new OleDbParameter("@Auditdate"       , OleDbType.Date     , 8 ){ Value = pressure.Auditdate       },
                new OleDbParameter("@StatusId"        , OleDbType.Integer  , 4 ){ Value = pressure.Status          },
                new OleDbParameter("@Str1"            , OleDbType.VarWChar , 50){ Value = pressure.Str1            },
                new OleDbParameter("@Str2"            , OleDbType.VarWChar , 50){ Value = pressure.Str2            },
                new OleDbParameter("@Str3"            , OleDbType.VarWChar , 50){ Value = pressure.Str3            },
                new OleDbParameter("@Str4"            , OleDbType.VarWChar , 50){ Value = pressure.Str4            },
                new OleDbParameter("@Str5"            , OleDbType.VarWChar , 50){ Value = pressure.Str5            },
                new OleDbParameter("@Str6"            , OleDbType.VarWChar , 50){ Value = pressure.Str6            },
                new OleDbParameter("@Str7"            , OleDbType.VarWChar , 50){ Value = pressure.Str7            },
                new OleDbParameter("@Str8"            , OleDbType.VarWChar , 50){ Value = pressure.Str8            },
                new OleDbParameter("@Str9"            , OleDbType.VarWChar , 50){ Value = pressure.Str9            },
                new OleDbParameter("@Str10"           , OleDbType.VarWChar , 50){ Value = pressure.Str10           },
                new OleDbParameter("@T3001002_ename"  , OleDbType.VarWChar , 50){ Value = pressure.T3001002_ename  },
                new OleDbParameter("@T3001002_cname"  , OleDbType.VarWChar , 50){ Value = pressure.T3001002_cname  },
                new OleDbParameter("@T3001002_unit"   , OleDbType.VarWChar , 50){ Value = pressure.T3001002_unit   },
                new OleDbParameter("@T3001002_srange" , OleDbType.Integer  , 4 ){ Value = pressure.T3001002_srange },
                new OleDbParameter("@T3001002_lrange" , OleDbType.Integer  , 4 ){ Value = pressure.T3001002_lrange },
                new OleDbParameter("@T3001002_value"  , OleDbType.Integer  , 4 ){ Value = pressure.T3001002_value  },
                new OleDbParameter("@T3001003_ename"  , OleDbType.VarWChar , 50){ Value = pressure.T3001003_ename  },
                new OleDbParameter("@T3001003_cname"  , OleDbType.VarWChar , 50){ Value = pressure.T3001003_cname  },
                new OleDbParameter("@T3001003_unit"   , OleDbType.VarWChar , 50){ Value = pressure.T3001003_unit   },
                new OleDbParameter("@T3001003_srange" , OleDbType.Integer  , 4 ){ Value = pressure.T3001003_srange },
                new OleDbParameter("@T3001003_lrange" , OleDbType.Integer  , 4 ){ Value = pressure.T3001003_lrange },
                new OleDbParameter("@T3001003_value"  , OleDbType.Integer  , 4 ){ Value = pressure.T3001003_value  },
                new OleDbParameter("@T3001004_ename"  , OleDbType.VarWChar , 50){ Value = pressure.T3001004_ename  },
                new OleDbParameter("@T3001004_cname"  , OleDbType.VarWChar , 50){ Value = pressure.T3001004_cname  },
                new OleDbParameter("@T3001004_unit"   , OleDbType.VarWChar , 50){ Value = pressure.T3001004_unit   },
                new OleDbParameter("@T3001004_srange" , OleDbType.Integer  , 4 ){ Value = pressure.T3001004_srange },
                new OleDbParameter("@T3001004_lrange" , OleDbType.Integer  , 4 ){ Value = pressure.T3001004_lrange },
                new OleDbParameter("@T3001004_value"  , OleDbType.Integer  , 4 ){ Value = pressure.T3001004_value  },
                new OleDbParameter("@T3001008_ename"  , OleDbType.VarWChar , 50){ Value = pressure.T3001008_ename  },
                new OleDbParameter("@T3001008_cname"  , OleDbType.VarWChar , 50){ Value = pressure.T3001008_cname  },
                new OleDbParameter("@T3001008_unit"   , OleDbType.VarWChar , 50){ Value = pressure.T3001008_unit   },
                new OleDbParameter("@T3001008_srange" , OleDbType.Integer  , 4 ){ Value = pressure.T3001008_srange },
                new OleDbParameter("@T3001008_lrange" , OleDbType.Integer  , 4 ){ Value = pressure.T3001008_lrange },
                new OleDbParameter("@T3001008_value"  , OleDbType.Integer  , 4 ){ Value = pressure.T3001008_value  }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ��Ѫѹ����ࣨPressure�����ݣ�������������ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="pressure">Ѫѹ����ࣨPressure��ʵ������</param>
        public override int Update(Pressure pressure)
        {
            string sqlText = "UPDATE [Pressure] SET "
                           + "[Checkdate]=@Checkdate,[ExamNo]=@ExamNo,[CheckID]=@CheckID,[Name]=@Name,[SexId]=@SexId,[Age]=@Age,[Doctor]=@Doctor,"
                           + "[DeviceID]=@DeviceID,[Version]=@Version,[Reserve]=@Reserve,[Check_flagId]=@Check_flagId,[Hosname]=@Hosname,[Auditdoctor]=@Auditdoctor,"
                           + "[Auditdate]=@Auditdate,[StatusId]=@StatusId,[Str1]=@Str1,[Str2]=@Str2,[Str3]=@Str3,[Str4]=@Str4,[Str5]=@Str5,[Str6]=@Str6,[Str7]=@Str7,[Str8]=@Str8,[Str9]=@Str9,"
                           + "[Str10]=@Str10,[T3001002_ename]=@T3001002_ename,[T3001002_cname]=@T3001002_cname,[T3001002_unit]=@T3001002_unit,"
                           + "[T3001002_srange]=@T3001002_srange,[T3001002_lrange]=@T3001002_lrange,[T3001002_value]=@T3001002_value,[T3001003_ename]=@T3001003_ename,"
                           + "[T3001003_cname]=@T3001003_cname,[T3001003_unit]=@T3001003_unit,[T3001003_srange]=@T3001003_srange,[T3001003_lrange]=@T3001003_lrange,"
                           + "[T3001003_value]=@T3001003_value,[T3001004_ename]=@T3001004_ename,[T3001004_cname]=@T3001004_cname,[T3001004_unit]=@T3001004_unit,"
                           + "[T3001004_srange]=@T3001004_srange,[T3001004_lrange]=@T3001004_lrange,[T3001004_value]=@T3001004_value,[T3001008_ename]=@T3001008_ename,"
                           + "[T3001008_cname]=@T3001008_cname,[T3001008_unit]=@T3001008_unit,[T3001008_srange]=@T3001008_srange,[T3001008_lrange]=@T3001008_lrange,"
                           + "[T3001008_value]=@T3001008_value "
                           + "WHERE [Id]=@Id";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Checkdate"       , OleDbType.Date     , 8 ){ Value = pressure.Checkdate       },
                new OleDbParameter("@ExamNo"          , OleDbType.VarWChar , 50){ Value = pressure.ExamNo          },
                new OleDbParameter("@CheckID"         , OleDbType.VarWChar , 50){ Value = pressure.CheckID         },
                new OleDbParameter("@Name"            , OleDbType.VarWChar , 50){ Value = pressure.Name            },
                new OleDbParameter("@SexId"           , OleDbType.VarWChar , 50){ Value = pressure.Sex             },
                new OleDbParameter("@Age"             , OleDbType.Integer  , 4 ){ Value = pressure.Age             },
                new OleDbParameter("@Doctor"          , OleDbType.VarWChar , 50){ Value = pressure.Doctor          },
                new OleDbParameter("@DeviceID"        , OleDbType.VarWChar , 50){ Value = pressure.DeviceID        },
                new OleDbParameter("@Version"         , OleDbType.VarWChar , 50){ Value = pressure.Version         },
                new OleDbParameter("@Reserve"         , OleDbType.VarWChar , 50){ Value = pressure.Reserve         },
                new OleDbParameter("@Check_flagId"    , OleDbType.Integer  , 4 ){ Value = pressure.Check_flag      },
                new OleDbParameter("@Hosname"         , OleDbType.VarWChar , 50){ Value = pressure.Hosname         },
                new OleDbParameter("@Auditdoctor"     , OleDbType.VarWChar , 50){ Value = pressure.Auditdoctor     },
                new OleDbParameter("@Auditdate"       , OleDbType.Date     , 8 ){ Value = pressure.Auditdate       },
                new OleDbParameter("@StatusId"        , OleDbType.Integer  , 4 ){ Value = pressure.Status          },
                new OleDbParameter("@Str1"            , OleDbType.VarWChar , 50){ Value = pressure.Str1            },
                new OleDbParameter("@Str2"            , OleDbType.VarWChar , 50){ Value = pressure.Str2            },
                new OleDbParameter("@Str3"            , OleDbType.VarWChar , 50){ Value = pressure.Str3            },
                new OleDbParameter("@Str4"            , OleDbType.VarWChar , 50){ Value = pressure.Str4            },
                new OleDbParameter("@Str5"            , OleDbType.VarWChar , 50){ Value = pressure.Str5            },
                new OleDbParameter("@Str6"            , OleDbType.VarWChar , 50){ Value = pressure.Str6            },
                new OleDbParameter("@Str7"            , OleDbType.VarWChar , 50){ Value = pressure.Str7            },
                new OleDbParameter("@Str8"            , OleDbType.VarWChar , 50){ Value = pressure.Str8            },
                new OleDbParameter("@Str9"            , OleDbType.VarWChar , 50){ Value = pressure.Str9            },
                new OleDbParameter("@Str10"           , OleDbType.VarWChar , 50){ Value = pressure.Str10           },
                new OleDbParameter("@T3001002_ename"  , OleDbType.VarWChar , 50){ Value = pressure.T3001002_ename  },
                new OleDbParameter("@T3001002_cname"  , OleDbType.VarWChar , 50){ Value = pressure.T3001002_cname  },
                new OleDbParameter("@T3001002_unit"   , OleDbType.VarWChar , 50){ Value = pressure.T3001002_unit   },
                new OleDbParameter("@T3001002_srange" , OleDbType.Integer  , 4 ){ Value = pressure.T3001002_srange },
                new OleDbParameter("@T3001002_lrange" , OleDbType.Integer  , 4 ){ Value = pressure.T3001002_lrange },
                new OleDbParameter("@T3001002_value"  , OleDbType.Integer  , 4 ){ Value = pressure.T3001002_value  },
                new OleDbParameter("@T3001003_ename"  , OleDbType.VarWChar , 50){ Value = pressure.T3001003_ename  },
                new OleDbParameter("@T3001003_cname"  , OleDbType.VarWChar , 50){ Value = pressure.T3001003_cname  },
                new OleDbParameter("@T3001003_unit"   , OleDbType.VarWChar , 50){ Value = pressure.T3001003_unit   },
                new OleDbParameter("@T3001003_srange" , OleDbType.Integer  , 4 ){ Value = pressure.T3001003_srange },
                new OleDbParameter("@T3001003_lrange" , OleDbType.Integer  , 4 ){ Value = pressure.T3001003_lrange },
                new OleDbParameter("@T3001003_value"  , OleDbType.Integer  , 4 ){ Value = pressure.T3001003_value  },
                new OleDbParameter("@T3001004_ename"  , OleDbType.VarWChar , 50){ Value = pressure.T3001004_ename  },
                new OleDbParameter("@T3001004_cname"  , OleDbType.VarWChar , 50){ Value = pressure.T3001004_cname  },
                new OleDbParameter("@T3001004_unit"   , OleDbType.VarWChar , 50){ Value = pressure.T3001004_unit   },
                new OleDbParameter("@T3001004_srange" , OleDbType.Integer  , 4 ){ Value = pressure.T3001004_srange },
                new OleDbParameter("@T3001004_lrange" , OleDbType.Integer  , 4 ){ Value = pressure.T3001004_lrange },
                new OleDbParameter("@T3001004_value"  , OleDbType.Integer  , 4 ){ Value = pressure.T3001004_value  },
                new OleDbParameter("@T3001008_ename"  , OleDbType.VarWChar , 50){ Value = pressure.T3001008_ename  },
                new OleDbParameter("@T3001008_cname"  , OleDbType.VarWChar , 50){ Value = pressure.T3001008_cname  },
                new OleDbParameter("@T3001008_unit"   , OleDbType.VarWChar , 50){ Value = pressure.T3001008_unit   },
                new OleDbParameter("@T3001008_srange" , OleDbType.Integer  , 4 ){ Value = pressure.T3001008_srange },
                new OleDbParameter("@T3001008_lrange" , OleDbType.Integer  , 4 ){ Value = pressure.T3001008_lrange },
                new OleDbParameter("@T3001008_value"  , OleDbType.Integer  , 4 ){ Value = pressure.T3001008_value  },
                new OleDbParameter("@Id"              , OleDbType.Integer  , 4 ){ Value = pressure.Id              }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ����Ѫѹ����ࣨPressure������������ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">Ѫѹ����ࣨPressure������������ţ�Id����</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [Pressure] "
                           + "WHERE [Id]=@Id";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id" , OleDbType.Integer , 4){ Value = id }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ����Ѫѹ����ࣨPressure������������ţ�Id���������ݿ��л�ȡѪѹ����ࣨPressure����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼������Ѫѹ����ࣨPressure����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">Ѫѹ����ࣨPressure������������ţ�Id����</param>
        public override Pressure GetDataById(int id)
        {
            Pressure pressure = null;
            string sqlText = "SELECT [Id],[Checkdate],[ExamNo],[CheckID],[Name],[SexId],[Age],[Doctor],[DeviceID],[Version],[Reserve],[Check_flagId],[Hosname],[Auditdoctor],[Auditdate],"
                           + "[StatusId],[Str1],[Str2],[Str3],[Str4],[Str5],[Str6],[Str7],[Str8],[Str9],[Str10],[T3001002_ename],[T3001002_cname],[T3001002_unit],[T3001002_srange],"
                           + "[T3001002_lrange],[T3001002_value],[T3001003_ename],[T3001003_cname],[T3001003_unit],[T3001003_srange],[T3001003_lrange],[T3001003_value],"
                           + "[T3001004_ename],[T3001004_cname],[T3001004_unit],[T3001004_srange],[T3001004_lrange],[T3001004_value],[T3001008_ename],[T3001008_cname],"
                           + "[T3001008_unit],[T3001008_srange],[T3001008_lrange],[T3001008_value] "
                           + "FROM [Pressure] "
                           + "WHERE [Id]=@Id";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id" , OleDbType.Integer , 4){ Value = id }
            };

            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, parameters);
            if (oleDbDataReader.Read())
            {
                pressure = new Pressure();
                ReadPressureAllData(oleDbDataReader,pressure);
            }
            oleDbDataReader.Close();
            return pressure;
        }


        /// <summary>
        /// �����ݿ��ж�ȡ����������Ѫѹ����ࣨPressure��List�б�
        /// </summary>
        public override List<Pressure> GetAllList()
        {
            string sqlText = "SELECT [Id],[Checkdate],[ExamNo],[CheckID],[Name],[SexId],[Age],[Doctor],[DeviceID],[Version],[Reserve],[Check_flagId],[Hosname],[Auditdoctor],[Auditdate],"
                           + "[StatusId],[Str1],[Str2],[Str3],[Str4],[Str5],[Str6],[Str7],[Str8],[Str9],[Str10],[T3001002_ename],[T3001002_cname],[T3001002_unit],[T3001002_srange],"
                           + "[T3001002_lrange],[T3001002_value],[T3001003_ename],[T3001003_cname],[T3001003_unit],[T3001003_srange],[T3001003_lrange],[T3001003_value],"
                           + "[T3001004_ename],[T3001004_cname],[T3001004_unit],[T3001004_srange],[T3001004_lrange],[T3001004_value],[T3001008_ename],[T3001008_cname],"
                           + "[T3001008_unit],[T3001008_srange],[T3001008_lrange],[T3001008_value] "
                           + "FROM [Pressure]";
            List<Pressure> list = new List<Pressure>();
            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, null);
            while (oleDbDataReader.Read())
            {
                Pressure pressure = new Pressure();
                ReadPressureAllData(oleDbDataReader, pressure);
                list.Add(pressure);
            }
            oleDbDataReader.Close();
            return list;
        }


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ���Ѫѹ����ࣨPressure�����б���ҳ��Ϣ��
        /// �÷�������ȡ��Ѫѹ����ࣨPressure���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
        /// </summary>
        public override PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "SELECT [Id],[Checkdate],[ExamNo],[CheckID],[Name],[SexId],[Doctor],[Check_flagId],[Hosname],[StatusId] "
                           + "FROM [Pressure]";
            List<Pressure> list = new List<Pressure>();
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
                    Pressure pressure = new Pressure();
                    ReadPressurePageData(oleDbDataReader, pressure);
                    list.Add(pressure);
                }
            }
            oleDbDataReader.Close();

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
