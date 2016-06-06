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
    /// �������ƣ��߼�����SQL Server���ݷ������ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ���߼������ࣨҵ���߼��㣩�����SQL Server�ġ���ɾ�Ĳ顱�ȸ������ݷ��ʷ������̳�ͨ�����ݷ��ʸ��ࡣ
    /// ����˵����ͨ������Ҫֱ��ʵ�������࣬��ʹ�á��߼������ࣨҵ���߼��㣩���е�DataAccess���������ñ�����ʵ�ֵķ�����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:12:40
    /// </summary>
    public class AdvancedExaminationDAL:DAL.Common.AdvancedExaminationDAL
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬ʵ���˸����ж���ĳ��󷽷����벻Ҫֱ���޸ĸ������е��κδ��룬   
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>
        /// ���߼�����AdvancedExamination�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="advancedExamination">�߼�����AdvancedExamination��ʵ������</param>
        public override int Insert(AdvancedExamination advancedExamination)
        {
            string sqlText = "INSERT INTO [AdvancedExamination]"
                           + "([Id],[Oral],[LeftEye],[RightEye],[Hearing],[FMA],[Fundus],[Skin],[Sclera],[LN],[Lung],[Heart],[Abdomen],[LowerExtremityEdema],[DPAP],[Dre],[FBG],[CBCId],"
                           + "[RoutineUrineId],[U_MTB],[LiverId],[RenalId],[TGId],[GHb],[HBsAG],[ECG],[XRay],[BUltrasonic],[CervicalSmear],[Other],[Physical],[Guidance])"
                           + "VALUES"
                           + "(@Id,@Oral,@LeftEye,@RightEye,@Hearing,@FMA,@Fundus,@Skin,@Sclera,@LN,@Lung,@Heart,@Abdomen,@LowerExtremityEdema,@DPAP,@Dre,@FBG,@CBCId,"
                           + "@RoutineUrineId,@U_MTB,@LiverId,@RenalId,@TGId,@GHb,@HBsAG,@ECG,@XRay,@BUltrasonic,@CervicalSmear,@Other,@Physical,@Guidance)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id"                  , SqlDbType.Int      , 4 ){ Value = advancedExamination.Id                  },
                new SqlParameter("@Oral"                , SqlDbType.NVarChar , 50){ Value = advancedExamination.Oral                },
                new SqlParameter("@LeftEye"             , SqlDbType.Decimal  , 9 ){ Value = advancedExamination.LeftEye             },
                new SqlParameter("@RightEye"            , SqlDbType.Decimal  , 9 ){ Value = advancedExamination.RightEye            },
                new SqlParameter("@Hearing"             , SqlDbType.NVarChar , 50){ Value = advancedExamination.Hearing             },
                new SqlParameter("@FMA"                 , SqlDbType.NVarChar , 50){ Value = advancedExamination.FMA                 },
                new SqlParameter("@Fundus"              , SqlDbType.NVarChar , 50){ Value = advancedExamination.Fundus              },
                new SqlParameter("@Skin"                , SqlDbType.NVarChar , 50){ Value = advancedExamination.Skin                },
                new SqlParameter("@Sclera"              , SqlDbType.NVarChar , 50){ Value = advancedExamination.Sclera              },
                new SqlParameter("@LN"                  , SqlDbType.NVarChar , 50){ Value = advancedExamination.LN                  },
                new SqlParameter("@Lung"                , SqlDbType.NVarChar , 50){ Value = advancedExamination.Lung                },
                new SqlParameter("@Heart"               , SqlDbType.NVarChar , 50){ Value = advancedExamination.Heart               },
                new SqlParameter("@Abdomen"             , SqlDbType.NVarChar , 50){ Value = advancedExamination.Abdomen             },
                new SqlParameter("@LowerExtremityEdema" , SqlDbType.NVarChar , 50){ Value = advancedExamination.LowerExtremityEdema },
                new SqlParameter("@DPAP"                , SqlDbType.NVarChar , 50){ Value = advancedExamination.DPAP                },
                new SqlParameter("@Dre"                 , SqlDbType.NVarChar , 50){ Value = advancedExamination.Dre                 },
                new SqlParameter("@FBG"                 , SqlDbType.NVarChar , 50){ Value = advancedExamination.FBG                 },
                new SqlParameter("@CBCId"               , SqlDbType.Int      , 4 ){ Value = advancedExamination.CBC.Id                 },
                new SqlParameter("@RoutineUrineId"      , SqlDbType.Int      , 4 ){ Value = advancedExamination.RoutineUrine.Id        },
                new SqlParameter("@U_MTB"               , SqlDbType.NVarChar , 50){ Value = advancedExamination.U_MTB               },
                new SqlParameter("@LiverId"             , SqlDbType.Int      , 4 ){ Value = advancedExamination.Liver.Id               },
                new SqlParameter("@RenalId"             , SqlDbType.Int      , 4 ){ Value = advancedExamination.Renal.Id               },
                new SqlParameter("@TGId"                , SqlDbType.Int      , 4 ){ Value = advancedExamination.TG.Id                  },
                new SqlParameter("@GHb"                 , SqlDbType.NVarChar , 50){ Value = advancedExamination.GHb                 },
                new SqlParameter("@HBsAG"               , SqlDbType.NVarChar , 50){ Value = advancedExamination.HBsAG               },
                new SqlParameter("@ECG"                 , SqlDbType.NVarChar , 50){ Value = advancedExamination.ECG                 },
                new SqlParameter("@XRay"                , SqlDbType.NVarChar , 50){ Value = advancedExamination.XRay                },
                new SqlParameter("@BUltrasonic"         , SqlDbType.NVarChar , 50){ Value = advancedExamination.BUltrasonic         },
                new SqlParameter("@CervicalSmear"       , SqlDbType.NVarChar , 50){ Value = advancedExamination.CervicalSmear       },
                new SqlParameter("@Other"               , SqlDbType.NVarChar , 50){ Value = advancedExamination.Other               },
                new SqlParameter("@Physical"            , SqlDbType.NVarChar , 50){ Value = advancedExamination.Physical            },
                new SqlParameter("@Guidance"            , SqlDbType.NVarChar , 50){ Value = advancedExamination.Guidance            }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ���߼�����AdvancedExamination�����ݣ���������������ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="advancedExamination">�߼�����AdvancedExamination��ʵ������</param>
        public override int Update(AdvancedExamination advancedExamination)
        {
            string sqlText = "UPDATE [AdvancedExamination] SET "
                           + "[Oral]=@Oral,[LeftEye]=@LeftEye,[RightEye]=@RightEye,[Hearing]=@Hearing,[FMA]=@FMA,[Fundus]=@Fundus,[Skin]=@Skin,[Sclera]=@Sclera,"
                           + "[LN]=@LN,[Lung]=@Lung,[Heart]=@Heart,[Abdomen]=@Abdomen,[LowerExtremityEdema]=@LowerExtremityEdema,[DPAP]=@DPAP,[Dre]=@Dre,[FBG]=@FBG,"
                           + "[CBCId]=@CBCId,[RoutineUrineId]=@RoutineUrineId,[U_MTB]=@U_MTB,[LiverId]=@LiverId,[RenalId]=@RenalId,[TGId]=@TGId,[GHb]=@GHb,[HBsAG]=@HBsAG,"
                           + "[ECG]=@ECG,[XRay]=@XRay,[BUltrasonic]=@BUltrasonic,[CervicalSmear]=@CervicalSmear,[Other]=@Other,[Physical]=@Physical,[Guidance]=@Guidance "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Oral"                , SqlDbType.NVarChar , 50){ Value = advancedExamination.Oral                },
                new SqlParameter("@LeftEye"             , SqlDbType.Decimal  , 9 ){ Value = advancedExamination.LeftEye             },
                new SqlParameter("@RightEye"            , SqlDbType.Decimal  , 9 ){ Value = advancedExamination.RightEye            },
                new SqlParameter("@Hearing"             , SqlDbType.NVarChar , 50){ Value = advancedExamination.Hearing             },
                new SqlParameter("@FMA"                 , SqlDbType.NVarChar , 50){ Value = advancedExamination.FMA                 },
                new SqlParameter("@Fundus"              , SqlDbType.NVarChar , 50){ Value = advancedExamination.Fundus              },
                new SqlParameter("@Skin"                , SqlDbType.NVarChar , 50){ Value = advancedExamination.Skin                },
                new SqlParameter("@Sclera"              , SqlDbType.NVarChar , 50){ Value = advancedExamination.Sclera              },
                new SqlParameter("@LN"                  , SqlDbType.NVarChar , 50){ Value = advancedExamination.LN                  },
                new SqlParameter("@Lung"                , SqlDbType.NVarChar , 50){ Value = advancedExamination.Lung                },
                new SqlParameter("@Heart"               , SqlDbType.NVarChar , 50){ Value = advancedExamination.Heart               },
                new SqlParameter("@Abdomen"             , SqlDbType.NVarChar , 50){ Value = advancedExamination.Abdomen             },
                new SqlParameter("@LowerExtremityEdema" , SqlDbType.NVarChar , 50){ Value = advancedExamination.LowerExtremityEdema },
                new SqlParameter("@DPAP"                , SqlDbType.NVarChar , 50){ Value = advancedExamination.DPAP                },
                new SqlParameter("@Dre"                 , SqlDbType.NVarChar , 50){ Value = advancedExamination.Dre                 },
                new SqlParameter("@FBG"                 , SqlDbType.NVarChar , 50){ Value = advancedExamination.FBG                 },
                new SqlParameter("@CBCId"               , SqlDbType.Int      , 4 ){ Value = advancedExamination.CBC.Id                 },
                new SqlParameter("@RoutineUrineId"      , SqlDbType.Int      , 4 ){ Value = advancedExamination.RoutineUrine.Id        },
                new SqlParameter("@U_MTB"               , SqlDbType.NVarChar , 50){ Value = advancedExamination.U_MTB               },
                new SqlParameter("@LiverId"             , SqlDbType.Int      , 4 ){ Value = advancedExamination.Liver.Id               },
                new SqlParameter("@RenalId"             , SqlDbType.Int      , 4 ){ Value = advancedExamination.Renal.Id               },
                new SqlParameter("@TGId"                , SqlDbType.Int      , 4 ){ Value = advancedExamination.TG.Id                  },
                new SqlParameter("@GHb"                 , SqlDbType.NVarChar , 50){ Value = advancedExamination.GHb                 },
                new SqlParameter("@HBsAG"               , SqlDbType.NVarChar , 50){ Value = advancedExamination.HBsAG               },
                new SqlParameter("@ECG"                 , SqlDbType.NVarChar , 50){ Value = advancedExamination.ECG                 },
                new SqlParameter("@XRay"                , SqlDbType.NVarChar , 50){ Value = advancedExamination.XRay                },
                new SqlParameter("@BUltrasonic"         , SqlDbType.NVarChar , 50){ Value = advancedExamination.BUltrasonic         },
                new SqlParameter("@CervicalSmear"       , SqlDbType.NVarChar , 50){ Value = advancedExamination.CervicalSmear       },
                new SqlParameter("@Other"               , SqlDbType.NVarChar , 50){ Value = advancedExamination.Other               },
                new SqlParameter("@Physical"            , SqlDbType.NVarChar , 50){ Value = advancedExamination.Physical            },
                new SqlParameter("@Guidance"            , SqlDbType.NVarChar , 50){ Value = advancedExamination.Guidance            },
                new SqlParameter("@Id"                  , SqlDbType.Int      , 4 ){ Value = advancedExamination.Id                  }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ���ݸ߼�����AdvancedExamination��������������ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">�߼�����AdvancedExamination��������������ţ�Id����</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [AdvancedExamination] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ���ݸ߼�����AdvancedExamination��������������ţ�Id���������ݿ��л�ȡ�߼�����AdvancedExamination����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�����¸߼�����AdvancedExamination����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">�߼�����AdvancedExamination��������������ţ�Id����</param>
        public override AdvancedExamination GetDataById(int id)
        {
            AdvancedExamination advancedExamination = null;
            string sqlText = "SELECT [Id],[Oral],[LeftEye],[RightEye],[Hearing],[FMA],[Fundus],[Skin],[Sclera],[LN],[Lung],[Heart],[Abdomen],[LowerExtremityEdema],[DPAP],[Dre],[FBG],[CBCId],"
                           + "[RoutineUrineId],[U_MTB],[LiverId],[RenalId],[TGId],[GHb],[HBsAG],[ECG],[XRay],[BUltrasonic],[CervicalSmear],[Other],[Physical],[Guidance] "
                           + "FROM [AdvancedExamination] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                advancedExamination = new AdvancedExamination();
                ReadAdvancedExaminationAllData(sqlDataReader,advancedExamination);
            }
            sqlDataReader.Close();
            return advancedExamination;
        }


        /// <summary>
        /// �����ݿ��ж�ȡ���������и߼�����AdvancedExamination��List�б�
        /// </summary>
        public override List<AdvancedExamination> GetAllList()
        {
            string sqlText = "SELECT [Id],[Oral],[LeftEye],[RightEye],[Hearing],[FMA],[Fundus],[Skin],[Sclera],[LN],[Lung],[Heart],[Abdomen],[LowerExtremityEdema],[DPAP],[Dre],[FBG],[CBCId],"
                           + "[RoutineUrineId],[U_MTB],[LiverId],[RenalId],[TGId],[GHb],[HBsAG],[ECG],[XRay],[BUltrasonic],[CervicalSmear],[Other],[Physical],[Guidance] "
                           + "FROM [AdvancedExamination]";
            List<AdvancedExamination> list = new List<AdvancedExamination>();
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, null);
            while (sqlDataReader.Read())
            {
                AdvancedExamination advancedExamination = new AdvancedExamination();
                ReadAdvancedExaminationAllData(sqlDataReader, advancedExamination);
                list.Add(advancedExamination);
            }
            sqlDataReader.Close();
            return list;
        }


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ��ĸ߼�����AdvancedExamination�����б���ҳ��Ϣ��
        /// �÷�������ȡ�ĸ߼�����AdvancedExamination���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
        /// </summary>
        public override PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "SELECT [Id],[Oral],[LeftEye],[RightEye],[Hearing],[Guidance] "
                           + "FROM [AdvancedExamination]";
            List<AdvancedExamination> list = new List<AdvancedExamination>();
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
                    AdvancedExamination advancedExamination = new AdvancedExamination();
                    ReadAdvancedExaminationPageData(sqlDataReader, advancedExamination);
                    list.Add(advancedExamination);
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
