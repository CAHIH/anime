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
    public struct Jojo
    {
        public string name;
        public bool isLife;
        public int vozrast;
        public Button lbl;
        

        public Jojo(string _name, bool _isLife, int _vozrast, string _tag)
        {
            name = _name;
            isLife = _isLife;
            vozrast = _vozrast;

            lbl = new Button();
            lbl.Size = new Size(127, 53);
            lbl.Tag = _tag;
            lbl.Text = name;
        }
    }

    public partial class HeroesForm : Form        
    {
        Button[] knopki = new Button[10];

        Jojo[] persons = new Jojo[10];


        public HeroesForm(string hero)
        {
            InitializeComponent();
            Text = hero;

            persons[0] = new Jojo("Джоске", true, 17, "Joske");
            persons[1] = new Jojo("Джозеф", true, 57, "Joseph");
            persons[2] = new Jojo("Джотаро", true, 33, "Jotaro");
            persons[3] = new Jojo("Пуччи", true, 39, "Pucci");
            persons[4] = new Jojo("Джолин", true, 19, "Jolin");
            persons[5] = new Jojo("Окуясу", true, 17, "Okuyasu");
            persons[6] = new Jojo("Дьяволо", true, 35, "Diavolo");
            persons[7] = new Jojo("Дио Брандо", true, 113, "Dio");
            persons[8] = new Jojo("Джонни", true, 19 , "Jonny");
            persons[9] = new Jojo("Спидвагон", true, 36, "Speedwagon");
            int x = 0;
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].lbl.Location = new Point(x, 3);
                persons[i].lbl.Click += new EventHandler(jonniButton_Click);
                panel1.Controls.Add(persons[i].lbl);

                x = x + 130;
            }


            /*if (hero == "Главные герои")
            {
                button2.Tag = "Jonatan";
                button2.Text = "Джонатан Джостар";



            }
            else if (hero == "Второстепенные персонажи")
            {
                button3.Tag = "Gyro Zepelli";
                button3.Text = "Джайро Цепппеле";

                for (int i = 1 ; i < 6; i++)
                    knopki[i].Visible = false;

            }*/
        }

        private void jonniButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ChelovekForm f = new ChelovekForm(btn.Tag.ToString());
            f.ShowDialog();
        }

        private void HeroesForm_Load(object sender, EventArgs e)
        {

        }


        private void button7_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].lbl.Visible = true;

                //По возрасту
                if (vozrastComboBox.Text != "" &&
                    persons[i].vozrast > Convert.ToInt32(vozrastComboBox.Text))
                {
                    persons[i].lbl.Visible = false;
                }

                //По статусу
                if (persons[i].isLife == true && statusComboBox.Text == "Мертв")
                {
                    persons[i].lbl.Visible = false;
                }
                if (persons[i].isLife == false && statusComboBox.Text == "Жив")
                {
                    persons[i].lbl.Visible = false;
                }



            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HeroesForm_Load_1(object sender, EventArgs e)
        {

        }

        private void скачатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }
    }
}
