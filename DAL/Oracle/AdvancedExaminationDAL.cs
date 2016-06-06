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
    /// 对象名称：高级体检表Oracle数据访问子类（数据访问层）
    /// 对象说明：提供“高级体检表类（业务逻辑层）”针对Oracle的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“高级体检表类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 17:12:40
    /// </summary>
    public class AdvancedExaminationDAL:DAL.Common.AdvancedExaminationDAL
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将高级体检表（AdvancedExamination）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="advancedExamination">高级体检表（AdvancedExamination）实例对象</param>
        public override int Insert(AdvancedExamination advancedExamination)
        {
            string sqlText = "INSERT INTO \"AdvancedExamination\""
                           + "(\"Id\",\"Oral\",\"LeftEye\",\"RightEye\",\"Hearing\",\"FMA\",\"Fundus\",\"Skin\",\"Sclera\",\"LN\",\"Lung\",\"Heart\",\"Abdomen\",\"LowerExtremityEdema\",\"DPAP\",\"Dre\",\"FBG\",\"CBCId\","
                           + "\"RoutineUrineId\",\"U_MTB\",\"LiverId\",\"RenalId\",\"TGId\",\"GHb\",\"HBsAG\",\"ECG\",\"XRay\",\"BUltrasonic\",\"CervicalSmear\",\"Other\",\"Physical\",\"Guidance\")"
                           + "VALUES"
                           + "(:Id,:Oral,:LeftEye,:RightEye,:Hearing,:FMA,:Fundus,:Skin,:Sclera,:LN,:Lung,:Heart,:Abdomen,:LowerExtremityEdema,:DPAP,:Dre,:FBG,:CBCId,"
                           + ":RoutineUrineId,:U_MTB,:LiverId,:RenalId,:TGId,:GHb,:HBsAG,:ECG,:XRay,:BUltrasonic,:CervicalSmear,:Other,:Physical,:Guidance)";
            OracleParameter[] parameters = 
            {
                new OracleParameter(":Id"                  , OracleType.Int32    , 4 ){ Value = advancedExamination.Id                  },
                new OracleParameter(":Oral"                , OracleType.NVarChar , 50){ Value = advancedExamination.Oral                },
                new OracleParameter(":LeftEye"             , OracleType.Number   , 9 ){ Value = advancedExamination.LeftEye             },
                new OracleParameter(":RightEye"            , OracleType.Number   , 9 ){ Value = advancedExamination.RightEye            },
                new OracleParameter(":Hearing"             , OracleType.NVarChar , 50){ Value = advancedExamination.Hearing             },
                new OracleParameter(":FMA"                 , OracleType.NVarChar , 50){ Value = advancedExamination.FMA                 },
                new OracleParameter(":Fundus"              , OracleType.NVarChar , 50){ Value = advancedExamination.Fundus              },
                new OracleParameter(":Skin"                , OracleType.NVarChar , 50){ Value = advancedExamination.Skin                },
                new OracleParameter(":Sclera"              , OracleType.NVarChar , 50){ Value = advancedExamination.Sclera              },
                new OracleParameter(":LN"                  , OracleType.NVarChar , 50){ Value = advancedExamination.LN                  },
                new OracleParameter(":Lung"                , OracleType.NVarChar , 50){ Value = advancedExamination.Lung                },
                new OracleParameter(":Heart"               , OracleType.NVarChar , 50){ Value = advancedExamination.Heart               },
                new OracleParameter(":Abdomen"             , OracleType.NVarChar , 50){ Value = advancedExamination.Abdomen             },
                new OracleParameter(":LowerExtremityEdema" , OracleType.NVarChar , 50){ Value = advancedExamination.LowerExtremityEdema },
                new OracleParameter(":DPAP"                , OracleType.NVarChar , 50){ Value = advancedExamination.DPAP                },
                new OracleParameter(":Dre"                 , OracleType.NVarChar , 50){ Value = advancedExamination.Dre                 },
                new OracleParameter(":FBG"                 , OracleType.NVarChar , 50){ Value = advancedExamination.FBG                 },
                new OracleParameter(":CBCId"               , OracleType.Int32    , 4 ){ Value = advancedExamination.CBC                 },
                new OracleParameter(":RoutineUrineId"      , OracleType.Int32    , 4 ){ Value = advancedExamination.RoutineUrine        },
                new OracleParameter(":U_MTB"               , OracleType.NVarChar , 50){ Value = advancedExamination.U_MTB               },
                new OracleParameter(":LiverId"             , OracleType.Int32    , 4 ){ Value = advancedExamination.Liver               },
                new OracleParameter(":RenalId"             , OracleType.Int32    , 4 ){ Value = advancedExamination.Renal               },
                new OracleParameter(":TGId"                , OracleType.Int32    , 4 ){ Value = advancedExamination.TG                  },
                new OracleParameter(":GHb"                 , OracleType.NVarChar , 50){ Value = advancedExamination.GHb                 },
                new OracleParameter(":HBsAG"               , OracleType.NVarChar , 50){ Value = advancedExamination.HBsAG               },
                new OracleParameter(":ECG"                 , OracleType.NVarChar , 50){ Value = advancedExamination.ECG                 },
                new OracleParameter(":XRay"                , OracleType.NVarChar , 50){ Value = advancedExamination.XRay                },
                new OracleParameter(":BUltrasonic"         , OracleType.NVarChar , 50){ Value = advancedExamination.BUltrasonic         },
                new OracleParameter(":CervicalSmear"       , OracleType.NVarChar , 50){ Value = advancedExamination.CervicalSmear       },
                new OracleParameter(":Other"               , OracleType.NVarChar , 50){ Value = advancedExamination.Other               },
                new OracleParameter(":Physical"            , OracleType.NVarChar , 50){ Value = advancedExamination.Physical            },
                new OracleParameter(":Guidance"            , OracleType.NVarChar , 50){ Value = advancedExamination.Guidance            }
            };
            return SFL.OracleHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将高级体检表（AdvancedExamination）数据，根据主键“检查编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="advancedExamination">高级体检表（AdvancedExamination）实例对象</param>
        public override int Update(AdvancedExamination advancedExamination)
        {
            string sqlText = "UPDATE \"AdvancedExamination\" SET "
                           + "\"Id\"=:Id,\"Oral\"=:Oral,\"LeftEye\"=:LeftEye,\"RightEye\"=:RightEye,\"Hearing\"=:Hearing,\"FMA\"=:FMA,\"Fundus\"=:Fundus,\"Skin\"=:Skin,"
                           + "\"Sclera\"=:Sclera,\"LN\"=:LN,\"Lung\"=:Lung,\"Heart\"=:Heart,\"Abdomen\"=:Abdomen,\"LowerExtremityEdema\"=:LowerExtremityEdema,\"DPAP\"=:DPAP,\"Dre\"=:Dre,\"FBG\"=:FBG,"
                           + "\"CBCId\"=:CBCId,\"RoutineUrineId\"=:RoutineUrineId,\"U_MTB\"=:U_MTB,\"LiverId\"=:LiverId,\"RenalId\"=:RenalId,\"TGId\"=:TGId,\"GHb\"=:GHb,\"HBsAG\"=:HBsAG,"
                           + "\"ECG\"=:ECG,\"XRay\"=:XRay,\"BUltrasonic\"=:BUltrasonic,\"CervicalSmear\"=:CervicalSmear,\"Other\"=:Other,\"Physical\"=:Physical,\"Guidance\"=:Guidance "
                           + "WHERE \"Id\"=:Id";
            OracleParameter[] parameters = 
            {
                new OracleParameter(":Id"                  , OracleType.Int32    , 4 ){ Value = advancedExamination.Id                  },
                new OracleParameter(":Oral"                , OracleType.NVarChar , 50){ Value = advancedExamination.Oral                },
                new OracleParameter(":LeftEye"             , OracleType.Number   , 9 ){ Value = advancedExamination.LeftEye             },
                new OracleParameter(":RightEye"            , OracleType.Number   , 9 ){ Value = advancedExamination.RightEye            },
                new OracleParameter(":Hearing"             , OracleType.NVarChar , 50){ Value = advancedExamination.Hearing             },
                new OracleParameter(":FMA"                 , OracleType.NVarChar , 50){ Value = advancedExamination.FMA                 },
                new OracleParameter(":Fundus"              , OracleType.NVarChar , 50){ Value = advancedExamination.Fundus              },
                new OracleParameter(":Skin"                , OracleType.NVarChar , 50){ Value = advancedExamination.Skin                },
                new OracleParameter(":Sclera"              , OracleType.NVarChar , 50){ Value = advancedExamination.Sclera              },
                new OracleParameter(":LN"                  , OracleType.NVarChar , 50){ Value = advancedExamination.LN                  },
                new OracleParameter(":Lung"                , OracleType.NVarChar , 50){ Value = advancedExamination.Lung                },
                new OracleParameter(":Heart"               , OracleType.NVarChar , 50){ Value = advancedExamination.Heart               },
                new OracleParameter(":Abdomen"             , OracleType.NVarChar , 50){ Value = advancedExamination.Abdomen             },
                new OracleParameter(":LowerExtremityEdema" , OracleType.NVarChar , 50){ Value = advancedExamination.LowerExtremityEdema },
                new OracleParameter(":DPAP"                , OracleType.NVarChar , 50){ Value = advancedExamination.DPAP                },
                new OracleParameter(":Dre"                 , OracleType.NVarChar , 50){ Value = advancedExamination.Dre                 },
                new OracleParameter(":FBG"                 , OracleType.NVarChar , 50){ Value = advancedExamination.FBG                 },
                new OracleParameter(":CBCId"               , OracleType.Int32    , 4 ){ Value = advancedExamination.CBC                 },
                new OracleParameter(":RoutineUrineId"      , OracleType.Int32    , 4 ){ Value = advancedExamination.RoutineUrine        },
                new OracleParameter(":U_MTB"               , OracleType.NVarChar , 50){ Value = advancedExamination.U_MTB               },
                new OracleParameter(":LiverId"             , OracleType.Int32    , 4 ){ Value = advancedExamination.Liver               },
                new OracleParameter(":RenalId"             , OracleType.Int32    , 4 ){ Value = advancedExamination.Renal               },
                new OracleParameter(":TGId"                , OracleType.Int32    , 4 ){ Value = advancedExamination.TG                  },
                new OracleParameter(":GHb"                 , OracleType.NVarChar , 50){ Value = advancedExamination.GHb                 },
                new OracleParameter(":HBsAG"               , OracleType.NVarChar , 50){ Value = advancedExamination.HBsAG               },
                new OracleParameter(":ECG"                 , OracleType.NVarChar , 50){ Value = advancedExamination.ECG                 },
                new OracleParameter(":XRay"                , OracleType.NVarChar , 50){ Value = advancedExamination.XRay                },
                new OracleParameter(":BUltrasonic"         , OracleType.NVarChar , 50){ Value = advancedExamination.BUltrasonic         },
                new OracleParameter(":CervicalSmear"       , OracleType.NVarChar , 50){ Value = advancedExamination.CervicalSmear       },
                new OracleParameter(":Other"               , OracleType.NVarChar , 50){ Value = advancedExamination.Other               },
                new OracleParameter(":Physical"            , OracleType.NVarChar , 50){ Value = advancedExamination.Physical            },
                new OracleParameter(":Guidance"            , OracleType.NVarChar , 50){ Value = advancedExamination.Guidance            },
                new OracleParameter(":Id"                  , OracleType.Int32    , 4 ){ Value = advancedExamination.Id                  }
            };
            return SFL.OracleHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据高级体检表（AdvancedExamination）的主键“检查编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">高级体检表（AdvancedExamination）的主键“检查编号（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM \"AdvancedExamination\"" 
                           + "WHERE \"Id\"=:Id";
            OracleParameter[] parameters = 
            {
                new OracleParameter(":Id" , OracleType.Int32 , 4){ Value = id }
            };
            return SFL.OracleHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据高级体检表（AdvancedExamination）的主键“检查编号（Id）”从数据库中获取高级体检表（AdvancedExamination）的实例。
        /// 成功从数据库中取得记录返回新高级体检表（AdvancedExamination）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">高级体检表（AdvancedExamination）的主键“检查编号（Id）”</param>
        public override AdvancedExamination GetDataById(int id)
        {
            AdvancedExamination advancedExamination = null;
            string sqlText = "SELECT \"Id\",\"Oral\",\"LeftEye\",\"RightEye\",\"Hearing\",\"FMA\",\"Fundus\",\"Skin\",\"Sclera\",\"LN\",\"Lung\",\"Heart\",\"Abdomen\",\"LowerExtremityEdema\",\"DPAP\",\"Dre\",\"FBG\",\"CBCId\","
                           + "\"RoutineUrineId\",\"U_MTB\",\"LiverId\",\"RenalId\",\"TGId\",\"GHb\",\"HBsAG\",\"ECG\",\"XRay\",\"BUltrasonic\",\"CervicalSmear\",\"Other\",\"Physical\",\"Guidance\" "
                           + "FROM \"AdvancedExamination\" "
                           + "WHERE \"Id\"=:Id";
            OracleParameter[] parameters = 
            {
                new OracleParameter(":Id" , OracleType.Int32 , 4){ Value = id }
            };

            OracleDataReader oracleDataReader = SFL.OracleHelper.ExecuteReader(sqlText, parameters);
            if (oracleDataReader.Read())
            {
                advancedExamination = new AdvancedExamination();
                ReadAdvancedExaminationAllData(oracleDataReader,advancedExamination);
            }
            oracleDataReader.Close();
            return advancedExamination;
        }


        /// <summary>
        /// 从数据库中读取并返回所有高级体检表（AdvancedExamination）List列表。
        /// </summary>
        public override List<AdvancedExamination> GetAllList()
        {
            string sqlText = "SELECT \"Id\",\"Oral\",\"LeftEye\",\"RightEye\",\"Hearing\",\"FMA\",\"Fundus\",\"Skin\",\"Sclera\",\"LN\",\"Lung\",\"Heart\",\"Abdomen\",\"LowerExtremityEdema\",\"DPAP\",\"Dre\",\"FBG\",\"CBCId\","
                           + "\"RoutineUrineId\",\"U_MTB\",\"LiverId\",\"RenalId\",\"TGId\",\"GHb\",\"HBsAG\",\"ECG\",\"XRay\",\"BUltrasonic\",\"CervicalSmear\",\"Other\",\"Physical\",\"Guidance\" "
                           + "FROM \"AdvancedExamination\"";
            List<AdvancedExamination> list = new List<AdvancedExamination>();
            OracleDataReader oracleDataReader = SFL.OracleHelper.ExecuteReader(sqlText, null);
            while (oracleDataReader.Read())
            {
                AdvancedExamination advancedExamination = new AdvancedExamination();
                ReadAdvancedExaminationAllData(oracleDataReader, advancedExamination);
                list.Add(advancedExamination);
            }
            oracleDataReader.Close();
            return list;
        }


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的高级体检表（AdvancedExamination）的列表及分页信息。
        /// 该方法所获取的高级体检表（AdvancedExamination）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public override PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "SELECT \"Id\",\"Oral\",\"LeftEye\",\"RightEye\",\"Hearing\",\"Guidance\" "
                           + "FROM \"AdvancedExamination\"";
            List<AdvancedExamination> list = new List<AdvancedExamination>();
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
                    AdvancedExamination advancedExamination = new AdvancedExamination();
                    ReadAdvancedExaminationPageData(oracleDataReader, advancedExamination);
                    list.Add(advancedExamination);
                }
            }
            oracleDataReader.Close();

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
