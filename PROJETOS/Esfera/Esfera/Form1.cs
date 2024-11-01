using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Esfera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                area.Text = "0";
                volume.Text = "0";
            }
            else
            {
                double raio = 0;
                double.TryParse(textBox1.Text.Replace(".", ","), out raio);
                if (raio <= 0)
                {
                    MessageBox.Show("Valor Incorreto!");
                }
                else
                {
                    area.Text = Convert.ToString((4 * 3.14) * (Math.Pow(raio, 2)));
                    volume.Text = Convert.ToString(((4 * 3.14) * (Math.Pow(raio, 3))) / 3);
                }
            }
        }
    }
}
