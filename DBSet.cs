using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Admin
{
    internal class DBSet
    {
        public delegate void CannotSave(string message);
        public event CannotSave ErrorSave;

        public bool QuestionTableSave(DataGridView questions)
        {
            if (DoDataGridViewHaveAnyEmptyCells(questions))
            {
                ErrorSave?.Invoke("Có trường dữ liệu ô bị trống!");
                ErrorSave = null;
                return false;
            }

            using (SqlConnection con = new SqlConnection(DBQuery.ConnectionString))
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    cmd.Connection = con;
                    cmd.CommandText = $"DELETE * FROM {DBQuery.QuestionsTable}";

                    con.Open();
                    cmd.ExecuteNonQuery();

                    for (int i = 0; i < questions.Rows.Count; i++)
                    {
                        DataGridViewRow row = questions.Rows[i];
                        if (!row.IsNewRow)
                        {
                            string id = row.Cells[DBQuery.QuestionIdColumn].Value.ToString();
                            string question = row.Cells[DBQuery.QuestionColumn].Value.ToString();
                            string answer = row.Cells[DBQuery.QuestionAnswerColumn].Value.ToString();
                            string choice1 = row.Cells[DBQuery.QuestionChoice1Column].Value.ToString();
                            string choice2 = row.Cells[DBQuery.QuestionChoice2Column].Value.ToString();
                            string choice3 = row.Cells[DBQuery.QuestionChoice3Column].Value.ToString();

                            string query = $"INSERT INTO {DBQuery.QuestionsTable} VALUES (@id, @question, @answer, @choice1, @choice2, @choice3)";

                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.Parameters.AddWithValue("@question", question);
                            cmd.Parameters.AddWithValue("@answer", answer);
                            cmd.Parameters.AddWithValue("@choice1", choice1);
                            cmd.Parameters.AddWithValue("@choice2", choice2);
                            cmd.Parameters.AddWithValue("@choice3", choice3);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    con.Close();
                }
                catch (SqlException ex)
                {
                    ErrorSave?.Invoke(ex.Message);
                    return false;
                }
                finally { con.Close(); }
            }
            return true;
        }
        public bool StudentTableSave(DataGridView students)
        {
            if (DoDataGridViewHaveAnyEmptyCells(students))
            {
                ErrorSave?.Invoke("Có trường dữ liệu ô bị trống!");
                ErrorSave = null;
                return false;
            }

            using (SqlConnection con = new SqlConnection(DBQuery.ConnectionString))
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    cmd.Connection = con;
                    cmd.CommandText = $"DELETE * FROM {DBQuery.StudentTableName}";

                    con.Open();
                    cmd.ExecuteNonQuery();

                    for (int i = 0; i < students.Rows.Count; i++)
                    {
                        DataGridViewRow row = students.Rows[i];
                        if (!row.IsNewRow)
                        {
                            string id = row.Cells[DBQuery.StudentIdColumn].Value.ToString();
                            string name = row.Cells[DBQuery.StudentNameColumn].Value.ToString();
                            string score = row.Cells[DBQuery.StudentScoreColumn].Value.ToString();
                            string attendance = row.Cells[DBQuery.StudentAttendanceColumn].Value.ToString();

                            string query = $"INSERT INTO {DBQuery.StudentTableName} VALUES (@studentId, @name, @score, @attendance)";

                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@studentId", id);
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@score", score);
                            cmd.Parameters.AddWithValue("@attendance", attendance);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    con.Close();
                }
                catch (SqlException ex)
                {
                    ErrorSave?.Invoke(ex.Message);
                    return false;
                }
                finally { con.Close(); }
            }
            return true;
        }
        public bool AccountTableSave(DataGridView accounts)
        {
            if (DoDataGridViewHaveAnyEmptyCells(accounts))
            {
                ErrorSave?.Invoke("Có trường dữ liệu ô bị trống!");
                ErrorSave = null;
                return false;
            }

            using (SqlConnection con = new SqlConnection(DBQuery.ConnectionString))
            using (SqlCommand cmd = new SqlCommand())
            {
                try
                {
                    cmd.Connection = con;
                    cmd.CommandText = $"DELETE * FROM {DBQuery.AccountsTableName}";

                    con.Open();
                    cmd.ExecuteNonQuery();

                    for (int i = 0; i < accounts.Rows.Count; i++)
                    {
                        DataGridViewRow row = accounts.Rows[i];
                        if (!row.IsNewRow)
                        {
                            string id = row.Cells[DBQuery.AccountIdColumn].Value.ToString();
                            string name = row.Cells[DBQuery.AccountNameColumn].Value.ToString();
                            string email = row.Cells[DBQuery.AccountEmailColumn].Value.ToString();
                            string password = row.Cells[DBQuery.AccountPasswordColumn].Value.ToString();

                            string query = $"INSERT INTO {DBQuery.StudentTableName} VALUES (@stuId, @name, @email, @password)";

                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@stuId", id);
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@password", password);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    con.Close();
                }
                catch (SqlException ex)
                {
                    ErrorSave?.Invoke(ex.Message);
                    return false;
                }
                finally { con.Close(); }
            }
            return true;
        }
        public bool DoDataGridViewHaveAnyEmptyCells(DataGridView grid)
        {
            if (grid.Rows.Count == 0) return true;
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                        if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                            return true;
                }
                else _ = row.IsNewRow;
            }
            return false;
        }
    }
}