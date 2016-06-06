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
    /// �������ƣ���ͥOleDb���ݷ������ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ����ͥ�ࣨҵ���߼��㣩�����OleDb�ġ���ɾ�Ĳ顱�ȸ������ݷ��ʷ������̳�ͨ�����ݷ��ʸ��ࡣ
    /// ����˵����ͨ������Ҫֱ��ʵ�������࣬��ʹ�á���ͥ�ࣨҵ���߼��㣩���е�DataAccess���������ñ�����ʵ�ֵķ�����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016-4-21 17:18:21
    /// </summary>
    public class FamilyDAL:DAL.Common.FamilyDAL
    {
        #region �����ʽ�µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ�����ʽ���룬ʵ���˸����ж���ĳ��󷽷����벻Ҫֱ���޸ĸ������е��κδ��룬   
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö����ʽ���븲�����еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>
        /// ����ͥ��Family�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="family">��ͥ��Family��ʵ������</param>
        public override int Insert(Family family)
        {
            string sqlText = "INSERT INTO [Family]"
                           + "([Name],[Owner],[FamilyType],[HousingTypes],[Total],[Old],[ResponsibleDoctor],[CreateDate],[ManageInstitutionsId],[Remark])"
                           + "VALUES"
                           + "(@Name,@Owner,@FamilyType,@HousingTypes,@Total,@Old,@ResponsibleDoctor,@CreateDate,@ManageInstitutionsId,@Remark)";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Name"                 , OleDbType.VarWChar , 50){ Value = family.Name               },
                new OleDbParameter("@Owner"                , OleDbType.VarWChar , 50){ Value = family.Owner              },
                new OleDbParameter("@FamilyType"           , OleDbType.Integer  , 4 ){ Value = family.FamilyType         },
                new OleDbParameter("@HousingTypes"         , OleDbType.Integer  , 4 ){ Value = family.HousingTypes       },
                new OleDbParameter("@Total"                , OleDbType.Integer  , 4 ){ Value = family.Total              },
                new OleDbParameter("@Old"                  , OleDbType.Integer  , 4 ){ Value = family.Old                },
                new OleDbParameter("@ResponsibleDoctor"    , OleDbType.VarWChar , 50){ Value = family.ResponsibleDoctor  },
                new OleDbParameter("@CreateDate"           , OleDbType.Date     , 8 ){ Value = family.CreateDate         },
                new OleDbParameter("@ManageInstitutionsId" , OleDbType.Integer  , 4 ){ Value = family.ManageInstitutions },
                new OleDbParameter("@Remark"               , OleDbType.VarWChar , 50){ Value = family.Remark             }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ����ͥ��Family�����ݣ�������������ͥ�����ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="family">��ͥ��Family��ʵ������</param>
        public override int Update(Family family)
        {
            string sqlText = "UPDATE [Family] SET "
                           + "[Name]=@Name,[Owner]=@Owner,[FamilyType]=@FamilyType,[HousingTypes]=@HousingTypes,[Total]=@Total,[Old]=@Old,"
                           + "[ResponsibleDoctor]=@ResponsibleDoctor,[CreateDate]=@CreateDate,[ManageInstitutionsId]=@ManageInstitutionsId,[Remark]=@Remark "
                           + "WHERE [Id]=@Id";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Name"                 , OleDbType.VarWChar , 50){ Value = family.Name               },
                new OleDbParameter("@Owner"                , OleDbType.VarWChar , 50){ Value = family.Owner              },
                new OleDbParameter("@FamilyType"           , OleDbType.Integer  , 4 ){ Value = family.FamilyType         },
                new OleDbParameter("@HousingTypes"         , OleDbType.Integer  , 4 ){ Value = family.HousingTypes       },
                new OleDbParameter("@Total"                , OleDbType.Integer  , 4 ){ Value = family.Total              },
                new OleDbParameter("@Old"                  , OleDbType.Integer  , 4 ){ Value = family.Old                },
                new OleDbParameter("@ResponsibleDoctor"    , OleDbType.VarWChar , 50){ Value = family.ResponsibleDoctor  },
                new OleDbParameter("@CreateDate"           , OleDbType.Date     , 8 ){ Value = family.CreateDate         },
                new OleDbParameter("@ManageInstitutionsId" , OleDbType.Integer  , 4 ){ Value = family.ManageInstitutions },
                new OleDbParameter("@Remark"               , OleDbType.VarWChar , 50){ Value = family.Remark             },
                new OleDbParameter("@Id"                   , OleDbType.Integer  , 4 ){ Value = family.Id                 }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ���ݼ�ͥ��Family������������ͥ�����ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">��ͥ��Family������������ͥ�����ţ�Id����</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [Family] "
                           + "WHERE [Id]=@Id";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id" , OleDbType.Integer , 4){ Value = id }
            };
            return SFL.OleDbHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ���ݼ�ͥ��Family������������ͥ�����ţ�Id���������ݿ��л�ȡ��ͥ��Family����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼�����¼�ͥ��Family����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">��ͥ��Family������������ͥ�����ţ�Id����</param>
        public override Family GetDataById(int id)
        {
            Family family = null;
            string sqlText = "SELECT [Id],[Name],[Owner],[FamilyType],[HousingTypes],[Total],[Old],[ResponsibleDoctor],[CreateDate],[ManageInstitutionsId],[Remark] "
                           + "FROM [Family] "
                           + "WHERE [Id]=@Id";
            OleDbParameter[] parameters = 
            {
                new OleDbParameter("@Id" , OleDbType.Integer , 4){ Value = id }
            };

            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, parameters);
            if (oleDbDataReader.Read())
            {
                family = new Family();
                ReadFamilyAllData(oleDbDataReader,family);
            }
            oleDbDataReader.Close();
            return family;
        }


        /// <summary>
        /// �����ݿ��ж�ȡ���������м�ͥ��Family��List�б�
        /// </summary>
        public override List<Family> GetAllList()
        {
            string sqlText = "SELECT [Id],[Name],[Owner],[FamilyType],[HousingTypes],[Total],[Old],[ResponsibleDoctor],[CreateDate],[ManageInstitutionsId],[Remark] "
                           + "FROM [Family]";
            List<Family> list = new List<Family>();
            OleDbDataReader oleDbDataReader = SFL.OleDbHelper.ExecuteReader(sqlText, null);
            while (oleDbDataReader.Read())
            {
                Family family = new Family();
                ReadFamilyAllData(oleDbDataReader, family);
                list.Add(family);
            }
            oleDbDataReader.Close();
            return list;
        }


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ��ļ�ͥ��Family�����б���ҳ��Ϣ��
        /// �÷�������ȡ�ļ�ͥ��Family���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
        /// </summary>
        public override PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "SELECT [Id],[Name],[Owner],[FamilyType],[HousingTypes],[Total],[Old],[ResponsibleDoctor],[CreateDate] "
                           + "FROM [Family]";
            List<Family> list = new List<Family>();
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
                    Family family = new Family();
                    ReadFamilyPageData(oleDbDataReader, family);
                    list.Add(family);
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
