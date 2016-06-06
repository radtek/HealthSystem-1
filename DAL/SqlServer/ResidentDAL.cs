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
    /// �������ƣ�����SQL Server���ݷ������ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ�������ࣨҵ���߼��㣩�����SQL Server�ġ���ɾ�Ĳ顱�ȸ������ݷ��ʷ������̳�ͨ�����ݷ��ʸ��ࡣ
    /// ����˵����ͨ������Ҫֱ��ʵ�������࣬��ʹ�á������ࣨҵ���߼��㣩���е�DataAccess���������ñ�����ʵ�ֵķ�����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 16:41:14
    /// </summary>
    public class ResidentDAL:DAL.Common.ResidentDAL
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬ʵ���˸����ж���ĳ��󷽷����벻Ҫֱ���޸ĸ������е��κδ��룬   
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>
        /// ������Resident�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="resident">����Resident��ʵ������</param>
        public override int Insert(Resident resident)
        {
            string sqlText = "INSERT INTO [Resident]"
                           + "([ResidentId],[Name],[IdNumber],[Sex],[Phone],[DateOfBirth],[Nation],[ContactName],[ContactPhone],[Education],[BloodType],[Professional],"
                           + "[WorkUnits],[Payment],[FamilyId],[MaritalStatus],[Children],[FathersName],[MotherName],[GuardiansName],[GuardianPhone],[CrowdType],[ResidentialType],"
                           + "[PermanentType],[Registered],[RegisteredAddress],[Live],[LiveAddress],[InputtingInstitutions],[InputtingPerson],[InputtingTime],[ResponsibleDoctor],"
                           + "[ManagementStatus],[EnableTime],[FocusOn],[RHNegative],[Remarks])"
                           + "VALUES"
                           + "(@ResidentId,@Name,@IdNumber,@Sex,@Phone,@DateOfBirth,@Nation,@ContactName,@ContactPhone,@Education,@BloodType,@Professional,"
                           + "@WorkUnits,@Payment,@FamilyId,@MaritalStatus,@Children,@FathersName,@MotherName,@GuardiansName,@GuardianPhone,@CrowdType,@ResidentialType,"
                           + "@PermanentType,@Registered,@RegisteredAddress,@Live,@LiveAddress,@InputtingInstitutions,@InputtingPerson,@InputtingTime,@ResponsibleDoctor,"
                           + "@ManagementStatus,@EnableTime,@FocusOn,@RHNegative,@Remarks)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@ResidentId"            , SqlDbType.NVarChar , 50 ){ Value = resident.ResidentId               },
                new SqlParameter("@Name"                  , SqlDbType.NVarChar , 50 ){ Value = resident.Name                     },
                new SqlParameter("@IdNumber"              , SqlDbType.Int      , 4  ){ Value = resident.IdNumber                 },
                new SqlParameter("@Sex"                   , SqlDbType.Int      , 4  ){ Value = resident.Sex                      },
                new SqlParameter("@Phone"                 , SqlDbType.NVarChar , 20 ){ Value = resident.Phone                    },
                new SqlParameter("@DateOfBirth"           , SqlDbType.DateTime , 8  ){ Value = resident.DateOfBirth              },
                new SqlParameter("@Nation"                , SqlDbType.NVarChar , 20 ){ Value = resident.Nation                   },
                new SqlParameter("@ContactName"           , SqlDbType.NVarChar , 50 ){ Value = resident.ContactName              },
                new SqlParameter("@ContactPhone"          , SqlDbType.NVarChar , 20 ){ Value = resident.ContactPhone             },
                new SqlParameter("@Education"             , SqlDbType.Int      , 4  ){ Value = resident.Education                },
                new SqlParameter("@BloodType"             , SqlDbType.Int      , 4  ){ Value = resident.BloodType                },
                new SqlParameter("@Professional"          , SqlDbType.NVarChar , 50 ){ Value = resident.Professional             },
                new SqlParameter("@WorkUnits"             , SqlDbType.NVarChar , 50 ){ Value = resident.WorkUnits                },
                new SqlParameter("@Payment"               , SqlDbType.Int      , 4  ){ Value = resident.Payment                  },
                new SqlParameter("@FamilyId"              , SqlDbType.Int      , 4  ){ Value = resident.FamilyId.Id              },
                new SqlParameter("@MaritalStatus"         , SqlDbType.Int      , 4  ){ Value = resident.MaritalStatus            },
                new SqlParameter("@Children"              , SqlDbType.Int      , 4  ){ Value = resident.Children                 },
                new SqlParameter("@FathersName"           , SqlDbType.NVarChar , 50 ){ Value = resident.FathersName              },
                new SqlParameter("@MotherName"            , SqlDbType.NVarChar , 50 ){ Value = resident.MotherName               },
                new SqlParameter("@GuardiansName"         , SqlDbType.NVarChar , 50 ){ Value = resident.GuardiansName            },
                new SqlParameter("@GuardianPhone"         , SqlDbType.NVarChar , 50 ){ Value = resident.GuardianPhone            },
                new SqlParameter("@CrowdType"             , SqlDbType.Int      , 4  ){ Value = resident.CrowdType                },
                new SqlParameter("@ResidentialType"       , SqlDbType.Int      , 4  ){ Value = resident.ResidentialType          },
                new SqlParameter("@PermanentType"         , SqlDbType.Int      , 4  ){ Value = resident.PermanentType            },
                new SqlParameter("@Registered"            , SqlDbType.NVarChar , 50 ){ Value = resident.Registered               },
                new SqlParameter("@RegisteredAddress"     , SqlDbType.NVarChar , 50 ){ Value = resident.RegisteredAddress        },
                new SqlParameter("@Live"                  , SqlDbType.NVarChar , 50 ){ Value = resident.Live                     },
                new SqlParameter("@LiveAddress"           , SqlDbType.NVarChar , 50 ){ Value = resident.LiveAddress              },
                new SqlParameter("@InputtingInstitutions" , SqlDbType.Int      , 4  ){ Value = resident.InputtingInstitutions.Id },
                new SqlParameter("@InputtingPerson"       , SqlDbType.NVarChar , 50 ){ Value = resident.InputtingPerson          },
                new SqlParameter("@InputtingTime"         , SqlDbType.DateTime , 8  ){ Value = resident.InputtingTime            },
                new SqlParameter("@ResponsibleDoctor"     , SqlDbType.NVarChar , 50 ){ Value = resident.ResponsibleDoctor        },
                new SqlParameter("@ManagementStatus"      , SqlDbType.Int      , 4  ){ Value = resident.ManagementStatus         },
                new SqlParameter("@EnableTime"            , SqlDbType.DateTime , 8  ){ Value = resident.EnableTime               },
                new SqlParameter("@FocusOn"               , SqlDbType.SmallInt , 2  ){ Value = resident.FocusOn                  },
                new SqlParameter("@RHNegative"            , SqlDbType.SmallInt , 2  ){ Value = resident.RHNegative               },
                new SqlParameter("@Remarks"               , SqlDbType.NVarChar , 200){ Value = resident.Remarks                  }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ������Resident�����ݣ������������Զ���ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="resident">����Resident��ʵ������</param>
        public override int Update(Resident resident)
        {
            string sqlText = "UPDATE [Resident] SET "
                           + "[ResidentId]=@ResidentId,[Name]=@Name,[IdNumber]=@IdNumber,[Sex]=@Sex,[Phone]=@Phone,[DateOfBirth]=@DateOfBirth,[Nation]=@Nation,"
                           + "[ContactName]=@ContactName,[ContactPhone]=@ContactPhone,[Education]=@Education,[BloodType]=@BloodType,[Professional]=@Professional,[WorkUnits]=@WorkUnits,"
                           + "[Payment]=@Payment,[FamilyId]=@FamilyId,[MaritalStatus]=@MaritalStatus,[Children]=@Children,[FathersName]=@FathersName,[MotherName]=@MotherName,"
                           + "[GuardiansName]=@GuardiansName,[GuardianPhone]=@GuardianPhone,[CrowdType]=@CrowdType,[ResidentialType]=@ResidentialType,[PermanentType]=@PermanentType,"
                           + "[Registered]=@Registered,[RegisteredAddress]=@RegisteredAddress,[Live]=@Live,[LiveAddress]=@LiveAddress,[InputtingInstitutions]=@InputtingInstitutions,"
                           + "[InputtingPerson]=@InputtingPerson,[InputtingTime]=@InputtingTime,[ResponsibleDoctor]=@ResponsibleDoctor,[ManagementStatus]=@ManagementStatus,"
                           + "[EnableTime]=@EnableTime,[FocusOn]=@FocusOn,[RHNegative]=@RHNegative,[Remarks]=@Remarks "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@ResidentId"            , SqlDbType.NVarChar , 50 ){ Value = resident.ResidentId               },
                new SqlParameter("@Name"                  , SqlDbType.NVarChar , 50 ){ Value = resident.Name                     },
                new SqlParameter("@IdNumber"              , SqlDbType.Int      , 4  ){ Value = resident.IdNumber                 },
                new SqlParameter("@Sex"                   , SqlDbType.Int      , 4  ){ Value = resident.Sex                      },
                new SqlParameter("@Phone"                 , SqlDbType.NVarChar , 20 ){ Value = resident.Phone                    },
                new SqlParameter("@DateOfBirth"           , SqlDbType.DateTime , 8  ){ Value = resident.DateOfBirth              },
                new SqlParameter("@Nation"                , SqlDbType.NVarChar , 20 ){ Value = resident.Nation                   },
                new SqlParameter("@ContactName"           , SqlDbType.NVarChar , 50 ){ Value = resident.ContactName              },
                new SqlParameter("@ContactPhone"          , SqlDbType.NVarChar , 20 ){ Value = resident.ContactPhone             },
                new SqlParameter("@Education"             , SqlDbType.Int      , 4  ){ Value = resident.Education                },
                new SqlParameter("@BloodType"             , SqlDbType.Int      , 4  ){ Value = resident.BloodType                },
                new SqlParameter("@Professional"          , SqlDbType.NVarChar , 50 ){ Value = resident.Professional             },
                new SqlParameter("@WorkUnits"             , SqlDbType.NVarChar , 50 ){ Value = resident.WorkUnits                },
                new SqlParameter("@Payment"               , SqlDbType.Int      , 4  ){ Value = resident.Payment                  },
                new SqlParameter("@FamilyId"              , SqlDbType.Int      , 4  ){ Value = resident.FamilyId.Id              },
                new SqlParameter("@MaritalStatus"         , SqlDbType.Int      , 4  ){ Value = resident.MaritalStatus            },
                new SqlParameter("@Children"              , SqlDbType.Int      , 4  ){ Value = resident.Children                 },
                new SqlParameter("@FathersName"           , SqlDbType.NVarChar , 50 ){ Value = resident.FathersName              },
                new SqlParameter("@MotherName"            , SqlDbType.NVarChar , 50 ){ Value = resident.MotherName               },
                new SqlParameter("@GuardiansName"         , SqlDbType.NVarChar , 50 ){ Value = resident.GuardiansName            },
                new SqlParameter("@GuardianPhone"         , SqlDbType.NVarChar , 50 ){ Value = resident.GuardianPhone            },
                new SqlParameter("@CrowdType"             , SqlDbType.Int      , 4  ){ Value = resident.CrowdType                },
                new SqlParameter("@ResidentialType"       , SqlDbType.Int      , 4  ){ Value = resident.ResidentialType          },
                new SqlParameter("@PermanentType"         , SqlDbType.Int      , 4  ){ Value = resident.PermanentType            },
                new SqlParameter("@Registered"            , SqlDbType.NVarChar , 50 ){ Value = resident.Registered               },
                new SqlParameter("@RegisteredAddress"     , SqlDbType.NVarChar , 50 ){ Value = resident.RegisteredAddress        },
                new SqlParameter("@Live"                  , SqlDbType.NVarChar , 50 ){ Value = resident.Live                     },
                new SqlParameter("@LiveAddress"           , SqlDbType.NVarChar , 50 ){ Value = resident.LiveAddress              },
                new SqlParameter("@InputtingInstitutions" , SqlDbType.Int      , 4  ){ Value = resident.InputtingInstitutions.Id },
                new SqlParameter("@InputtingPerson"       , SqlDbType.NVarChar , 50 ){ Value = resident.InputtingPerson          },
                new SqlParameter("@InputtingTime"         , SqlDbType.DateTime , 8  ){ Value = resident.InputtingTime            },
                new SqlParameter("@ResponsibleDoctor"     , SqlDbType.NVarChar , 50 ){ Value = resident.ResponsibleDoctor        },
                new SqlParameter("@ManagementStatus"      , SqlDbType.Int      , 4  ){ Value = resident.ManagementStatus         },
                new SqlParameter("@EnableTime"            , SqlDbType.DateTime , 8  ){ Value = resident.EnableTime               },
                new SqlParameter("@FocusOn"               , SqlDbType.SmallInt , 2  ){ Value = resident.FocusOn                  },
                new SqlParameter("@RHNegative"            , SqlDbType.SmallInt , 2  ){ Value = resident.RHNegative               },
                new SqlParameter("@Remarks"               , SqlDbType.NVarChar , 200){ Value = resident.Remarks                  },
                new SqlParameter("@Id"                    , SqlDbType.Int      , 4  ){ Value = resident.Id                       }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ���ݾ���Resident�����������Զ���ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">����Resident�����������Զ���ţ�Id����</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [Resident] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ���ݾ���Resident�����������Զ���ţ�Id���������ݿ��л�ȡ����Resident����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�����¾���Resident����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">����Resident�����������Զ���ţ�Id����</param>
        public override Resident GetDataById(int id)
        {
            Resident resident = null;
            string sqlText = "SELECT [Id],[ResidentId],[Name],[IdNumber],[Sex],[Phone],[DateOfBirth],[Nation],[ContactName],[ContactPhone],[Education],[BloodType],[Professional],"
                           + "[WorkUnits],[Payment],[FamilyId],[MaritalStatus],[Children],[FathersName],[MotherName],[GuardiansName],[GuardianPhone],[CrowdType],[ResidentialType],"
                           + "[PermanentType],[Registered],[RegisteredAddress],[Live],[LiveAddress],[InputtingInstitutions],[InputtingPerson],[InputtingTime],[ResponsibleDoctor],"
                           + "[ManagementStatus],[EnableTime],[FocusOn],[RHNegative],[Remarks] "
                           + "FROM [Resident] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                resident = new Resident();
                ReadResidentAllData(sqlDataReader,resident);
            }
            sqlDataReader.Close();
            return resident;
        }


        /// <summary>
        /// �����ݿ��ж�ȡ���������о���Resident��List�б�
        /// </summary>
        public override List<Resident> GetAllList()
        {
            string sqlText = "SELECT [Id],[ResidentId],[Name],[IdNumber],[Sex],[Phone],[DateOfBirth],[Nation],[ContactName],[ContactPhone],[Education],[BloodType],[Professional],"
                           + "[WorkUnits],[Payment],[FamilyId],[MaritalStatus],[Children],[FathersName],[MotherName],[GuardiansName],[GuardianPhone],[CrowdType],[ResidentialType],"
                           + "[PermanentType],[Registered],[RegisteredAddress],[Live],[LiveAddress],[InputtingInstitutions],[InputtingPerson],[InputtingTime],[ResponsibleDoctor],"
                           + "[ManagementStatus],[EnableTime],[FocusOn],[RHNegative],[Remarks] "
                           + "FROM [Resident]";
            List<Resident> list = new List<Resident>();
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, null);
            while (sqlDataReader.Read())
            {
                Resident resident = new Resident();
                ReadResidentAllData(sqlDataReader, resident);
                list.Add(resident);
            }
            sqlDataReader.Close();
            return list;
        }


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ��ľ���Resident�����б���ҳ��Ϣ��
        /// �÷�������ȡ�ľ���Resident���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
        /// </summary>
        public override PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "SELECT [Id],[ResidentId],[Name],[IdNumber],[Sex],[FamilyId],[InputtingInstitutions],[InputtingPerson],[InputtingTime],[ResponsibleDoctor],"
                           + "[ManagementStatus],[EnableTime] "
                           + "FROM [Resident]";
            List<Resident> list = new List<Resident>();
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
                    Resident resident = new Resident();
                    ReadResidentPageData(sqlDataReader, resident);
                    list.Add(resident);
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
