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
    /// �������ƣ�����OleDb���ݷ������ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ�������ࣨҵ���߼��㣩�����OleDb�ġ���ɾ�Ĳ顱�ȸ������ݷ��ʷ������̳�ͨ�����ݷ��ʸ��ࡣ
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
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@ResidentId"            , OleDbType.VarWChar , 50 ){ Value = resident.ResidentId               },
                new OleDbParameter("@Name"                  , OleDbType.VarWChar , 50 ){ Value = resident.Name                     },
                new OleDbParameter("@IdNumber"              , OleDbType.Integer  , 4  ){ Value = resident.IdNumber                 },
                new OleDbParameter("@Sex"                   , OleDbType.Integer  , 4  ){ Value = resident.Sex                      },
                new OleDbParameter("@Phone"                 , OleDbType.VarWChar , 20 ){ Value = resident.Phone                    },
                new OleDbParameter("@DateOfBirth"           , OleDbType.Date     , 8  ){ Value = resident.DateOfBirth              },
                new OleDbParameter("@Nation"                , OleDbType.VarWChar , 20 ){ Value = resident.Nation                   },
                new OleDbParameter("@ContactName"           , OleDbType.VarWChar , 50 ){ Value = resident.ContactName              },
                new OleDbParameter("@ContactPhone"          , OleDbType.VarWChar , 20 ){ Value = resident.ContactPhone             },
                new OleDbParameter("@Education"             , OleDbType.Integer  , 4  ){ Value = resident.Education                },
                new OleDbParameter("@BloodType"             , OleDbType.Integer  , 4  ){ Value = resident.BloodType                },
                new OleDbParameter("@Professional"          , OleDbType.VarWChar , 50 ){ Value = resident.Professional             },
                new OleDbParameter("@WorkUnits"             , OleDbType.VarWChar , 50 ){ Value = resident.WorkUnits                },
                new OleDbParameter("@Payment"               , OleDbType.Integer  , 4  ){ Value = resident.Payment                  },
                new OleDbParameter("@FamilyId"              , OleDbType.Integer  , 4  ){ Value = resident.FamilyId.Id              },
                new OleDbParameter("@MaritalStatus"         , OleDbType.Integer  , 4  ){ Value = resident.MaritalStatus            },
                new OleDbParameter("@Children"              , OleDbType.Integer  , 4  ){ Value = resident.Children                 },
                new OleDbParameter("@FathersName"           , OleDbType.VarWChar , 50 ){ Value = resident.FathersName              },
                new OleDbParameter("@MotherName"            , OleDbType.VarWChar , 50 ){ Value = resident.MotherName               },
                new OleDbParameter("@GuardiansName"         , OleDbType.VarWChar , 50 ){ Value = resident.GuardiansName            },
                new OleDbParameter("@GuardianPhone"         , OleDbType.VarWChar , 50 ){ Value = resident.GuardianPhone            },
                new OleDbParameter("@CrowdType"             , OleDbType.Integer  , 4  ){ Value = resident.CrowdType                },
                new OleDbParameter("@ResidentialType"       , OleDbType.Integer  , 4  ){ Value = resident.ResidentialType          },
                new OleDbParameter("@PermanentType"         , OleDbType.Integer  , 4  ){ Value = resident.PermanentType            },
                new OleDbParameter("@Registered"            , OleDbType.VarWChar , 50 ){ Value = resident.Registered               },
                new OleDbParameter("@RegisteredAddress"     , OleDbType.VarWChar , 50 ){ Value = resident.RegisteredAddress        },
                new OleDbParameter("@Live"                  , OleDbType.VarWChar , 50 ){ Value = resident.Live                     },
                new OleDbParameter("@LiveAddress"           , OleDbType.VarWChar , 50 ){ Value = resident.LiveAddress              },
                new OleDbParameter("@InputtingInstitutions" , OleDbType.Integer  , 4  ){ Value = resident.InputtingInstitutions.Id },
                new OleDbParameter("@InputtingPerson"       , OleDbType.VarWChar , 50 ){ Value = resident.InputtingPerson          },
                new OleDbParameter("@InputtingTime"         , OleDbType.Date     , 8  ){ Value = resident.InputtingTime            },
                new OleDbParameter("@ResponsibleDoctor"     , OleDbType.VarWChar , 50 ){ Value = resident.ResponsibleDoctor        },
                new OleDbParameter("@ManagementStatus"      , OleDbType.Integer  , 4  ){ Value = resident.ManagementStatus         },
                new OleDbParameter("@EnableTime"            , OleDbType.Date     , 8  ){ Value = resident.EnableTime               },
                new OleDbParameter("@FocusOn"               , OleDbType.SmallInt , 2  ){ Value = resident.FocusOn                  },
                new OleDbParameter("@RHNegative"            , OleDbType.SmallInt , 2  ){ Value = resident.RHNegative               },
                new OleDbParameter("@Remarks"               , OleDbType.VarWChar , 200){ Value = resident.Remarks                  }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
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
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@ResidentId"            , OleDbType.VarWChar , 50 ){ Value = resident.ResidentId               },
                new OleDbParameter("@Name"                  , OleDbType.VarWChar , 50 ){ Value = resident.Name                     },
                new OleDbParameter("@IdNumber"              , OleDbType.Integer  , 4  ){ Value = resident.IdNumber                 },
                new OleDbParameter("@Sex"                   , OleDbType.Integer  , 4  ){ Value = resident.Sex                      },
                new OleDbParameter("@Phone"                 , OleDbType.VarWChar , 20 ){ Value = resident.Phone                    },
                new OleDbParameter("@DateOfBirth"           , OleDbType.Date     , 8  ){ Value = resident.DateOfBirth              },
                new OleDbParameter("@Nation"                , OleDbType.VarWChar , 20 ){ Value = resident.Nation                   },
                new OleDbParameter("@ContactName"           , OleDbType.VarWChar , 50 ){ Value = resident.ContactName              },
                new OleDbParameter("@ContactPhone"          , OleDbType.VarWChar , 20 ){ Value = resident.ContactPhone             },
                new OleDbParameter("@Education"             , OleDbType.Integer  , 4  ){ Value = resident.Education                },
                new OleDbParameter("@BloodType"             , OleDbType.Integer  , 4  ){ Value = resident.BloodType                },
                new OleDbParameter("@Professional"          , OleDbType.VarWChar , 50 ){ Value = resident.Professional             },
                new OleDbParameter("@WorkUnits"             , OleDbType.VarWChar , 50 ){ Value = resident.WorkUnits                },
                new OleDbParameter("@Payment"               , OleDbType.Integer  , 4  ){ Value = resident.Payment                  },
                new OleDbParameter("@FamilyId"              , OleDbType.Integer  , 4  ){ Value = resident.FamilyId.Id              },
                new OleDbParameter("@MaritalStatus"         , OleDbType.Integer  , 4  ){ Value = resident.MaritalStatus            },
                new OleDbParameter("@Children"              , OleDbType.Integer  , 4  ){ Value = resident.Children                 },
                new OleDbParameter("@FathersName"           , OleDbType.VarWChar , 50 ){ Value = resident.FathersName              },
                new OleDbParameter("@MotherName"            , OleDbType.VarWChar , 50 ){ Value = resident.MotherName               },
                new OleDbParameter("@GuardiansName"         , OleDbType.VarWChar , 50 ){ Value = resident.GuardiansName            },
                new OleDbParameter("@GuardianPhone"         , OleDbType.VarWChar , 50 ){ Value = resident.GuardianPhone            },
                new OleDbParameter("@CrowdType"             , OleDbType.Integer  , 4  ){ Value = resident.CrowdType                },
                new OleDbParameter("@ResidentialType"       , OleDbType.Integer  , 4  ){ Value = resident.ResidentialType          },
                new OleDbParameter("@PermanentType"         , OleDbType.Integer  , 4  ){ Value = resident.PermanentType            },
                new OleDbParameter("@Registered"            , OleDbType.VarWChar , 50 ){ Value = resident.Registered               },
                new OleDbParameter("@RegisteredAddress"     , OleDbType.VarWChar , 50 ){ Value = resident.RegisteredAddress        },
                new OleDbParameter("@Live"                  , OleDbType.VarWChar , 50 ){ Value = resident.Live                     },
                new OleDbParameter("@LiveAddress"           , OleDbType.VarWChar , 50 ){ Value = resident.LiveAddress              },
                new OleDbParameter("@InputtingInstitutions" , OleDbType.Integer  , 4  ){ Value = resident.InputtingInstitutions.Id },
                new OleDbParameter("@InputtingPerson"       , OleDbType.VarWChar , 50 ){ Value = resident.InputtingPerson          },
                new OleDbParameter("@InputtingTime"         , OleDbType.Date     , 8  ){ Value = resident.InputtingTime            },
                new OleDbParameter("@ResponsibleDoctor"     , OleDbType.VarWChar , 50 ){ Value = resident.ResponsibleDoctor        },
                new OleDbParameter("@ManagementStatus"      , OleDbType.Integer  , 4  ){ Value = resident.ManagementStatus         },
                new OleDbParameter("@EnableTime"            , OleDbType.Date     , 8  ){ Value = resident.EnableTime               },
                new OleDbParameter("@FocusOn"               , OleDbType.SmallInt , 2  ){ Value = resident.FocusOn                  },
                new OleDbParameter("@RHNegative"            , OleDbType.SmallInt , 2  ){ Value = resident.RHNegative               },
                new OleDbParameter("@Remarks"               , OleDbType.VarWChar , 200){ Value = resident.Remarks                  },
                new OleDbParameter("@Id"                    , OleDbType.Integer  , 4  ){ Value = resident.Id                       }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ���ݾ���Resident�����������Զ���ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">����Resident�����������Զ���ţ�Id����</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [Resident] "
                           + "WHERE [Id]=@Id";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id" , OleDbType.Integer , 4){ Value = id }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
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
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id" , OleDbType.Integer , 4){ Value = id }
            };

            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, parameters);
            if (oleDbDataReader.Read())
            {
                resident = new Resident();
                ReadResidentAllData(oleDbDataReader,resident);
            }
            oleDbDataReader.Close();
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
            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, null);
            while (oleDbDataReader.Read())
            {
                Resident resident = new Resident();
                ReadResidentAllData(oleDbDataReader, resident);
                list.Add(resident);
            }
            oleDbDataReader.Close();
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
                    Resident resident = new Resident();
                    ReadResidentPageData(oleDbDataReader, resident);
                    list.Add(resident);
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
