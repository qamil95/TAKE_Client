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
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            MessageBox.Show(HTTP.NewSurvey(textBoxDate.Text, textBoxDescription.Text, new string[] { "Dlaczego ula?", "Dlaczego drabson?", "Dlaczego zmitac?" }));
        }
    }
}
