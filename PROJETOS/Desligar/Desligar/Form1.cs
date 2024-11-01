using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Desligar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String shutdown;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = (Convert.ToInt32(label3.Text) - 1).ToString();
        }

        private void start_Click(object sender, EventArgs e)
        {
            Process.Start("Shutdown", shutdown + " -t " + textBox1.Text + @" -c ""Sua sessão será encerrada!""" + " -f");
            timer1.Start(); label3.Text = textBox1.Text;

        }

        private void stop_Click(object sender, EventArgs e)
        {
            Process.Start("Shutdown", "-a"); timer1.Stop();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: shutdown = " -s"; break;
                case 1: shutdown = " -r"; break;
            }
        }

        private void log_Click(object sender, EventArgs e)
        {
            Process.Start("Shutdown", " -l" + " -f");
        }
    }
}
