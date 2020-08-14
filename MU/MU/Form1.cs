using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string Conteudo
        {
            get;
            set;
        }
        private void cript_Click_1(object sender, EventArgs e)
        {
            erro1.Text = string.Empty;
            erro2.Text = string.Empty;
            atencao.Text = string.Empty;

            if (!arquivo.Text.Equals(string.Empty))
            {
                if (!File.Exists("c:\\" + arquivo.Text + ".txt"))
                {
                    if (!serial.Text.Equals(string.Empty))
                    {
                        if (serial.Text.Length >= 8)
                        {
                            if (!conteudo.Text.Equals(string.Empty))
                            {
                                File.Create("c:\\" + arquivo.Text + ".txt").Close();
                                StreamWriter sw = new StreamWriter("c:\\" + arquivo.Text + ".txt");
                                try
                                {
                                    sw.Write(Cript.Criptografar(conteudo.Text, serial.Text));
                                    sw.Close();
                                    MessageBox.Show("Criptografado com sucesso em " + "c:\\" + arquivo.Text + ".txt");
                                    atencao.ForeColor = Color.White;
                                    atencao.Text = "*Atenção: Guarde sua Chave de Segurança.";
                                }
                                catch (Exception ex)
                                {
                                    Conteudo = ex.Message;
                                    sw.Close();
                                    MessageBox.Show("Erro ao Criptografar! ex: " + Conteudo);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Insira o conteúdo do arquivo!");
                            }
                        }
                        else
                        {
                            erro2.ForeColor = Color.Red;
                            erro2.Text = "*Mínimo 8 dígitos.";
                        }
                    }
                    else
                    {
                        erro2.ForeColor = Color.Red;
                        erro2.Text = "*Insira o serial do arquivo.";
                    }
                }
                else
                {
                    erro1.ForeColor = Color.Red;
                    erro1.Text = "*Arquivo já existente.";
                }
            }
            else
            {
                erro1.ForeColor = Color.Red;
                erro1.Text = "*Insira o nome do arquivo.";
            }
        }

        private void descript_Click_1(object sender, EventArgs e)
        {
            erro1.Text = string.Empty;
            erro2.Text = string.Empty;
            atencao.Text = string.Empty;
            Conteudo = string.Empty;

            if (!arquivo.Text.Equals(string.Empty))
            {
                if (!serial.Text.Equals(string.Empty))
                {
                    if (serial.Text.Length >= 8)
                    {
                        if (File.Exists("c:\\" + arquivo.Text + ".txt"))
                        {
                            StreamReader sw = new StreamReader("c:\\" + arquivo.Text + ".txt");

                            try
                            {
                                while (!sw.EndOfStream)
                                {
                                    Conteudo += sw.ReadLine();
                                }
                                sw.Close();
                            }
                            catch (Exception ex)
                            {
                                Conteudo = ex.Message;
                                sw.Close();
                            }

                            try
                            {
                                conteudo.Text = Cript.Descriptografar(Conteudo, serial.Text);
                            }
                            catch (Exception ex)
                            {
                                Conteudo = ex.Message;
                                MessageBox.Show("Chave de Segurança Incorreta ou Conteúdo do Arquivo Corrompido. ex: " + Conteudo);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Arquivo não encontrado em " + "c:\\" + arquivo.Text + ".txt");
                        }
                    }
                    else
                    {
                        erro2.ForeColor = Color.Red;
                        erro2.Text = "*Mínimo 8 dígitos.";
                    }
                }
                else
                {
                    erro2.ForeColor = Color.Red;
                    erro2.Text = "*Insira o serial do arquivo.";
                }
            }
            else
            {
                erro1.ForeColor = Color.Red;
                erro1.Text = "*Insira o nome do arquivo.";
            }
        }

        private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            Help ajuda = new Help();
            ajuda.Show();
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("EncryptSecurity v. 2.0 - Criado por João Paulo Aramuni - 2011");
        }

        private void f1HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help ajuda = new Help();
            ajuda.Show();
        }

        private void encryptSecurityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EncryptSecurity v. 2.0 - Criado por João Paulo Aramuni - 2011");
        }
    }
}
