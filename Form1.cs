using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] week = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        string[] zz = { "Овен", "Телец", "Близнецы", "Рак", "Лев", "Дева", "Весы", "Скорпион", "Стрелец", "Козерог", "Водолей", "Рыбы" };
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(zz);
            comboBox2.Items.AddRange(week);
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string vweek = comboBox2.Text;
            string vzz = comboBox1.Text;

            if (vzz.Length > 0 && vweek.Length > 0)
            {
                    Random rnd = new Random();
                    int value = rnd.Next(0, 10);
                    string secondLine = File.ReadLines("C:\\Pozelania.txt").Skip(value).First();
                    listBox1.Items.Add($"{vzz} {vweek} - {secondLine}");
            }
            else if (comboBox1.SelectedIndex == -1)
            {
              listBox1.Items.Add("Ошибка, выберете знак зодиака");
            }
            else if (comboBox2.SelectedIndex == -1)
            { listBox1.Items.Add("Ошибка, выберете День недели"); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}