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
    /// �������ƣ���������SQL Server���ݷ������ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ�����������ࣨҵ���߼��㣩�����SQL Server�ġ���ɾ�Ĳ顱�ȸ������ݷ��ʷ������̳�ͨ�����ݷ��ʸ��ࡣ
    /// ����˵����ͨ������Ҫֱ��ʵ�������࣬��ʹ�á����������ࣨҵ���߼��㣩���е�DataAccess���������ñ�����ʵ�ֵķ�����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 16:58:59
    /// </summary>
    public class BasicExaminationDAL:DAL.Common.BasicExaminationDAL
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬ʵ���˸����ж���ĳ��󷽷����벻Ҫֱ���޸ĸ������е��κδ��룬   
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>
        /// ����������BasicExamination�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="basicExamination">��������BasicExamination��ʵ������</param>
        public override int Insert(BasicExamination basicExamination)
        {
            string sqlText = "INSERT INTO [BasicExamination]"
                           + "([Id],[ResidentId],[TheName],[CheckID],[CheckDate],[Doctor],[SymptomsId],[Temperature],[BPM],[RR],[BP],[Height],[Weight],[Waist],[BMI],"
                           + "[PhysicalExercise],[EatingHabitsId],[Smoking],[Drinking],[OccupationalExposure])"
                           + "VALUES"
                           + "(@Id,@ResidentId,@TheName,@CheckID,@CheckDate,@Doctor,@SymptomsId,@Temperature,@BPM,@RR,@BP,@Height,@Weight,@Waist,@BMI,"
                           + "@PhysicalExercise,@EatingHabitsId,@Smoking,@Drinking,@OccupationalExposure)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id"                   , SqlDbType.Int      , 4 ){ Value = basicExamination.Id                   },
                new SqlParameter("@ResidentId"           , SqlDbType.NVarChar , 50){ Value = basicExamination.ResidentId           },
                new SqlParameter("@TheName"              , SqlDbType.NVarChar , 50){ Value = basicExamination.TheName              },
                new SqlParameter("@CheckID"              , SqlDbType.NVarChar , 50){ Value = basicExamination.CheckID              },
                new SqlParameter("@CheckDate"            , SqlDbType.NVarChar , 50){ Value = basicExamination.CheckDate            },
                new SqlParameter("@Doctor"               , SqlDbType.NVarChar , 50){ Value = basicExamination.Doctor               },
                new SqlParameter("@SymptomsId"           , SqlDbType.Int      , 4 ){ Value = basicExamination.Symptoms             },
                new SqlParameter("@Temperature"          , SqlDbType.Decimal  , 9 ){ Value = basicExamination.Temperature          },
                new SqlParameter("@BPM"                  , SqlDbType.Decimal  , 9 ){ Value = basicExamination.BPM                  },
                new SqlParameter("@RR"                   , SqlDbType.Decimal  , 9 ){ Value = basicExamination.RR                   },
                new SqlParameter("@BP"                   , SqlDbType.Decimal  , 9 ){ Value = basicExamination.BP                   },
                new SqlParameter("@Height"               , SqlDbType.Decimal  , 9 ){ Value = basicExamination.Height               },
                new SqlParameter("@Weight"               , SqlDbType.Decimal  , 9 ){ Value = basicExamination.Weight               },
                new SqlParameter("@Waist"                , SqlDbType.Decimal  , 9 ){ Value = basicExamination.Waist                },
                new SqlParameter("@BMI"                  , SqlDbType.Decimal  , 9 ){ Value = basicExamination.BMI                  },
                new SqlParameter("@PhysicalExercise"     , SqlDbType.NVarChar , 50){ Value = basicExamination.PhysicalExercise     },
                new SqlParameter("@EatingHabitsId"       , SqlDbType.Int      , 4 ){ Value = basicExamination.EatingHabits         },
                new SqlParameter("@Smoking"              , SqlDbType.NVarChar , 50){ Value = basicExamination.Smoking              },
                new SqlParameter("@Drinking"             , SqlDbType.NVarChar , 50){ Value = basicExamination.Drinking             },
                new SqlParameter("@OccupationalExposure" , SqlDbType.NVarChar , 50){ Value = basicExamination.OccupationalExposure }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ����������BasicExamination�����ݣ�������������ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="basicExamination">��������BasicExamination��ʵ������</param>
        public override int Update(BasicExamination basicExamination)
        {
            string sqlText = "UPDATE [BasicExamination] SET "
                           + "[ResidentId]=@ResidentId,[TheName]=@TheName,[CheckID]=@CheckID,[CheckDate]=@CheckDate,[Doctor]=@Doctor,[SymptomsId]=@SymptomsId,"
                           + "[Temperature]=@Temperature,[BPM]=@BPM,[RR]=@RR,[BP]=@BP,[Height]=@Height,[Weight]=@Weight,[Waist]=@Waist,[BMI]=@BMI,[PhysicalExercise]=@PhysicalExercise,"
                           + "[EatingHabitsId]=@EatingHabitsId,[Smoking]=@Smoking,[Drinking]=@Drinking,[OccupationalExposure]=@OccupationalExposure "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@ResidentId"           , SqlDbType.NVarChar , 50){ Value = basicExamination.ResidentId           },
                new SqlParameter("@TheName"              , SqlDbType.NVarChar , 50){ Value = basicExamination.TheName              },
                new SqlParameter("@CheckID"              , SqlDbType.NVarChar , 50){ Value = basicExamination.CheckID              },
                new SqlParameter("@CheckDate"            , SqlDbType.NVarChar , 50){ Value = basicExamination.CheckDate            },
                new SqlParameter("@Doctor"               , SqlDbType.NVarChar , 50){ Value = basicExamination.Doctor               },
                new SqlParameter("@SymptomsId"           , SqlDbType.Int      , 4 ){ Value = basicExamination.Symptoms             },
                new SqlParameter("@Temperature"          , SqlDbType.Decimal  , 9 ){ Value = basicExamination.Temperature          },
                new SqlParameter("@BPM"                  , SqlDbType.Decimal  , 9 ){ Value = basicExamination.BPM                  },
                new SqlParameter("@RR"                   , SqlDbType.Decimal  , 9 ){ Value = basicExamination.RR                   },
                new SqlParameter("@BP"                   , SqlDbType.Decimal  , 9 ){ Value = basicExamination.BP                   },
                new SqlParameter("@Height"               , SqlDbType.Decimal  , 9 ){ Value = basicExamination.Height               },
                new SqlParameter("@Weight"               , SqlDbType.Decimal  , 9 ){ Value = basicExamination.Weight               },
                new SqlParameter("@Waist"                , SqlDbType.Decimal  , 9 ){ Value = basicExamination.Waist                },
                new SqlParameter("@BMI"                  , SqlDbType.Decimal  , 9 ){ Value = basicExamination.BMI                  },
                new SqlParameter("@PhysicalExercise"     , SqlDbType.NVarChar , 50){ Value = basicExamination.PhysicalExercise     },
                new SqlParameter("@EatingHabitsId"       , SqlDbType.Int      , 4 ){ Value = basicExamination.EatingHabits         },
                new SqlParameter("@Smoking"              , SqlDbType.NVarChar , 50){ Value = basicExamination.Smoking              },
                new SqlParameter("@Drinking"             , SqlDbType.NVarChar , 50){ Value = basicExamination.Drinking             },
                new SqlParameter("@OccupationalExposure" , SqlDbType.NVarChar , 50){ Value = basicExamination.OccupationalExposure },
                new SqlParameter("@Id"                   , SqlDbType.Int      , 4 ){ Value = basicExamination.Id                   }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ���ݻ�������BasicExamination������������ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">��������BasicExamination������������ţ�Id����</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [BasicExamination] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ���ݻ�������BasicExamination������������ţ�Id���������ݿ��л�ȡ��������BasicExamination����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�����»�������BasicExamination����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">��������BasicExamination������������ţ�Id����</param>
        public override BasicExamination GetDataById(int id)
        {
            BasicExamination basicExamination = null;
            string sqlText = "SELECT [Id],[ResidentId],[TheName],[CheckID],[CheckDate],[Doctor],[SymptomsId],[Temperature],[BPM],[RR],[BP],[Height],[Weight],[Waist],[BMI],"
                           + "[PhysicalExercise],[EatingHabitsId],[Smoking],[Drinking],[OccupationalExposure] "
                           + "FROM [BasicExamination] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                basicExamination = new BasicExamination();
                ReadBasicExaminationAllData(sqlDataReader,basicExamination);
            }
            sqlDataReader.Close();
            return basicExamination;
        }


        /// <summary>
        /// �����ݿ��ж�ȡ���������л�������BasicExamination��List�б�
        /// </summary>
        public override List<BasicExamination> GetAllList()
        {
            string sqlText = "SELECT [Id],[ResidentId],[TheName],[CheckID],[CheckDate],[Doctor],[SymptomsId],[Temperature],[BPM],[RR],[BP],[Height],[Weight],[Waist],[BMI],"
                           + "[PhysicalExercise],[EatingHabitsId],[Smoking],[Drinking],[OccupationalExposure] "
                           + "FROM [BasicExamination]";
            List<BasicExamination> list = new List<BasicExamination>();
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, null);
            while (sqlDataReader.Read())
            {
                BasicExamination basicExamination = new BasicExamination();
                ReadBasicExaminationAllData(sqlDataReader, basicExamination);
                list.Add(basicExamination);
            }
            sqlDataReader.Close();
            return list;
        }


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ��Ļ�������BasicExamination�����б���ҳ��Ϣ��
        /// �÷�������ȡ�Ļ�������BasicExamination���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
        /// </summary>
        public override PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "SELECT [Id],[ResidentId],[TheName],[CheckID],[CheckDate],[Doctor],[SymptomsId] "
                           + "FROM [BasicExamination]";
            List<BasicExamination> list = new List<BasicExamination>();
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
                    BasicExamination basicExamination = new BasicExamination();
                    ReadBasicExaminationPageData(sqlDataReader, basicExamination);
                    list.Add(basicExamination);
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

        /// <summary>
        /// ���ݻ����������ƣ�BasicExamination�����ֶΡ�TheName��TheName���������ݿ��л�ȡ�����������ƣ�BasicExamination����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�����»����������ƣ�BasicExamination����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="theName">�����������ƣ�BasicExamination�����ֶΡ�TheName��TheName����</param>
        public override List<BasicExamination> GetDataByTheName(string theName)
        {
            BasicExamination basicExamination = null;
            string sqlText = "SELECT [Id],[ResidentId],[TheName],[CheckID],[CheckDate],[Doctor],[SymptomsId],[Temperature],[BPM],[RR],[BP],[Height],[Weight],[Waist],[BMI],"
                           + "[PhysicalExercise],[EatingHabitsId],[Smoking],[Drinking],[OccupationalExposure] "
                           + "FROM [BasicExamination] "
                           + "WHERE [TheName]=@TheName";
            List<BasicExamination> list = new List<BasicExamination>();
            SqlParameter[] parameters =
            {
                new SqlParameter("@TheName" , SqlDbType.NVarChar , 50){ Value = theName }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            while (sqlDataReader.Read())
            {
                basicExamination = new BasicExamination();
                ReadBasicExaminationAllData(sqlDataReader, basicExamination);
                list.Add(basicExamination);
            }
            sqlDataReader.Close();
            return list;
        }








    }
}
