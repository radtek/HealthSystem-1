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
    /// 对象名称：基础体检表SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“基础体检表类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“基础体检表类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 16:58:59
    /// </summary>
    public class BasicExaminationDAL:DAL.Common.BasicExaminationDAL
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将基础体检表（BasicExamination）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="basicExamination">基础体检表（BasicExamination）实例对象</param>
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
        /// 将基础体检表（BasicExamination）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="basicExamination">基础体检表（BasicExamination）实例对象</param>
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
        /// 根据基础体检表（BasicExamination）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">基础体检表（BasicExamination）的主键“编号（Id）”</param>
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
        /// 根据基础体检表（BasicExamination）的主键“编号（Id）”从数据库中获取基础体检表（BasicExamination）的实例。
        /// 成功从数据库中取得记录返回新基础体检表（BasicExamination）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">基础体检表（BasicExamination）的主键“编号（Id）”</param>
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
        /// 从数据库中读取并返回所有基础体检表（BasicExamination）List列表。
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
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的基础体检表（BasicExamination）的列表及分页信息。
        /// 该方法所获取的基础体检表（BasicExamination）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
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

        #endregion 多层框架式下的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，请先在本类的父类中对相关抽象方法进行定义，再在本类中进行具体实现。
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍

        /// <summary>
        /// 根据基础对象名称（BasicExamination）的字段“TheName（TheName）”从数据库中获取基础对象名称（BasicExamination）的实例。
        /// 成功从数据库中取得记录返回新基础对象名称（BasicExamination）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="theName">基础对象名称（BasicExamination）的字段“TheName（TheName）”</param>
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
