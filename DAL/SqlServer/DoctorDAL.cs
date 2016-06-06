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
    /// �������ƣ�����ҽ��SQL Server���ݷ������ࣨ���ݷ��ʲ㣩
    /// ����˵�����ṩ������ҽ���ࣨҵ���߼��㣩�����SQL Server�ġ���ɾ�Ĳ顱�ȸ������ݷ��ʷ������̳�ͨ�����ݷ��ʸ��ࡣ
    /// ����˵����ͨ������Ҫֱ��ʵ�������࣬��ʹ�á�����ҽ���ࣨҵ���߼��㣩���е�DataAccess���������ñ�����ʵ�ֵķ�����
    /// ������������������ѧ�麣ѧԺ�����������ѧԺ
    /// ��д���ڣ�2016/4/28 13:59:21
    /// </summary>
    public class DoctorDAL:DAL.Common.DoctorDAL
    {
        #region ������µ�Ĭ�ϴ���
        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ������Ĵ���Ϊ��������Զ����ɣ�ʵ���˸����ж���ĳ��󷽷����벻Ҫֱ���޸ĸ������е��κδ��룬   
        //  ���ڸ�����������κ��Զ�����룬�����෢�����ʱ����������ʱʹ�ö�����������ɸ������еĴ��롣  
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l


        /// <summary>
        /// ������ҽ����Doctor�����ݣ�����INSERT�������뵽���ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="doctor">����ҽ����Doctor��ʵ������</param>
        public override int Insert(Doctor doctor)
        {
            string sqlText = "INSERT INTO [Doctor]"
                           + "([DoctorId],[Name],[ExamNo],[Pwd],[InstitutionId],[Remarks])"
                           + "VALUES"
                           + "(@DoctorId,@Name,@ExamNo,@Pwd,@InstitutionId,@Remarks)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@DoctorId"      , SqlDbType.NVarChar , 50){ Value = doctor.DoctorId    },
                new SqlParameter("@Name"          , SqlDbType.NVarChar , 50){ Value = doctor.Name        },
                new SqlParameter("@ExamNo"        , SqlDbType.NVarChar , 50){ Value = doctor.ExamNo      },
                new SqlParameter("@Pwd"           , SqlDbType.NVarChar , 50){ Value = doctor.Pwd         },
                new SqlParameter("@InstitutionId" , SqlDbType.Int      , 4 ){ Value = doctor.Institution.Id },
                new SqlParameter("@Remarks"       , SqlDbType.NVarChar , 50){ Value = doctor.Remarks     }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ������ҽ����Doctor�����ݣ������������Զ���ţ�Id��������UPDATE�������µ����ݿ��У���������Ӱ���������
        /// </summary>
        /// <param name="doctor">����ҽ����Doctor��ʵ������</param>
        public override int Update(Doctor doctor)
        {
            string sqlText = "UPDATE [Doctor] SET "
                           + "[DoctorId]=@DoctorId,[Name]=@Name,[ExamNo]=@ExamNo,[Pwd]=@Pwd,[InstitutionId]=@InstitutionId,[Remarks]=@Remarks "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@DoctorId"      , SqlDbType.NVarChar , 50){ Value = doctor.DoctorId    },
                new SqlParameter("@Name"          , SqlDbType.NVarChar , 50){ Value = doctor.Name        },
                new SqlParameter("@ExamNo"        , SqlDbType.NVarChar , 50){ Value = doctor.ExamNo      },
                new SqlParameter("@Pwd"           , SqlDbType.NVarChar , 50){ Value = doctor.Pwd         },
                new SqlParameter("@InstitutionId" , SqlDbType.Int      , 4 ){ Value = doctor.Institution.Id },
                new SqlParameter("@Remarks"       , SqlDbType.NVarChar , 50){ Value = doctor.Remarks     },
                new SqlParameter("@Id"            , SqlDbType.Int      , 4 ){ Value = doctor.Id          }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ��������ҽ����Doctor�����������Զ���ţ�Id��������DELETE���������ݿ���ɾ����ؼ�¼����������Ӱ���������
        /// </summary>
        /// <param name="id">����ҽ����Doctor�����������Զ���ţ�Id����</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [Doctor] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// ��������ҽ����Doctor�����������Զ���ţ�Id���������ݿ��л�ȡ����ҽ����Doctor����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼����������ҽ����Doctor����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="id">����ҽ����Doctor�����������Զ���ţ�Id����</param>
        public override Doctor GetDataById(int id)
        {
            Doctor doctor = null;
            string sqlText = "SELECT [Id],[DoctorId],[Name],[ExamNo],[Pwd],[InstitutionId],[Remarks] "
                           + "FROM [Doctor] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                doctor = new Doctor();
                ReadDoctorAllData(sqlDataReader,doctor);
            }
            sqlDataReader.Close();
            return doctor;
        }


        /// <summary>
        ///  ��������ҽ����Doctor���ġ�ҽ����ţ�DoctorId���������ݿ��л�ȡ����ҽ����Doctor����ʵ����
        /// �ɹ������ݿ���ȡ�ü�¼����������ҽ����Doctor����ʵ������û��ȡ����¼����nullֵ��
        /// </summary>
        /// <param name="doctorid">����ҽ����Doctor���ġ�ҽ����ţ�DoctorId����</param>
        /// <returns></returns>
        public override Doctor GetDataByDoctorId(string doctorid)
        {
            Doctor doctor = null;
            string sqlText = "SELECT [Id],[DoctorId],[Name],[ExamNo],[Pwd],[InstitutionId],[Remarks] "
                           + "FROM [Doctor] "
                           + "WHERE [DoctorId]=@DoctorId";
            SqlParameter[] parameters =
            {
                new SqlParameter("@DoctorId" , SqlDbType.NVarChar , 50){ Value = doctorid }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                doctor = new Doctor();
                ReadDoctorAllData(sqlDataReader, doctor);
            }
            sqlDataReader.Close();
            return doctor;
        }

        /// <summary>
        /// �����ݿ��ж�ȡ��������������ҽ����Doctor��List�б�
        /// </summary>
        public override List<Doctor> GetAllList()
        {
            string sqlText = "SELECT [Id],[DoctorId],[Name],[ExamNo],[Pwd],[InstitutionId],[Remarks] "
                           + "FROM [Doctor]";
            List<Doctor> list = new List<Doctor>();
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, null);
            while (sqlDataReader.Read())
            {
                Doctor doctor = new Doctor();
                ReadDoctorAllData(sqlDataReader, doctor);
                list.Add(doctor);
            }
            sqlDataReader.Close();
            return list;
        }


        /// <summary>
        /// ����ÿҳ��¼������Ҫ��ȡ��ҳ���������ݿ��ж�ȡ�����ؾ�����ҳ�������ҽ����Doctor�����б���ҳ��Ϣ��
        /// �÷�������ȡ������ҽ����Doctor���б�����������ݿؼ�����ʾ���÷���ֻΪ��������Ҫ��ʾ�����Խ��и�ֵ��
        /// </summary>
        public override PageData GetPageList(int pageSize, int curPage)
        {
            string sqlText = "SELECT [Id],[DoctorId],[Name],[ExamNo],[Pwd],[InstitutionId],[Remarks] "
                           + "FROM [Doctor]";
            List<Doctor> list = new List<Doctor>();
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
                    Doctor doctor = new Doctor();
                    ReadDoctorPageData(sqlDataReader, doctor);
                    list.Add(doctor);
                }
            }
            sqlDataReader.Close();

            if(pageData.RecordCount>0)
                pageData.PageCount = Convert.ToInt32(Math.Ceiling((double)pageData.RecordCount / (double)pageSize));

            pageData.PageList = list;
            return pageData;
        }

        #endregion ������µ�Ĭ�ϴ���

        //�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h�h
        //  ˵������������Ĵ���Ϊ��ƿ�����Ա����д����ҪΪ��չ�����ݷ�����Ĺ��ܣ�������ı��������Լ�������ݷ��ʷ�����  
        //  ע�⣺Ϊ�˱�֤����Ŀ�Ķ����ݿ�֧������չ�ԣ������ڱ���ĸ����ж���س��󷽷����ж��壬���ڱ����н��о���ʵ�֡�
        //�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l�l










    }
}
