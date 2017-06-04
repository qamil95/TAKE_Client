using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAKE_Client
{
    public partial class CreateSurvey : UserControl
    {
        string[] questions;
        public CreateSurvey()
        {
            InitializeComponent();
        }

        private void buttonAcceptNumberOfQuestions_Click(object sender, EventArgs e)
        {
            nudNumberOfQuestions.Enabled = false;
            buttonAcceptNumberOfQuestions.Enabled = false;
            nudEditQuestion.Enabled = true;
            nudEditQuestion.Maximum = nudNumberOfQuestions.Value;
            richTextBoxEditQuestion.Enabled = true;
            buttonCreate.Enabled = true;
            questions = new string[(int)nudNumberOfQuestions.Value];
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            bool error = false;
            for (int i=0; i<questions.Length; i++)
            {
                if (string.IsNullOrEmpty(questions[i]))
                {
                    MessageBox.Show("Question number " + (i + 1).ToString() + " is empty!");
                    error = true;
                    break;
                }
            }
            if (!error)
            {
                MessageBox.Show(HTTP.NewSurvey(textBoxDate.Text, textBoxDescription.Text, questions));
                resetForm();
            }            
        }

        private void nudEditQuestion_ValueChanged(object sender, EventArgs e)
        {            
            richTextBoxEditQuestion.Text = questions[(int)nudEditQuestion.Value - 1];
        }

        private void richTextBoxEditQuestion_TextChanged(object sender, EventArgs e)
        {
            questions[(int)nudEditQuestion.Value - 1] = richTextBoxEditQuestion.Text;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }
        private void resetForm()
        {
            nudEditQuestion.Value = 1;
            richTextBoxEditQuestion.Enabled = false;
            richTextBoxEditQuestion.Text = string.Empty;
            textBoxDate.Text = string.Empty;
            textBoxDescription.Text = string.Empty;
            questions = null;
            nudNumberOfQuestions.Enabled = true;
            nudNumberOfQuestions.Value = 1;
            buttonAcceptNumberOfQuestions.Enabled = true;
            nudEditQuestion.Enabled = false;
            nudEditQuestion.Value = 1;
            buttonCreate.Enabled = false;
        }
    }
}
