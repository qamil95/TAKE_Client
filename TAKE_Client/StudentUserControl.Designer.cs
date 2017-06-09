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
            this.dataGridViewSurvey = new System.Windows.Forms.DataGridView();
            this.buttonSendSurvey = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelAdditionalInformation = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxAdditionalInformation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSurvey)).BeginInit();
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
            // dataGridViewSurvey
            // 
            this.dataGridViewSurvey.AllowUserToAddRows = false;
            this.dataGridViewSurvey.AllowUserToDeleteRows = false;
            this.dataGridViewSurvey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSurvey.Location = new System.Drawing.Point(7, 91);
            this.dataGridViewSurvey.Name = "dataGridViewSurvey";
            this.dataGridViewSurvey.Size = new System.Drawing.Size(757, 385);
            this.dataGridViewSurvey.TabIndex = 4;
            // 
            // buttonSendSurvey
            // 
            this.buttonSendSurvey.Enabled = false;
            this.buttonSendSurvey.Location = new System.Drawing.Point(7, 482);
            this.buttonSendSurvey.Name = "buttonSendSurvey";
            this.buttonSendSurvey.Size = new System.Drawing.Size(757, 39);
            this.buttonSendSurvey.TabIndex = 5;
            this.buttonSendSurvey.Text = "Send Survey";
            this.buttonSendSurvey.UseVisualStyleBackColor = true;
            this.buttonSendSurvey.Click += new System.EventHandler(this.buttonSendSurvey_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(7, 48);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 13);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Date:";
            // 
            // labelAdditionalInformation
            // 
            this.labelAdditionalInformation.AutoSize = true;
            this.labelAdditionalInformation.Location = new System.Drawing.Point(394, 48);
            this.labelAdditionalInformation.Name = "labelAdditionalInformation";
            this.labelAdditionalInformation.Size = new System.Drawing.Size(110, 13);
            this.labelAdditionalInformation.TabIndex = 7;
            this.labelAdditionalInformation.Text = "Additional information:";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(10, 65);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(360, 20);
            this.textBoxDate.TabIndex = 8;
            // 
            // textBoxAdditionalInformation
            // 
            this.textBoxAdditionalInformation.Location = new System.Drawing.Point(397, 65);
            this.textBoxAdditionalInformation.Name = "textBoxAdditionalInformation";
            this.textBoxAdditionalInformation.Size = new System.Drawing.Size(367, 20);
            this.textBoxAdditionalInformation.TabIndex = 9;
            // 
            // StudentUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxAdditionalInformation);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.labelAdditionalInformation);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.buttonSendSurvey);
            this.Controls.Add(this.dataGridViewSurvey);
            this.Controls.Add(this.comboBoxSurveys);
            this.Controls.Add(this.labelSurvey);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.comboBoxTeachers);
            this.Name = "StudentUserControl";
            this.Size = new System.Drawing.Size(776, 536);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSurvey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTeachers;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.Label labelSurvey;
        private System.Windows.Forms.ComboBox comboBoxSurveys;
        private System.Windows.Forms.DataGridView dataGridViewSurvey;
        private System.Windows.Forms.Button buttonSendSurvey;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelAdditionalInformation;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxAdditionalInformation;
    }
}
