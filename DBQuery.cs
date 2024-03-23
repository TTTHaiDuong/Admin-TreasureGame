using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    internal class DBQuery
    {
        public delegate void SqlError(Exception ex);

        public static event SqlError Error;
        private const string ConnectionString = @"Data source=DUONG\HAIDUONG;Initial Catalog=TREASUREGAME;Integrated Security = True";

        public const string QuestionsTableName = "QUESTION";
        public const string StudentsTableName = "PLAYER";
        public const string AccountsTableName = "ACCOUNT";

        public static DataTable ExecuteQuery(string query)
        {
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(table);
                    }
                }
                catch (SqlException ex)
                {
                    Error?.Invoke(ex);
                }
                finally
                {
                    con.Close();
                }
            }
            return table;
        }

        public static DataTable ExecuteQuery(string query, string[] parameters, string[] values)
        {
            if (parameters.Length != values.Length) throw new Exception("Số lượng tham số và giá trị không bằng nhau!");
            DataTable table = new DataTable();
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        for (int i = 0; i < parameters.Length; i++)
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);

                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(table);
                    }
                }
                catch (SqlException ex)
                {
                    Error?.Invoke(ex);
                }
                finally
                {
                    con.Close();
                }
            }
            return table;
        }

        public static object ExecuteScalar(string query)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.CommandType = CommandType.Text;
                        con.Open();
                        return cmd.ExecuteScalar();
                    }
                }
                catch (SqlException ex)
                {
                    Error?.Invoke(ex);
                }
                finally
                {
                    con.Close();
                }
            }
            return null;
        }
    }
}
