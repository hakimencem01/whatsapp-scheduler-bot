﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            string clockHrs = DateTime.Now.ToString("HH tt");
            string clockMin = DateTime.Now.ToString("mm tt");
            HRS.Text = clockHrs;
            MIN.Text = clockMin;
        }
    }
}
