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
            this.buttonDeleteTeacher = new System.Windows.Forms.Button();
            this.buttonEditTeacher = new System.Windows.Forms.Button();
            this.dataGridTeachersAdminPanel = new System.Windows.Forms.DataGridView();
            this.buttonShowAllTeachers = new System.Windows.Forms.Button();
            this.tabAdminSurveys = new System.Windows.Forms.TabPage();
            this.dataGridQuestions = new System.Windows.Forms.DataGridView();
            this.buttonShowAllSurveys = new System.Windows.Forms.Button();
            this.dataGridSurveys = new System.Windows.Forms.DataGridView();
            this.tabTeacher = new System.Windows.Forms.TabPage();
            this.dataGridSurveyDetailsTeacherPanel = new System.Windows.Forms.DataGridView();
            this.labelSurveyDetails = new System.Windows.Forms.Label();
            this.labelFilledSurveys = new System.Windows.Forms.Label();
            this.dataGridFilledSurveysTeacherPanel = new System.Windows.Forms.DataGridView();
            this.labelTeacherName = new System.Windows.Forms.Label();
            this.dataGridTeachersTeacherPanel = new System.Windows.Forms.DataGridView();
            this.createNewTeacher1 = new TAKE_Client.CreateTeacher();
            this.createSurvey1 = new TAKE_Client.CreateSurvey();
            this.tabControl.SuspendLayout();
            this.tabAdminTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeachersAdminPanel)).BeginInit();
            this.tabAdminSurveys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSurveys)).BeginInit();
            this.tabTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSurveyDetailsTeacherPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFilledSurveysTeacherPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeachersTeacherPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAdminTeachers);
            this.tabControl.Controls.Add(this.tabAdminSurveys);
            this.tabControl.Controls.Add(this.tabTeacher);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 562);
            this.tabControl.TabIndex = 0;
            // 
            // tabAdminTeachers
            // 
            this.tabAdminTeachers.Controls.Add(this.buttonDeleteTeacher);
            this.tabAdminTeachers.Controls.Add(this.buttonEditTeacher);
            this.tabAdminTeachers.Controls.Add(this.dataGridTeachersAdminPanel);
            this.tabAdminTeachers.Controls.Add(this.buttonShowAllTeachers);
            this.tabAdminTeachers.Controls.Add(this.createNewTeacher1);
            this.tabAdminTeachers.Location = new System.Drawing.Point(4, 22);
            this.tabAdminTeachers.Name = "tabAdminTeachers";
            this.tabAdminTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdminTeachers.Size = new System.Drawing.Size(776, 536);
            this.tabAdminTeachers.TabIndex = 0;
            this.tabAdminTeachers.Text = "[ADMIN]Teachers";
            this.tabAdminTeachers.UseVisualStyleBackColor = true;
            this.tabAdminTeachers.Enter += new System.EventHandler(this.tabAdminTeachers_Enter);
            // 
            // buttonDeleteTeacher
            // 
            this.buttonDeleteTeacher.Location = new System.Drawing.Point(673, 172);
            this.buttonDeleteTeacher.Name = "buttonDeleteTeacher";
            this.buttonDeleteTeacher.Size = new System.Drawing.Size(95, 23);
            this.buttonDeleteTeacher.TabIndex = 10;
            this.buttonDeleteTeacher.Text = "Delete teacher";
            this.buttonDeleteTeacher.UseVisualStyleBackColor = true;
            this.buttonDeleteTeacher.Click += new System.EventHandler(this.buttonDeleteTeacher_Click);
            // 
            // buttonEditTeacher
            // 
            this.buttonEditTeacher.Location = new System.Drawing.Point(592, 172);
            this.buttonEditTeacher.Name = "buttonEditTeacher";
            this.buttonEditTeacher.Size = new System.Drawing.Size(75, 23);
            this.buttonEditTeacher.TabIndex = 9;
            this.buttonEditTeacher.Text = "Edit teacher";
            this.buttonEditTeacher.UseVisualStyleBackColor = true;
            this.buttonEditTeacher.Click += new System.EventHandler(this.buttonEditTeacher_Click);
            // 
            // dataGridTeachersAdminPanel
            // 
            this.dataGridTeachersAdminPanel.AllowUserToAddRows = false;
            this.dataGridTeachersAdminPanel.AllowUserToDeleteRows = false;
            this.dataGridTeachersAdminPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTeachersAdminPanel.Location = new System.Drawing.Point(189, 6);
            this.dataGridTeachersAdminPanel.Name = "dataGridTeachersAdminPanel";
            this.dataGridTeachersAdminPanel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTeachersAdminPanel.Size = new System.Drawing.Size(579, 159);
            this.dataGridTeachersAdminPanel.TabIndex = 8;
            // 
            // buttonShowAllTeachers
            // 
            this.buttonShowAllTeachers.Location = new System.Drawing.Point(9, 115);
            this.buttonShowAllTeachers.Name = "buttonShowAllTeachers";
            this.buttonShowAllTeachers.Size = new System.Drawing.Size(174, 50);
            this.buttonShowAllTeachers.TabIndex = 5;
            this.buttonShowAllTeachers.Text = "Refresh teachers";
            this.buttonShowAllTeachers.UseVisualStyleBackColor = true;
            this.buttonShowAllTeachers.Click += new System.EventHandler(this.buttonShowAllTeachers_Click);
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
            this.dataGridQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            this.dataGridSurveys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSurveys.Size = new System.Drawing.Size(536, 285);
            this.dataGridSurveys.TabIndex = 10;
            // 
            // tabTeacher
            // 
            this.tabTeacher.Controls.Add(this.dataGridSurveyDetailsTeacherPanel);
            this.tabTeacher.Controls.Add(this.labelSurveyDetails);
            this.tabTeacher.Controls.Add(this.labelFilledSurveys);
            this.tabTeacher.Controls.Add(this.dataGridFilledSurveysTeacherPanel);
            this.tabTeacher.Controls.Add(this.labelTeacherName);
            this.tabTeacher.Controls.Add(this.dataGridTeachersTeacherPanel);
            this.tabTeacher.Location = new System.Drawing.Point(4, 22);
            this.tabTeacher.Name = "tabTeacher";
            this.tabTeacher.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeacher.Size = new System.Drawing.Size(776, 536);
            this.tabTeacher.TabIndex = 2;
            this.tabTeacher.Text = "[TEACHER]";
            this.tabTeacher.UseVisualStyleBackColor = true;
            this.tabTeacher.Enter += new System.EventHandler(this.tabTeacher_Enter);
            // 
            // dataGridSurveyDetailsTeacherPanel
            // 
            this.dataGridSurveyDetailsTeacherPanel.AllowUserToAddRows = false;
            this.dataGridSurveyDetailsTeacherPanel.AllowUserToDeleteRows = false;
            this.dataGridSurveyDetailsTeacherPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSurveyDetailsTeacherPanel.Location = new System.Drawing.Point(8, 287);
            this.dataGridSurveyDetailsTeacherPanel.Name = "dataGridSurveyDetailsTeacherPanel";
            this.dataGridSurveyDetailsTeacherPanel.ReadOnly = true;
            this.dataGridSurveyDetailsTeacherPanel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSurveyDetailsTeacherPanel.Size = new System.Drawing.Size(760, 241);
            this.dataGridSurveyDetailsTeacherPanel.TabIndex = 14;
            // 
            // labelSurveyDetails
            // 
            this.labelSurveyDetails.AutoSize = true;
            this.labelSurveyDetails.Location = new System.Drawing.Point(9, 271);
            this.labelSurveyDetails.Name = "labelSurveyDetails";
            this.labelSurveyDetails.Size = new System.Drawing.Size(76, 13);
            this.labelSurveyDetails.TabIndex = 13;
            this.labelSurveyDetails.Text = "Survey details:";
            // 
            // labelFilledSurveys
            // 
            this.labelFilledSurveys.AutoSize = true;
            this.labelFilledSurveys.Location = new System.Drawing.Point(9, 144);
            this.labelFilledSurveys.Name = "labelFilledSurveys";
            this.labelFilledSurveys.Size = new System.Drawing.Size(73, 13);
            this.labelFilledSurveys.TabIndex = 12;
            this.labelFilledSurveys.Text = "Filled surveys:";
            // 
            // dataGridFilledSurveysTeacherPanel
            // 
            this.dataGridFilledSurveysTeacherPanel.AllowUserToAddRows = false;
            this.dataGridFilledSurveysTeacherPanel.AllowUserToDeleteRows = false;
            this.dataGridFilledSurveysTeacherPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFilledSurveysTeacherPanel.Location = new System.Drawing.Point(8, 160);
            this.dataGridFilledSurveysTeacherPanel.Name = "dataGridFilledSurveysTeacherPanel";
            this.dataGridFilledSurveysTeacherPanel.ReadOnly = true;
            this.dataGridFilledSurveysTeacherPanel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFilledSurveysTeacherPanel.Size = new System.Drawing.Size(760, 108);
            this.dataGridFilledSurveysTeacherPanel.TabIndex = 11;
            // 
            // labelTeacherName
            // 
            this.labelTeacherName.AutoSize = true;
            this.labelTeacherName.Location = new System.Drawing.Point(9, 14);
            this.labelTeacherName.Name = "labelTeacherName";
            this.labelTeacherName.Size = new System.Drawing.Size(50, 13);
            this.labelTeacherName.TabIndex = 10;
            this.labelTeacherName.Text = "Teacher:";
            // 
            // dataGridTeachersTeacherPanel
            // 
            this.dataGridTeachersTeacherPanel.AllowUserToAddRows = false;
            this.dataGridTeachersTeacherPanel.AllowUserToDeleteRows = false;
            this.dataGridTeachersTeacherPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTeachersTeacherPanel.Location = new System.Drawing.Point(8, 33);
            this.dataGridTeachersTeacherPanel.Name = "dataGridTeachersTeacherPanel";
            this.dataGridTeachersTeacherPanel.ReadOnly = true;
            this.dataGridTeachersTeacherPanel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTeachersTeacherPanel.Size = new System.Drawing.Size(760, 108);
            this.dataGridTeachersTeacherPanel.TabIndex = 9;
            this.dataGridTeachersTeacherPanel.Click += new System.EventHandler(this.dataGridTeachersTeacherPanel_Click);
            // 
            // createNewTeacher1
            // 
            this.createNewTeacher1.Location = new System.Drawing.Point(8, 6);
            this.createNewTeacher1.Name = "createNewTeacher1";
            this.createNewTeacher1.Size = new System.Drawing.Size(175, 103);
            this.createNewTeacher1.TabIndex = 4;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeachersAdminPanel)).EndInit();
            this.tabAdminSurveys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSurveys)).EndInit();
            this.tabTeacher.ResumeLayout(false);
            this.tabTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSurveyDetailsTeacherPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFilledSurveysTeacherPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTeachersTeacherPanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAdminTeachers;
        private CreateTeacher createNewTeacher1;
        private System.Windows.Forms.TabPage tabAdminSurveys;
        private System.Windows.Forms.Button buttonShowAllTeachers;
        private System.Windows.Forms.DataGridView dataGridTeachersAdminPanel;
        private System.Windows.Forms.Button buttonShowAllSurveys;
        private System.Windows.Forms.DataGridView dataGridSurveys;
        private CreateSurvey createSurvey1;
        private System.Windows.Forms.DataGridView dataGridQuestions;
        private System.Windows.Forms.Button buttonDeleteTeacher;
        private System.Windows.Forms.Button buttonEditTeacher;
        private System.Windows.Forms.TabPage tabTeacher;
        private System.Windows.Forms.DataGridView dataGridTeachersTeacherPanel;
        private System.Windows.Forms.DataGridView dataGridSurveyDetailsTeacherPanel;
        private System.Windows.Forms.Label labelSurveyDetails;
        private System.Windows.Forms.Label labelFilledSurveys;
        private System.Windows.Forms.DataGridView dataGridFilledSurveysTeacherPanel;
        private System.Windows.Forms.Label labelTeacherName;
    }
}

