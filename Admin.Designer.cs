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
            this.Tabs = new System.Windows.Forms.TabControl();
            this.QuestionsPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ConnectButtonQ = new System.Windows.Forms.Button();
            this.SaveButtonQ = new System.Windows.Forms.Button();
            this.QuestionsDataView = new System.Windows.Forms.DataGridView();
            this.StudentsPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConnectButtonS = new System.Windows.Forms.Button();
            this.SaveButtonS = new System.Windows.Forms.Button();
            this.StudentsDataView = new System.Windows.Forms.DataGridView();
            this.AccountsPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ConnectButtonA = new System.Windows.Forms.Button();
            this.SaveButtonA = new System.Windows.Forms.Button();
            this.AccountsDataView = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Tabs.SuspendLayout();
            this.QuestionsPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsDataView)).BeginInit();
            this.StudentsPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataView)).BeginInit();
            this.AccountsPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsDataView)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.QuestionsPage);
            this.Tabs.Controls.Add(this.StudentsPage);
            this.Tabs.Controls.Add(this.AccountsPage);
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(1099, 744);
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
            this.QuestionsPage.Size = new System.Drawing.Size(1091, 715);
            this.QuestionsPage.TabIndex = 0;
            this.QuestionsPage.Text = "Questions";
            this.QuestionsPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ConnectButtonQ);
            this.groupBox2.Controls.Add(this.SaveButtonQ);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(60, 600);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(982, 89);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Công cụ";
            // 
            // ConnectButtonQ
            // 
            this.ConnectButtonQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButtonQ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConnectButtonQ.Location = new System.Drawing.Point(256, 40);
            this.ConnectButtonQ.Name = "ConnectButtonQ";
            this.ConnectButtonQ.Size = new System.Drawing.Size(136, 40);
            this.ConnectButtonQ.TabIndex = 9;
            this.ConnectButtonQ.Text = "Kết nối";
            this.ConnectButtonQ.UseVisualStyleBackColor = true;
            this.ConnectButtonQ.Click += new System.EventHandler(this.ConnectButtonQ_Click);
            // 
            // SaveButtonQ
            // 
            this.SaveButtonQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButtonQ.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveButtonQ.Location = new System.Drawing.Point(579, 40);
            this.SaveButtonQ.Name = "SaveButtonQ";
            this.SaveButtonQ.Size = new System.Drawing.Size(100, 40);
            this.SaveButtonQ.TabIndex = 3;
            this.SaveButtonQ.Text = "Lưu";
            this.SaveButtonQ.UseVisualStyleBackColor = true;
            // 
            // QuestionsDataView
            // 
            this.QuestionsDataView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.QuestionsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.QuestionsDataView.Size = new System.Drawing.Size(1085, 540);
            this.QuestionsDataView.TabIndex = 0;
            // 
            // StudentsPage
            // 
            this.StudentsPage.Controls.Add(this.groupBox1);
            this.StudentsPage.Controls.Add(this.StudentsDataView);
            this.StudentsPage.Location = new System.Drawing.Point(4, 25);
            this.StudentsPage.Name = "StudentsPage";
            this.StudentsPage.Padding = new System.Windows.Forms.Padding(3);
            this.StudentsPage.Size = new System.Drawing.Size(1091, 715);
            this.StudentsPage.TabIndex = 1;
            this.StudentsPage.Text = "Students";
            this.StudentsPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConnectButtonS);
            this.groupBox1.Controls.Add(this.SaveButtonS);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 600);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 89);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Công cụ";
            // 
            // ConnectButtonS
            // 
            this.ConnectButtonS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButtonS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConnectButtonS.Location = new System.Drawing.Point(256, 40);
            this.ConnectButtonS.Name = "ConnectButtonS";
            this.ConnectButtonS.Size = new System.Drawing.Size(136, 40);
            this.ConnectButtonS.TabIndex = 9;
            this.ConnectButtonS.Text = "Kết nối";
            this.ConnectButtonS.UseVisualStyleBackColor = true;
            // 
            // SaveButtonS
            // 
            this.SaveButtonS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButtonS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveButtonS.Location = new System.Drawing.Point(579, 40);
            this.SaveButtonS.Name = "SaveButtonS";
            this.SaveButtonS.Size = new System.Drawing.Size(100, 40);
            this.SaveButtonS.TabIndex = 3;
            this.SaveButtonS.Text = "Lưu";
            this.SaveButtonS.UseVisualStyleBackColor = true;
            // 
            // StudentsDataView
            // 
            this.StudentsDataView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.StudentsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDataView.Dock = System.Windows.Forms.DockStyle.Top;
            this.StudentsDataView.Location = new System.Drawing.Point(3, 3);
            this.StudentsDataView.Name = "StudentsDataView";
            this.StudentsDataView.RowHeadersWidth = 51;
            this.StudentsDataView.RowTemplate.Height = 24;
            this.StudentsDataView.Size = new System.Drawing.Size(1085, 540);
            this.StudentsDataView.TabIndex = 0;
            // 
            // AccountsPage
            // 
            this.AccountsPage.Controls.Add(this.groupBox3);
            this.AccountsPage.Controls.Add(this.AccountsDataView);
            this.AccountsPage.Location = new System.Drawing.Point(4, 25);
            this.AccountsPage.Name = "AccountsPage";
            this.AccountsPage.Padding = new System.Windows.Forms.Padding(3);
            this.AccountsPage.Size = new System.Drawing.Size(1091, 715);
            this.AccountsPage.TabIndex = 2;
            this.AccountsPage.Text = "Accounts";
            this.AccountsPage.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ConnectButtonA);
            this.groupBox3.Controls.Add(this.SaveButtonA);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(60, 600);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(982, 89);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Công cụ";
            // 
            // ConnectButtonA
            // 
            this.ConnectButtonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButtonA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConnectButtonA.Location = new System.Drawing.Point(256, 40);
            this.ConnectButtonA.Name = "ConnectButtonA";
            this.ConnectButtonA.Size = new System.Drawing.Size(136, 40);
            this.ConnectButtonA.TabIndex = 9;
            this.ConnectButtonA.Text = "Kết nối";
            this.ConnectButtonA.UseVisualStyleBackColor = true;
            // 
            // SaveButtonA
            // 
            this.SaveButtonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButtonA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SaveButtonA.Location = new System.Drawing.Point(579, 40);
            this.SaveButtonA.Name = "SaveButtonA";
            this.SaveButtonA.Size = new System.Drawing.Size(100, 40);
            this.SaveButtonA.TabIndex = 3;
            this.SaveButtonA.Text = "Lưu";
            this.SaveButtonA.UseVisualStyleBackColor = true;
            // 
            // AccountsDataView
            // 
            this.AccountsDataView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.AccountsDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountsDataView.Dock = System.Windows.Forms.DockStyle.Top;
            this.AccountsDataView.Location = new System.Drawing.Point(3, 3);
            this.AccountsDataView.Name = "AccountsDataView";
            this.AccountsDataView.RowHeadersWidth = 51;
            this.AccountsDataView.RowTemplate.Height = 24;
            this.AccountsDataView.Size = new System.Drawing.Size(1085, 540);
            this.AccountsDataView.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1091, 715);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Game Manage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(224, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 34);
            this.textBox1.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 744);
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
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataView)).EndInit();
            this.AccountsPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountsDataView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ConnectButtonS;
        private System.Windows.Forms.Button SaveButtonS;
        private System.Windows.Forms.DataGridView StudentsDataView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ConnectButtonA;
        private System.Windows.Forms.Button SaveButtonA;
        private System.Windows.Forms.DataGridView AccountsDataView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
    }
}