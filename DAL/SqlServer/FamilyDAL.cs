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
    /// 对象名称：家庭SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“家庭类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“家庭类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：北京理工大学珠海学院　－　计算机学院
    /// 编写日期：2016-4-21 17:18:21
    /// </summary>
    public class FamilyDAL:DAL.Common.FamilyDAL
    {
        #region 多层框架式下的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为多层框架式代码，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用多层框架式代码覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍
        

        /// <summary>
        /// 将家庭（Family）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="family">家庭（Family）实例对象</param>
        public override int Insert(Family family)
        {
            string sqlText = "INSERT INTO [Family]"
                           + "([Name],[Owner],[FamilyType],[HousingTypes],[Total],[Old],[ResponsibleDoctor],[CreateDate],[ManageInstitutionsId],[Remark])"
                           + "VALUES"
                           + "(@Name,@Owner,@FamilyType,@HousingTypes,@Total,@Old,@ResponsibleDoctor,@CreateDate,@ManageInstitutionsId,@Remark)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Name"                 , SqlDbType.NVarChar , 50){ Value = family.Name               },
                new SqlParameter("@Owner"                , SqlDbType.NVarChar , 50){ Value = family.Owner              },
                new SqlParameter("@FamilyType"           , SqlDbType.Int      , 4 ){ Value = family.FamilyType         },
                new SqlParameter("@HousingTypes"         , SqlDbType.Int      , 4 ){ Value = family.HousingTypes       },
                new SqlParameter("@Total"                , SqlDbType.Int      , 4 ){ Value = family.Total              },
                new SqlParameter("@Old"                  , SqlDbType.Int      , 4 ){ Value = family.Old                },
                new SqlParameter("@ResponsibleDoctor"    , SqlDbType.NVarChar , 50){ Value = family.ResponsibleDoctor  },
                new SqlParameter("@CreateDate"           , SqlDbType.DateTime , 8 ){ Value = family.CreateDate         },
                new SqlParameter("@ManageInstitutionsId" , SqlDbType.Int      , 4 ){ Value = family.ManageInstitutions.Id },
                new SqlParameter("@Remark"               , SqlDbType.NVarChar , 50){ Value = family.Remark             }
            };
         
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将家庭（Family）数据，根据主键“家庭档案号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="family">家庭（Family）实例对象</param>
        public override int Update(Family family)
        {
            string sqlText = "UPDATE [Family] SET "
                           + "[Name]=@Name,[Owner]=@Owner,[FamilyType]=@FamilyType,[HousingTypes]=@HousingTypes,[Total]=@Total,[Old]=@Old,"
                           + "[ResponsibleDoctor]=@ResponsibleDoctor,[CreateDate]=@CreateDate,[ManageInstitutionsId]=@ManageInstitutionsId,[Remark]=@Remark "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Name"                 , SqlDbType.NVarChar , 50){ Value = family.Name               },
                new SqlParameter("@Owner"                , SqlDbType.NVarChar , 50){ Value = family.Owner              },
                new SqlParameter("@FamilyType"           , SqlDbType.Int      , 4 ){ Value = family.FamilyType         },
                new SqlParameter("@HousingTypes"         , SqlDbType.Int      , 4 ){ Value = family.HousingTypes       },
                new SqlParameter("@Total"                , SqlDbType.Int      , 4 ){ Value = family.Total              },
                new SqlParameter("@Old"                  , SqlDbType.Int      , 4 ){ Value = family.Old                },
                new SqlParameter("@ResponsibleDoctor"    , SqlDbType.NVarChar , 50){ Value = family.ResponsibleDoctor  },
                new SqlParameter("@CreateDate"           , SqlDbType.DateTime , 8 ){ Value = family.CreateDate         },
                new SqlParameter("@ManageInstitutionsId" , SqlDbType.Int      , 4 ){ Value = family.ManageInstitutions.Id },
                new SqlParameter("@Remark"               , SqlDbType.NVarChar , 50){ Value = family.Remark             },
                new SqlParameter("@Id"                   , SqlDbType.Int      , 4 ){ Value = family.Id                 }
            };
         
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据家庭（Family）的主键“家庭档案号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">家庭（Family）的主键“家庭档案号（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [Family] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据家庭（Family）的主键“家庭档案号（Id）”从数据库中获取家庭（Family）的实例。
        /// 成功从数据库中取得记录返回新家庭（Family）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">家庭（Family）的主键“家庭档案号（Id）”</param>
        public override Family GetDataById(int id)
        {
            Family family = null;
            string sqlText = "SELECT [Id],[Name],[Owner],[FamilyType],[HousingTypes],[Total],[Old],[ResponsibleDoctor],[CreateDate],[ManageInstitutionsId],[Remark] "
                           + "FROM [Family] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                family = new Family();
                ReadFamilyAllData(sqlDataReader,family);
            }
            sqlDataReader.Close();
            return family;
        }


        /// <summary>
        /// 从数据库中读取并返回所有家庭（Family）List列表。
        /// </summary>
        public override List<Family> GetAllList()
        {
            string sqlText = "SELECT [Id],[Name],[Owner],[FamilyType],[HousingTypes],[Total],[Old],[ResponsibleDoctor],[CreateDate],[ManageInstitutionsId],[Remark] "
                           + "FROM [Family]";
            List<Family> list = new List<Family>();
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, null);
            while (sqlDataReader.Read())
            {
                Family family = new Family();
                ReadFamilyAllData(sqlDataReader, family);
                list.Add(family);
            }
            sqlDataReader.Close();
            return list;
        }


        /// <summary>
        /// 根据每页记录数及所要获取的页数，从数据库中读取并返回经过分页后的家庭（Family）的列表及分页信息。
        /// 该方法所获取的家庭（Family）列表仅用于在数据控件中显示，该方法只为对象中需要显示的属性进行赋值。
        /// </summary>
        public override PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "SELECT [Id],[Name],[Owner],[FamilyType],[HousingTypes],[Total],[Old],[ResponsibleDoctor],[CreateDate] "
                           + "FROM [Family]";
            List<Family> list = new List<Family>();
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
                    Family family = new Family();
                    ReadFamilyPageData(sqlDataReader, family);
                    list.Add(family);
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










    }
}
