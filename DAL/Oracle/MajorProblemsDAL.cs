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
    /// �������ƣ��ִ潡�������Oracle���ݷ������ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ���ִ潡��������ࣨҵ���߼��㣩�����Oracle�ġ���ɾ�Ĳ顱�ȸ������ݷ��ʷ������̳�ͨ�����ݷ��ʸ��ࡣ
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
            string sqlText = "INSERT INTO \"MajorProblems\""
                           + "(\"CheckId\",\"CerebrovascularDiseaseId\",\"KidneyDiseaseId\",\"HeartDiseaseId\",\"VascularDiseaseId\",\"EyeDiseaseId\","
                           + "\"DiseasesOfTheNervousSystem\",\"OtherSystemDiseases\",\"HospitalizationIs\",\"MainMedications\",\"IPVHistory\",\"HealthAssessment\",\"Guidance\",\"RiskControlSuggestions\")"
                           + "VALUES"
                           + "(:CheckId,:CerebrovascularDiseaseId,:KidneyDiseaseId,:HeartDiseaseId,:VascularDiseaseId,:EyeDiseaseId,"
                           + ":DiseasesOfTheNervousSystem,:OtherSystemDiseases,:HospitalizationIs,:MainMedications,:IPVHistory,:HealthAssessment,:Guidance,:RiskControlSuggestions)";
            OracleParameter[] parameters = 
            {
                new OracleParameter(":CheckId"                    , OracleType.Int32    , 4 ){ Value = majorProblems.CheckId                    },
                new OracleParameter(":CerebrovascularDiseaseId"   , OracleType.Int32    , 4 ){ Value = majorProblems.CerebrovascularDisease     },
                new OracleParameter(":KidneyDiseaseId"            , OracleType.Int32    , 4 ){ Value = majorProblems.KidneyDisease              },
                new OracleParameter(":HeartDiseaseId"             , OracleType.Int32    , 4 ){ Value = majorProblems.HeartDisease               },
                new OracleParameter(":VascularDiseaseId"          , OracleType.Int32    , 4 ){ Value = majorProblems.VascularDisease            },
                new OracleParameter(":EyeDiseaseId"               , OracleType.Int32    , 4 ){ Value = majorProblems.EyeDisease                 },
                new OracleParameter(":DiseasesOfTheNervousSystem" , OracleType.NVarChar , 50){ Value = majorProblems.DiseasesOfTheNervousSystem },
                new OracleParameter(":OtherSystemDiseases"        , OracleType.NVarChar , 50){ Value = majorProblems.OtherSystemDiseases        },
                new OracleParameter(":HospitalizationIs"          , OracleType.NVarChar , 50){ Value = majorProblems.HospitalizationIs          },
                new OracleParameter(":MainMedications"            , OracleType.NVarChar , 50){ Value = majorProblems.MainMedications            },
                new OracleParameter(":IPVHistory"                 , OracleType.NVarChar , 50){ Value = majorProblems.IPVHistory                 },
                new OracleParameter(":HealthAssessment"           , OracleType.NVarChar , 50){ Value = majorProblems.HealthAssessment           },
                new OracleParameter(":Guidance"                   , OracleType.NVarChar , 50){ Value = majorProblems.Guidance                   },
                new OracleParameter(":RiskControlSuggestions"     , OracleType.NVarChar , 50){ Value = majorProblems.RiskControlSuggestions     }
            };
            return SFL.OracleHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ���ִ潡�������MajorProblems�����ݣ���������������ţ�CheckId��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="majorProblems">�ִ潡�������MajorProblems��ʵ������</param>
        public override int Update(MajorProblems majorProblems)
        {
            string sqlText = "UPDATE \"MajorProblems\" SET "
                           + "\"CheckId\"=:CheckId,\"CerebrovascularDiseaseId\"=:CerebrovascularDiseaseId,\"KidneyDiseaseId\"=:KidneyDiseaseId,"
                           + "\"HeartDiseaseId\"=:HeartDiseaseId,\"VascularDiseaseId\"=:VascularDiseaseId,\"EyeDiseaseId\"=:EyeDiseaseId,\"DiseasesOfTheNervousSystem\"=:DiseasesOfTheNervousSystem,"
                           + "\"OtherSystemDiseases\"=:OtherSystemDiseases,\"HospitalizationIs\"=:HospitalizationIs,\"MainMedications\"=:MainMedications,\"IPVHistory\"=:IPVHistory,"
                           + "\"HealthAssessment\"=:HealthAssessment,\"Guidance\"=:Guidance,\"RiskControlSuggestions\"=:RiskControlSuggestions "
                           + "WHERE \"CheckId\"=:CheckId";
            OracleParameter[] parameters = 
            {
                new OracleParameter(":CheckId"                    , OracleType.Int32    , 4 ){ Value = majorProblems.CheckId                    },
                new OracleParameter(":CerebrovascularDiseaseId"   , OracleType.Int32    , 4 ){ Value = majorProblems.CerebrovascularDisease     },
                new OracleParameter(":KidneyDiseaseId"            , OracleType.Int32    , 4 ){ Value = majorProblems.KidneyDisease              },
                new OracleParameter(":HeartDiseaseId"             , OracleType.Int32    , 4 ){ Value = majorProblems.HeartDisease               },
                new OracleParameter(":VascularDiseaseId"          , OracleType.Int32    , 4 ){ Value = majorProblems.VascularDisease            },
                new OracleParameter(":EyeDiseaseId"               , OracleType.Int32    , 4 ){ Value = majorProblems.EyeDisease                 },
                new OracleParameter(":DiseasesOfTheNervousSystem" , OracleType.NVarChar , 50){ Value = majorProblems.DiseasesOfTheNervousSystem },
                new OracleParameter(":OtherSystemDiseases"        , OracleType.NVarChar , 50){ Value = majorProblems.OtherSystemDiseases        },
                new OracleParameter(":HospitalizationIs"          , OracleType.NVarChar , 50){ Value = majorProblems.HospitalizationIs          },
                new OracleParameter(":MainMedications"            , OracleType.NVarChar , 50){ Value = majorProblems.MainMedications            },
                new OracleParameter(":IPVHistory"                 , OracleType.NVarChar , 50){ Value = majorProblems.IPVHistory                 },
                new OracleParameter(":HealthAssessment"           , OracleType.NVarChar , 50){ Value = majorProblems.HealthAssessment           },
                new OracleParameter(":Guidance"                   , OracleType.NVarChar , 50){ Value = majorProblems.Guidance                   },
                new OracleParameter(":RiskControlSuggestions"     , OracleType.NVarChar , 50){ Value = majorProblems.RiskControlSuggestions     },
                new OracleParameter(":CheckId"                    , OracleType.Int32    , 4 ){ Value = majorProblems.CheckId                    }
            };
            return SFL.OracleHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// �����ִ潡�������MajorProblems��������������ţ�CheckId��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="checkId">�ִ潡�������MajorProblems��������������ţ�CheckId����</param>
        public override int Delete(int checkId)
        {
            string sqlText = "DELETE FROM \"MajorProblems\"" 
                           + "WHERE \"CheckId\"=:CheckId";
            OracleParameter[] parameters = 
            {
                new OracleParameter(":CheckId" , OracleType.Int32 , 4){ Value = checkId }
            };
            return SFL.OracleHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// �����ִ潡�������MajorProblems��������������ţ�CheckId���������ݿ��л�ȡ�ִ潡�������MajorProblems����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�������ִ潡�������MajorProblems����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="checkId">�ִ潡�������MajorProblems��������������ţ�CheckId����</param>
        public override MajorProblems GetDataByCheckId(int checkId)
        {
            MajorProblems majorProblems = null;
            string sqlText = "SELECT \"CheckId\",\"CerebrovascularDiseaseId\",\"KidneyDiseaseId\",\"HeartDiseaseId\",\"VascularDiseaseId\",\"EyeDiseaseId\","
                           + "\"DiseasesOfTheNervousSystem\",\"OtherSystemDiseases\",\"HospitalizationIs\",\"MainMedications\",\"IPVHistory\",\"HealthAssessment\",\"Guidance\",\"RiskControlSuggestions\" "
                           + "FROM \"MajorProblems\" "
                           + "WHERE \"CheckId\"=:CheckId";
            OracleParameter[] parameters = 
            {
                new OracleParameter(":CheckId" , OracleType.Int32 , 4){ Value = checkId }
            };

            OracleDataReader oracleDataReader = SFL.OracleHelper.ExecuteReader(sqlText, parameters);
            if (oracleDataReader.Read())
            {
                majorProblems = new MajorProblems();
                ReadMajorProblemsAllData(oracleDataReader,majorProblems);
            }
            oracleDataReader.Close();
            return majorProblems;
        }


        /// <summary>
        /// �����ݿ��ж�ȡ�����������ִ潡�������MajorProblems��List�б�
        /// </summary>
        public override List<MajorProblems> GetAllList()
        {
            string sqlText = "SELECT \"CheckId\",\"CerebrovascularDiseaseId\",\"KidneyDiseaseId\",\"HeartDiseaseId\",\"VascularDiseaseId\",\"EyeDiseaseId\","
                           + "\"DiseasesOfTheNervousSystem\",\"OtherSystemDiseases\",\"HospitalizationIs\",\"MainMedications\",\"IPVHistory\",\"HealthAssessment\",\"Guidance\",\"RiskControlSuggestions\" "
                           + "FROM \"MajorProblems\"";
            List<MajorProblems> list = new List<MajorProblems>();
            OracleDataReader oracleDataReader = SFL.OracleHelper.ExecuteReader(sqlText, null);
            while (oracleDataReader.Read())
            {
                MajorProblems majorProblems = new MajorProblems();
                ReadMajorProblemsAllData(oracleDataReader, majorProblems);
                list.Add(majorProblems);
            }
            oracleDataReader.Close();
            return list;
        }


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ����ִ潡�������MajorProblems�����б���ҳ��Ϣ��
        /// �÷�������ȡ���ִ潡�������MajorProblems���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
        /// </summary>
        public override PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "SELECT \"CheckId\",\"HealthAssessment\",\"RiskControlSuggestions\" "
                           + "FROM \"MajorProblems\"";
            List<MajorProblems> list = new List<MajorProblems>();
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
                    MajorProblems majorProblems = new MajorProblems();
                    ReadMajorProblemsPageData(oracleDataReader, majorProblems);
                    list.Add(majorProblems);
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
