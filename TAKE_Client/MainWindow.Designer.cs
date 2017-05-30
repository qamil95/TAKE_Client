namespace TAKE_Client
{
    partial class MainWindow
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAdminTeachers = new System.Windows.Forms.TabPage();
            this.dataGridTeachers = new System.Windows.Forms.DataGridView();
            this.buttonShowAllTeachers = new System.Windows.Forms.Button();
            this.createNewTeacher1 = new TAKE_Client.CreateTeacher();
            this.tabAdminSurveys = new System.Windows.Forms.TabPage();
            this.dataGridQuestions = new System.Windows.Forms.DataGridView();
            this.buttonShowAllSurveys = new System.Windows.Forms.Button();
            this.dataGridSurveys = new System.Windows.Forms.DataGridView();
            this.createSurvey1 = new TAKE_Client.CreateSurvey();
            this.tabControl.SuspendLayout();
            this.tabAdminTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeachers)).BeginInit();
            this.tabAdminSurveys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSurveys)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAdminTeachers);
            this.tabControl.Controls.Add(this.tabAdminSurveys);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 562);
            this.tabControl.TabIndex = 0;
            // 
            // tabAdminTeachers
            // 
            this.tabAdminTeachers.Controls.Add(this.dataGridTeachers);
            this.tabAdminTeachers.Controls.Add(this.buttonShowAllTeachers);
            this.tabAdminTeachers.Controls.Add(this.createNewTeacher1);
            this.tabAdminTeachers.Location = new System.Drawing.Point(4, 22);
            this.tabAdminTeachers.Name = "tabAdminTeachers";
            this.tabAdminTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminTeachers.Size = new System.Drawing.Size(776, 536);
            this.tabAdminTeachers.TabIndex = 0;
            this.tabAdminTeachers.Text = "[ADMIN]Teachers";
            this.tabAdminTeachers.UseVisualStyleBackColor = true;
            // 
            // dataGridTeachers
            // 
            this.dataGridTeachers.AllowUserToAddRows = false;
            this.dataGridTeachers.AllowUserToDeleteRows = false;
            this.dataGridTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTeachers.Location = new System.Drawing.Point(189, 6);
            this.dataGridTeachers.Name = "dataGridTeachers";
            this.dataGridTeachers.ReadOnly = true;
            this.dataGridTeachers.Size = new System.Drawing.Size(579, 159);
            this.dataGridTeachers.TabIndex = 8;
            // 
            // buttonShowAllTeachers
            // 
            this.buttonShowAllTeachers.Location = new System.Drawing.Point(9, 115);
            this.buttonShowAllTeachers.Name = "buttonShowAllTeachers";
            this.buttonShowAllTeachers.Size = new System.Drawing.Size(174, 23);
            this.buttonShowAllTeachers.TabIndex = 5;
            this.buttonShowAllTeachers.Text = "Refresh teachers";
            this.buttonShowAllTeachers.UseVisualStyleBackColor = true;
            this.buttonShowAllTeachers.Click += new System.EventHandler(this.buttonShowAllTeachers_Click);
            // 
            // createNewTeacher1
            // 
            this.createNewTeacher1.Location = new System.Drawing.Point(8, 6);
            this.createNewTeacher1.Name = "createNewTeacher1";
            this.createNewTeacher1.Size = new System.Drawing.Size(175, 103);
            this.createNewTeacher1.TabIndex = 4;
            // 
            // tabAdminSurveys
            // 
            this.tabAdminSurveys.Controls.Add(this.dataGridQuestions);
            this.tabAdminSurveys.Controls.Add(this.buttonShowAllSurveys);
            this.tabAdminSurveys.Controls.Add(this.dataGridSurveys);
            this.tabAdminSurveys.Controls.Add(this.createSurvey1);
            this.tabAdminSurveys.Location = new System.Drawing.Point(4, 22);
            this.tabAdminSurveys.Name = "tabAdminSurveys";
            this.tabAdminSurveys.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminSurveys.Size = new System.Drawing.Size(776, 536);
            this.tabAdminSurveys.TabIndex = 1;
            this.tabAdminSurveys.Text = "[ADMIN]Surveys";
            this.tabAdminSurveys.UseVisualStyleBackColor = true;
            // 
            // dataGridQuestions
            // 
            this.dataGridQuestions.AllowUserToAddRows = false;
            this.dataGridQuestions.AllowUserToDeleteRows = false;
            this.dataGridQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuestions.Location = new System.Drawing.Point(8, 299);
            this.dataGridQuestions.Name = "dataGridQuestions";
            this.dataGridQuestions.ReadOnly = true;
            this.dataGridQuestions.Size = new System.Drawing.Size(758, 229);
            this.dataGridQuestions.TabIndex = 12;
            // 
            // buttonShowAllSurveys
            // 
            this.buttonShowAllSurveys.Location = new System.Drawing.Point(8, 269);
            this.buttonShowAllSurveys.Name = "buttonShowAllSurveys";
            this.buttonShowAllSurveys.Size = new System.Drawing.Size(216, 23);
            this.buttonShowAllSurveys.TabIndex = 11;
            this.buttonShowAllSurveys.Text = "Refresh surveys";
            this.buttonShowAllSurveys.UseVisualStyleBackColor = true;
            this.buttonShowAllSurveys.Click += new System.EventHandler(this.buttonShowAllSurveys_Click);
            // 
            // dataGridSurveys
            // 
            this.dataGridSurveys.AllowUserToAddRows = false;
            this.dataGridSurveys.AllowUserToDeleteRows = false;
            this.dataGridSurveys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSurveys.Location = new System.Drawing.Point(230, 6);
            this.dataGridSurveys.Name = "dataGridSurveys";
            this.dataGridSurveys.ReadOnly = true;
            this.dataGridSurveys.Size = new System.Drawing.Size(536, 285);
            this.dataGridSurveys.TabIndex = 10;
            // 
            // createSurvey1
            // 
            this.createSurvey1.Location = new System.Drawing.Point(8, 6);
            this.createSurvey1.Name = "createSurvey1";
            this.createSurvey1.Size = new System.Drawing.Size(216, 257);
            this.createSurvey1.TabIndex = 7;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tabControl);
            this.Name = "MainWindow";
            this.Text = "TAKE Survey Client";
            this.tabControl.ResumeLayout(false);
            this.tabAdminTeachers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeachers)).EndInit();
            this.tabAdminSurveys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSurveys)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAdminTeachers;
        private CreateTeacher createNewTeacher1;
        private System.Windows.Forms.TabPage tabAdminSurveys;
        private System.Windows.Forms.Button buttonShowAllTeachers;
        private System.Windows.Forms.DataGridView dataGridTeachers;
        private System.Windows.Forms.Button buttonShowAllSurveys;
        private System.Windows.Forms.DataGridView dataGridSurveys;
        private CreateSurvey createSurvey1;
        private System.Windows.Forms.DataGridView dataGridQuestions;
    }
}

