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
    /// �������ƣ����¼����SQL Server���ݷ������ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ�����¼�����ࣨҵ���߼��㣩�����SQL Server�ġ���ɾ�Ĳ顱�ȸ������ݷ��ʷ������̳�ͨ�����ݷ��ʸ��ࡣ
    /// ����˵����ͨ������Ҫֱ��ʵ�������࣬��ʹ�á����¼�����ࣨҵ���߼��㣩���е�DataAccess���������ñ�����ʵ�ֵķ�����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 16:57:39
    /// </summary>
    public class TemperatureDAL:DAL.Common.TemperatureDAL
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬ʵ���˸����ж���ĳ��󷽷����벻Ҫֱ���޸ĸ������е��κδ��룬   
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>
        /// �����¼���ࣨTemperature�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="temperature">���¼���ࣨTemperature��ʵ������</param>
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
        /// �����¼���ࣨTemperature�����ݣ�������������ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="temperature">���¼���ࣨTemperature��ʵ������</param>
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
        /// �������¼���ࣨTemperature������������ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">���¼���ࣨTemperature������������ţ�Id����</param>
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
        /// �������¼���ࣨTemperature������������ţ�Id���������ݿ��л�ȡ���¼���ࣨTemperature����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼���������¼���ࣨTemperature����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">���¼���ࣨTemperature������������ţ�Id����</param>
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
        /// �����ݿ��ж�ȡ�������������¼���ࣨTemperature��List�б�
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
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ������¼���ࣨTemperature�����б���ҳ��Ϣ��
        /// �÷�������ȡ�����¼���ࣨTemperature���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
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

        #endregion �����ʽ�µ�Ĭ�ϴ���

        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ˵������������Ĵ���Ϊ��ƿ�����Ա����д����ҪΪ��չ�����ݷ�����Ĺ��ܣ�������ı��������Լ�������ݷ��ʷ�����  
        //  ע�⣺Ϊ�˱�֤����Ŀ�Ķ����ݿ�֧������չ�ԣ������ڱ���ĸ����ж���س��󷽷����ж��壬���ڱ����н��о���ʵ�֡�
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l










    }
}
