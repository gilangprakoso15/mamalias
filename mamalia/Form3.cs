﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mamalia
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();

            }
            else
            {
                Form5 form5 = new Form5();
                form5.Show();
                this.Hide();

            }
        }
    }
}
