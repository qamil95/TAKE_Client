using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace TAKE_Client
{
    public partial class StudentUserControl : UserControl
    {
        Dictionary<int, int> dictionaryTeachers, dictionarySurveys;
        public StudentUserControl()
        {
            InitializeComponent();
        }

        private void comboBoxSurveys_SelectedIndexChanged(object sender, EventArgs e)
        {
            StringReader theReader = new StringReader(HTTP.GetSurvey(dictionarySurveys[comboBoxSurveys.SelectedIndex]));
            DataSet theDataSet = new DataSet();
            theDataSet.ReadXml(theReader);
            if (theDataSet.Tables.Count != 0)
            {
                dataGridViewSurvey.DataSource = theDataSet.Tables["questions"];
                dataGridViewSurvey.Columns["idq"].Visible = false;
                dataGridViewSurvey.Columns["text"].HeaderText = "Question";
                dataGridViewSurvey.Columns["text"].ReadOnly = true;
            }
            
        }

        private void buttonSendSurvey_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> answers = new Dictionary<int, string>();
            foreach (DataGridViewRow row in dataGridViewSurvey.Rows)
            {
                if ((string)row.Cells["text"].Value != String.Empty)
                {
                    answers.Add(int.Parse((string)row.Cells["idq"].Value), (string)row.Cells["text"].Value);
                }                
            }
            if (comboBoxTeachers.SelectedIndex >= 0)
            {
                MessageBox.Show(HTTP.NewFilledSurvey(dictionarySurveys[comboBoxSurveys.SelectedIndex],
                dictionaryTeachers[comboBoxTeachers.SelectedIndex],
                textBoxDate.Text,
                textBoxAdditionalInformation.Text,
                answers));
            }
            else
            {
                MessageBox.Show("Choose teacher!");
            }            
        }

        internal void Initialize()
        {
            dictionaryTeachers = new Dictionary<int, int>();
            dictionarySurveys = new Dictionary<int, int>();
            comboBoxTeachers.Items.Clear();
            comboBoxSurveys.Items.Clear();
            XElement teachers = XElement.Parse(HTTP.GetTeachers());
            List<XElement> ordered = teachers.Elements("set")
                .OrderBy(element => (string)element.Element("lastName"))
                .ToList();
            teachers.RemoveAll();
            teachers.Add(ordered);
            foreach (XElement teacher in teachers.Elements())
            {
                int num = comboBoxTeachers.Items.Add(teacher.Element("lastName").Value + ' ' + teacher.Element("firstName").Value);
                dictionaryTeachers.Add(num, int.Parse(teacher.Attribute("idt").Value));
            }

            XElement surveys = XElement.Parse(HTTP.GetSurveys());
            ordered = surveys.Elements("set")
                .OrderBy(element => (string)element.Element("date"))
                .ToList();
            surveys.RemoveAll();
            surveys.Add(ordered);
            foreach (XElement survey in surveys.Elements())
            {
                int num = comboBoxSurveys.Items.Add(survey.Element("date").Value + " - " + survey.Element("description").Value);
                dictionarySurveys.Add(num, int.Parse(survey.Attribute("ids").Value));
            }
            dataGridViewSurvey.Columns.Add("answers", "Answer");
        }
    }
}
