﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marsel_karton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {




        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dioButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ChelovekForm f = new ChelovekForm(btn.Tag.ToString());
            f.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

