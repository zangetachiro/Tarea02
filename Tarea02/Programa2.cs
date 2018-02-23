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
    public partial class Programa2 : Form
    {
        public Programa2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tamaño = "", cubierta = "",ingredientes="",donde="";
            string salida = "";
            if(rbtP.Checked==true)
            {
                tamaño = rbtP.Text;
            }
            else if (rbtM.Checked)
            {
                tamaño = rbtM.Text;
            }
            else
            {
                tamaño = rbtG.Text;
            }
            if(rbtCD.Checked)
            {
                cubierta = rbtCD.Text;
            }
            else
            {
                cubierta = rbtCG.Text;
            }

            foreach (var ctrl in groupBox3.Controls)
            {
                if(ctrl is CheckBox && ((CheckBox)ctrl).Checked)
                {
                    ingredientes += ((CheckBox)ctrl).Text+"\n";
                }
            }
            if (rbtAq.Checked)
            {
                donde = rbtAq.Text;
            }
            else
            {
                donde = rbtLl.Text;
            }

            salida += string.Format("El tamaño sera: {0}\nTipo de cubierta: {1}\n", tamaño,cubierta)
                +     string.Format("Los ingredientes seran: {0}",ingredientes)
                +     string.Format("Será para comer: {0}",donde);

            MessageBox.Show(salida, "La pizza que elegiste");
        }

        private void button1_Click_1(object sender, EventArgs e) => Close();
    }
}
