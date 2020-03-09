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
    public partial class ChelovekForm : Form
    {
        public ChelovekForm(string name)
        {
            InitializeComponent();
            Text = "Информация о " + name;

            try
            {
                pictureBox1.Load("../../Resources/" + name + ".jpg");
                textBox1.Lines =
                    System.IO.File.ReadAllLines("../../Resources/" + name + ".txt");
            }
            catch(Exception) { }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
