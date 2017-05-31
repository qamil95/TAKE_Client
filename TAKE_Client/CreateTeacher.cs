using System;
using System.Windows.Forms;

namespace TAKE_Client
{
    public partial class CreateTeacher : UserControl
    {
        public CreateTeacher()
        {
            InitializeComponent();
        }

        private void buttonCreateTeacher_Click(object sender, EventArgs e)
        {
            if ((textBoxName.Text != String.Empty) && (textBoxSurname.Text !=String.Empty))
            {
                MessageBox.Show(HTTP.NewTeacher(textBoxName.Text, textBoxSurname.Text));
                textBoxName.Text = string.Empty;
                textBoxSurname.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Enter name and surname!");
            }            
        }
    }
}
