using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC11_PrimeiroProjetoGrafico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome;
            string sobrenome;
            nome = TestBoxNOME.Text;
            sobrenome = textBoxSOBRENOME.Text;

            MessageBox.Show(nome + " " + sobrenome);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void g_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttoncalcular_Click(object sender, EventArgs e)
        {
            double numero1;
            double numero2;
            string  resultado;

            numero1 = Double.Parse(textBox1n1.Text);    
            numero2 = Double.Parse(textBoxn2.Text);


            resultado = Convert.ToString(numero1 + numero2);

            MessageBox.Show(resultado);

          }
            

        private void textBoxNUMERO_dois_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxumero_um_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
