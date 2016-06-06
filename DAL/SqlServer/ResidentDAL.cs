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
    /// 对象名称：居民SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“居民类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“居民类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 16:41:14
    /// </summary>
    public class ResidentDAL:DAL.Common.ResidentDAL
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将居民（Resident）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="resident">居民（Resident）实例对象</param>
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
        /// 将居民（Resident）数据，根据主键“自动编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="resident">居民（Resident）实例对象</param>
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
        /// 根据居民（Resident）的主键“自动编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">居民（Resident）的主键“自动编号（Id）”</param>
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
        /// 根据居民（Resident）的主键“自动编号（Id）”从数据库中获取居民（Resident）的实例。
        /// 成功从数据库中取得记录返回新居民（Resident）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">居民（Resident）的主键“自动编号（Id）”</param>
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
        /// 从数据库中读取并返回所有居民（Resident）List列表。
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
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的居民（Resident）的列表及分页信息。
        /// 该方法所获取的居民（Resident）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
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

        #endregion 多层框架式下的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，请先在本类的父类中对相关抽象方法进行定义，再在本类中进行具体实现。
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
