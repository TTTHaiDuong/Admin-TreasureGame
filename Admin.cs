using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Admin
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            DBQuery.Error += QuestionDatabaseFailedConnect;
        }

        private readonly int ConnectionTime = 1000;

        private void AddButton_Click(object sender, EventArgs e)
        {
            DataTable table = QuestionsDataView.DataSource as DataTable;
            table.Rows.Add(null, null, null, null, null, null);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            QuestionDBLoad();
            StudentsDBLoad();
            AccountsDBLoad();
        }

        private void QuestionDBLoad()
        {
            DataTable tb;
            for (int i = 0; i < ConnectionTime; i++)
            {
                QuestionsDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                tb = DBQuery.ExecuteQuery($"SELECT * FROM {DBQuery.QuestionsTableName}");
                QuestionsDataView.DataSource = tb;
                if (tb != null) break;
            }
        }

        private void StudentsDBLoad()
        {
            DataTable tb;
            for (int i = 0; i < ConnectionTime; i++)
            {
                StudentsDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                tb = DBQuery.ExecuteQuery($"SELECT * FROM {DBQuery.StudentsTableName}");
                StudentsDataView.DataSource = tb;
                if (tb != null) break;
            }
        }

        private void AccountsDBLoad()
        {
            DataTable tb;
            for (int i = 0; i < ConnectionTime; i++)
            {
                StudentsDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                tb = DBQuery.ExecuteQuery($"SELECT * FROM {DBQuery.AccountsTableName}");
                AccountsDataView.DataSource = tb;
                if (tb != null) break;
            }
        }

        private void QuestionDatabaseFailedConnect(Exception ex)
        {
            MessageBox.Show($"Lỗi SQL! {ex.Message}", "Lỗi SQL!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ConnectButtonQ_Click(object sender, EventArgs e)
        {
            QuestionDBLoad();
        }

        private void RemoveButtonQ_Click(object sender, EventArgs e)
        {
            if (QuestionsDataView.SelectedRows.Count > 0)
            {
                int selectedIndex = QuestionsDataView.SelectedRows[0].Index;
                QuestionsDataView.Rows.RemoveAt(selectedIndex);
            }
        }
    }
}
