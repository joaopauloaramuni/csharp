using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HD obj = new HD();

            totalResp.Text = obj.HDCapacidade();
            usadoResp.Text = obj.HDEspacoOcupado();
            livreResp.Text = obj.HDEspacoLivre();
            serialResp.Text = obj.HDSerial();
        }
    }
}
