using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Core
{
    public sealed class SqlProvider
    {
        private static readonly Lazy<SqlProvider> lazy = new Lazy<SqlProvider>(() => new SqlProvider());
        private string connectionString;
        private int commandTimeout = 30;

        public static SqlProvider Instance { get { return lazy.Value; } }

        private SqlProvider()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public void UseConnectionString(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Connection string required");
            connectionString = value;
        }

        public void SetCommandTimeout(int seconds)
        {
            if (seconds <= 0) throw new ArgumentOutOfRangeException(nameof(seconds));
            commandTimeout = seconds;
        }

        public int ExecuteNonQuery(string textOrProc, Dictionary<string, object> parameters, CommandType commandType)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(textOrProc, conn))
            {
                cmd.CommandType = commandType;
                cmd.CommandTimeout = commandTimeout;
                AddParameters(cmd, parameters);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public object ExecuteScalar(string textOrProc, Dictionary<string, object> parameters, CommandType commandType)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(textOrProc, conn))
            {
                cmd.CommandType = commandType;
                cmd.CommandTimeout = commandTimeout;
                AddParameters(cmd, parameters);
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }

        public DataTable ExecuteReader(string textOrProc, Dictionary<string, object> parameters, CommandType commandType)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(textOrProc, conn))
            {
                cmd.CommandType = commandType;
                cmd.CommandTimeout = commandTimeout;
                AddParameters(cmd, parameters);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        private static void AddParameters(SqlCommand cmd, Dictionary<string, object> parameters)
        {
            if (parameters == null) return;
            foreach (KeyValuePair<string, object> kv in parameters)
            {
                object v = kv.Value ?? DBNull.Value;
                cmd.Parameters.AddWithValue("@" + kv.Key, v);
            }
        }
    }
}
