using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void agendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agendaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agendaDataSet.Agenda' table. You can move, or remove it, as needed.
            this.agendaTableAdapter.Fill(this.agendaDataSet.Agenda);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Criado por JP Aramuni.");
        }
    }
}
