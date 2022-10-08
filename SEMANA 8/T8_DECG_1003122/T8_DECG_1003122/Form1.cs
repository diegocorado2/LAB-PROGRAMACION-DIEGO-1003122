using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T8_DECG_1003122
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
            int NUMERO = int.Parse(textBox1.Text);
            int RESULTADO;
            string BINARIO = "";

            while (NUMERO > 0)
            {
                RESULTADO = NUMERO % 2;
                NUMERO /= 2;
                BINARIO = RESULTADO.ToString() + BINARIO;
            }
            label3.Text = BINARIO;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int NUMERO = int.Parse(textBox2.Text);
            string HEXADECIMAL = Convert.ToString(NUMERO, 16);
            label6.Text = HEXADECIMAL;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
