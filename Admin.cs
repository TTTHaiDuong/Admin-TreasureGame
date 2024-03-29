using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Admin
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            DBQuery.Error += QuestionDatabaseFailedConnect;
            QuestionsDataView.ForeColor = System.Drawing.Color.Black;
            StudentsDataView.ForeColor = System.Drawing.Color.Black;
            AccountsDataView.ForeColor = System.Drawing.Color.Black;
        }

        public static string SettingFilePath = @"C:\Users\tranh\OneDrive\Tài liệu\Desktop Application Development\TreasureAdmin.txt";
        private readonly int ConnectionTime = 1000;
        private bool IsCellsChanged;

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
            ReadSettingGameFile();

            if (QuestionsDataView.RowCount == 0)
            {
                MessageBox.Show("Kết nối cơ sở dữ liệu không thành công!", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuestionDBLoad()
        {
            DataTable tb;
            for (int i = 0; i < ConnectionTime; i++)
            {
                QuestionsDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                tb = DBQuery.ExecuteQuery($"SELECT * FROM {DBQuery.QuestionsTable}");
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
                tb = DBQuery.ExecuteQuery($"SELECT * FROM {DBQuery.StudentTableName}");
                StudentsDataView.DataSource = tb;
                if (tb != null) break;
            }
        }

        private void AccountsDBLoad()
        {
            DataTable tb;
            for (int i = 0; i < ConnectionTime; i++)
            {
                AccountsDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void StartServerBut_Click(object sender, EventArgs e)
        {
            if (GamePasswordTxtBox.Text == "" || TimeToPlayTxtBox.Text == "" || ConnectionStringTxtBox.Text == "" || GameLocation.Text == "")
            {
                MessageBox.Show("Không thể để trống các cài đặt!", "Lỗi chưa nhập đầy đủ thông tin cài đặt game!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            WriteSettingGameFile(sender, e);

            try
            {
                Process.Start(GameLocation.Text);
            }
            catch
            {
                MessageBox.Show("Vị trí của server game không chính xác!", "Lỗi chạy server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GamePasswordTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void PlayingTimeTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void ConnectButtonS_Click(object sender, EventArgs e)
        {
            StudentsDBLoad();
        }

        private void ConnectButtonA_Click(object sender, EventArgs e)
        {
            AccountsDBLoad();
        }

        private void SaveButtonQ_Click(object sender, EventArgs e)
        {
        }

        private void QuestionsDataView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            IsCellsChanged = true;
        }

        private void StudentsDataView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            IsCellsChanged = true;
        }

        private void AccountsDataView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            IsCellsChanged = true;
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            if (IsCellsChanged && MessageBox.Show("Dữ liệu của các bảng đã bị thay đổi bạn có muốn lưu lại không?", "Dữ liệu chưa được lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Save_Click(sender, e);
            }
            else Application.Exit();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            Admin_Load(sender, e);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            DBSet set = new DBSet();
            set.ErrorSave += CannotSave;

            if (set.QuestionTableSave(QuestionsDataView)
            && set.StudentTableSave(StudentsDataView)
            && set.AccountTableSave(AccountsDataView))
                CompleteSave();
        }

        private void CompleteSave()
        {
            IsCellsChanged = false;
            MessageBox.Show("Dữ liệu được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CannotSave(string message)
        {
            MessageBox.Show(message, "Lỗi khi lưu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void WriteSettingGameFile(object sender, EventArgs e)
        {
            List<string> setting = new List<string>()
            {
                "Game Location_____: " + GameLocation.Text,
                "Room Password_____: " + GamePasswordTxtBox.Text,
                "Time To Play______: " + TimeToPlayTxtBox.Text,
                "Connection String_: " + ConnectionStringTxtBox.Text
            };

            File.WriteAllLines(SettingFilePath, setting.ToArray());
        }

        private void ReadSettingGameFile()
        {
            if (File.Exists(SettingFilePath))
            {
                const int len = 21;
                string[] lines = File.ReadAllLines(SettingFilePath);
                foreach (string line in lines)
                {
                    if (line.Contains("Room Password_____: ")) GamePasswordTxtBox.Text = line.Substring(len, line.Length - len);
                    else if (line.Contains("Connection String_: ")) ConnectionStringTxtBox.Text = line.Substring(len, line.Length - len);
                    else if (line.Contains("Time To Play______: ")) TimeToPlayTxtBox.Text = line.Substring(len, line.Length - len);
                    else if (line.Contains("Game Location_____: ")) GameLocation.Text = line.Substring(len, line.Length - len);
                }
            }
        }
    }
}
