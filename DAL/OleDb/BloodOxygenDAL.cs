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
    /// �������ƣ�Ѫ�������OleDb���ݷ������ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ��Ѫ��������ࣨҵ���߼��㣩�����OleDb�ġ���ɾ�Ĳ顱�ȸ������ݷ��ʷ������̳�ͨ�����ݷ��ʸ��ࡣ
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
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Checkdate"       , OleDbType.Date     , 8 ){ Value = bloodOxygen.Checkdate       },
                new OleDbParameter("@ExamNo"          , OleDbType.VarWChar , 50){ Value = bloodOxygen.ExamNo          },
                new OleDbParameter("@CheckID"         , OleDbType.VarWChar , 50){ Value = bloodOxygen.CheckID         },
                new OleDbParameter("@Name"            , OleDbType.VarWChar , 50){ Value = bloodOxygen.Name            },
                new OleDbParameter("@SexId"           , OleDbType.VarWChar , 50){ Value = bloodOxygen.Sex             },
                new OleDbParameter("@Age"             , OleDbType.Integer  , 4 ){ Value = bloodOxygen.Age             },
                new OleDbParameter("@Doctor"          , OleDbType.VarWChar , 50){ Value = bloodOxygen.Doctor          },
                new OleDbParameter("@DeviceID"        , OleDbType.VarWChar , 50){ Value = bloodOxygen.DeviceID        },
                new OleDbParameter("@Version"         , OleDbType.VarWChar , 50){ Value = bloodOxygen.Version         },
                new OleDbParameter("@Reserve"         , OleDbType.VarWChar , 50){ Value = bloodOxygen.Reserve         },
                new OleDbParameter("@Check_flagId"    , OleDbType.Integer  , 4 ){ Value = bloodOxygen.Check_flag      },
                new OleDbParameter("@Hosname"         , OleDbType.VarWChar , 50){ Value = bloodOxygen.Hosname         },
                new OleDbParameter("@Auditdoctor"     , OleDbType.VarWChar , 50){ Value = bloodOxygen.Auditdoctor     },
                new OleDbParameter("@Auditdate"       , OleDbType.Date     , 8 ){ Value = bloodOxygen.Auditdate       },
                new OleDbParameter("@StatusId"        , OleDbType.Integer  , 4 ){ Value = bloodOxygen.Status          },
                new OleDbParameter("@Str1"            , OleDbType.VarWChar , 50){ Value = bloodOxygen.Str1            },
                new OleDbParameter("@Str2"            , OleDbType.VarWChar , 50){ Value = bloodOxygen.Str2            },
                new OleDbParameter("@Str3"            , OleDbType.VarWChar , 50){ Value = bloodOxygen.Str3            },
                new OleDbParameter("@Str4"            , OleDbType.VarWChar , 50){ Value = bloodOxygen.Str4            },
                new OleDbParameter("@Str5"            , OleDbType.VarWChar , 50){ Value = bloodOxygen.Str5            },
                new OleDbParameter("@Str6"            , OleDbType.VarWChar , 50){ Value = bloodOxygen.Str6            },
                new OleDbParameter("@Str7"            , OleDbType.VarWChar , 50){ Value = bloodOxygen.Str7            },
                new OleDbParameter("@Str8"            , OleDbType.VarWChar , 50){ Value = bloodOxygen.Str8            },
                new OleDbParameter("@Str9"            , OleDbType.VarWChar , 50){ Value = bloodOxygen.Str9            },
                new OleDbParameter("@Str10"           , OleDbType.VarWChar , 50){ Value = bloodOxygen.Str10           },
                new OleDbParameter("@T3001005_ename"  , OleDbType.VarWChar , 50){ Value = bloodOxygen.T3001005_ename  },
                new OleDbParameter("@T3001005_cname"  , OleDbType.VarWChar , 50){ Value = bloodOxygen.T3001005_cname  },
                new OleDbParameter("@T3001005_unit"   , OleDbType.VarWChar , 50){ Value = bloodOxygen.T3001005_unit   },
                new OleDbParameter("@T3001005_srange" , OleDbType.Integer  , 4 ){ Value = bloodOxygen.T3001005_srange },
                new OleDbParameter("@T3001005_lrange" , OleDbType.Integer  , 4 ){ Value = bloodOxygen.T3001005_lrange },
                new OleDbParameter("@T3001005_value"  , OleDbType.Integer  , 4 ){ Value = bloodOxygen.T3001005_value  },
                new OleDbParameter("@T3001009_ename"  , OleDbType.VarWChar , 50){ Value = bloodOxygen.T3001009_ename  },
                new OleDbParameter("@T3001009_cname"  , OleDbType.VarWChar , 50){ Value = bloodOxygen.T3001009_cname  },
                new OleDbParameter("@T3001009_unit"   , OleDbType.VarWChar , 50){ Value = bloodOxygen.T3001009_unit   },
                new OleDbParameter("@T3001009_srange" , OleDbType.Integer  , 4 ){ Value = bloodOxygen.T3001009_srange },
                new OleDbParameter("@T3001009_lrange" , OleDbType.Integer  , 4 ){ Value = bloodOxygen.T3001009_lrange },
                new OleDbParameter("@T3001009_value"  , OleDbType.Integer  , 4 ){ Value = bloodOxygen.T3001009_value  }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
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
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Checkdate"       , OleDbType.Date     , 8 ){ Value = bloodOxygen.Checkdate       },
                new OleDbParameter("@ExamNo"          , OleDbType.VarWChar , 50){ Value = bloodOxygen.ExamNo          },
                new OleDbParameter("@CheckID"         , OleDbType.VarWChar , 50){ Value = bloodOxygen.CheckID         },
                new OleDbParameter("@Name"            , OleDbType.VarWChar , 50){ Value = bloodOxygen.Name            },
                new OleDbParameter("@SexId"           , OleDbType.VarWChar , 50){ Value = bloodOxygen.Sex             },
                new OleDbParameter("@Age"             , OleDbType.Integer  , 4 ){ Value = bloodOxygen.Age             },
                new OleDbParameter("@Doctor"          , OleDbType.VarWChar , 50){ Value = bloodOxygen.Doctor          },
                new OleDbParameter("@DeviceID"        , OleDbType.VarWChar , 50){ Value = bloodOxygen.DeviceID        },
                new OleDbParameter("@Version"         , OleDbType.VarWChar , 50){ Value = bloodOxygen.Version         },
                new OleDbParameter("@Reserve"         , OleDbType.VarWChar , 50){ Value = bloodOxygen.Reserve         },
                new OleDbParameter("@Check_flagId"    , OleDbType.Integer  , 4 ){ Value = bloodOxygen.Check_flag      },
                new OleDbParameter("@Hosname"         , OleDbType.VarWChar , 50){ Value = bloodOxygen.Hosname         },
                new OleDbParameter("@Auditdoctor"     , OleDbType.VarWChar , 50){ Value = bloodOxygen.Auditdoctor     },
                new OleDbParameter("@Auditdate"       , OleDbType.Date     , 8 ){ Value = bloodOxygen.Auditdate       },
                new OleDbParameter("@StatusId"        , OleDbType.Integer  , 4 ){ Value = bloodOxygen.Status          },
                new OleDbParameter("@Str1"            , OleDbType.VarWChar , 50){ Value = bloodOxygen.Str1            },
                new OleDbParameter("@Str2"            , OleDbType.VarWChar , 50){ Value = bloodOxygen.Str2            },
                new OleDbParameter("@Str3"            , OleDbType.VarWChar , 50){ Value = bloodOxygen.Str3            },
                new OleDbParameter("@Str4"            , OleDbType.VarWChar , 50){ Value = bloodOxygen.Str4            },
                new OleDbParameter("@Str5"            , OleDbType.VarWChar , 50){ Value = bloodOxygen.Str5            },
                new OleDbParameter("@Str6"            , OleDbType.VarWChar , 50){ Value = bloodOxygen.Str6            },
                new OleDbParameter("@Str7"            , OleDbType.VarWChar , 50){ Value = bloodOxygen.Str7            },
                new OleDbParameter("@Str8"            , OleDbType.VarWChar , 50){ Value = bloodOxygen.Str8            },
                new OleDbParameter("@Str9"            , OleDbType.VarWChar , 50){ Value = bloodOxygen.Str9            },
                new OleDbParameter("@Str10"           , OleDbType.VarWChar , 50){ Value = bloodOxygen.Str10           },
                new OleDbParameter("@T3001005_ename"  , OleDbType.VarWChar , 50){ Value = bloodOxygen.T3001005_ename  },
                new OleDbParameter("@T3001005_cname"  , OleDbType.VarWChar , 50){ Value = bloodOxygen.T3001005_cname  },
                new OleDbParameter("@T3001005_unit"   , OleDbType.VarWChar , 50){ Value = bloodOxygen.T3001005_unit   },
                new OleDbParameter("@T3001005_srange" , OleDbType.Integer  , 4 ){ Value = bloodOxygen.T3001005_srange },
                new OleDbParameter("@T3001005_lrange" , OleDbType.Integer  , 4 ){ Value = bloodOxygen.T3001005_lrange },
                new OleDbParameter("@T3001005_value"  , OleDbType.Integer  , 4 ){ Value = bloodOxygen.T3001005_value  },
                new OleDbParameter("@T3001009_ename"  , OleDbType.VarWChar , 50){ Value = bloodOxygen.T3001009_ename  },
                new OleDbParameter("@T3001009_cname"  , OleDbType.VarWChar , 50){ Value = bloodOxygen.T3001009_cname  },
                new OleDbParameter("@T3001009_unit"   , OleDbType.VarWChar , 50){ Value = bloodOxygen.T3001009_unit   },
                new OleDbParameter("@T3001009_srange" , OleDbType.Integer  , 4 ){ Value = bloodOxygen.T3001009_srange },
                new OleDbParameter("@T3001009_lrange" , OleDbType.Integer  , 4 ){ Value = bloodOxygen.T3001009_lrange },
                new OleDbParameter("@T3001009_value"  , OleDbType.Integer  , 4 ){ Value = bloodOxygen.T3001009_value  },
                new OleDbParameter("@Id"              , OleDbType.Integer  , 4 ){ Value = bloodOxygen.Id              }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ����Ѫ������ࣨBloodOxygen������������ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">Ѫ������ࣨBloodOxygen������������ţ�Id����</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [BloodOxygen] "
                           + "WHERE [Id]=@Id";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id" , OleDbType.Integer , 4){ Value = id }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
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
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id" , OleDbType.Integer , 4){ Value = id }
            };

            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, parameters);
            if (oleDbDataReader.Read())
            {
                bloodOxygen = new BloodOxygen();
                ReadBloodOxygenAllData(oleDbDataReader,bloodOxygen);
            }
            oleDbDataReader.Close();
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
            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, null);
            while (oleDbDataReader.Read())
            {
                BloodOxygen bloodOxygen = new BloodOxygen();
                ReadBloodOxygenAllData(oleDbDataReader, bloodOxygen);
                list.Add(bloodOxygen);
            }
            oleDbDataReader.Close();
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
                    BloodOxygen bloodOxygen = new BloodOxygen();
                    ReadBloodOxygenPageData(oleDbDataReader, bloodOxygen);
                    list.Add(bloodOxygen);
                }
            }
            oleDbDataReader.Close();

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
            OleDbParameter[] parameters =
            {
                new OleDbParameter("@Name" , OleDbType.WChar , 50){ Value = name }
            };
            List<BloodOxygen> list = new List<BloodOxygen>();
            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, parameters);
            if (oleDbDataReader.Read())
            {
                bloodOxygen = new BloodOxygen();
                ReadBloodOxygenAllData(oleDbDataReader, bloodOxygen);
                list.Add(bloodOxygen);
               
            }
            oleDbDataReader.Close();
            return list;
        }

        #endregion �����ʽ�µ�Ĭ�ϴ���

        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ˵������������Ĵ���Ϊ��ƿ�����Ա����д����ҪΪ��չ�����ݷ�����Ĺ��ܣ�������ı��������Լ�������ݷ��ʷ�����  
        //  ע�⣺Ϊ�˱�֤����Ŀ�Ķ����ݿ�֧������չ�ԣ������ڱ���ĸ����ж���س��󷽷����ж��壬���ڱ����н��о���ʵ�֡�
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l










    }
}
