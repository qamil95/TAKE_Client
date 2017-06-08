namespace TAKE_Client
{
    partial class StudentUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxTeachers = new System.Windows.Forms.ComboBox();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.labelSurvey = new System.Windows.Forms.Label();
            this.comboBoxSurveys = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxTeachers
            // 
            this.comboBoxTeachers.AllowDrop = true;
            this.comboBoxTeachers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeachers.FormattingEnabled = true;
            this.comboBoxTeachers.Location = new System.Drawing.Point(3, 20);
            this.comboBoxTeachers.Name = "comboBoxTeachers";
            this.comboBoxTeachers.Size = new System.Drawing.Size(367, 21);
            this.comboBoxTeachers.TabIndex = 0;
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Location = new System.Drawing.Point(4, 4);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(50, 13);
            this.labelTeacher.TabIndex = 1;
            this.labelTeacher.Text = "Teacher:";
            // 
            // labelSurvey
            // 
            this.labelSurvey.AutoSize = true;
            this.labelSurvey.Location = new System.Drawing.Point(394, 4);
            this.labelSurvey.Name = "labelSurvey";
            this.labelSurvey.Size = new System.Drawing.Size(43, 13);
            this.labelSurvey.TabIndex = 2;
            this.labelSurvey.Text = "Survey:";
            // 
            // comboBoxSurveys
            // 
            this.comboBoxSurveys.AllowDrop = true;
            this.comboBoxSurveys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSurveys.FormattingEnabled = true;
            this.comboBoxSurveys.Location = new System.Drawing.Point(397, 20);
            this.comboBoxSurveys.Name = "comboBoxSurveys";
            this.comboBoxSurveys.Size = new System.Drawing.Size(367, 21);
            this.comboBoxSurveys.TabIndex = 3;
            this.comboBoxSurveys.SelectedIndexChanged += new System.EventHandler(this.comboBoxSurveys_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxSurveys);
            this.Controls.Add(this.labelSurvey);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.comboBoxTeachers);
            this.Name = "StudentUserControl";
            this.Size = new System.Drawing.Size(776, 536);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTeachers;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.Label labelSurvey;
        private System.Windows.Forms.ComboBox comboBoxSurveys;
        private System.Windows.Forms.Button button1;
    }
}
