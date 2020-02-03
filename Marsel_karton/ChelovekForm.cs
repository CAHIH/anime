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
            pictureBox1.Load("../../Resources/" + name + ".jpg");

            if (name == "Dio")
            {
                textBox1.Text = "Дио Брандо главный злодей первых трёх частей ДжоДжо." +
                    "Обладатель стенда Whe World обладающий большой стилой , реакцией и точностью" +
                    " умеющий останавливать время на 5 секунд ," +
                    " но после того как Дио впитал кровь Джозефа Джостара он останавливал время на 10 секунд ";
            }
            if (name == "ДжоДжо")
            {
                textBox1.Text = "Джотаро Куджо главный герой второго и третьего сезона ДжоДжо " +
                    "обладатель стенд Star Platinum обладающий невероятной силой , точностью и реакцией" +
                    " умеющий останавливать время на 3 секунды ";
            }
            if (name == "Joske")
            {
                textBox1.Text = "Главный герой четвёртой части ДжоДжо" +
                    Environment.NewLine + ", сын Джозефа Джостара. Обладатель стенда Crazy Diamond обладающий большой силой ," +
                    " хорошей реакцией и точностью умеющий возвращать вещи в изначальное состояние ," +
                    " так-же может вылечить человека от физического урона" ;
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
