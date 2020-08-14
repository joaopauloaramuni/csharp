using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Txt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gravar_Click(object sender, EventArgs e)
        {
            Gravar gravacao = new Gravar(richTextBox1.Text);
            label2.Text = "Gravado com Sucesso em c:\\texto.txt";

        }
        private void Form1_Load(object sender, EventArgs e)
        { 
            string arquivo = "c:\\texto.txt";
            if (File.Exists(arquivo))
            {
                Ler leitura = new Ler();
                richTextBox1.Text = leitura.Conteudo;
            }
            else
            {
                File.Create("c:\\texto.txt").Close();
            }
        }
    }
}
