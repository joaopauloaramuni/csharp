using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Email
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage(remetente.Text,destinatario.Text);
            mail.Subject = assunto.Text;
            mail.Body = body.Text;
            SmtpClient smtp = new SmtpClient(ip.Text);
            smtp.Host = email.Text;
            smtp.Credentials = new NetworkCredential(remetente.Text, senha.Text);
            try
            {
                smtp.Send(mail);
                MessageBox.Show("Enviado!");
            }
            catch 
            {
                MessageBox.Show("Erro!");
            }
        }

        private void limpa_Enter(object sender, EventArgs e)
        {
            ip.Text = string.Empty;
            ip.ForeColor = Color.Black;
        }

        private void limpa2_Enter(object sender, EventArgs e)
        {
            email.Text = string.Empty;
            email.ForeColor = Color.Black;
        }
    }
}
