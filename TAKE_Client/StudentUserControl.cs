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

namespace TAKE_Client
{
    public partial class StudentUserControl : UserControl
    {
        Dictionary<int, int> dictionaryTeachers, dictionarySurveys;
        public StudentUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxTeachers.SelectedIndex.ToString()+ " ma idt " + dictionaryTeachers[comboBoxTeachers.SelectedIndex]);
        }

        private void comboBoxSurveys_SelectedIndexChanged(object sender, EventArgs e)
        {            
            MessageBox.Show(HTTP.GetSurvey(dictionarySurveys[comboBoxSurveys.SelectedIndex]));
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
        }
    }
}
