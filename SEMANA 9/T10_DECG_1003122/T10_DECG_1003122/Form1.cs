using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T10_DECG_1003122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radio = double.Parse(textBox1.Text);
            CIRCULO _objcirculo = new CIRCULO(radio);
            double resultado = _objcirculo.getperimetro();
            MessageBox.Show(" EL RESUTADO DEL PERIMETRO ES: "+resultado.ToString(), "RESULTADO DEL PERIMETRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double radio = double.Parse(textBox1.Text);
            CIRCULO _objcirculo = new CIRCULO(radio);
            double resultado = _objcirculo.getarea();
            MessageBox.Show(" EL RESUTADO DEL AREA ES: " + resultado.ToString(), "RESULTADO DEL AREA", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double radio = double.Parse(textBox1.Text);
            CIRCULO _objcirculo = new CIRCULO(radio);
            double resultado = _objcirculo.getvolumen();
            MessageBox.Show(" EL RESUTADO DEL VOLUMEN ES: " + resultado.ToString(), "RESULTADO DEL VOLUMEN", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
