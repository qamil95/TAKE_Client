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
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.buttonShowAllTeachers = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.createNewTeacher1 = new TAKE_Client.CreateTeacher();
            this.createSurvey1 = new TAKE_Client.CreateSurvey();
            this.tabControl.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAdmin);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 562);
            this.tabControl.TabIndex = 0;
            // 
            // tabAdmin
            // 
            this.tabAdmin.Controls.Add(this.createSurvey1);
            this.tabAdmin.Controls.Add(this.buttonShowAllTeachers);
            this.tabAdmin.Controls.Add(this.createNewTeacher1);
            this.tabAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdmin.Size = new System.Drawing.Size(776, 536);
            this.tabAdmin.TabIndex = 0;
            this.tabAdmin.Text = "Admin panel";
            this.tabAdmin.UseVisualStyleBackColor = true;
            // 
            // buttonShowAllTeachers
            // 
            this.buttonShowAllTeachers.Location = new System.Drawing.Point(9, 7);
            this.buttonShowAllTeachers.Name = "buttonShowAllTeachers";
            this.buttonShowAllTeachers.Size = new System.Drawing.Size(174, 23);
            this.buttonShowAllTeachers.TabIndex = 5;
            this.buttonShowAllTeachers.Text = "Show all teachers";
            this.buttonShowAllTeachers.UseVisualStyleBackColor = true;
            this.buttonShowAllTeachers.Click += new System.EventHandler(this.buttonShowAllTeachers_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // createNewTeacher1
            // 
            this.createNewTeacher1.Location = new System.Drawing.Point(8, 36);
            this.createNewTeacher1.Name = "createNewTeacher1";
            this.createNewTeacher1.Size = new System.Drawing.Size(175, 103);
            this.createNewTeacher1.TabIndex = 4;
            // 
            // createSurvey1
            // 
            this.createSurvey1.Location = new System.Drawing.Point(190, 36);
            this.createSurvey1.Name = "createSurvey1";
            this.createSurvey1.Size = new System.Drawing.Size(216, 257);
            this.createSurvey1.TabIndex = 6;
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
            this.tabAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAdmin;
        private CreateTeacher createNewTeacher1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonShowAllTeachers;
        private CreateSurvey createSurvey1;
    }
}

