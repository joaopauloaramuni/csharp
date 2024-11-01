using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hexa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = string.Empty;
            string CharForChar = textBox1.Text;
            string[] armazenarIF = new string[4];
            string comparar;
            int contIF = 0;
            bool OnOff = false;
            char[] verificar = textBox1.Text.ToCharArray();
            bool passar = false;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (verificar[i].Equals('0') || verificar[i].Equals('1'))
                {
                    passar = true;
                }
                else
                {
                    passar = false;
                    break;
                }
            }
            if (textBox1.Text.Length >= 4)
            {
                if (passar)
                {
                    foreach (char bin in CharForChar)
                    {
                        armazenarIF[contIF] = bin.ToString();

                        if (contIF == 3)
                        {
                            comparar = armazenarIF[0] + armazenarIF[1] + armazenarIF[2] + armazenarIF[3];
                            if (comparar == "0001")
                            {
                                textBox2.Text += 1;
                            }
                            else if (comparar == "0010")
                            {
                                textBox2.Text += 2;
                            }
                            else if (comparar == "0011")
                            {
                                textBox2.Text += 3;
                            }
                            else if (comparar == "0100")
                            {
                                textBox2.Text += 4;
                            }
                            else if (comparar == "0101")
                            {
                                textBox2.Text += 5;
                            }
                            else if (comparar == "0110")
                            {
                                textBox2.Text += 6;
                            }
                            else if (comparar == "0111")
                            {
                                textBox2.Text += 7;
                            }
                            else if (comparar == "1000")
                            {
                                textBox2.Text += 8;
                            }
                            else if (comparar == "1001")
                            {
                                textBox2.Text += 9;
                            }
                            else if (comparar == "1010")
                            {
                                textBox2.Text += "A";
                            }
                            else if (comparar == "1011")
                            {
                                textBox2.Text += "B";
                            }
                            else if (comparar == "1100")
                            {
                                textBox2.Text += "C";
                            }
                            else if (comparar == "1101")
                            {
                                textBox2.Text += "D";
                            }
                            else if (comparar == "1110")
                            {
                                textBox2.Text += "E";
                            }
                            else if (comparar == "1111")
                            {
                                textBox2.Text += "F";
                            }
                            contIF = 0;
                            comparar = "";
                            OnOff = true;
                        }
                        contIF++;
                        if (OnOff == true)
                        {
                            contIF = 0;
                        }
                        else
                        {
                            OnOff = false;
                        }
                        OnOff = false;
                    }
                }
                else label3.Text = "Apenas Binários!";
            } else label3.Text = "Mínimo 4 dígitos!";
        }
    }
}
