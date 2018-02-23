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
    public partial class Programa3 : Form
    {
        int valorinicial, valorincdec;
        int resincr, contador, resdecr;

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            valorinicial = int.Parse(txtInicial.Text);
            valorincdec = int.Parse(txtIncDec.Text);

            resincr = valorinicial;
            resdecr = valorinicial;
            contador = 0;

            lblRInc.Text = txtInicial.Text;
            lblRDecremento.Text = txtInicial.Text;
            lblContador.Text = "0";
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            resincr += valorincdec;
            resdecr -= valorincdec;
            contador += 1;

            //Mostrar valores en las etiquetas
            lblRInc.Text = resincr.ToString();
            lblRDecremento.Text = resdecr.ToString();
            lblContador.Text = contador.ToString();

        }

        private void btnIntercambiar_Click(object sender, EventArgs e)
        {
            int temp;

            temp = resincr;
            resincr=resdecr;
            resdecr = temp;

            lblRInc.Text = resincr.ToString();
            lblRDecremento.Text = resdecr.ToString();
        }

        public Programa3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
