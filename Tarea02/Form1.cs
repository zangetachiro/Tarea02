using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i=5, suma = 0;
            txtSalida.Clear();
            do
            {
                txtSalida.Text += i.ToString() + "\r\n";
                suma += i;
                i++;
            } while (i <= 200);
            lblResultado.Text = suma.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Numeros del 1-100 con While
            int i,ini,fin,suma=0;
            ini = 1;
            fin = 100;
            i = ini;
            txtSalida.Clear();//Borra cuadro de texto

            while (i<=fin)
            {
                txtSalida.Text += i.ToString() + "\r\n";
                suma += i;
                i++;
            }
            lblResultado.Text = suma.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i, ini, fin, suma = 0;
            ini = 100;
            fin = 1;
            i = ini;
            txtSalida.Clear();
            while(i>=fin)
             {
                txtSalida.Text += i.ToString() + "\r\n";
                suma += i;
                i--;
            }
            lblResultado.Text = suma.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i, suma = 0;
            txtSalida.Clear();
            for (i=50;i<=200;i=i+2)
            {
                txtSalida.Text += i.ToString() + "\r\n";
                suma += i;
            }
            lblResultado.Text = suma.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i, suma = 0;
            txtSalida.Clear();
            for (i = 99; i >= 1; i = i - 2)
            {
                txtSalida.Text += i.ToString() + "\r\n";
                suma += i;
            }
            lblResultado.Text = suma.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i, suma = 0;
            txtSalida.Clear();
            for (i = 5; i <= 95; i = i + 5)
            {
                txtSalida.Text += i.ToString() + "\r\n";
                suma += i;
            }
            lblResultado.Text = suma.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i, suma = 0;
            txtSalida.Clear();
            for (i = 272; i >= 40; i = i - 4)
            {
                txtSalida.Text += i.ToString() + "\r\n";
                suma += i;
            }
            lblResultado.Text = suma.ToString();
        }
    }
}
