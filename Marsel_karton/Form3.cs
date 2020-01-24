using System;
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
    public partial class Form3 : Form
    {
        public Form3(string name)
        {
            InitializeComponent();
            Text = "Инрформация о " + name;

            if (name == "Дио Брандо")
            {
                pictureBox1.Image = Properties.Resources.Dio;
                textBox1.Text = "Дио Брандо главный злодей первых трёх частей ДжоДжо. ";
            }
            if (name == "ДжоДжо")
            {
                pictureBox1.Image = Properties.Resources.Jotaro;
                textBox1.Text = "Джотаро Куджо главный герой второго и третьего сезона ДжоДжо ";
            }
            if (name == "Джоске")
            {
                pictureBox1.Image = Properties.Resources.Joske;
                textBox1.Text = "Главный герой четвёртой части ДжоДжо сын Джозефа Джостара  ";
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
