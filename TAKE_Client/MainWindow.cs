﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            MessageBox.Show(HTTP.GetTeachers());
        }

        private void buttonShowAllSurveys_Click(object sender, EventArgs e)
        {
            MessageBox.Show(HTTP.GetSurveys());
        }
    }
}
