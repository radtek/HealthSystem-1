using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OracleClient;
using System.Text;
using System.Data;

namespace Zhbit.HealthSystem.SFL
{
    public class OracleHelper
    {
        private static OracleConnection GetNewConnection()
        {
            OracleConnection oracleConnection = new OracleConnection();
            oracleConnection.ConnectionString = System.Configuration.ConfigurationManager.AppSettings["OracleConnString"];

            try
            {
                oracleConnection.Open();
            }
            catch (Exception ex)
            {
                oracleConnection.Close();
                throw new CustomException("系统无法与数据库建立连结，请您与系统管理员联系。", ExceptionType.Error, "错误信息：" + ex.Message);
            }
            return oracleConnection;
        }

        /// <summary>
        /// 执行SQL语句，并返回一个OracleDataReader对象。
        /// </summary>
        /// <param name="commandText">SQL语句</param>
        /// <returns>OracleDataReader对象</returns>
        public static OracleDataReader ExecuteReader(string commandText, OracleParameter[] commandParm)
        {
            OracleConnection oracleConnection = GetNewConnection();
            OracleCommand oracleCommand = new OracleCommand(commandText, oracleConnection);
            PrepareCommand(oracleCommand, commandParm);
            try
            {
                OracleDataReader dbDataReader = oracleCommand.ExecuteReader(CommandBehavior.CloseConnection);
                return dbDataReader;
            }
            catch (Exception e)
            {
                oracleConnection.Close();
                throw new CustomException("系统对数据库进行操作时发生错误，请您与系统管理员联系。", ExceptionType.Error, "执行语句：" + commandText + "\r\n错误信息：" + e.Message);
            }
        }



        /// <summary>
        /// 执行SQL语句，不返回任何对象。
        /// </summary>
        /// <param name="commandText">SQL语句</param>
        public static int ExecuteNonQuery(string commandText, OracleParameter[] commandParm)
        {
            OracleConnection oracleConnection = GetNewConnection();
            OracleCommand oracleCommand = new OracleCommand(commandText, oracleConnection);
            PrepareCommand(oracleCommand, commandParm);
            int rowCount = 0;
            try
            {
                rowCount = oracleCommand.ExecuteNonQuery();
                oracleConnection.Close();
            }
            catch (Exception e)
            {
                oracleConnection.Close();
                throw new CustomException("系统对数据库进行操作时发生错误，请您与系统管理员联系。", ExceptionType.Error, "执行语句：" + commandText + "\r\n错误信息：" + e.Message);
            }
            return rowCount;
        }

        private static void PrepareCommand(OracleCommand oracleCommand, OracleParameter[] commandParms)
        {
            if (commandParms != null)
            {
                foreach (OracleParameter parameter in commandParms)
                {
                    if (parameter.Value == null)
                    {
                        parameter.Value = DBNull.Value;
                    }
                    oracleCommand.Parameters.Add(parameter);
                }
            }
        }
    }
}
