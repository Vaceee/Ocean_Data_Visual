﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Visual
{
    public partial class SQLEnsure : Form
    {

        public SQLEnsure()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            sql_source.dt_source = ".";
            welcome form = new welcome();
            this.Hide();
            form.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            sql_source.dt_source = @".\SQLEXPRESS";
            welcome form = new welcome();
            this.Hide();
            form.ShowDialog();
        }
    }
}
