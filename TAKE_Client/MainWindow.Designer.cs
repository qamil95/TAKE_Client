﻿namespace TAKE_Client
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
            this.createNewTeacher1 = new TAKE_Client.CreateNewTeacher();
            this.buttonShowAllTeachers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createNewTeacher1
            // 
            this.createNewTeacher1.Location = new System.Drawing.Point(12, 164);
            this.createNewTeacher1.Name = "createNewTeacher1";
            this.createNewTeacher1.Size = new System.Drawing.Size(163, 86);
            this.createNewTeacher1.TabIndex = 0;
            // 
            // buttonShowAllTeachers
            // 
            this.buttonShowAllTeachers.Location = new System.Drawing.Point(13, 13);
            this.buttonShowAllTeachers.Name = "buttonShowAllTeachers";
            this.buttonShowAllTeachers.Size = new System.Drawing.Size(75, 23);
            this.buttonShowAllTeachers.TabIndex = 1;
            this.buttonShowAllTeachers.Text = "All teachers";
            this.buttonShowAllTeachers.UseVisualStyleBackColor = true;
            this.buttonShowAllTeachers.Click += new System.EventHandler(this.buttonShowAllTeachers_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonShowAllTeachers);
            this.Controls.Add(this.createNewTeacher1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CreateNewTeacher createNewTeacher1;
        private System.Windows.Forms.Button buttonShowAllTeachers;
    }
}

