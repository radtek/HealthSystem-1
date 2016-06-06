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
    /// 对象名称：基础体检表OleDb数据访问子类（数据访问层）
    /// 对象说明：提供“基础体检表类（业务逻辑层）”针对OleDb的“增删改查”等各种数据访问方法，继承通用数据访问父类。
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
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id"                   , OleDbType.Integer  , 4 ){ Value = basicExamination.Id                   },
                new OleDbParameter("@ResidentId"           , OleDbType.VarWChar , 50){ Value = basicExamination.ResidentId           },
                new OleDbParameter("@TheName"              , OleDbType.VarWChar , 50){ Value = basicExamination.TheName              },
                new OleDbParameter("@CheckID"              , OleDbType.VarWChar , 50){ Value = basicExamination.CheckID              },
                new OleDbParameter("@CheckDate"            , OleDbType.VarWChar , 50){ Value = basicExamination.CheckDate            },
                new OleDbParameter("@Doctor"               , OleDbType.VarWChar , 50){ Value = basicExamination.Doctor               },
                new OleDbParameter("@SymptomsId"           , OleDbType.Integer  , 4 ){ Value = basicExamination.Symptoms             },
                new OleDbParameter("@Temperature"          , OleDbType.Decimal  , 9 ){ Value = basicExamination.Temperature          },
                new OleDbParameter("@BPM"                  , OleDbType.Decimal  , 9 ){ Value = basicExamination.BPM                  },
                new OleDbParameter("@RR"                   , OleDbType.Decimal  , 9 ){ Value = basicExamination.RR                   },
                new OleDbParameter("@BP"                   , OleDbType.Decimal  , 9 ){ Value = basicExamination.BP                   },
                new OleDbParameter("@Height"               , OleDbType.Decimal  , 9 ){ Value = basicExamination.Height               },
                new OleDbParameter("@Weight"               , OleDbType.Decimal  , 9 ){ Value = basicExamination.Weight               },
                new OleDbParameter("@Waist"                , OleDbType.Decimal  , 9 ){ Value = basicExamination.Waist                },
                new OleDbParameter("@BMI"                  , OleDbType.Decimal  , 9 ){ Value = basicExamination.BMI                  },
                new OleDbParameter("@PhysicalExercise"     , OleDbType.VarWChar , 50){ Value = basicExamination.PhysicalExercise     },
                new OleDbParameter("@EatingHabitsId"       , OleDbType.Integer  , 4 ){ Value = basicExamination.EatingHabits         },
                new OleDbParameter("@Smoking"              , OleDbType.VarWChar , 50){ Value = basicExamination.Smoking              },
                new OleDbParameter("@Drinking"             , OleDbType.VarWChar , 50){ Value = basicExamination.Drinking             },
                new OleDbParameter("@OccupationalExposure" , OleDbType.VarWChar , 50){ Value = basicExamination.OccupationalExposure }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
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
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@ResidentId"           , OleDbType.VarWChar , 50){ Value = basicExamination.ResidentId           },
                new OleDbParameter("@TheName"              , OleDbType.VarWChar , 50){ Value = basicExamination.TheName              },
                new OleDbParameter("@CheckID"              , OleDbType.VarWChar , 50){ Value = basicExamination.CheckID              },
                new OleDbParameter("@CheckDate"            , OleDbType.VarWChar , 50){ Value = basicExamination.CheckDate            },
                new OleDbParameter("@Doctor"               , OleDbType.VarWChar , 50){ Value = basicExamination.Doctor               },
                new OleDbParameter("@SymptomsId"           , OleDbType.Integer  , 4 ){ Value = basicExamination.Symptoms             },
                new OleDbParameter("@Temperature"          , OleDbType.Decimal  , 9 ){ Value = basicExamination.Temperature          },
                new OleDbParameter("@BPM"                  , OleDbType.Decimal  , 9 ){ Value = basicExamination.BPM                  },
                new OleDbParameter("@RR"                   , OleDbType.Decimal  , 9 ){ Value = basicExamination.RR                   },
                new OleDbParameter("@BP"                   , OleDbType.Decimal  , 9 ){ Value = basicExamination.BP                   },
                new OleDbParameter("@Height"               , OleDbType.Decimal  , 9 ){ Value = basicExamination.Height               },
                new OleDbParameter("@Weight"               , OleDbType.Decimal  , 9 ){ Value = basicExamination.Weight               },
                new OleDbParameter("@Waist"                , OleDbType.Decimal  , 9 ){ Value = basicExamination.Waist                },
                new OleDbParameter("@BMI"                  , OleDbType.Decimal  , 9 ){ Value = basicExamination.BMI                  },
                new OleDbParameter("@PhysicalExercise"     , OleDbType.VarWChar , 50){ Value = basicExamination.PhysicalExercise     },
                new OleDbParameter("@EatingHabitsId"       , OleDbType.Integer  , 4 ){ Value = basicExamination.EatingHabits         },
                new OleDbParameter("@Smoking"              , OleDbType.VarWChar , 50){ Value = basicExamination.Smoking              },
                new OleDbParameter("@Drinking"             , OleDbType.VarWChar , 50){ Value = basicExamination.Drinking             },
                new OleDbParameter("@OccupationalExposure" , OleDbType.VarWChar , 50){ Value = basicExamination.OccupationalExposure },
                new OleDbParameter("@Id"                   , OleDbType.Integer  , 4 ){ Value = basicExamination.Id                   }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据基础体检表（BasicExamination）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">基础体检表（BasicExamination）的主键“编号（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [BasicExamination] "
                           + "WHERE [Id]=@Id";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id" , OleDbType.Integer , 4){ Value = id }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
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
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id" , OleDbType.Integer , 4){ Value = id }
            };

            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, parameters);
            if (oleDbDataReader.Read())
            {
                basicExamination = new BasicExamination();
                ReadBasicExaminationAllData(oleDbDataReader,basicExamination);
            }
            oleDbDataReader.Close();
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
            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, null);
            while (oleDbDataReader.Read())
            {
                BasicExamination basicExamination = new BasicExamination();
                ReadBasicExaminationAllData(oleDbDataReader, basicExamination);
                list.Add(basicExamination);
            }
            oleDbDataReader.Close();
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
                    BasicExamination basicExamination = new BasicExamination();
                    ReadBasicExaminationPageData(oleDbDataReader, basicExamination);
                    list.Add(basicExamination);
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
            OleDbParameter[] parameters =
            {
                new OleDbParameter("@TheName" , OleDbType.VarWChar , 50){ Value = theName }
            };

            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, parameters);
            if (oleDbDataReader.Read())
            {
                basicExamination = new BasicExamination();
                ReadBasicExaminationAllData(oleDbDataReader, basicExamination);
                list.Add(basicExamination);
            }
            oleDbDataReader.Close();
            return list;
        }









    }
}
