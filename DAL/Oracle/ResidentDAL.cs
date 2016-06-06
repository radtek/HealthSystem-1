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
    /// �������ƣ�����Oracle���ݷ������ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ�������ࣨҵ���߼��㣩�����Oracle�ġ���ɾ�Ĳ顱�ȸ������ݷ��ʷ������̳�ͨ�����ݷ��ʸ��ࡣ
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
            string sqlText = "INSERT INTO \"Resident\""
                           + "(\"ResidentId\",\"Name\",\"IdNumber\",\"Sex\",\"Phone\",\"DateOfBirth\",\"Nation\",\"ContactName\",\"ContactPhone\",\"Education\",\"BloodType\",\"Professional\","
                           + "\"WorkUnits\",\"Payment\",\"FamilyId\",\"MaritalStatus\",\"Children\",\"FathersName\",\"MotherName\",\"GuardiansName\",\"GuardianPhone\",\"CrowdType\",\"ResidentialType\","
                           + "\"PermanentType\",\"Registered\",\"RegisteredAddress\",\"Live\",\"LiveAddress\",\"InputtingInstitutions\",\"InputtingPerson\",\"InputtingTime\",\"ResponsibleDoctor\","
                           + "\"ManagementStatus\",\"EnableTime\",\"FocusOn\",\"RHNegative\",\"Remarks\")"
                           + "VALUES"
                           + "(:ResidentId,:Name,:IdNumber,:Sex,:Phone,:DateOfBirth,:Nation,:ContactName,:ContactPhone,:Education,:BloodType,:Professional,"
                           + ":WorkUnits,:Payment,:FamilyId,:MaritalStatus,:Children,:FathersName,:MotherName,:GuardiansName,:GuardianPhone,:CrowdType,:ResidentialType,"
                           + ":PermanentType,:Registered,:RegisteredAddress,:Live,:LiveAddress,:InputtingInstitutions,:InputtingPerson,:InputtingTime,:ResponsibleDoctor,"
                           + ":ManagementStatus,:EnableTime,:FocusOn,:RHNegative,:Remarks)";
            OracleParameter[] parameters = 
            {
                new OracleParameter(":ResidentId"            , OracleType.NVarChar , 50 ){ Value = resident.ResidentId               },
                new OracleParameter(":Name"                  , OracleType.NVarChar , 50 ){ Value = resident.Name                     },
                new OracleParameter(":IdNumber"              , OracleType.Int32    , 4  ){ Value = resident.IdNumber                 },
                new OracleParameter(":Sex"                   , OracleType.Int32    , 4  ){ Value = resident.Sex                      },
                new OracleParameter(":Phone"                 , OracleType.NVarChar , 20 ){ Value = resident.Phone                    },
                new OracleParameter(":DateOfBirth"           , OracleType.DateTime , 8  ){ Value = resident.DateOfBirth              },
                new OracleParameter(":Nation"                , OracleType.NVarChar , 20 ){ Value = resident.Nation                   },
                new OracleParameter(":ContactName"           , OracleType.NVarChar , 50 ){ Value = resident.ContactName              },
                new OracleParameter(":ContactPhone"          , OracleType.NVarChar , 20 ){ Value = resident.ContactPhone             },
                new OracleParameter(":Education"             , OracleType.Int32    , 4  ){ Value = resident.Education                },
                new OracleParameter(":BloodType"             , OracleType.Int32    , 4  ){ Value = resident.BloodType                },
                new OracleParameter(":Professional"          , OracleType.NVarChar , 50 ){ Value = resident.Professional             },
                new OracleParameter(":WorkUnits"             , OracleType.NVarChar , 50 ){ Value = resident.WorkUnits                },
                new OracleParameter(":Payment"               , OracleType.Int32    , 4  ){ Value = resident.Payment                  },
                new OracleParameter(":FamilyId"              , OracleType.Int32    , 4  ){ Value = resident.FamilyId.Id              },
                new OracleParameter(":MaritalStatus"         , OracleType.Int32    , 4  ){ Value = resident.MaritalStatus            },
                new OracleParameter(":Children"              , OracleType.Int32    , 4  ){ Value = resident.Children                 },
                new OracleParameter(":FathersName"           , OracleType.NVarChar , 50 ){ Value = resident.FathersName              },
                new OracleParameter(":MotherName"            , OracleType.NVarChar , 50 ){ Value = resident.MotherName               },
                new OracleParameter(":GuardiansName"         , OracleType.NVarChar , 50 ){ Value = resident.GuardiansName            },
                new OracleParameter(":GuardianPhone"         , OracleType.NVarChar , 50 ){ Value = resident.GuardianPhone            },
                new OracleParameter(":CrowdType"             , OracleType.Int32    , 4  ){ Value = resident.CrowdType                },
                new OracleParameter(":ResidentialType"       , OracleType.Int32    , 4  ){ Value = resident.ResidentialType          },
                new OracleParameter(":PermanentType"         , OracleType.Int32    , 4  ){ Value = resident.PermanentType            },
                new OracleParameter(":Registered"            , OracleType.NVarChar , 50 ){ Value = resident.Registered               },
                new OracleParameter(":RegisteredAddress"     , OracleType.NVarChar , 50 ){ Value = resident.RegisteredAddress        },
                new OracleParameter(":Live"                  , OracleType.NVarChar , 50 ){ Value = resident.Live                     },
                new OracleParameter(":LiveAddress"           , OracleType.NVarChar , 50 ){ Value = resident.LiveAddress              },
                new OracleParameter(":InputtingInstitutions" , OracleType.Int32    , 4  ){ Value = resident.InputtingInstitutions.Id },
                new OracleParameter(":InputtingPerson"       , OracleType.NVarChar , 50 ){ Value = resident.InputtingPerson          },
                new OracleParameter(":InputtingTime"         , OracleType.DateTime , 8  ){ Value = resident.InputtingTime            },
                new OracleParameter(":ResponsibleDoctor"     , OracleType.NVarChar , 50 ){ Value = resident.ResponsibleDoctor        },
                new OracleParameter(":ManagementStatus"      , OracleType.Int32    , 4  ){ Value = resident.ManagementStatus         },
                new OracleParameter(":EnableTime"            , OracleType.DateTime , 8  ){ Value = resident.EnableTime               },
                new OracleParameter(":FocusOn"               , OracleType.Int16    , 2  ){ Value = resident.FocusOn                  },
                new OracleParameter(":RHNegative"            , OracleType.Int16    , 2  ){ Value = resident.RHNegative               },
                new OracleParameter(":Remarks"               , OracleType.NVarChar , 200){ Value = resident.Remarks                  }
            };
            return SFL.OracleHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ������Resident�����ݣ������������Զ���ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="resident">����Resident��ʵ������</param>
        public override int Update(Resident resident)
        {
            string sqlText = "UPDATE \"Resident\" SET "
                           + "\"ResidentId\"=:ResidentId,\"Name\"=:Name,\"IdNumber\"=:IdNumber,\"Sex\"=:Sex,\"Phone\"=:Phone,\"DateOfBirth\"=:DateOfBirth,\"Nation\"=:Nation,"
                           + "\"ContactName\"=:ContactName,\"ContactPhone\"=:ContactPhone,\"Education\"=:Education,\"BloodType\"=:BloodType,\"Professional\"=:Professional,\"WorkUnits\"=:WorkUnits,"
                           + "\"Payment\"=:Payment,\"FamilyId\"=:FamilyId,\"MaritalStatus\"=:MaritalStatus,\"Children\"=:Children,\"FathersName\"=:FathersName,\"MotherName\"=:MotherName,"
                           + "\"GuardiansName\"=:GuardiansName,\"GuardianPhone\"=:GuardianPhone,\"CrowdType\"=:CrowdType,\"ResidentialType\"=:ResidentialType,\"PermanentType\"=:PermanentType,"
                           + "\"Registered\"=:Registered,\"RegisteredAddress\"=:RegisteredAddress,\"Live\"=:Live,\"LiveAddress\"=:LiveAddress,\"InputtingInstitutions\"=:InputtingInstitutions,"
                           + "\"InputtingPerson\"=:InputtingPerson,\"InputtingTime\"=:InputtingTime,\"ResponsibleDoctor\"=:ResponsibleDoctor,\"ManagementStatus\"=:ManagementStatus,"
                           + "\"EnableTime\"=:EnableTime,\"FocusOn\"=:FocusOn,\"RHNegative\"=:RHNegative,\"Remarks\"=:Remarks "
                           + "WHERE \"Id\"=:Id";
            OracleParameter[] parameters = 
            {
                new OracleParameter(":ResidentId"            , OracleType.NVarChar , 50 ){ Value = resident.ResidentId               },
                new OracleParameter(":Name"                  , OracleType.NVarChar , 50 ){ Value = resident.Name                     },
                new OracleParameter(":IdNumber"              , OracleType.Int32    , 4  ){ Value = resident.IdNumber                 },
                new OracleParameter(":Sex"                   , OracleType.Int32    , 4  ){ Value = resident.Sex                      },
                new OracleParameter(":Phone"                 , OracleType.NVarChar , 20 ){ Value = resident.Phone                    },
                new OracleParameter(":DateOfBirth"           , OracleType.DateTime , 8  ){ Value = resident.DateOfBirth              },
                new OracleParameter(":Nation"                , OracleType.NVarChar , 20 ){ Value = resident.Nation                   },
                new OracleParameter(":ContactName"           , OracleType.NVarChar , 50 ){ Value = resident.ContactName              },
                new OracleParameter(":ContactPhone"          , OracleType.NVarChar , 20 ){ Value = resident.ContactPhone             },
                new OracleParameter(":Education"             , OracleType.Int32    , 4  ){ Value = resident.Education                },
                new OracleParameter(":BloodType"             , OracleType.Int32    , 4  ){ Value = resident.BloodType                },
                new OracleParameter(":Professional"          , OracleType.NVarChar , 50 ){ Value = resident.Professional             },
                new OracleParameter(":WorkUnits"             , OracleType.NVarChar , 50 ){ Value = resident.WorkUnits                },
                new OracleParameter(":Payment"               , OracleType.Int32    , 4  ){ Value = resident.Payment                  },
                new OracleParameter(":FamilyId"              , OracleType.Int32    , 4  ){ Value = resident.FamilyId.Id              },
                new OracleParameter(":MaritalStatus"         , OracleType.Int32    , 4  ){ Value = resident.MaritalStatus            },
                new OracleParameter(":Children"              , OracleType.Int32    , 4  ){ Value = resident.Children                 },
                new OracleParameter(":FathersName"           , OracleType.NVarChar , 50 ){ Value = resident.FathersName              },
                new OracleParameter(":MotherName"            , OracleType.NVarChar , 50 ){ Value = resident.MotherName               },
                new OracleParameter(":GuardiansName"         , OracleType.NVarChar , 50 ){ Value = resident.GuardiansName            },
                new OracleParameter(":GuardianPhone"         , OracleType.NVarChar , 50 ){ Value = resident.GuardianPhone            },
                new OracleParameter(":CrowdType"             , OracleType.Int32    , 4  ){ Value = resident.CrowdType                },
                new OracleParameter(":ResidentialType"       , OracleType.Int32    , 4  ){ Value = resident.ResidentialType          },
                new OracleParameter(":PermanentType"         , OracleType.Int32    , 4  ){ Value = resident.PermanentType            },
                new OracleParameter(":Registered"            , OracleType.NVarChar , 50 ){ Value = resident.Registered               },
                new OracleParameter(":RegisteredAddress"     , OracleType.NVarChar , 50 ){ Value = resident.RegisteredAddress        },
                new OracleParameter(":Live"                  , OracleType.NVarChar , 50 ){ Value = resident.Live                     },
                new OracleParameter(":LiveAddress"           , OracleType.NVarChar , 50 ){ Value = resident.LiveAddress              },
                new OracleParameter(":InputtingInstitutions" , OracleType.Int32    , 4  ){ Value = resident.InputtingInstitutions.Id },
                new OracleParameter(":InputtingPerson"       , OracleType.NVarChar , 50 ){ Value = resident.InputtingPerson          },
                new OracleParameter(":InputtingTime"         , OracleType.DateTime , 8  ){ Value = resident.InputtingTime            },
                new OracleParameter(":ResponsibleDoctor"     , OracleType.NVarChar , 50 ){ Value = resident.ResponsibleDoctor        },
                new OracleParameter(":ManagementStatus"      , OracleType.Int32    , 4  ){ Value = resident.ManagementStatus         },
                new OracleParameter(":EnableTime"            , OracleType.DateTime , 8  ){ Value = resident.EnableTime               },
                new OracleParameter(":FocusOn"               , OracleType.Int16    , 2  ){ Value = resident.FocusOn                  },
                new OracleParameter(":RHNegative"            , OracleType.Int16    , 2  ){ Value = resident.RHNegative               },
                new OracleParameter(":Remarks"               , OracleType.NVarChar , 200){ Value = resident.Remarks                  },
                new OracleParameter(":Id"                    , OracleType.Int32    , 4  ){ Value = resident.Id                       }
            };
            return SFL.OracleHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ���ݾ���Resident�����������Զ���ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">����Resident�����������Զ���ţ�Id����</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM \"Resident\"" 
                           + "WHERE \"Id\"=:Id";
            OracleParameter[] parameters = 
            {
                new OracleParameter(":Id" , OracleType.Int32 , 4){ Value = id }
            };
            return SFL.OracleHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ���ݾ���Resident�����������Զ���ţ�Id���������ݿ��л�ȡ����Resident����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�����¾���Resident����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">����Resident�����������Զ���ţ�Id����</param>
        public override Resident GetDataById(int id)
        {
            Resident resident = null;
            string sqlText = "SELECT \"Id\",\"ResidentId\",\"Name\",\"IdNumber\",\"Sex\",\"Phone\",\"DateOfBirth\",\"Nation\",\"ContactName\",\"ContactPhone\",\"Education\",\"BloodType\",\"Professional\","
                           + "\"WorkUnits\",\"Payment\",\"FamilyId\",\"MaritalStatus\",\"Children\",\"FathersName\",\"MotherName\",\"GuardiansName\",\"GuardianPhone\",\"CrowdType\",\"ResidentialType\","
                           + "\"PermanentType\",\"Registered\",\"RegisteredAddress\",\"Live\",\"LiveAddress\",\"InputtingInstitutions\",\"InputtingPerson\",\"InputtingTime\",\"ResponsibleDoctor\","
                           + "\"ManagementStatus\",\"EnableTime\",\"FocusOn\",\"RHNegative\",\"Remarks\" "
                           + "FROM \"Resident\" "
                           + "WHERE \"Id\"=:Id";
            OracleParameter[] parameters = 
            {
                new OracleParameter(":Id" , OracleType.Int32 , 4){ Value = id }
            };

            OracleDataReader oracleDataReader = SFL.OracleHelper.ExecuteReader(sqlText, parameters);
            if (oracleDataReader.Read())
            {
                resident = new Resident();
                ReadResidentAllData(oracleDataReader,resident);
            }
            oracleDataReader.Close();
            return resident;
        }


        /// <summary>
        /// �����ݿ��ж�ȡ���������о���Resident��List�б�
        /// </summary>
        public override List<Resident> GetAllList()
        {
            string sqlText = "SELECT \"Id\",\"ResidentId\",\"Name\",\"IdNumber\",\"Sex\",\"Phone\",\"DateOfBirth\",\"Nation\",\"ContactName\",\"ContactPhone\",\"Education\",\"BloodType\",\"Professional\","
                           + "\"WorkUnits\",\"Payment\",\"FamilyId\",\"MaritalStatus\",\"Children\",\"FathersName\",\"MotherName\",\"GuardiansName\",\"GuardianPhone\",\"CrowdType\",\"ResidentialType\","
                           + "\"PermanentType\",\"Registered\",\"RegisteredAddress\",\"Live\",\"LiveAddress\",\"InputtingInstitutions\",\"InputtingPerson\",\"InputtingTime\",\"ResponsibleDoctor\","
                           + "\"ManagementStatus\",\"EnableTime\",\"FocusOn\",\"RHNegative\",\"Remarks\" "
                           + "FROM \"Resident\"";
            List<Resident> list = new List<Resident>();
            OracleDataReader oracleDataReader = SFL.OracleHelper.ExecuteReader(sqlText, null);
            while (oracleDataReader.Read())
            {
                Resident resident = new Resident();
                ReadResidentAllData(oracleDataReader, resident);
                list.Add(resident);
            }
            oracleDataReader.Close();
            return list;
        }


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ��ľ���Resident�����б���ҳ��Ϣ��
        /// �÷�������ȡ�ľ���Resident���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
        /// </summary>
        public override PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "SELECT \"Id\",\"ResidentId\",\"Name\",\"IdNumber\",\"Sex\",\"FamilyId\",\"InputtingInstitutions\",\"InputtingPerson\",\"InputtingTime\",\"ResponsibleDoctor\","
                           + "\"ManagementStatus\",\"EnableTime\" "
                           + "FROM \"Resident\"";
            List<Resident> list = new List<Resident>();
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
                    Resident resident = new Resident();
                    ReadResidentPageData(oracleDataReader, resident);
                    list.Add(resident);
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
