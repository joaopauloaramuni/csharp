using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DespertadorProgramavel
{
    public partial class Form1 : Form
    {

        #region members

        string music = string.Empty;

        #endregion members

        #region constructor

        public Form1()
        {
            InitializeComponent();
        }

        #endregion constructor

        #region clicks

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!textBoxMusica.Text.Equals(""))
            {
                if (TbxHoraImput.Text.Equals("  :  :"))
                {
                    TimeSpan TempoSomado = TimeSpan.Parse(DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00")) + TimeSpan.Parse("03:55:00");
                    labelDesp.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", TempoSomado.Hours, TempoSomado.Minutes, TempoSomado.Seconds);

                }
                else
                {
                    labelDesp.Text = TbxHoraImput.Text;
                }
                timerDesp.Start();
            }
            else {
                MessageBox.Show("Insira uma música!");
            }
        }

        private void AddMusic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            if (opn.ShowDialog() == DialogResult.OK) {
                music = opn.FileName;
                textBoxMusica.Text = opn.SafeFileName;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Media.Ctlcontrols.stop();
            timerDesp.Stop();
            labelDesp.Text = "00:00:00";
        }

        #endregion clicks

        #region timers

        private void timerAtual_Tick(object sender, EventArgs e)
        {
            labelAtual.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
        }

        private void timerDesp_Tick(object sender, EventArgs e)
        {
            if (labelAtual.Text.Equals(labelDesp.Text)) {
                Media.URL = music;
            }
        }

        #endregion timers

    }
}
