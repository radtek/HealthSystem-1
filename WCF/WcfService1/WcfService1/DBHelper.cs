using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WcfService1
{
    class DBHelper
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["DBConnStr"].ConnectionString;
    

        public static string ConnectionString
        {
            get
            {
                return connectionString;
            }
        }
        /// <summary>
        /// 执行Sql语句，返回影响的记录数
        /// </summary>
        /// <param name="strSql">SQL语句</param>
        /// <param name="conString">连接字符串</param>
        /// <returns>影响的行数</returns>
        public static int ExecuteNonQuerySql(string strSql, string conString)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(strSql, connection))
                {
                    connection.Open();
                    try
                    {
                        int rows = cmd.ExecuteNonQuery();
                        return rows;
                        
                    }
                    catch(Exception e)
                    {
                        
                        return 0;
                    }

                }
            }
        }

        /// <summary>
        /// 执行Sql语句，返回第一行第一列
        /// </summary>
        /// <param name="strSql">SQL语句</param>
        /// <param name="conString">连接字符串</param>
        /// <returns>第一行第一列的值</returns>
        public static int ExecuteScalarSql(string strSql, string conString)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(strSql, connection))
                {
                    connection.Open();
                    try
                    {
                        int value = (int)cmd.ExecuteScalar();
                        return value;

                    }
                    catch (Exception e)
                    {
                        
                        return -1;
                    }
                    
                }
            }
        }
        public static string ExecuteScalarSql_string(string strSql, string conString)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(strSql, connection))
                {
                    connection.Open();
                    try
                    {
                        string value = (string)cmd.ExecuteScalar();
                        return value;

                    }
                    catch (Exception e)
                    {
                       
                        return "-1";
                    }

                }
            }
        }
        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="strSql">查询语句</param>
        /// <param name="conString">连接字符串</param>
        /// <returns>DataSet</returns>
        public static DataSet Query(string strSql, string conString)
        {
            using (SqlConnection connection = new SqlConnection(conString))
            {
                DataSet ds = new DataSet();
                connection.Open();
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter(strSql, connection);
                    sda.Fill(ds, "ds");
                    return ds;
                }
                catch(Exception e)
                {
                    
                    return ds;
                }
            }
        }

        //public static SqlCommand Sqlcmm(string strSql, string conString)
        //{
            
        //    using (SqlConnection connection = new SqlConnection(conString))
        //    {               
        //        connection.Open();
        //        try
        //        {
        //            SqlCommand SCD = new SqlCommand(strSql, connection);                    
        //            return SCD;
        //        }
        //        catch (Exception e)
        //        {
        //           
        //            SqlCommand SCD = new SqlCommand();
        //            return SCD;
        //        }

        //    }
        //}
    }
}
