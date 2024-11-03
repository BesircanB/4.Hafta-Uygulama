using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int sayac = 0;

        void TekrarOyna()
        {
            Application.Restart();
        }

        void Kazanan(string sembol)
        {
            if (button1.Text == sembol && button2.Text==sembol && button3.Text==sembol)
            {
                MessageBox.Show(sembol + " kazandı");
                TekrarOyna();
            }
            else if(button4.Text == sembol && button5.Text == sembol && button6.Text == sembol)
            {

                MessageBox.Show(sembol + " kazandı");
                TekrarOyna();
            }
            else if(button7.Text == sembol && button8.Text == sembol && button9.Text == sembol)
            {
                MessageBox.Show(sembol + " kazandı");
                TekrarOyna();
            }
            else if (button1.Text == sembol && button5.Text == sembol && button9.Text == sembol)
            {
                MessageBox.Show(sembol + " kazandı");
                TekrarOyna();
            }
            else if (button3.Text == sembol && button5.Text == sembol && button7.Text == sembol)
            {
                MessageBox.Show(sembol + " kazandı");
                TekrarOyna();
            }
            else if (button1.Text == sembol && button4.Text == sembol && button7.Text == sembol)
            {

                MessageBox.Show(sembol + " kazandı");
                TekrarOyna();
            }
            else if (button2.Text == sembol && button5.Text == sembol && button8.Text == sembol)
            {
                MessageBox.Show(sembol + " kazandı");
                TekrarOyna();
            }
            else if (button3.Text == sembol && button6.Text == sembol && button9.Text == sembol)
            {
                MessageBox.Show(sembol + " kazandı");
                TekrarOyna();
            }
        }

        void sembol(object senderobj)
        {
            string buttontxt = ((Button)senderobj).Text;
            if (buttontxt == "")
            {
                if (sayac % 2 == 0)
                {
                    ((Button)senderobj).Text = "O";
                }
                   

                       
                else
                {
                    ((Button)senderobj).Text = "X";

                }
                sayac++;
                Kazanan("O");
                Kazanan("X");
            }
                
            else{
                MessageBox.Show("Geçersiz tıklama!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            sembol(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sembol(sender);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            sembol(sender);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            sembol(sender);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            sembol(sender);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            sembol(sender);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sembol(sender);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sembol(sender);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sembol(sender);

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
