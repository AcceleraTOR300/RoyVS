using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_9
{
    public partial class Form2 : Form
    {
        //Здесь интерфейс
        interface IMovable
        {

            string Move { get; }
            string Stop { get; }

            string Attention { get; }
        }


        struct Car : IMovable
        {
            public string Move { get => "Ехать"; }
            public string Stop { get => "Стоять"; }

            public string Attention { get => "Внимание"; }
        }

        class Bus : IMovable
        {
            public string Move { get => "Ехать"; }
            public string Stop { get => "Стоять"; }

            public string Attention { get => "Внимание"; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        Car car = new Car();
        Bus bus = new Bus();


        private void button1_Click(object sender, EventArgs e)
        {
            // Видоизменяем дизайн кнопок во время операциии
            button1.BackColor = Color.Red;
            button6.BackColor = Color.Green;

            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;

            label2.Text = car.Stop;
            label4.Text = bus.Move;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Видоизменяем дизайн кнопок во время операциии
            button2.BackColor = Color.Yellow;
            button5.BackColor = Color.Yellow;

            button1.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button6.BackColor = Color.White;

            label2.Text = car.Attention;
            label4.Text = bus.Attention;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Green;
            button4.BackColor = Color.Red;

            button2.BackColor = Color.White;
            button1.BackColor = Color.White;
            button6.BackColor = Color.White;
            button5.BackColor = Color.White;

            label2.Text = car.Move;
            label4.Text = bus.Stop;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Green;
            button4.BackColor = Color.Red;

            button2.BackColor = Color.White;
            button1.BackColor = Color.White;
            button6.BackColor = Color.White;
            button5.BackColor = Color.White;

            label2.Text = car.Move;
            label4.Text = bus.Stop;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Yellow;
            button5.BackColor = Color.Yellow;

            button1.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button6.BackColor = Color.White;

            label2.Text = car.Attention;
            label4.Text = bus.Attention;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button6.BackColor = Color.Green;

            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;

            label2.Text = car.Stop;
            label4.Text = bus.Move;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Переходим на другую форму
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
