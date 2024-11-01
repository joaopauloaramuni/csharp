using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Conversor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bin_Click(object sender, EventArgs e)
        {
            DecimalBinario dec2bin = new DecimalBinario();
            textBox2.Text = dec2bin.DecimalParaBinario(textBox1.Text);
        }

        private void limp_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void dec_Click(object sender, EventArgs e)
        {
            label7.Text = string.Empty;
            BinarioDecimal bin2dec = new BinarioDecimal();
            if (bin2dec.BinarioParaDecimal(textBox3.Text) == 2)
            {
                label7.Text = "Apenas binários!";
            }
            else textBox4.Text = bin2dec.BinarioParaDecimal(textBox3.Text).ToString();
        }

        private void limp2_Click_1(object sender, EventArgs e)
        {
            textBox3.Clear();
            textBox4.Clear();
            label7.Text = string.Empty;
        }

    }
}
