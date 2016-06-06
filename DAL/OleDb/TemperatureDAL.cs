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
    /// �������ƣ����¼����OleDb���ݷ������ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ�����¼�����ࣨҵ���߼��㣩�����OleDb�ġ���ɾ�Ĳ顱�ȸ������ݷ��ʷ������̳�ͨ�����ݷ��ʸ��ࡣ
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
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Checkdate"       , OleDbType.Date     , 8 ){ Value = temperature.Checkdate       },
                new OleDbParameter("@ExamNo"          , OleDbType.VarWChar , 50){ Value = temperature.ExamNo          },
                new OleDbParameter("@CheckID"         , OleDbType.VarWChar , 50){ Value = temperature.CheckID         },
                new OleDbParameter("@Name"            , OleDbType.VarWChar , 50){ Value = temperature.Name            },
                new OleDbParameter("@SexId"           , OleDbType.VarWChar , 50){ Value = temperature.Sex             },
                new OleDbParameter("@Age"             , OleDbType.Integer  , 4 ){ Value = temperature.Age             },
                new OleDbParameter("@Doctor"          , OleDbType.VarWChar , 50){ Value = temperature.Doctor          },
                new OleDbParameter("@DeviceID"        , OleDbType.VarWChar , 50){ Value = temperature.DeviceID        },
                new OleDbParameter("@Version"         , OleDbType.VarWChar , 50){ Value = temperature.Version         },
                new OleDbParameter("@Reserve"         , OleDbType.VarWChar , 50){ Value = temperature.Reserve         },
                new OleDbParameter("@Check_flagId"    , OleDbType.Integer  , 4 ){ Value = temperature.Check_flag      },
                new OleDbParameter("@Hosname"         , OleDbType.VarWChar , 50){ Value = temperature.Hosname         },
                new OleDbParameter("@Auditdoctor"     , OleDbType.VarWChar , 50){ Value = temperature.Auditdoctor     },
                new OleDbParameter("@Auditdate"       , OleDbType.Date     , 8 ){ Value = temperature.Auditdate       },
                new OleDbParameter("@StatusId"        , OleDbType.Integer  , 4 ){ Value = temperature.Status          },
                new OleDbParameter("@Str1"            , OleDbType.VarWChar , 50){ Value = temperature.Str1            },
                new OleDbParameter("@Str2"            , OleDbType.VarWChar , 50){ Value = temperature.Str2            },
                new OleDbParameter("@Str3"            , OleDbType.VarWChar , 50){ Value = temperature.Str3            },
                new OleDbParameter("@Str4"            , OleDbType.VarWChar , 50){ Value = temperature.Str4            },
                new OleDbParameter("@Str5"            , OleDbType.VarWChar , 50){ Value = temperature.Str5            },
                new OleDbParameter("@Str6"            , OleDbType.VarWChar , 50){ Value = temperature.Str6            },
                new OleDbParameter("@Str7"            , OleDbType.VarWChar , 50){ Value = temperature.Str7            },
                new OleDbParameter("@Str8"            , OleDbType.VarWChar , 50){ Value = temperature.Str8            },
                new OleDbParameter("@Str9"            , OleDbType.VarWChar , 50){ Value = temperature.Str9            },
                new OleDbParameter("@Str10"           , OleDbType.VarWChar , 50){ Value = temperature.Str10           },
                new OleDbParameter("@T3001007_ename"  , OleDbType.VarWChar , 50){ Value = temperature.T3001007_ename  },
                new OleDbParameter("@T3001007_cname"  , OleDbType.VarWChar , 50){ Value = temperature.T3001007_cname  },
                new OleDbParameter("@T3001007_unit"   , OleDbType.VarWChar , 50){ Value = temperature.T3001007_unit   },
                new OleDbParameter("@T3001007_srange" , OleDbType.Integer  , 4 ){ Value = temperature.T3001007_srange },
                new OleDbParameter("@T3001007_lrange" , OleDbType.Integer  , 4 ){ Value = temperature.T3001007_lrange },
                new OleDbParameter("@T3001007_value"  , OleDbType.Integer  , 4 ){ Value = temperature.T3001007_value  }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
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
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Checkdate"       , OleDbType.Date     , 8 ){ Value = temperature.Checkdate       },
                new OleDbParameter("@ExamNo"          , OleDbType.VarWChar , 50){ Value = temperature.ExamNo          },
                new OleDbParameter("@CheckID"         , OleDbType.VarWChar , 50){ Value = temperature.CheckID         },
                new OleDbParameter("@Name"            , OleDbType.VarWChar , 50){ Value = temperature.Name            },
                new OleDbParameter("@SexId"           , OleDbType.VarWChar , 50){ Value = temperature.Sex             },
                new OleDbParameter("@Age"             , OleDbType.Integer  , 4 ){ Value = temperature.Age             },
                new OleDbParameter("@Doctor"          , OleDbType.VarWChar , 50){ Value = temperature.Doctor          },
                new OleDbParameter("@DeviceID"        , OleDbType.VarWChar , 50){ Value = temperature.DeviceID        },
                new OleDbParameter("@Version"         , OleDbType.VarWChar , 50){ Value = temperature.Version         },
                new OleDbParameter("@Reserve"         , OleDbType.VarWChar , 50){ Value = temperature.Reserve         },
                new OleDbParameter("@Check_flagId"    , OleDbType.Integer  , 4 ){ Value = temperature.Check_flag      },
                new OleDbParameter("@Hosname"         , OleDbType.VarWChar , 50){ Value = temperature.Hosname         },
                new OleDbParameter("@Auditdoctor"     , OleDbType.VarWChar , 50){ Value = temperature.Auditdoctor     },
                new OleDbParameter("@Auditdate"       , OleDbType.Date     , 8 ){ Value = temperature.Auditdate       },
                new OleDbParameter("@StatusId"        , OleDbType.Integer  , 4 ){ Value = temperature.Status          },
                new OleDbParameter("@Str1"            , OleDbType.VarWChar , 50){ Value = temperature.Str1            },
                new OleDbParameter("@Str2"            , OleDbType.VarWChar , 50){ Value = temperature.Str2            },
                new OleDbParameter("@Str3"            , OleDbType.VarWChar , 50){ Value = temperature.Str3            },
                new OleDbParameter("@Str4"            , OleDbType.VarWChar , 50){ Value = temperature.Str4            },
                new OleDbParameter("@Str5"            , OleDbType.VarWChar , 50){ Value = temperature.Str5            },
                new OleDbParameter("@Str6"            , OleDbType.VarWChar , 50){ Value = temperature.Str6            },
                new OleDbParameter("@Str7"            , OleDbType.VarWChar , 50){ Value = temperature.Str7            },
                new OleDbParameter("@Str8"            , OleDbType.VarWChar , 50){ Value = temperature.Str8            },
                new OleDbParameter("@Str9"            , OleDbType.VarWChar , 50){ Value = temperature.Str9            },
                new OleDbParameter("@Str10"           , OleDbType.VarWChar , 50){ Value = temperature.Str10           },
                new OleDbParameter("@T3001007_ename"  , OleDbType.VarWChar , 50){ Value = temperature.T3001007_ename  },
                new OleDbParameter("@T3001007_cname"  , OleDbType.VarWChar , 50){ Value = temperature.T3001007_cname  },
                new OleDbParameter("@T3001007_unit"   , OleDbType.VarWChar , 50){ Value = temperature.T3001007_unit   },
                new OleDbParameter("@T3001007_srange" , OleDbType.Integer  , 4 ){ Value = temperature.T3001007_srange },
                new OleDbParameter("@T3001007_lrange" , OleDbType.Integer  , 4 ){ Value = temperature.T3001007_lrange },
                new OleDbParameter("@T3001007_value"  , OleDbType.Integer  , 4 ){ Value = temperature.T3001007_value  },
                new OleDbParameter("@Id"              , OleDbType.Integer  , 4 ){ Value = temperature.Id              }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// �������¼���ࣨTemperature������������ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">���¼���ࣨTemperature������������ţ�Id����</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [Temperature] "
                           + "WHERE [Id]=@Id";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id" , OleDbType.Integer , 4){ Value = id }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
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
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id" , OleDbType.Integer , 4){ Value = id }
            };

            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, parameters);
            if (oleDbDataReader.Read())
            {
                temperature = new Temperature();
                ReadTemperatureAllData(oleDbDataReader,temperature);
            }
            oleDbDataReader.Close();
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
            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, null);
            while (oleDbDataReader.Read())
            {
                Temperature temperature = new Temperature();
                ReadTemperatureAllData(oleDbDataReader, temperature);
                list.Add(temperature);
            }
            oleDbDataReader.Close();
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
                    Temperature temperature = new Temperature();
                    ReadTemperaturePageData(oleDbDataReader, temperature);
                    list.Add(temperature);
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
