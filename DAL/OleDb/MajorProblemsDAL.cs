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
    /// 对象名称：现存健康问题表OleDb数据访问子类（数据访问层）
    /// 对象说明：提供“现存健康问题表类（业务逻辑层）”针对OleDb的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“现存健康问题表类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 17:01:17
    /// </summary>
    public class MajorProblemsDAL:DAL.Common.MajorProblemsDAL
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将现存健康问题表（MajorProblems）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="majorProblems">现存健康问题表（MajorProblems）实例对象</param>
        public override int Insert(MajorProblems majorProblems)
        {
            string sqlText = "INSERT INTO [MajorProblems]"
                           + "([CheckId],[CerebrovascularDiseaseId],[KidneyDiseaseId],[HeartDiseaseId],[VascularDiseaseId],[EyeDiseaseId],"
                           + "[DiseasesOfTheNervousSystem],[OtherSystemDiseases],[HospitalizationIs],[MainMedications],[IPVHistory],[HealthAssessment],[Guidance],[RiskControlSuggestions])"
                           + "VALUES"
                           + "(@CheckId,@CerebrovascularDiseaseId,@KidneyDiseaseId,@HeartDiseaseId,@VascularDiseaseId,@EyeDiseaseId,"
                           + "@DiseasesOfTheNervousSystem,@OtherSystemDiseases,@HospitalizationIs,@MainMedications,@IPVHistory,@HealthAssessment,@Guidance,@RiskControlSuggestions)";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@CheckId"                    , OleDbType.Integer  , 4 ){ Value = majorProblems.CheckId                    },
                new OleDbParameter("@CerebrovascularDiseaseId"   , OleDbType.Integer  , 4 ){ Value = majorProblems.CerebrovascularDisease     },
                new OleDbParameter("@KidneyDiseaseId"            , OleDbType.Integer  , 4 ){ Value = majorProblems.KidneyDisease              },
                new OleDbParameter("@HeartDiseaseId"             , OleDbType.Integer  , 4 ){ Value = majorProblems.HeartDisease               },
                new OleDbParameter("@VascularDiseaseId"          , OleDbType.Integer  , 4 ){ Value = majorProblems.VascularDisease            },
                new OleDbParameter("@EyeDiseaseId"               , OleDbType.Integer  , 4 ){ Value = majorProblems.EyeDisease                 },
                new OleDbParameter("@DiseasesOfTheNervousSystem" , OleDbType.VarWChar , 50){ Value = majorProblems.DiseasesOfTheNervousSystem },
                new OleDbParameter("@OtherSystemDiseases"        , OleDbType.VarWChar , 50){ Value = majorProblems.OtherSystemDiseases        },
                new OleDbParameter("@HospitalizationIs"          , OleDbType.VarWChar , 50){ Value = majorProblems.HospitalizationIs          },
                new OleDbParameter("@MainMedications"            , OleDbType.VarWChar , 50){ Value = majorProblems.MainMedications            },
                new OleDbParameter("@IPVHistory"                 , OleDbType.VarWChar , 50){ Value = majorProblems.IPVHistory                 },
                new OleDbParameter("@HealthAssessment"           , OleDbType.VarWChar , 50){ Value = majorProblems.HealthAssessment           },
                new OleDbParameter("@Guidance"                   , OleDbType.VarWChar , 50){ Value = majorProblems.Guidance                   },
                new OleDbParameter("@RiskControlSuggestions"     , OleDbType.VarWChar , 50){ Value = majorProblems.RiskControlSuggestions     }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将现存健康问题表（MajorProblems）数据，根据主键“体检编号（CheckId）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="majorProblems">现存健康问题表（MajorProblems）实例对象</param>
        public override int Update(MajorProblems majorProblems)
        {
            string sqlText = "UPDATE [MajorProblems] SET "
                           + "[CerebrovascularDiseaseId]=@CerebrovascularDiseaseId,[KidneyDiseaseId]=@KidneyDiseaseId,[HeartDiseaseId]=@HeartDiseaseId,"
                           + "[VascularDiseaseId]=@VascularDiseaseId,[EyeDiseaseId]=@EyeDiseaseId,[DiseasesOfTheNervousSystem]=@DiseasesOfTheNervousSystem,"
                           + "[OtherSystemDiseases]=@OtherSystemDiseases,[HospitalizationIs]=@HospitalizationIs,[MainMedications]=@MainMedications,[IPVHistory]=@IPVHistory,"
                           + "[HealthAssessment]=@HealthAssessment,[Guidance]=@Guidance,[RiskControlSuggestions]=@RiskControlSuggestions "
                           + "WHERE [CheckId]=@CheckId";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@CerebrovascularDiseaseId"   , OleDbType.Integer  , 4 ){ Value = majorProblems.CerebrovascularDisease     },
                new OleDbParameter("@KidneyDiseaseId"            , OleDbType.Integer  , 4 ){ Value = majorProblems.KidneyDisease              },
                new OleDbParameter("@HeartDiseaseId"             , OleDbType.Integer  , 4 ){ Value = majorProblems.HeartDisease               },
                new OleDbParameter("@VascularDiseaseId"          , OleDbType.Integer  , 4 ){ Value = majorProblems.VascularDisease            },
                new OleDbParameter("@EyeDiseaseId"               , OleDbType.Integer  , 4 ){ Value = majorProblems.EyeDisease                 },
                new OleDbParameter("@DiseasesOfTheNervousSystem" , OleDbType.VarWChar , 50){ Value = majorProblems.DiseasesOfTheNervousSystem },
                new OleDbParameter("@OtherSystemDiseases"        , OleDbType.VarWChar , 50){ Value = majorProblems.OtherSystemDiseases        },
                new OleDbParameter("@HospitalizationIs"          , OleDbType.VarWChar , 50){ Value = majorProblems.HospitalizationIs          },
                new OleDbParameter("@MainMedications"            , OleDbType.VarWChar , 50){ Value = majorProblems.MainMedications            },
                new OleDbParameter("@IPVHistory"                 , OleDbType.VarWChar , 50){ Value = majorProblems.IPVHistory                 },
                new OleDbParameter("@HealthAssessment"           , OleDbType.VarWChar , 50){ Value = majorProblems.HealthAssessment           },
                new OleDbParameter("@Guidance"                   , OleDbType.VarWChar , 50){ Value = majorProblems.Guidance                   },
                new OleDbParameter("@RiskControlSuggestions"     , OleDbType.VarWChar , 50){ Value = majorProblems.RiskControlSuggestions     },
                new OleDbParameter("@CheckId"                    , OleDbType.Integer  , 4 ){ Value = majorProblems.CheckId                    }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据现存健康问题表（MajorProblems）的主键“体检编号（CheckId）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="checkId">现存健康问题表（MajorProblems）的主键“体检编号（CheckId）”</param>
        public override int Delete(int checkId)
        {
            string sqlText = "DELETE FROM [MajorProblems] "
                           + "WHERE [CheckId]=@CheckId";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@CheckId" , OleDbType.Integer , 4){ Value = checkId }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据现存健康问题表（MajorProblems）的主键“体检编号（CheckId）”从数据库中获取现存健康问题表（MajorProblems）的实例。
        /// 成功从数据库中取得记录返回新现存健康问题表（MajorProblems）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="checkId">现存健康问题表（MajorProblems）的主键“体检编号（CheckId）”</param>
        public override MajorProblems GetDataByCheckId(int checkId)
        {
            MajorProblems majorProblems = null;
            string sqlText = "SELECT [CheckId],[CerebrovascularDiseaseId],[KidneyDiseaseId],[HeartDiseaseId],[VascularDiseaseId],[EyeDiseaseId],"
                           + "[DiseasesOfTheNervousSystem],[OtherSystemDiseases],[HospitalizationIs],[MainMedications],[IPVHistory],[HealthAssessment],[Guidance],[RiskControlSuggestions] "
                           + "FROM [MajorProblems] "
                           + "WHERE [CheckId]=@CheckId";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@CheckId" , OleDbType.Integer , 4){ Value = checkId }
            };

            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, parameters);
            if (oleDbDataReader.Read())
            {
                majorProblems = new MajorProblems();
                ReadMajorProblemsAllData(oleDbDataReader,majorProblems);
            }
            oleDbDataReader.Close();
            return majorProblems;
        }


        /// <summary>
        /// 从数据库中读取并返回所有现存健康问题表（MajorProblems）List列表。
        /// </summary>
        public override List<MajorProblems> GetAllList()
        {
            string sqlText = "SELECT [CheckId],[CerebrovascularDiseaseId],[KidneyDiseaseId],[HeartDiseaseId],[VascularDiseaseId],[EyeDiseaseId],"
                           + "[DiseasesOfTheNervousSystem],[OtherSystemDiseases],[HospitalizationIs],[MainMedications],[IPVHistory],[HealthAssessment],[Guidance],[RiskControlSuggestions] "
                           + "FROM [MajorProblems]";
            List<MajorProblems> list = new List<MajorProblems>();
            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, null);
            while (oleDbDataReader.Read())
            {
                MajorProblems majorProblems = new MajorProblems();
                ReadMajorProblemsAllData(oleDbDataReader, majorProblems);
                list.Add(majorProblems);
            }
            oleDbDataReader.Close();
            return list;
        }


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的现存健康问题表（MajorProblems）的列表及分页信息。
        /// 该方法所获取的现存健康问题表（MajorProblems）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public override PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "SELECT [CheckId],[HealthAssessment],[RiskControlSuggestions] "
                           + "FROM [MajorProblems]";
            List<MajorProblems> list = new List<MajorProblems>();
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
                    MajorProblems majorProblems = new MajorProblems();
                    ReadMajorProblemsPageData(oleDbDataReader, majorProblems);
                    list.Add(majorProblems);
                }
            }
            oleDbDataReader.Close();

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
