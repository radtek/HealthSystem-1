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
    /// �������ƣ�Ѫ�������SQL Server���ݷ������ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ��Ѫ��������ࣨҵ���߼��㣩�����SQL Server�ġ���ɾ�Ĳ顱�ȸ������ݷ��ʷ������̳�ͨ�����ݷ��ʸ��ࡣ
    /// ����˵����ͨ������Ҫֱ��ʵ�������࣬��ʹ�á�Ѫ��������ࣨҵ���߼��㣩���е�DataAccess���������ñ�����ʵ�ֵķ�����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 16:55:49
    /// </summary>
    public class BloodOxygenDAL:DAL.Common.BloodOxygenDAL
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬ʵ���˸����ж���ĳ��󷽷����벻Ҫֱ���޸ĸ������е��κδ��룬   
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>
        /// ��Ѫ������ࣨBloodOxygen�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="bloodOxygen">Ѫ������ࣨBloodOxygen��ʵ������</param>
        public override int Insert(BloodOxygen bloodOxygen)
        {
            string sqlText = "INSERT INTO [BloodOxygen]"
                           + "([Checkdate],[ExamNo],[CheckID],[Name],[SexId],[Age],[Doctor],[DeviceID],[Version],[Reserve],[Check_flagId],[Hosname],[Auditdoctor],[Auditdate],"
                           + "[StatusId],[Str1],[Str2],[Str3],[Str4],[Str5],[Str6],[Str7],[Str8],[Str9],[Str10],[T3001005_ename],[T3001005_cname],[T3001005_unit],[T3001005_srange],"
                           + "[T3001005_lrange],[T3001005_value],[T3001009_ename],[T3001009_cname],[T3001009_unit],[T3001009_srange],[T3001009_lrange],[T3001009_value])"
                           + "VALUES"
                           + "(@Checkdate,@ExamNo,@CheckID,@Name,@SexId,@Age,@Doctor,@DeviceID,@Version,@Reserve,@Check_flagId,@Hosname,@Auditdoctor,@Auditdate,"
                           + "@StatusId,@Str1,@Str2,@Str3,@Str4,@Str5,@Str6,@Str7,@Str8,@Str9,@Str10,@T3001005_ename,@T3001005_cname,@T3001005_unit,@T3001005_srange,"
                           + "@T3001005_lrange,@T3001005_value,@T3001009_ename,@T3001009_cname,@T3001009_unit,@T3001009_srange,@T3001009_lrange,@T3001009_value)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Checkdate"       , SqlDbType.DateTime , 8 ){ Value = bloodOxygen.Checkdate       },
                new SqlParameter("@ExamNo"          , SqlDbType.NVarChar , 50){ Value = bloodOxygen.ExamNo          },
                new SqlParameter("@CheckID"         , SqlDbType.NVarChar , 50){ Value = bloodOxygen.CheckID         },
                new SqlParameter("@Name"            , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Name            },
                new SqlParameter("@SexId"           , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Sex             },
                new SqlParameter("@Age"             , SqlDbType.Int      , 4 ){ Value = bloodOxygen.Age             },
                new SqlParameter("@Doctor"          , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Doctor          },
                new SqlParameter("@DeviceID"        , SqlDbType.NVarChar , 50){ Value = bloodOxygen.DeviceID        },
                new SqlParameter("@Version"         , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Version         },
                new SqlParameter("@Reserve"         , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Reserve         },
                new SqlParameter("@Check_flagId"    , SqlDbType.Int      , 4 ){ Value = bloodOxygen.Check_flag      },
                new SqlParameter("@Hosname"         , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Hosname         },
                new SqlParameter("@Auditdoctor"     , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Auditdoctor     },
                new SqlParameter("@Auditdate"       , SqlDbType.DateTime , 8 ){ Value = bloodOxygen.Auditdate       },
                new SqlParameter("@StatusId"        , SqlDbType.Int      , 4 ){ Value = bloodOxygen.Status          },
                new SqlParameter("@Str1"            , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Str1            },
                new SqlParameter("@Str2"            , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Str2            },
                new SqlParameter("@Str3"            , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Str3            },
                new SqlParameter("@Str4"            , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Str4            },
                new SqlParameter("@Str5"            , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Str5            },
                new SqlParameter("@Str6"            , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Str6            },
                new SqlParameter("@Str7"            , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Str7            },
                new SqlParameter("@Str8"            , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Str8            },
                new SqlParameter("@Str9"            , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Str9            },
                new SqlParameter("@Str10"           , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Str10           },
                new SqlParameter("@T3001005_ename"  , SqlDbType.NVarChar , 50){ Value = bloodOxygen.T3001005_ename  },
                new SqlParameter("@T3001005_cname"  , SqlDbType.NVarChar , 50){ Value = bloodOxygen.T3001005_cname  },
                new SqlParameter("@T3001005_unit"   , SqlDbType.NVarChar , 50){ Value = bloodOxygen.T3001005_unit   },
                new SqlParameter("@T3001005_srange" , SqlDbType.Int      , 4 ){ Value = bloodOxygen.T3001005_srange },
                new SqlParameter("@T3001005_lrange" , SqlDbType.Int      , 4 ){ Value = bloodOxygen.T3001005_lrange },
                new SqlParameter("@T3001005_value"  , SqlDbType.Int      , 4 ){ Value = bloodOxygen.T3001005_value  },
                new SqlParameter("@T3001009_ename"  , SqlDbType.NVarChar , 50){ Value = bloodOxygen.T3001009_ename  },
                new SqlParameter("@T3001009_cname"  , SqlDbType.NVarChar , 50){ Value = bloodOxygen.T3001009_cname  },
                new SqlParameter("@T3001009_unit"   , SqlDbType.NVarChar , 50){ Value = bloodOxygen.T3001009_unit   },
                new SqlParameter("@T3001009_srange" , SqlDbType.Int      , 4 ){ Value = bloodOxygen.T3001009_srange },
                new SqlParameter("@T3001009_lrange" , SqlDbType.Int      , 4 ){ Value = bloodOxygen.T3001009_lrange },
                new SqlParameter("@T3001009_value"  , SqlDbType.Int      , 4 ){ Value = bloodOxygen.T3001009_value  }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ��Ѫ������ࣨBloodOxygen�����ݣ�������������ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="bloodOxygen">Ѫ������ࣨBloodOxygen��ʵ������</param>
        public override int Update(BloodOxygen bloodOxygen)
        {
            string sqlText = "UPDATE [BloodOxygen] SET "
                           + "[Checkdate]=@Checkdate,[ExamNo]=@ExamNo,[CheckID]=@CheckID,[Name]=@Name,[SexId]=@SexId,[Age]=@Age,[Doctor]=@Doctor,"
                           + "[DeviceID]=@DeviceID,[Version]=@Version,[Reserve]=@Reserve,[Check_flagId]=@Check_flagId,[Hosname]=@Hosname,[Auditdoctor]=@Auditdoctor,"
                           + "[Auditdate]=@Auditdate,[StatusId]=@StatusId,[Str1]=@Str1,[Str2]=@Str2,[Str3]=@Str3,[Str4]=@Str4,[Str5]=@Str5,[Str6]=@Str6,[Str7]=@Str7,[Str8]=@Str8,[Str9]=@Str9,"
                           + "[Str10]=@Str10,[T3001005_ename]=@T3001005_ename,[T3001005_cname]=@T3001005_cname,[T3001005_unit]=@T3001005_unit,"
                           + "[T3001005_srange]=@T3001005_srange,[T3001005_lrange]=@T3001005_lrange,[T3001005_value]=@T3001005_value,[T3001009_ename]=@T3001009_ename,"
                           + "[T3001009_cname]=@T3001009_cname,[T3001009_unit]=@T3001009_unit,[T3001009_srange]=@T3001009_srange,[T3001009_lrange]=@T3001009_lrange,"
                           + "[T3001009_value]=@T3001009_value "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Checkdate"       , SqlDbType.DateTime , 8 ){ Value = bloodOxygen.Checkdate       },
                new SqlParameter("@ExamNo"          , SqlDbType.NVarChar , 50){ Value = bloodOxygen.ExamNo          },
                new SqlParameter("@CheckID"         , SqlDbType.NVarChar , 50){ Value = bloodOxygen.CheckID         },
                new SqlParameter("@Name"            , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Name            },
                new SqlParameter("@SexId"           , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Sex             },
                new SqlParameter("@Age"             , SqlDbType.Int      , 4 ){ Value = bloodOxygen.Age             },
                new SqlParameter("@Doctor"          , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Doctor          },
                new SqlParameter("@DeviceID"        , SqlDbType.NVarChar , 50){ Value = bloodOxygen.DeviceID        },
                new SqlParameter("@Version"         , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Version         },
                new SqlParameter("@Reserve"         , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Reserve         },
                new SqlParameter("@Check_flagId"    , SqlDbType.Int      , 4 ){ Value = bloodOxygen.Check_flag      },
                new SqlParameter("@Hosname"         , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Hosname         },
                new SqlParameter("@Auditdoctor"     , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Auditdoctor     },
                new SqlParameter("@Auditdate"       , SqlDbType.DateTime , 8 ){ Value = bloodOxygen.Auditdate       },
                new SqlParameter("@StatusId"        , SqlDbType.Int      , 4 ){ Value = bloodOxygen.Status          },
                new SqlParameter("@Str1"            , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Str1            },
                new SqlParameter("@Str2"            , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Str2            },
                new SqlParameter("@Str3"            , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Str3            },
                new SqlParameter("@Str4"            , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Str4            },
                new SqlParameter("@Str5"            , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Str5            },
                new SqlParameter("@Str6"            , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Str6            },
                new SqlParameter("@Str7"            , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Str7            },
                new SqlParameter("@Str8"            , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Str8            },
                new SqlParameter("@Str9"            , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Str9            },
                new SqlParameter("@Str10"           , SqlDbType.NVarChar , 50){ Value = bloodOxygen.Str10           },
                new SqlParameter("@T3001005_ename"  , SqlDbType.NVarChar , 50){ Value = bloodOxygen.T3001005_ename  },
                new SqlParameter("@T3001005_cname"  , SqlDbType.NVarChar , 50){ Value = bloodOxygen.T3001005_cname  },
                new SqlParameter("@T3001005_unit"   , SqlDbType.NVarChar , 50){ Value = bloodOxygen.T3001005_unit   },
                new SqlParameter("@T3001005_srange" , SqlDbType.Int      , 4 ){ Value = bloodOxygen.T3001005_srange },
                new SqlParameter("@T3001005_lrange" , SqlDbType.Int      , 4 ){ Value = bloodOxygen.T3001005_lrange },
                new SqlParameter("@T3001005_value"  , SqlDbType.Int      , 4 ){ Value = bloodOxygen.T3001005_value  },
                new SqlParameter("@T3001009_ename"  , SqlDbType.NVarChar , 50){ Value = bloodOxygen.T3001009_ename  },
                new SqlParameter("@T3001009_cname"  , SqlDbType.NVarChar , 50){ Value = bloodOxygen.T3001009_cname  },
                new SqlParameter("@T3001009_unit"   , SqlDbType.NVarChar , 50){ Value = bloodOxygen.T3001009_unit   },
                new SqlParameter("@T3001009_srange" , SqlDbType.Int      , 4 ){ Value = bloodOxygen.T3001009_srange },
                new SqlParameter("@T3001009_lrange" , SqlDbType.Int      , 4 ){ Value = bloodOxygen.T3001009_lrange },
                new SqlParameter("@T3001009_value"  , SqlDbType.Int      , 4 ){ Value = bloodOxygen.T3001009_value  },
                new SqlParameter("@Id"              , SqlDbType.Int      , 4 ){ Value = bloodOxygen.Id              }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ����Ѫ������ࣨBloodOxygen������������ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">Ѫ������ࣨBloodOxygen������������ţ�Id����</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [BloodOxygen] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ����Ѫ������ࣨBloodOxygen������������ţ�Id���������ݿ��л�ȡѪ������ࣨBloodOxygen����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼������Ѫ������ࣨBloodOxygen����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">Ѫ������ࣨBloodOxygen������������ţ�Id����</param>
        public override BloodOxygen GetDataById(int id)
        {
            BloodOxygen bloodOxygen = null;
            string sqlText = "SELECT [Id],[Checkdate],[ExamNo],[CheckID],[Name],[SexId],[Age],[Doctor],[DeviceID],[Version],[Reserve],[Check_flagId],[Hosname],[Auditdoctor],[Auditdate],"
                           + "[StatusId],[Str1],[Str2],[Str3],[Str4],[Str5],[Str6],[Str7],[Str8],[Str9],[Str10],[T3001005_ename],[T3001005_cname],[T3001005_unit],[T3001005_srange],"
                           + "[T3001005_lrange],[T3001005_value],[T3001009_ename],[T3001009_cname],[T3001009_unit],[T3001009_srange],[T3001009_lrange],[T3001009_value] "
                           + "FROM [BloodOxygen] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                bloodOxygen = new BloodOxygen();
                ReadBloodOxygenAllData(sqlDataReader,bloodOxygen);
            }
            sqlDataReader.Close();
            return bloodOxygen;
        }


        /// <summary>
        /// �����ݿ��ж�ȡ����������Ѫ������ࣨBloodOxygen��List�б�
        /// </summary>
        public override List<BloodOxygen> GetAllList()
        {
            string sqlText = "SELECT [Id],[Checkdate],[ExamNo],[CheckID],[Name],[SexId],[Age],[Doctor],[DeviceID],[Version],[Reserve],[Check_flagId],[Hosname],[Auditdoctor],[Auditdate],"
                           + "[StatusId],[Str1],[Str2],[Str3],[Str4],[Str5],[Str6],[Str7],[Str8],[Str9],[Str10],[T3001005_ename],[T3001005_cname],[T3001005_unit],[T3001005_srange],"
                           + "[T3001005_lrange],[T3001005_value],[T3001009_ename],[T3001009_cname],[T3001009_unit],[T3001009_srange],[T3001009_lrange],[T3001009_value] "
                           + "FROM [BloodOxygen]";
            List<BloodOxygen> list = new List<BloodOxygen>();
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, null);
            while (sqlDataReader.Read())
            {
                BloodOxygen bloodOxygen = new BloodOxygen();
                ReadBloodOxygenAllData(sqlDataReader, bloodOxygen);
                list.Add(bloodOxygen);
            }
            sqlDataReader.Close();
            return list;
        }


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ���Ѫ������ࣨBloodOxygen�����б���ҳ��Ϣ��
        /// �÷�������ȡ��Ѫ������ࣨBloodOxygen���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
        /// </summary>
        public override PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "SELECT [Id],[Checkdate],[ExamNo],[CheckID],[Name],[SexId],[Doctor],[DeviceID],[Check_flagId],[Hosname],[StatusId] "
                           + "FROM [BloodOxygen]";
            List<BloodOxygen> list = new List<BloodOxygen>();
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
                    BloodOxygen bloodOxygen = new BloodOxygen();
                    ReadBloodOxygenPageData(sqlDataReader, bloodOxygen);
                    list.Add(bloodOxygen);
                }
            }
            sqlDataReader.Close();

            if(pageData.RecordCount>0)
                pageData.PageCount = Convert.ToInt32(Math.Ceiling((double)pageData.RecordCount / (double)pageSize));

            pageData.PageList = list;
            return pageData;
        }

       

        public override List<BloodOxygen> GetDatasByName(string name)
        {
            BloodOxygen bloodOxygen = null;
            string sqlText = "SELECT [Id],[Checkdate],[ExamNo],[CheckID],[Name],[SexId],[Age],[Doctor],[DeviceID],[Version],[Reserve],[Check_flagId],[Hosname],[Auditdoctor],[Auditdate],"
                           + "[StatusId],[Str1],[Str2],[Str3],[Str4],[Str5],[Str6],[Str7],[Str8],[Str9],[Str10],[T3001005_ename],[T3001005_cname],[T3001005_unit],[T3001005_srange],"
                           + "[T3001005_lrange],[T3001005_value],[T3001009_ename],[T3001009_cname],[T3001009_unit],[T3001009_srange],[T3001009_lrange],[T3001009_value] "
                           + "FROM [BloodOxygen] "
                           + "WHERE [Name]=@Name";
            List<BloodOxygen> list = new List<BloodOxygen>();
            SqlParameter[] parameters =
            {
                new SqlParameter("@Name" , SqlDbType.NVarChar, 50){ Value = name }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                bloodOxygen = new BloodOxygen();
                ReadBloodOxygenAllData(sqlDataReader, bloodOxygen);
                list.Add(bloodOxygen);
            }
            sqlDataReader.Close();
            return list;
        }

        #endregion �����ʽ�µ�Ĭ�ϴ���

        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ˵������������Ĵ���Ϊ��ƿ�����Ա����д����ҪΪ��չ�����ݷ�����Ĺ��ܣ�������ı��������Լ�������ݷ��ʷ�����  
        //  ע�⣺Ϊ�˱�֤����Ŀ�Ķ����ݿ�֧������չ�ԣ������ڱ���ĸ����ж���س��󷽷����ж��壬���ڱ����н��о���ʵ�֡�
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l










    }
}
