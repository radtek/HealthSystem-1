﻿using System;
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
    /// 对象名称：居民疾病信息OleDb数据访问子类（数据访问层）
    /// 对象说明：提供“居民疾病信息类（业务逻辑层）”针对OleDb的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“居民疾病信息类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-7 17:24:34
    /// </summary>
    public class ResidentDiseaseInfoDAL:DAL.Common.ResidentDiseaseInfoDAL
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将居民疾病信息（ResidentDiseaseInfo）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="residentDiseaseInfo">居民疾病信息（ResidentDiseaseInfo）实例对象</param>
        public override int Insert(ResidentDiseaseInfo residentDiseaseInfo)
        {
            string sqlText = "INSERT INTO [ResidentDiseaseInfo]"
                           + "([Id],[HODA],[EH],[HBP],[HBPTime],[GDM],[GDMTime],[CH],[CHTime],[COP],[COPTime],[MTC],[MTCTime],[Stroke],[StrokeTime],[SMI],[SMITime],[TB],[TBTime],[Hepatitis],"
                           + "[HepatitisTime],[OLID],[OLIDTime],[OD],[ODTime],[Other],[OtherTime],[HistoryOfFather],[HistoryOfMother],[HistoryOfBrothers],[HistoryOfChildren],"
                           + "[GeneticHistory],[Disability],[Remarks])"
                           + "VALUES"
                           + "(@Id,@HODA,@EH,@HBP,@HBPTime,@GDM,@GDMTime,@CH,@CHTime,@COP,@COPTime,@MTC,@MTCTime,@Stroke,@StrokeTime,@SMI,@SMITime,@TB,@TBTime,@Hepatitis,"
                           + "@HepatitisTime,@OLID,@OLIDTime,@OD,@ODTime,@Other,@OtherTime,@HistoryOfFather,@HistoryOfMother,@HistoryOfBrothers,@HistoryOfChildren,"
                           + "@GeneticHistory,@Disability,@Remarks)";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id"                , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.Id                },
                new OleDbParameter("@HODA"              , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.HODA              },
                new OleDbParameter("@EH"                , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.EH                },
                new OleDbParameter("@HBP"               , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.HBP               },
                new OleDbParameter("@HBPTime"           , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.HBPTime           },
                new OleDbParameter("@GDM"               , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.GDM               },
                new OleDbParameter("@GDMTime"           , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.GDMTime           },
                new OleDbParameter("@CH"                , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.CH                },
                new OleDbParameter("@CHTime"            , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.CHTime            },
                new OleDbParameter("@COP"               , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.COP               },
                new OleDbParameter("@COPTime"           , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.COPTime           },
                new OleDbParameter("@MTC"               , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.MTC               },
                new OleDbParameter("@MTCTime"           , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.MTCTime           },
                new OleDbParameter("@Stroke"            , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.Stroke            },
                new OleDbParameter("@StrokeTime"        , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.StrokeTime        },
                new OleDbParameter("@SMI"               , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.SMI               },
                new OleDbParameter("@SMITime"           , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.SMITime           },
                new OleDbParameter("@TB"                , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.TB                },
                new OleDbParameter("@TBTime"            , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.TBTime            },
                new OleDbParameter("@Hepatitis"         , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.Hepatitis         },
                new OleDbParameter("@HepatitisTime"     , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.HepatitisTime     },
                new OleDbParameter("@OLID"              , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.OLID              },
                new OleDbParameter("@OLIDTime"          , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.OLIDTime          },
                new OleDbParameter("@OD"                , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.OD                },
                new OleDbParameter("@ODTime"            , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.ODTime            },
                new OleDbParameter("@Other"             , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.Other             },
                new OleDbParameter("@OtherTime"         , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.OtherTime         },
                new OleDbParameter("@HistoryOfFather"   , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.HistoryOfFather   },
                new OleDbParameter("@HistoryOfMother"   , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.HistoryOfMother   },
                new OleDbParameter("@HistoryOfBrothers" , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.HistoryOfBrothers },
                new OleDbParameter("@HistoryOfChildren" , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.HistoryOfChildren },
                new OleDbParameter("@GeneticHistory"    , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.GeneticHistory    },
                new OleDbParameter("@Disability"        , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.Disability        },
                new OleDbParameter("@Remarks"           , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.Remarks           }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将居民疾病信息（ResidentDiseaseInfo）数据，根据主键“居民内部编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="residentDiseaseInfo">居民疾病信息（ResidentDiseaseInfo）实例对象</param>
        public override int Update(ResidentDiseaseInfo residentDiseaseInfo)
        {
            string sqlText = "UPDATE [ResidentDiseaseInfo] SET "
                           + "[HODA]=@HODA,[EH]=@EH,[HBP]=@HBP,[HBPTime]=@HBPTime,[GDM]=@GDM,[GDMTime]=@GDMTime,[CH]=@CH,[CHTime]=@CHTime,[COP]=@COP,[COPTime]=@COPTime,"
                           + "[MTC]=@MTC,[MTCTime]=@MTCTime,[Stroke]=@Stroke,[StrokeTime]=@StrokeTime,[SMI]=@SMI,[SMITime]=@SMITime,[TB]=@TB,[TBTime]=@TBTime,"
                           + "[Hepatitis]=@Hepatitis,[HepatitisTime]=@HepatitisTime,[OLID]=@OLID,[OLIDTime]=@OLIDTime,[OD]=@OD,[ODTime]=@ODTime,[Other]=@Other,[OtherTime]=@OtherTime,"
                           + "[HistoryOfFather]=@HistoryOfFather,[HistoryOfMother]=@HistoryOfMother,[HistoryOfBrothers]=@HistoryOfBrothers,[HistoryOfChildren]=@HistoryOfChildren,"
                           + "[GeneticHistory]=@GeneticHistory,[Disability]=@Disability,[Remarks]=@Remarks "
                           + "WHERE [Id]=@Id";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@HODA"              , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.HODA              },
                new OleDbParameter("@EH"                , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.EH                },
                new OleDbParameter("@HBP"               , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.HBP               },
                new OleDbParameter("@HBPTime"           , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.HBPTime           },
                new OleDbParameter("@GDM"               , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.GDM               },
                new OleDbParameter("@GDMTime"           , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.GDMTime           },
                new OleDbParameter("@CH"                , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.CH                },
                new OleDbParameter("@CHTime"            , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.CHTime            },
                new OleDbParameter("@COP"               , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.COP               },
                new OleDbParameter("@COPTime"           , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.COPTime           },
                new OleDbParameter("@MTC"               , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.MTC               },
                new OleDbParameter("@MTCTime"           , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.MTCTime           },
                new OleDbParameter("@Stroke"            , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.Stroke            },
                new OleDbParameter("@StrokeTime"        , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.StrokeTime        },
                new OleDbParameter("@SMI"               , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.SMI               },
                new OleDbParameter("@SMITime"           , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.SMITime           },
                new OleDbParameter("@TB"                , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.TB                },
                new OleDbParameter("@TBTime"            , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.TBTime            },
                new OleDbParameter("@Hepatitis"         , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.Hepatitis         },
                new OleDbParameter("@HepatitisTime"     , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.HepatitisTime     },
                new OleDbParameter("@OLID"              , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.OLID              },
                new OleDbParameter("@OLIDTime"          , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.OLIDTime          },
                new OleDbParameter("@OD"                , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.OD                },
                new OleDbParameter("@ODTime"            , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.ODTime            },
                new OleDbParameter("@Other"             , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.Other             },
                new OleDbParameter("@OtherTime"         , OleDbType.Date     , 8 ){ Value = residentDiseaseInfo.OtherTime         },
                new OleDbParameter("@HistoryOfFather"   , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.HistoryOfFather   },
                new OleDbParameter("@HistoryOfMother"   , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.HistoryOfMother   },
                new OleDbParameter("@HistoryOfBrothers" , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.HistoryOfBrothers },
                new OleDbParameter("@HistoryOfChildren" , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.HistoryOfChildren },
                new OleDbParameter("@GeneticHistory"    , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.GeneticHistory    },
                new OleDbParameter("@Disability"        , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.Disability        },
                new OleDbParameter("@Remarks"           , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.Remarks           },
                new OleDbParameter("@Id"                , OleDbType.VarWChar , 50){ Value = residentDiseaseInfo.Id                }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据居民疾病信息（ResidentDiseaseInfo）的主键“居民内部编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">居民疾病信息（ResidentDiseaseInfo）的主键“居民内部编号（Id）”</param>
        public override int Delete(string id)
        {
            string sqlText = "DELETE FROM [ResidentDiseaseInfo] "
                           + "WHERE [Id]=@Id";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id" , OleDbType.VarWChar , 50){ Value = id }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据居民疾病信息（ResidentDiseaseInfo）的主键“居民内部编号（Id）”从数据库中获取居民疾病信息（ResidentDiseaseInfo）的实例。
        /// 成功从数据库中取得记录返回新居民疾病信息（ResidentDiseaseInfo）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">居民疾病信息（ResidentDiseaseInfo）的主键“居民内部编号（Id）”</param>
        public override ResidentDiseaseInfo GetDataById(string id)
        {
            ResidentDiseaseInfo residentDiseaseInfo = null;
            string sqlText = "SELECT [Id],[HODA],[EH],[HBP],[HBPTime],[GDM],[GDMTime],[CH],[CHTime],[COP],[COPTime],[MTC],[MTCTime],[Stroke],[StrokeTime],[SMI],[SMITime],[TB],[TBTime],[Hepatitis],"
                           + "[HepatitisTime],[OLID],[OLIDTime],[OD],[ODTime],[Other],[OtherTime],[HistoryOfFather],[HistoryOfMother],[HistoryOfBrothers],[HistoryOfChildren],"
                           + "[GeneticHistory],[Disability],[Remarks] "
                           + "FROM [ResidentDiseaseInfo] "
                           + "WHERE [Id]=@Id";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id" , OleDbType.VarWChar , 50){ Value = id }
            };

            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, parameters);
            if (oleDbDataReader.Read())
            {
                residentDiseaseInfo = new ResidentDiseaseInfo();
                ReadResidentDiseaseInfoAllData(oleDbDataReader,residentDiseaseInfo);
            }
            oleDbDataReader.Close();
            return residentDiseaseInfo;
        }


        /// <summary>
        /// 从数据库中读取并返回所有居民疾病信息（ResidentDiseaseInfo）List列表。
        /// </summary>
        public override List<ResidentDiseaseInfo> GetAllList()
        {
            string sqlText = "SELECT [Id],[HODA],[EH],[HBP],[HBPTime],[GDM],[GDMTime],[CH],[CHTime],[COP],[COPTime],[MTC],[MTCTime],[Stroke],[StrokeTime],[SMI],[SMITime],[TB],[TBTime],[Hepatitis],"
                           + "[HepatitisTime],[OLID],[OLIDTime],[OD],[ODTime],[Other],[OtherTime],[HistoryOfFather],[HistoryOfMother],[HistoryOfBrothers],[HistoryOfChildren],"
                           + "[GeneticHistory],[Disability],[Remarks] "
                           + "FROM [ResidentDiseaseInfo]";
            List<ResidentDiseaseInfo> list = new List<ResidentDiseaseInfo>();
            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, null);
            while (oleDbDataReader.Read())
            {
                ResidentDiseaseInfo residentDiseaseInfo = new ResidentDiseaseInfo();
                ReadResidentDiseaseInfoAllData(oleDbDataReader, residentDiseaseInfo);
                list.Add(residentDiseaseInfo);
            }
            oleDbDataReader.Close();
            return list;
        }


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的居民疾病信息（ResidentDiseaseInfo）的列表及分页信息。
        /// 该方法所获取的居民疾病信息（ResidentDiseaseInfo）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public override PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "SELECT [Id],[HODA],[EH],[Disability],[Remarks] "
                           + "FROM [ResidentDiseaseInfo]";
            List<ResidentDiseaseInfo> list = new List<ResidentDiseaseInfo>();
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
                    ResidentDiseaseInfo residentDiseaseInfo = new ResidentDiseaseInfo();
                    ReadResidentDiseaseInfoPageData(oleDbDataReader, residentDiseaseInfo);
                    list.Add(residentDiseaseInfo);
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
