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
    public partial class Form3 : Form
    {
        interface IAccount
        {
            object CurrentSum { get; }
            object CurrentSum_1 { get; }
            object Name { get; set; }

            void Put(int sum);
            void Withdraw(int sum);
            void Put_1(int v);
        }

        interface IClient
        {
            string Name { get; set; }
        }

        interface IBunk
        {
            int CurrentSum { get; }
            int CurrentSum_1 { get; }

        }

        class Client : IAccount, IClient, IBunk
        {
            int _sum, _sum_1, sum1 = 0;


            public string Name { get; set; }

            public Client(string name, int sum)
            {
                Name = name;
                _sum = sum;
                _sum_1 = sum1;
            }






            public int CurrentSum { get { return _sum; } }
            public int CurrentSum_1 { get { return _sum_1; } }

            object IAccount.CurrentSum { get { return _sum; } }

            object IAccount.CurrentSum_1 { get { return _sum_1; } }

            object IAccount.Name { get { return Name; } set { } }

            //операции, которые будут нужны в дальнейшемц

            public void Put(int sum)
            {
                _sum += sum;
            }

            public void Put_1(int sum)
            {
                _sum_1 += sum;
            }

            public void Withdraw(int sum)
            {
                if (_sum >= sum)
                {
                    _sum -= sum;
                }
            }


            public void Withdraw_1(int sum)
            {
                if (_sum_1 >= sum)
                {
                    _sum_1 -= sum;
                }
            }
        }


        public Form3()
        {
            InitializeComponent();
        }
        //начальные значения
        IAccount account = new Client("Борис", 2938);

        // конвертируем данные для нужных операциий
        private void button1_Click(object sender, EventArgs e)
        {
            account.Put(Convert.ToInt32(textBox1.Text));
            label2.Text = Convert.ToString(value: account.CurrentSum);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(account.CurrentSum);
            label6.Text = Convert.ToString(account.Name);

            label4.Text = Convert.ToString(account.CurrentSum_1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            account.Withdraw(Convert.ToInt32(textBox2.Text));
            label2.Text = Convert.ToString(account.CurrentSum);

            account.Put_1(Convert.ToInt32(textBox2.Text));
            label4.Text = Convert.ToString(account.CurrentSum_1);

        }
    }
}
