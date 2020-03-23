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
        Characters myPers;


        public ChelovekForm(Characters pers)
        {
            myPers = pers;

            InitializeComponent();
            Text = "Информация о " + pers.name;

            try
            {
                pictureBox1.Load("../../Resources/" + pers.picName + ".jpg");
                textBox1.Lines =
                    System.IO.File.ReadAllLines("../../Resources/" + pers.picName + ".txt");
            }
            catch(Exception) { }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HeroesForm.myTeam.Add(myPers);
        }
    }
}
