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
        

        public Jojo(string _name, bool _isLife, int _vozrast , Button lbl1)
        {
            name = _name;
            isLife = _isLife;
            vozrast = _vozrast;
            lbl = lbl1;
        }
    }

    public partial class HeroesForm : Form        
    {
        Button[] knopki = new Button[10];

        Jojo[] persons = new Jojo[100];


        public HeroesForm(string hero)
        {
            InitializeComponent();
            Text = hero;

            persons[0] = new Jojo("Джоске", true, 17, button1);
            persons[1] = new Jojo("Джозеф", true, 57, button2);
            persons[2] = new Jojo("Джотаро", true, 33, button3);
            persons[3] = new Jojo("Пуччи", true, 39, button4);
            persons[4] = new Jojo("Джолин", true, 19, button5);
            persons[5] = new Jojo("Окуясу", true, 17, button6);
            /*persons[6] = new Jojo("Дьяволо", true, 35);
            persons[7] = new Jojo("Дио Брандо", true,113);
            persons[8] = new Jojo("Джонни", true, 19);*/

            knopki[0] = button1;
            knopki[1] = button2;
            knopki[2] = button3;
            knopki[3] = button4;
            knopki[4] = button5;
            knopki[5] = button6;

            if (hero == "Главные герои")
            {
                button1.Tag = "Jonny";
                button1.Text = "Джонни Джостар";

                button2.Tag = "Jonatan";
                button2.Text = "Джонатан Джостар";

                button3.Tag = "Jotaro";
                button3.Text = "Джотаро Куджо";

                button4.Tag = "Joske";
                button4.Text = "Джоске Хигашиката";


                button5.Tag = "Jolin";
                button5.Text = "Джолин Куджо";


                button6.Tag = "Joseph";
                button6.Text = "Джозеф Джостар";
            }

            else if (hero == "Главные злодеи")
            {
                button1.Tag = "Dio";
                button1.Text = "Дио Брандо";

                button2.Tag = "Diavolo";
                button2.Text = "Дьяволо";
                
                button3.Tag = "Pucci";
                button3.Text = "Пуччи";


                for (int i = 3; i < 6; i++)
                    knopki[i].Visible = false;
            }
            else if (hero == "Второстепенные персонажи")
            {
                button1.Tag = "Okuyasu";
                button1.Text = "Неджимура Окуясу";
                button2.Tag = "Speedwagon";
                button2.Text = "Спидвагон";
                button3.Tag = "Gyro Zepelli";
                button3.Text = "Джайро Цепппеле";

                for (int i = 1 ; i < 6; i++)
                    knopki[i].Visible = false;

            }
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

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            for (int i = 0; i < 6; i++)
            {
                persons[i].lbl.Visible = false;
                if (persons[i].vozrast < Convert.ToInt32(comboBox1.Text))
                {
                    persons[i].lbl.Visible = true;
                    persons[i].lbl.Text = persons[i].name;
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
    }
}
