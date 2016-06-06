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
    /// �������ƣ��ִ潡�������SQL Server���ݷ������ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ���ִ潡��������ࣨҵ���߼��㣩�����SQL Server�ġ���ɾ�Ĳ顱�ȸ������ݷ��ʷ������̳�ͨ�����ݷ��ʸ��ࡣ
    /// ����˵����ͨ������Ҫֱ��ʵ�������࣬��ʹ�á��ִ潡��������ࣨҵ���߼��㣩���е�DataAccess���������ñ�����ʵ�ֵķ�����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:01:17
    /// </summary>
    public class MajorProblemsDAL:DAL.Common.MajorProblemsDAL
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬ʵ���˸����ж���ĳ��󷽷����벻Ҫֱ���޸ĸ������е��κδ��룬   
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>
        /// ���ִ潡�������MajorProblems�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="majorProblems">�ִ潡�������MajorProblems��ʵ������</param>
        public override int Insert(MajorProblems majorProblems)
        {
            string sqlText = "INSERT INTO [MajorProblems]"
                           + "([CheckId],[CerebrovascularDiseaseId],[KidneyDiseaseId],[HeartDiseaseId],[VascularDiseaseId],[EyeDiseaseId],"
                           + "[DiseasesOfTheNervousSystem],[OtherSystemDiseases],[HospitalizationIs],[MainMedications],[IPVHistory],[HealthAssessment],[Guidance],[RiskControlSuggestions])"
                           + "VALUES"
                           + "(@CheckId,@CerebrovascularDiseaseId,@KidneyDiseaseId,@HeartDiseaseId,@VascularDiseaseId,@EyeDiseaseId,"
                           + "@DiseasesOfTheNervousSystem,@OtherSystemDiseases,@HospitalizationIs,@MainMedications,@IPVHistory,@HealthAssessment,@Guidance,@RiskControlSuggestions)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@CheckId"                    , SqlDbType.Int      , 4 ){ Value = majorProblems.CheckId                    },
                new SqlParameter("@CerebrovascularDiseaseId"   , SqlDbType.Int      , 4 ){ Value = majorProblems.CerebrovascularDisease.Id     },
                new SqlParameter("@KidneyDiseaseId"            , SqlDbType.Int      , 4 ){ Value = majorProblems.KidneyDisease.Id              },
                new SqlParameter("@HeartDiseaseId"             , SqlDbType.Int      , 4 ){ Value = majorProblems.HeartDisease.Id               },
                new SqlParameter("@VascularDiseaseId"          , SqlDbType.Int      , 4 ){ Value = majorProblems.VascularDisease.Id            },
                new SqlParameter("@EyeDiseaseId"               , SqlDbType.Int      , 4 ){ Value = majorProblems.EyeDisease.Id                 },
                new SqlParameter("@DiseasesOfTheNervousSystem" , SqlDbType.NVarChar , 50){ Value = majorProblems.DiseasesOfTheNervousSystem },
                new SqlParameter("@OtherSystemDiseases"        , SqlDbType.NVarChar , 50){ Value = majorProblems.OtherSystemDiseases        },
                new SqlParameter("@HospitalizationIs"          , SqlDbType.NVarChar , 50){ Value = majorProblems.HospitalizationIs          },
                new SqlParameter("@MainMedications"            , SqlDbType.NVarChar , 50){ Value = majorProblems.MainMedications            },
                new SqlParameter("@IPVHistory"                 , SqlDbType.NVarChar , 50){ Value = majorProblems.IPVHistory                 },
                new SqlParameter("@HealthAssessment"           , SqlDbType.NVarChar , 50){ Value = majorProblems.HealthAssessment           },
                new SqlParameter("@Guidance"                   , SqlDbType.NVarChar , 50){ Value = majorProblems.Guidance                   },
                new SqlParameter("@RiskControlSuggestions"     , SqlDbType.NVarChar , 50){ Value = majorProblems.RiskControlSuggestions     }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ���ִ潡�������MajorProblems�����ݣ���������������ţ�CheckId��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="majorProblems">�ִ潡�������MajorProblems��ʵ������</param>
        public override int Update(MajorProblems majorProblems)
        {
            string sqlText = "UPDATE [MajorProblems] SET "
                           + "[CerebrovascularDiseaseId]=@CerebrovascularDiseaseId,[KidneyDiseaseId]=@KidneyDiseaseId,[HeartDiseaseId]=@HeartDiseaseId,"
                           + "[VascularDiseaseId]=@VascularDiseaseId,[EyeDiseaseId]=@EyeDiseaseId,[DiseasesOfTheNervousSystem]=@DiseasesOfTheNervousSystem,"
                           + "[OtherSystemDiseases]=@OtherSystemDiseases,[HospitalizationIs]=@HospitalizationIs,[MainMedications]=@MainMedications,[IPVHistory]=@IPVHistory,"
                           + "[HealthAssessment]=@HealthAssessment,[Guidance]=@Guidance,[RiskControlSuggestions]=@RiskControlSuggestions "
                           + "WHERE [CheckId]=@CheckId";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@CerebrovascularDiseaseId"   , SqlDbType.Int      , 4 ){ Value = majorProblems.CerebrovascularDisease.Id     },
                new SqlParameter("@KidneyDiseaseId"            , SqlDbType.Int      , 4 ){ Value = majorProblems.KidneyDisease.Id              },
                new SqlParameter("@HeartDiseaseId"             , SqlDbType.Int      , 4 ){ Value = majorProblems.HeartDisease.Id               },
                new SqlParameter("@VascularDiseaseId"          , SqlDbType.Int      , 4 ){ Value = majorProblems.VascularDisease.Id            },
                new SqlParameter("@EyeDiseaseId"               , SqlDbType.Int      , 4 ){ Value = majorProblems.EyeDisease.Id                 },
                new SqlParameter("@DiseasesOfTheNervousSystem" , SqlDbType.NVarChar , 50){ Value = majorProblems.DiseasesOfTheNervousSystem },
                new SqlParameter("@OtherSystemDiseases"        , SqlDbType.NVarChar , 50){ Value = majorProblems.OtherSystemDiseases        },
                new SqlParameter("@HospitalizationIs"          , SqlDbType.NVarChar , 50){ Value = majorProblems.HospitalizationIs          },
                new SqlParameter("@MainMedications"            , SqlDbType.NVarChar , 50){ Value = majorProblems.MainMedications            },
                new SqlParameter("@IPVHistory"                 , SqlDbType.NVarChar , 50){ Value = majorProblems.IPVHistory                 },
                new SqlParameter("@HealthAssessment"           , SqlDbType.NVarChar , 50){ Value = majorProblems.HealthAssessment           },
                new SqlParameter("@Guidance"                   , SqlDbType.NVarChar , 50){ Value = majorProblems.Guidance                   },
                new SqlParameter("@RiskControlSuggestions"     , SqlDbType.NVarChar , 50){ Value = majorProblems.RiskControlSuggestions     },
                new SqlParameter("@CheckId"                    , SqlDbType.Int      , 4 ){ Value = majorProblems.CheckId                    }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// �����ִ潡�������MajorProblems��������������ţ�CheckId��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="checkId">�ִ潡�������MajorProblems��������������ţ�CheckId����</param>
        public override int Delete(int checkId)
        {
            string sqlText = "DELETE FROM [MajorProblems] "
                           + "WHERE [CheckId]=@CheckId";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@CheckId" , SqlDbType.Int , 4){ Value = checkId }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// �����ִ潡�������MajorProblems��������������ţ�CheckId���������ݿ��л�ȡ�ִ潡�������MajorProblems����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�������ִ潡�������MajorProblems����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="checkId">�ִ潡�������MajorProblems��������������ţ�CheckId����</param>
        public override MajorProblems GetDataByCheckId(int checkId)
        {
            MajorProblems majorProblems = null;
            string sqlText = "SELECT [CheckId],[CerebrovascularDiseaseId],[KidneyDiseaseId],[HeartDiseaseId],[VascularDiseaseId],[EyeDiseaseId],"
                           + "[DiseasesOfTheNervousSystem],[OtherSystemDiseases],[HospitalizationIs],[MainMedications],[IPVHistory],[HealthAssessment],[Guidance],[RiskControlSuggestions] "
                           + "FROM [MajorProblems] "
                           + "WHERE [CheckId]=@CheckId";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@CheckId" , SqlDbType.Int , 4){ Value = checkId }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                majorProblems = new MajorProblems();
                ReadMajorProblemsAllData(sqlDataReader,majorProblems);
            }
            sqlDataReader.Close();
            return majorProblems;
        }


        /// <summary>
        /// �����ݿ��ж�ȡ�����������ִ潡�������MajorProblems��List�б�
        /// </summary>
        public override List<MajorProblems> GetAllList()
        {
            string sqlText = "SELECT [CheckId],[CerebrovascularDiseaseId],[KidneyDiseaseId],[HeartDiseaseId],[VascularDiseaseId],[EyeDiseaseId],"
                           + "[DiseasesOfTheNervousSystem],[OtherSystemDiseases],[HospitalizationIs],[MainMedications],[IPVHistory],[HealthAssessment],[Guidance],[RiskControlSuggestions] "
                           + "FROM [MajorProblems]";
            List<MajorProblems> list = new List<MajorProblems>();
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, null);
            while (sqlDataReader.Read())
            {
                MajorProblems majorProblems = new MajorProblems();
                ReadMajorProblemsAllData(sqlDataReader, majorProblems);
                list.Add(majorProblems);
            }
            sqlDataReader.Close();
            return list;
        }


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ����ִ潡�������MajorProblems�����б���ҳ��Ϣ��
        /// �÷�������ȡ���ִ潡�������MajorProblems���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
        /// </summary>
        public override PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "SELECT [CheckId],[HealthAssessment],[RiskControlSuggestions] "
                           + "FROM [MajorProblems]";
            List<MajorProblems> list = new List<MajorProblems>();
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
                    MajorProblems majorProblems = new MajorProblems();
                    ReadMajorProblemsPageData(sqlDataReader, majorProblems);
                    list.Add(majorProblems);
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
