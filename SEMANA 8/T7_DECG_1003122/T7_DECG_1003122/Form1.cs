using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T7_DECG_1003122
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double n = double.Parse(textBox2.Text);
            double a = double.Parse(textBox3.Text);

            if (x > 0 && n > 0 && a > 0)
            {
                //Ejercicio A
                for (int i = 1; i <= 1; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        textBox4.AppendText(i%j + "\r\n");
                    }
                }
                //Ejercicio B
                for (int i = 1; i <= 1; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        for (int h = 2; h <= 2; h++)
                        {
                            textBox5.AppendText(i % Math.Pow(h,j) + "\r\n");
                        }
                    }
                }
                //Ejercicio C
                double k = 0;

                double Sumatoria = Math.Pow(x, k) * Math.Pow(a, (n - k));

                label5.Text = Sumatoria.ToString();
            }

        }
    }
}
