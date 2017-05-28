namespace TAKE_Client
{
    partial class CreateSurvey
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.nudNumberOfQuestions = new System.Windows.Forms.NumericUpDown();
            this.labelNumberOfQuestions = new System.Windows.Forms.Label();
            this.richTextBoxEditQuestion = new System.Windows.Forms.RichTextBox();
            this.buttonAcceptNumberOfQuestions = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelEditQuestion = new System.Windows.Forms.Label();
            this.nudEditQuestion = new System.Windows.Forms.NumericUpDown();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.labelEditQuestion);
            this.groupBox.Controls.Add(this.nudEditQuestion);
            this.groupBox.Controls.Add(this.buttonCreate);
            this.groupBox.Controls.Add(this.buttonReset);
            this.groupBox.Controls.Add(this.buttonAcceptNumberOfQuestions);
            this.groupBox.Controls.Add(this.richTextBoxEditQuestion);
            this.groupBox.Controls.Add(this.labelNumberOfQuestions);
            this.groupBox.Controls.Add(this.nudNumberOfQuestions);
            this.groupBox.Controls.Add(this.labelDescription);
            this.groupBox.Controls.Add(this.textBoxDescription);
            this.groupBox.Controls.Add(this.textBoxDate);
            this.groupBox.Controls.Add(this.labelDate);
            this.groupBox.Location = new System.Drawing.Point(3, 3);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(208, 247);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Create survey";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(6, 25);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(71, 22);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(126, 20);
            this.textBoxDate.TabIndex = 1;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(71, 48);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(126, 20);
            this.textBoxDescription.TabIndex = 2;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(6, 51);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Description";
            // 
            // nudNumberOfQuestions
            // 
            this.nudNumberOfQuestions.Location = new System.Drawing.Point(116, 74);
            this.nudNumberOfQuestions.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberOfQuestions.Name = "nudNumberOfQuestions";
            this.nudNumberOfQuestions.Size = new System.Drawing.Size(43, 20);
            this.nudNumberOfQuestions.TabIndex = 4;
            this.nudNumberOfQuestions.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelNumberOfQuestions
            // 
            this.labelNumberOfQuestions.AutoSize = true;
            this.labelNumberOfQuestions.Location = new System.Drawing.Point(6, 76);
            this.labelNumberOfQuestions.Name = "labelNumberOfQuestions";
            this.labelNumberOfQuestions.Size = new System.Drawing.Size(104, 13);
            this.labelNumberOfQuestions.TabIndex = 5;
            this.labelNumberOfQuestions.Text = "Number of questions";
            // 
            // richTextBoxEditQuestion
            // 
            this.richTextBoxEditQuestion.Enabled = false;
            this.richTextBoxEditQuestion.Location = new System.Drawing.Point(9, 126);
            this.richTextBoxEditQuestion.Name = "richTextBoxEditQuestion";
            this.richTextBoxEditQuestion.Size = new System.Drawing.Size(187, 81);
            this.richTextBoxEditQuestion.TabIndex = 10;
            this.richTextBoxEditQuestion.Text = "";
            // 
            // buttonAcceptNumberOfQuestions
            // 
            this.buttonAcceptNumberOfQuestions.Location = new System.Drawing.Point(165, 74);
            this.buttonAcceptNumberOfQuestions.Name = "buttonAcceptNumberOfQuestions";
            this.buttonAcceptNumberOfQuestions.Size = new System.Drawing.Size(31, 20);
            this.buttonAcceptNumberOfQuestions.TabIndex = 13;
            this.buttonAcceptNumberOfQuestions.Text = "OK";
            this.buttonAcceptNumberOfQuestions.UseVisualStyleBackColor = true;
            this.buttonAcceptNumberOfQuestions.Click += new System.EventHandler(this.buttonAcceptNumberOfQuestions_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(122, 213);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Enabled = false;
            this.buttonCreate.Location = new System.Drawing.Point(9, 213);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 23);
            this.buttonCreate.TabIndex = 15;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelEditQuestion
            // 
            this.labelEditQuestion.AutoSize = true;
            this.labelEditQuestion.Location = new System.Drawing.Point(7, 102);
            this.labelEditQuestion.Name = "labelEditQuestion";
            this.labelEditQuestion.Size = new System.Drawing.Size(68, 13);
            this.labelEditQuestion.TabIndex = 17;
            this.labelEditQuestion.Text = "Edit question";
            // 
            // nudEditQuestion
            // 
            this.nudEditQuestion.Enabled = false;
            this.nudEditQuestion.Location = new System.Drawing.Point(142, 100);
            this.nudEditQuestion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEditQuestion.Name = "nudEditQuestion";
            this.nudEditQuestion.Size = new System.Drawing.Size(55, 20);
            this.nudEditQuestion.TabIndex = 16;
            this.nudEditQuestion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CreateSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "CreateSurvey";
            this.Size = new System.Drawing.Size(216, 257);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberOfQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RichTextBox richTextBoxEditQuestion;
        private System.Windows.Forms.Label labelNumberOfQuestions;
        private System.Windows.Forms.NumericUpDown nudNumberOfQuestions;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelEditQuestion;
        private System.Windows.Forms.NumericUpDown nudEditQuestion;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonAcceptNumberOfQuestions;
    }
}
