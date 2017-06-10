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
            dataGridTeachersAdminPanel.DataSource = teachersDataTable();
            UpdateTeacherButtons();
        }

        private void buttonShowAllSurveys_Click(object sender, EventArgs e)
        {
            refreshSurveys();
        }

        private DataTable teachersDataTable()
        {
            StringReader theReader = new StringReader(HTTP.GetTeachers());
            DataSet theDataSet = new DataSet();
            theDataSet.ReadXml(theReader);
            if (theDataSet.Tables.Count == 0)
            {
                return null;
            }
            else
            {
                theDataSet.Tables[0].DefaultView.Sort = "[lastName] asc";
                return theDataSet.Tables[0];
            }            
        }
        private void refreshSurveys()
        {
            StringReader theReader = new StringReader(HTTP.GetSurveys());
            DataSet theDataSet = new DataSet();
            theDataSet.ReadXml(theReader);
            if (theDataSet.Tables.Count != 0)
            {
                dataGridSurveys.DataSource = theDataSet.Tables[0];
                dataGridQuestions.DataSource = theDataSet.Tables[0];
                dataGridQuestions.DataMember = "set_questions";
                dataGridSurveys.Columns["ids"].Visible = false;
                dataGridQuestions.Columns["idq"].Visible = false;
            }            
            else
            {
                dataGridSurveys.DataSource = null;
                dataGridQuestions.DataSource = null;
            }
        }
        private void tabAdminTeachers_Enter(object sender, EventArgs e)
        {
            dataGridTeachersAdminPanel.DataSource = teachersDataTable();
            UpdateTeacherButtons();
        }

        private void buttonDeleteTeacher_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridTeachersAdminPanel.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridTeachersAdminPanel.Rows[selectedrowindex];
            int num = int.Parse((string)selectedRow.Cells["idt"].Value);
            MessageBox.Show(HTTP.DeleteTeacher(num));
            dataGridTeachersAdminPanel.DataSource = teachersDataTable();
            UpdateTeacherButtons();
        }

        private void buttonEditTeacher_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dataGridTeachersAdminPanel.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridTeachersAdminPanel.Rows[selectedrowindex];
            int num = int.Parse((string)selectedRow.Cells["idt"].Value);
            string name = (string)selectedRow.Cells["firstName"].Value;
            string surname = (string)selectedRow.Cells["lastName"].Value;
            MessageBox.Show(HTTP.EditTeacher(name, surname, num));
            dataGridTeachersAdminPanel.DataSource = teachersDataTable();
        }

        private void tabTeacher_Enter(object sender, EventArgs e)
        {
            dataGridTeachersTeacherPanel.DataSource = teachersDataTable();
            if (dataGridTeachersTeacherPanel.Columns["idt"] != null)
            {
                dataGridTeachersTeacherPanel.Columns["idt"].Visible = false;
            }
            UpdateTeacherButtons();
        }

        private void dataGridTeachersTeacherPanel_Click(object sender, EventArgs e)
        {
            if (dataGridTeachersTeacherPanel.Columns.Count != 0)
            {
                int selectedrowindex = dataGridTeachersTeacherPanel.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridTeachersTeacherPanel.Rows[selectedrowindex];
                int num = int.Parse((string)selectedRow.Cells["idt"].Value);
                StringReader theReader = new StringReader(HTTP.GetTeacher(num));
                DataSet theDataSet = new DataSet();
                theDataSet.ReadXml(theReader);
                dataGridFilledSurveysTeacherPanel.DataSource = theDataSet.Tables["filledSurveys"];
                dataGridSurveyDetailsTeacherPanel.DataSource = theDataSet.Tables["filledSurveys"];
                dataGridSurveyDetailsTeacherPanel.DataMember = "filledSurveys_answers";
                if (dataGridFilledSurveysTeacherPanel.DataSource != null)
                {
                    dataGridFilledSurveysTeacherPanel.Columns["idf"].Visible = false;          
                    dataGridSurveyDetailsTeacherPanel.Columns["idq"].Visible = false;
                    dataGridSurveyDetailsTeacherPanel.Columns["ida"].Visible = false;
                    dataGridSurveyDetailsTeacherPanel.Columns["questionText"].HeaderText = "Question";
                    dataGridSurveyDetailsTeacherPanel.Columns["text"].HeaderText = "Answer";
                }                
            }            
        }

        private void tabAdminSurveys_Enter(object sender, EventArgs e)
        {
            refreshSurveys();
        }

        private void tabStudent_Enter(object sender, EventArgs e)
        {
            studentUserControl.Initialize();
        }
        
        private void UpdateTeacherButtons()
        {
            if (dataGridTeachersAdminPanel.DataSource != null)
            {
                buttonDeleteTeacher.Enabled = true;
                buttonEditTeacher.Enabled = true;
            }
            else
            {
                buttonDeleteTeacher.Enabled = false;
                buttonEditTeacher.Enabled = false;
            }
        }

        private void buttonAdminDeleteSurvey_Click(object sender, EventArgs e)
        {
            if (dataGridSurveys.SelectedCells.Count != 0)
            {
                int selectedrowindex = dataGridSurveys.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridSurveys.Rows[selectedrowindex];
                int num = int.Parse((string)selectedRow.Cells["ids"].Value);
                MessageBox.Show(HTTP.DeleteSurvey(num));
                refreshSurveys();
            }
            else
            {
                MessageBox.Show("Select survey first");
            }
        }
        
        private void buttonAdminEditSurvey_Click(object sender, EventArgs e)
        {            
            if ((dataGridSurveys.SelectedCells.Count != 0) && (dataGridQuestions.Rows.Count > 1))
            {
                string[] questions = new string[dataGridQuestions.Rows.Count-1];
                for (int i=0; i<questions.Length; i++)
                {
                    questions[i] = (string)dataGridQuestions.Rows[i].Cells["text"].Value;
                }
                MessageBox.Show(HTTP.EditSurvey(
                    (string)dataGridSurveys.SelectedRows[0].Cells["date"].Value,
                    (string)dataGridSurveys.SelectedRows[0].Cells["description"].Value,
                    questions,
                    int.Parse((string)dataGridSurveys.SelectedRows[0].Cells["ids"].Value)
                    ));
            }
        }
    }    
}
