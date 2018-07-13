using System;
using System.Data;
using System.Data.SQLite;

namespace hzcl.swb.DAL
{
    public static class SqliteHelp
    {
        private static string conn = @"Data Source =D:\SqliteTest.db";


        /// <summary>
        ///获取所有信息
        /// </summary>
        /// <param name="sql">命令</param>
        /// <param name="parameters">参数</param>
        /// <returns>返回DataTable</returns>
        public static DataTable ExecuteTable(string sql, params SQLiteParameter[] parameters )
        {
            DataTable dt = new DataTable();
            using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sql, conn))
            {
                if (parameters != null)
                {
                    dataAdapter.SelectCommand.Parameters.AddRange(parameters);
                }

                dataAdapter.Fill(dt);
            }

            return dt;
        }


        public static int ExecuteNonQuery(string sql, params SQLiteParameter[] parameters)
        {
            int i;
            using (SQLiteConnection connection = new SQLiteConnection(conn))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }

                    i = command.ExecuteNonQuery();
                }
            }
            return i;
        }


        public static Object ExecuteScalar(string sql, params SQLiteParameter[] param)
        {
            using (SQLiteConnection connection = new SQLiteConnection(conn))
            {
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    if (param != null)
                    {
                        command.Parameters.AddRange(param);
                    }

                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
        }
    }
}