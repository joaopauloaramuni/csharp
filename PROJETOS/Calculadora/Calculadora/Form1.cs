using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void soma_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox2.Text.Replace(".", ","));
            double numero2 = Convert.ToDouble(textBox3.Text.Replace(".", ","));
            Calculo resultado = new Calculo();
            textBox1.Text = resultado.soma(numero1, numero2).ToString();
        }
        private void sub_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox2.Text.Replace(".", ","));
            double numero2 = Convert.ToDouble(textBox3.Text.Replace(".", ","));
            Calculo resultado = new Calculo();
            textBox1.Text = resultado.sub(numero1, numero2).ToString();
        }

        private void mult_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox2.Text.Replace(".", ","));
            double numero2 = Convert.ToDouble(textBox3.Text.Replace(".", ","));
            Calculo resultado = new Calculo();
            textBox1.Text = resultado.mult(numero1, numero2).ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(textBox2.Text.Replace(".", ","));
            double numero2 = Convert.ToDouble(textBox3.Text.Replace(".", ","));
            Calculo resultado = new Calculo();
            textBox1.Text = resultado.div(numero1, numero2).ToString();
        }

        private void limp_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty; 
        }
    }
}
