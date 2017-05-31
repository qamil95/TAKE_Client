using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAKE_Client
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonShowAllTeachers_Click(object sender, EventArgs e)
        {
            refreshTeachers();
        }

        private void buttonShowAllSurveys_Click(object sender, EventArgs e)
        {
            refreshSurveys();
        }

        private void refreshTeachers()
        {
            StringReader theReader = new StringReader(HTTP.GetTeachers());
            DataSet theDataSet = new DataSet();
            theDataSet.ReadXml(theReader);
            if (theDataSet.Tables.Count == 0)
            {
                dataGridTeachers.DataSource = null;
            }
            else
            {
                dataGridTeachers.DataSource = theDataSet.Tables[0];
            }            
        }
        private void refreshSurveys()
        {
            StringReader theReader = new StringReader(HTTP.GetSurveys());
            DataSet theDataSet = new DataSet();
            theDataSet.ReadXml(theReader);
            if (theDataSet.Tables.Count == 0)
            {
                MessageBox.Show("No surveys!");
            }
            else
            {
                dataGridSurveys.DataSource = theDataSet.Tables[0];
                dataGridQuestions.DataSource = theDataSet.Tables[0];
                dataGridQuestions.DataMember = theDataSet.Tables[0].ChildRelations[0].RelationName;
            }            
        }
        private void tabAdminTeachers_Enter(object sender, EventArgs e)
        {
            refreshTeachers();
        }

        private void buttonDeleteTeacher_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridTeachers.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridTeachers.Rows[selectedrowindex];
            int num = int.Parse((string)selectedRow.Cells["idt"].Value);
            MessageBox.Show(HTTP.DeleteTeacher(num));
            refreshTeachers();
        }

        private void buttonEditTeacher_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridTeachers.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridTeachers.Rows[selectedrowindex];
            int num = int.Parse((string)selectedRow.Cells["idt"].Value);
            string name = (string)selectedRow.Cells["firstName"].Value;
            string surname = (string)selectedRow.Cells["lastName"].Value;
            MessageBox.Show(HTTP.EditTeacher(name, surname, num));
            refreshTeachers();
        }
    }    
}
