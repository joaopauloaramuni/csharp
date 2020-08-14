using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fat_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(numericUpDown1.Text);
            double valor = 0;
            Calculo result = new Calculo();
            valor = result.fat(n);
            if (valor <= 0)
            {
                label6.Text = "Valor Limite Exedido.";
            }
            else
            {
                label6.Text = result.fat(n).ToString();
            }
        }

        private void fibo_Click(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(numericUpDown2.Text);
            double valor = 0;
            Calculo result = new Calculo();
            valor = result.fibo(n);
            if (valor < 0)
            {
                label6.Text = "Valor Limite Exedido.";
            }
            else
            {
                label7.Text = result.fibo(n).ToString();
            }
        }

    }
}
