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
                MessageBox.Show("No teachers!");
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
    }    
}
