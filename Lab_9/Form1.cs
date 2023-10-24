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

    public partial class Form1 : Form
    {
        interface IMovable
        {

            string Move { get; }
            string Stop { get; }

            string Attention { get; }
        }

        class Person : IMovable
        {
            public string Move { get => "Иди"; }
            public string Stop { get => "Стоять"; }
            public string Attention { get => "Внимание"; }

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



        public Form1()
        {
            InitializeComponent();
        }

        Car car = new Car();
        Person person = new Person();

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button4.BackColor = Color.Green;

            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button5.BackColor = Color.White;

            label2.Text = car.Stop;
            label4.Text = person.Move;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Yellow;

            button1.BackColor = Color.White;
            button3.BackColor = Color.White;
            button5.BackColor = Color.White;
            button4.BackColor = Color.White;

            label2.Text = car.Attention;
            label4.Text = person.Attention;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = car.Move;
            label4.Text = person.Stop;

            button3.BackColor = Color.Green;
            button5.BackColor = Color.Red;

            button2.BackColor = Color.White;
            button1.BackColor = Color.White;
            button4.BackColor = Color.White;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button4.BackColor = Color.Green;

            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button5.BackColor = Color.White;

            label2.Text = car.Stop;
            label4.Text = person.Move;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = car.Move;
            label4.Text = person.Stop;

            button3.BackColor = Color.Green;
            button5.BackColor = Color.Red;

            button2.BackColor = Color.White;
            button1.BackColor = Color.White;
            button4.BackColor = Color.White;
        }
    }
}
