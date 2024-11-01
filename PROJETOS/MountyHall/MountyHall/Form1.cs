using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MountyHall
{
    public partial class Form1 : Form
    {
        int portaSistema = 0;
        int portaNaoEscolhida = 0;
        int acesso = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPort1_Click(object sender, EventArgs e)
        {
            lbl_Result.Text = "";
            if (acesso == 1)
            {
                int portaUsuario = 1;

                // Reconhecer Porta Não Escolhida
                do
                {
                    portaNaoEscolhida = sortPort();
                } while (portaNaoEscolhida == portaSistema
                        || portaNaoEscolhida == portaUsuario);

                // Abrir Porta
                if (portaNaoEscolhida == 2)
                    button2.Visible = false;
                else if (portaNaoEscolhida == 3)
                    button3.Visible = false;
                
                acesso = 2;
            }
            else if (acesso == 2)
            {
                if (portaSistema == 1)
                    lbl_Result.Text = "Sucesso !";
                else
                    lbl_Result.Text = "Fracasso !";

                reset();
            }
        }

        private void btnPort2_Click(object sender, EventArgs e)
        {
            lbl_Result.Text = "";
            if (acesso == 1)
            {
                int portaUsuario = 2;

                // Reconhecer Porta Não Escolhida
                do
                {
                    portaNaoEscolhida = sortPort();
                } while (portaNaoEscolhida == portaSistema
                        || portaNaoEscolhida == portaUsuario);

                // Abrir Porta
                if (portaNaoEscolhida == 1)
                    btnPort1.Visible = false;
                else if (portaNaoEscolhida == 3)
                    button3.Visible = false;

                acesso = 2;
            }
            else if (acesso == 2)
            {
                if (portaSistema == 2)
                    lbl_Result.Text = "Sucesso !";
                else
                    lbl_Result.Text = "Fracasso !";

                reset();
            }
        }

        private void btnPort3_Click(object sender, EventArgs e)
        {
            lbl_Result.Text = "";
            if (acesso == 1)
            {
                int portaUsuario = 3;

                // Reconhecer Porta Não Escolhida
                do
                {
                    portaNaoEscolhida = sortPort();
                } while (portaNaoEscolhida == portaSistema
                        || portaNaoEscolhida == portaUsuario);

                // Abrir Porta
                if (portaNaoEscolhida == 1)
                    btnPort1.Visible = false;
                else if (portaNaoEscolhida == 2)
                    button2.Visible = false;

                acesso = 2;
            }
            else if (acesso == 2)
            {
                if (portaSistema == 3)
                    lbl_Result.Text = "Sucesso !";
                else
                    lbl_Result.Text = "Fracasso !";

                reset();
            }
        }

        private void reset() {
            acesso = 1;
            portaSistema = sortPort();

            btnPort1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
        }

        private int sortPort()
        {
            Random r = new Random();
            return (r.Next(3) + 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            portaSistema = sortPort();
            acesso = 1;
        }
    }
}
