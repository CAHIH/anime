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
    public struct Characters
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string name;
        public bool isLife;
        public int vozrast;
        /// <summary>
        /// Кнопка
        /// </summary>
        public Button lbl;
        public string picName;
        

        public Characters(string _name, bool _isLife, int _vozrast, string _tag)
        {
            name = _name;
            isLife = _isLife;
            vozrast = _vozrast;

            lbl = new Button();
            lbl.Size = new Size(127, 53);
            picName = _tag;
            lbl.Text = name;
        }
    }

    public partial class HeroesForm : Form
    {
        Button[] knopki = new Button[1];

        public static Characters[] persons = new Characters[11];

        
        

        public static List<Characters> myTeam = new List<Characters>();




        public HeroesForm(string hero)
        {
            InitializeComponent();


            Text = hero;


            persons[0] = new Characters("Джоске", true, 17, "Joske");
            persons[1] = new Characters("Джозеф", true, 57, "Joseph");
            persons[2] = new Characters("Джотаро", true, 33, "Jotaro");
            persons[3] = new Characters("Пуччи", true, 39, "Pucci");
            persons[4] = new Characters("Джолин", true, 19, "Jolin");
            persons[5] = new Characters("Окуясу", true, 17, "Okuyasu");
            persons[6] = new Characters("Дьяволо", true, 35, "Diavolo");
            persons[7] = new Characters("Дио Брандо", true, 113, "Dio");
            persons[8] = new Characters("Джонни", true, 19 , "Jonny");
            persons[9] = new Characters("Спидвагон", true, 36, "Speedwagon");
            persons[10] = new Characters("Джайро ", true, 43, "Gyro Zeppeli");


            int x = 0;
            int y = 3;
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].lbl.Location = new Point(x, y);
                persons[i].lbl.Click += new EventHandler(jonniButton_Click);
                panel1.Controls.Add(persons[i].lbl);

                x = x + 130;
                if (x + 130 > panel1.Width)
                {
                    x = 0;
                    y = y + 50;
                }
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

        public static void jonniButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < persons.Length; i++)
            {
                if (sender == persons[i].lbl ||
                    ((PictureBox)sender).) 
                {
                    ChelovekForm f = new ChelovekForm(persons[i]);
                    f.ShowDialog();
                }
            }
        }

        private void HeroesForm_Load(object sender, EventArgs e)
        {

        }


        private void button7_Click_1(object sender, EventArgs e)
        {
            int x = 0;
            int y = 3;
            for (int i = 0; i < persons.Length; i++)
            {
                if (sender == persons[i].lbl)

                persons[i].lbl.Visible = true;

                //По возрасту
                if (vozrastTextBox.Text != "" &&
                    persons[i].vozrast > Convert.ToInt32(vozrastTextBox.Text))
                {
                    persons[i].lbl.Visible = false;
                }
                //По имени
                if (nameTextBox.Text != "" &&
                    !persons[i].name.Contains(nameTextBox.Text))
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

                if (persons[i].lbl.Visible)
                {
                    persons[i].lbl.Location = new Point(x, y);
                    x = x + 130;
                    if (x + 130 > panel1.Width)
                    {
                        x = 0;
                        y = y + 50;
                    }
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
