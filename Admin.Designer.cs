namespace Admin
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.QuestionsPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ConnectButtonQ = new System.Windows.Forms.Button();
            this.SaveButtonQ = new System.Windows.Forms.Button();
            this.QuestionsDataView = new System.Windows.Forms.DataGridView();
            this.StudentsPage = new System.Windows.Forms.TabPage();
            this.StudentsDataView = new System.Windows.Forms.DataGridView();
            this.AccountsPage = new System.Windows.Forms.TabPage();
            this.AccountsDataView = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.StartServerBut = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GameLocation = new System.Windows.Forms.TextBox();
            this.ConnectionStringTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimeToPlayTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GamePasswordTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Tabs.SuspendLayout();
            this.QuestionsPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsDataView)).BeginInit();
            this.StudentsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataView)).BeginInit();
            this.AccountsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsDataView)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.QuestionsPage);
            this.Tabs.Controls.Add(this.StudentsPage);
            this.Tabs.Controls.Add(this.AccountsPage);
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1099, 564);
            this.Tabs.TabIndex = 0;
            // 
            // QuestionsPage
            // 
            this.QuestionsPage.Controls.Add(this.groupBox2);
            this.QuestionsPage.Controls.Add(this.QuestionsDataView);
            this.QuestionsPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionsPage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QuestionsPage.Location = new System.Drawing.Point(4, 25);
            this.QuestionsPage.Name = "QuestionsPage";
            this.QuestionsPage.Padding = new System.Windows.Forms.Padding(3);
            this.QuestionsPage.Size = new System.Drawing.Size(1091, 535);
            this.QuestionsPage.TabIndex = 0;
            this.QuestionsPage.Text = "Questions";
            this.QuestionsPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ConnectButtonQ);
            this.groupBox2.Controls.Add(this.SaveButtonQ);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(60, 569);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(982, 120);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Công cụ";
            // 
            // ConnectButtonQ
            // 
            this.ConnectButtonQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButtonQ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConnectButtonQ.Location = new System.Drawing.Point(36, 26);
            this.ConnectButtonQ.Name = "ConnectButtonQ";
            this.ConnectButtonQ.Size = new System.Drawing.Size(250, 70);
            this.ConnectButtonQ.TabIndex = 9;
            this.ConnectButtonQ.Text = "Kết nối";
            this.ConnectButtonQ.UseVisualStyleBackColor = true;
            this.ConnectButtonQ.Click += new System.EventHandler(this.ConnectButtonQ_Click);
            // 
            // SaveButtonQ
            // 
            this.SaveButtonQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButtonQ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveButtonQ.Location = new System.Drawing.Point(700, 26);
            this.SaveButtonQ.Name = "SaveButtonQ";
            this.SaveButtonQ.Size = new System.Drawing.Size(250, 70);
            this.SaveButtonQ.TabIndex = 3;
            this.SaveButtonQ.Text = "Lưu";
            this.SaveButtonQ.UseVisualStyleBackColor = true;
            this.SaveButtonQ.Click += new System.EventHandler(this.SaveButtonQ_Click);
            // 
            // QuestionsDataView
            // 
            this.QuestionsDataView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.QuestionsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.QuestionsDataView.DefaultCellStyle = dataGridViewCellStyle1;
            this.QuestionsDataView.Dock = System.Windows.Forms.DockStyle.Top;
            this.QuestionsDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.QuestionsDataView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.QuestionsDataView.Location = new System.Drawing.Point(3, 3);
            this.QuestionsDataView.Name = "QuestionsDataView";
            this.QuestionsDataView.RowHeadersWidth = 51;
            this.QuestionsDataView.RowTemplate.Height = 24;
            this.QuestionsDataView.Size = new System.Drawing.Size(1085, 510);
            this.QuestionsDataView.TabIndex = 0;
            this.QuestionsDataView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.QuestionsDataView_CellValueChanged);
            // 
            // StudentsPage
            // 
            this.StudentsPage.Controls.Add(this.StudentsDataView);
            this.StudentsPage.Location = new System.Drawing.Point(4, 25);
            this.StudentsPage.Name = "StudentsPage";
            this.StudentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.StudentsPage.Size = new System.Drawing.Size(1091, 535);
            this.StudentsPage.TabIndex = 1;
            this.StudentsPage.Text = "Students";
            this.StudentsPage.UseVisualStyleBackColor = true;
            // 
            // StudentsDataView
            // 
            this.StudentsDataView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.StudentsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentsDataView.DefaultCellStyle = dataGridViewCellStyle2;
            this.StudentsDataView.Dock = System.Windows.Forms.DockStyle.Top;
            this.StudentsDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.StudentsDataView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StudentsDataView.Location = new System.Drawing.Point(3, 3);
            this.StudentsDataView.Name = "StudentsDataView";
            this.StudentsDataView.RowHeadersWidth = 51;
            this.StudentsDataView.RowTemplate.Height = 24;
            this.StudentsDataView.Size = new System.Drawing.Size(1085, 510);
            this.StudentsDataView.TabIndex = 1;
            this.StudentsDataView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsDataView_CellValueChanged);
            // 
            // AccountsPage
            // 
            this.AccountsPage.Controls.Add(this.AccountsDataView);
            this.AccountsPage.Location = new System.Drawing.Point(4, 25);
            this.AccountsPage.Name = "AccountsPage";
            this.AccountsPage.Padding = new System.Windows.Forms.Padding(3);
            this.AccountsPage.Size = new System.Drawing.Size(1091, 535);
            this.AccountsPage.TabIndex = 2;
            this.AccountsPage.Text = "Accounts";
            this.AccountsPage.UseVisualStyleBackColor = true;
            // 
            // AccountsDataView
            // 
            this.AccountsDataView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.AccountsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AccountsDataView.DefaultCellStyle = dataGridViewCellStyle3;
            this.AccountsDataView.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountsDataView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.AccountsDataView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AccountsDataView.Location = new System.Drawing.Point(3, 3);
            this.AccountsDataView.Name = "AccountsDataView";
            this.AccountsDataView.RowHeadersWidth = 51;
            this.AccountsDataView.RowTemplate.Height = 24;
            this.AccountsDataView.Size = new System.Drawing.Size(1085, 510);
            this.AccountsDataView.TabIndex = 1;
            this.AccountsDataView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountsDataView_CellValueChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.StartServerBut);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1091, 535);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Game Manage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // StartServerBut
            // 
            this.StartServerBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartServerBut.Location = new System.Drawing.Point(399, 417);
            this.StartServerBut.Name = "StartServerBut";
            this.StartServerBut.Size = new System.Drawing.Size(299, 77);
            this.StartServerBut.TabIndex = 4;
            this.StartServerBut.Text = "Bắt đầu máy chủ";
            this.StartServerBut.UseVisualStyleBackColor = true;
            this.StartServerBut.Click += new System.EventHandler(this.StartServerBut_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.GameLocation);
            this.groupBox4.Controls.Add(this.ConnectionStringTxtBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.TimeToPlayTxtBox);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.GamePasswordTxtBox);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1085, 529);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Các cài đặt trong game";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(261, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Vị trí server game:";
            // 
            // GameLocation
            // 
            this.GameLocation.BackColor = System.Drawing.SystemColors.MenuBar;
            this.GameLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameLocation.Location = new System.Drawing.Point(508, 306);
            this.GameLocation.Name = "GameLocation";
            this.GameLocation.Size = new System.Drawing.Size(267, 34);
            this.GameLocation.TabIndex = 10;
            // 
            // ConnectionStringTxtBox
            // 
            this.ConnectionStringTxtBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ConnectionStringTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionStringTxtBox.Location = new System.Drawing.Point(508, 119);
            this.ConnectionStringTxtBox.Name = "ConnectionStringTxtBox";
            this.ConnectionStringTxtBox.Size = new System.Drawing.Size(267, 34);
            this.ConnectionStringTxtBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chuỗi kết nối: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thời gian phòng game:";
            // 
            // TimeToPlayTxtBox
            // 
            this.TimeToPlayTxtBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TimeToPlayTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeToPlayTxtBox.Location = new System.Drawing.Point(508, 241);
            this.TimeToPlayTxtBox.Name = "TimeToPlayTxtBox";
            this.TimeToPlayTxtBox.Size = new System.Drawing.Size(195, 34);
            this.TimeToPlayTxtBox.TabIndex = 1;
            this.TimeToPlayTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlayingTimeTxtBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mật khẩu phòng game:";
            // 
            // GamePasswordTxtBox
            // 
            this.GamePasswordTxtBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.GamePasswordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamePasswordTxtBox.Location = new System.Drawing.Point(508, 180);
            this.GamePasswordTxtBox.Name = "GamePasswordTxtBox";
            this.GamePasswordTxtBox.Size = new System.Drawing.Size(267, 34);
            this.GamePasswordTxtBox.TabIndex = 0;
            this.GamePasswordTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GamePasswordTxtBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(726, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giây";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 564);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 113);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(906, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Quit_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(266, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "Lưu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Save_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(52, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kết nối";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 677);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tabs);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản trị TreasureGame";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.Tabs.ResumeLayout(false);
            this.QuestionsPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsDataView)).EndInit();
            this.StudentsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataView)).EndInit();
            this.AccountsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountsDataView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage QuestionsPage;
        private System.Windows.Forms.TabPage StudentsPage;
        private System.Windows.Forms.TabPage AccountsPage;
        private System.Windows.Forms.DataGridView QuestionsDataView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SaveButtonQ;
        private System.Windows.Forms.Button ConnectButtonQ;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox GamePasswordTxtBox;
        private System.Windows.Forms.TextBox TimeToPlayTxtBox;
        private System.Windows.Forms.Button StartServerBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView StudentsDataView;
        private System.Windows.Forms.DataGridView AccountsDataView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ConnectionStringTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox GameLocation;
    }
}