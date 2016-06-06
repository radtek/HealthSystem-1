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
    /// �������ƣ��߼�����OleDb���ݷ������ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ���߼������ࣨҵ���߼��㣩�����OleDb�ġ���ɾ�Ĳ顱�ȸ������ݷ��ʷ������̳�ͨ�����ݷ��ʸ��ࡣ
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
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id"                  , OleDbType.Integer  , 4 ){ Value = advancedExamination.Id                  },
                new OleDbParameter("@Oral"                , OleDbType.VarWChar , 50){ Value = advancedExamination.Oral                },
                new OleDbParameter("@LeftEye"             , OleDbType.Decimal  , 9 ){ Value = advancedExamination.LeftEye             },
                new OleDbParameter("@RightEye"            , OleDbType.Decimal  , 9 ){ Value = advancedExamination.RightEye            },
                new OleDbParameter("@Hearing"             , OleDbType.VarWChar , 50){ Value = advancedExamination.Hearing             },
                new OleDbParameter("@FMA"                 , OleDbType.VarWChar , 50){ Value = advancedExamination.FMA                 },
                new OleDbParameter("@Fundus"              , OleDbType.VarWChar , 50){ Value = advancedExamination.Fundus              },
                new OleDbParameter("@Skin"                , OleDbType.VarWChar , 50){ Value = advancedExamination.Skin                },
                new OleDbParameter("@Sclera"              , OleDbType.VarWChar , 50){ Value = advancedExamination.Sclera              },
                new OleDbParameter("@LN"                  , OleDbType.VarWChar , 50){ Value = advancedExamination.LN                  },
                new OleDbParameter("@Lung"                , OleDbType.VarWChar , 50){ Value = advancedExamination.Lung                },
                new OleDbParameter("@Heart"               , OleDbType.VarWChar , 50){ Value = advancedExamination.Heart               },
                new OleDbParameter("@Abdomen"             , OleDbType.VarWChar , 50){ Value = advancedExamination.Abdomen             },
                new OleDbParameter("@LowerExtremityEdema" , OleDbType.VarWChar , 50){ Value = advancedExamination.LowerExtremityEdema },
                new OleDbParameter("@DPAP"                , OleDbType.VarWChar , 50){ Value = advancedExamination.DPAP                },
                new OleDbParameter("@Dre"                 , OleDbType.VarWChar , 50){ Value = advancedExamination.Dre                 },
                new OleDbParameter("@FBG"                 , OleDbType.VarWChar , 50){ Value = advancedExamination.FBG                 },
                new OleDbParameter("@CBCId"               , OleDbType.Integer  , 4 ){ Value = advancedExamination.CBC                 },
                new OleDbParameter("@RoutineUrineId"      , OleDbType.Integer  , 4 ){ Value = advancedExamination.RoutineUrine        },
                new OleDbParameter("@U_MTB"               , OleDbType.VarWChar , 50){ Value = advancedExamination.U_MTB               },
                new OleDbParameter("@LiverId"             , OleDbType.Integer  , 4 ){ Value = advancedExamination.Liver               },
                new OleDbParameter("@RenalId"             , OleDbType.Integer  , 4 ){ Value = advancedExamination.Renal               },
                new OleDbParameter("@TGId"                , OleDbType.Integer  , 4 ){ Value = advancedExamination.TG                  },
                new OleDbParameter("@GHb"                 , OleDbType.VarWChar , 50){ Value = advancedExamination.GHb                 },
                new OleDbParameter("@HBsAG"               , OleDbType.VarWChar , 50){ Value = advancedExamination.HBsAG               },
                new OleDbParameter("@ECG"                 , OleDbType.VarWChar , 50){ Value = advancedExamination.ECG                 },
                new OleDbParameter("@XRay"                , OleDbType.VarWChar , 50){ Value = advancedExamination.XRay                },
                new OleDbParameter("@BUltrasonic"         , OleDbType.VarWChar , 50){ Value = advancedExamination.BUltrasonic         },
                new OleDbParameter("@CervicalSmear"       , OleDbType.VarWChar , 50){ Value = advancedExamination.CervicalSmear       },
                new OleDbParameter("@Other"               , OleDbType.VarWChar , 50){ Value = advancedExamination.Other               },
                new OleDbParameter("@Physical"            , OleDbType.VarWChar , 50){ Value = advancedExamination.Physical            },
                new OleDbParameter("@Guidance"            , OleDbType.VarWChar , 50){ Value = advancedExamination.Guidance            }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
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
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Oral"                , OleDbType.VarWChar , 50){ Value = advancedExamination.Oral                },
                new OleDbParameter("@LeftEye"             , OleDbType.Decimal  , 9 ){ Value = advancedExamination.LeftEye             },
                new OleDbParameter("@RightEye"            , OleDbType.Decimal  , 9 ){ Value = advancedExamination.RightEye            },
                new OleDbParameter("@Hearing"             , OleDbType.VarWChar , 50){ Value = advancedExamination.Hearing             },
                new OleDbParameter("@FMA"                 , OleDbType.VarWChar , 50){ Value = advancedExamination.FMA                 },
                new OleDbParameter("@Fundus"              , OleDbType.VarWChar , 50){ Value = advancedExamination.Fundus              },
                new OleDbParameter("@Skin"                , OleDbType.VarWChar , 50){ Value = advancedExamination.Skin                },
                new OleDbParameter("@Sclera"              , OleDbType.VarWChar , 50){ Value = advancedExamination.Sclera              },
                new OleDbParameter("@LN"                  , OleDbType.VarWChar , 50){ Value = advancedExamination.LN                  },
                new OleDbParameter("@Lung"                , OleDbType.VarWChar , 50){ Value = advancedExamination.Lung                },
                new OleDbParameter("@Heart"               , OleDbType.VarWChar , 50){ Value = advancedExamination.Heart               },
                new OleDbParameter("@Abdomen"             , OleDbType.VarWChar , 50){ Value = advancedExamination.Abdomen             },
                new OleDbParameter("@LowerExtremityEdema" , OleDbType.VarWChar , 50){ Value = advancedExamination.LowerExtremityEdema },
                new OleDbParameter("@DPAP"                , OleDbType.VarWChar , 50){ Value = advancedExamination.DPAP                },
                new OleDbParameter("@Dre"                 , OleDbType.VarWChar , 50){ Value = advancedExamination.Dre                 },
                new OleDbParameter("@FBG"                 , OleDbType.VarWChar , 50){ Value = advancedExamination.FBG                 },
                new OleDbParameter("@CBCId"               , OleDbType.Integer  , 4 ){ Value = advancedExamination.CBC                 },
                new OleDbParameter("@RoutineUrineId"      , OleDbType.Integer  , 4 ){ Value = advancedExamination.RoutineUrine        },
                new OleDbParameter("@U_MTB"               , OleDbType.VarWChar , 50){ Value = advancedExamination.U_MTB               },
                new OleDbParameter("@LiverId"             , OleDbType.Integer  , 4 ){ Value = advancedExamination.Liver               },
                new OleDbParameter("@RenalId"             , OleDbType.Integer  , 4 ){ Value = advancedExamination.Renal               },
                new OleDbParameter("@TGId"                , OleDbType.Integer  , 4 ){ Value = advancedExamination.TG                  },
                new OleDbParameter("@GHb"                 , OleDbType.VarWChar , 50){ Value = advancedExamination.GHb                 },
                new OleDbParameter("@HBsAG"               , OleDbType.VarWChar , 50){ Value = advancedExamination.HBsAG               },
                new OleDbParameter("@ECG"                 , OleDbType.VarWChar , 50){ Value = advancedExamination.ECG                 },
                new OleDbParameter("@XRay"                , OleDbType.VarWChar , 50){ Value = advancedExamination.XRay                },
                new OleDbParameter("@BUltrasonic"         , OleDbType.VarWChar , 50){ Value = advancedExamination.BUltrasonic         },
                new OleDbParameter("@CervicalSmear"       , OleDbType.VarWChar , 50){ Value = advancedExamination.CervicalSmear       },
                new OleDbParameter("@Other"               , OleDbType.VarWChar , 50){ Value = advancedExamination.Other               },
                new OleDbParameter("@Physical"            , OleDbType.VarWChar , 50){ Value = advancedExamination.Physical            },
                new OleDbParameter("@Guidance"            , OleDbType.VarWChar , 50){ Value = advancedExamination.Guidance            },
                new OleDbParameter("@Id"                  , OleDbType.Integer  , 4 ){ Value = advancedExamination.Id                  }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ���ݸ߼�����AdvancedExamination��������������ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">�߼�����AdvancedExamination��������������ţ�Id����</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [AdvancedExamination] "
                           + "WHERE [Id]=@Id";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id" , OleDbType.Integer , 4){ Value = id }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
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
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id" , OleDbType.Integer , 4){ Value = id }
            };

            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, parameters);
            if (oleDbDataReader.Read())
            {
                advancedExamination = new AdvancedExamination();
                ReadAdvancedExaminationAllData(oleDbDataReader,advancedExamination);
            }
            oleDbDataReader.Close();
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
            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, null);
            while (oleDbDataReader.Read())
            {
                AdvancedExamination advancedExamination = new AdvancedExamination();
                ReadAdvancedExaminationAllData(oleDbDataReader, advancedExamination);
                list.Add(advancedExamination);
            }
            oleDbDataReader.Close();
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
                    AdvancedExamination advancedExamination = new AdvancedExamination();
                    ReadAdvancedExaminationPageData(oleDbDataReader, advancedExamination);
                    list.Add(advancedExamination);
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
