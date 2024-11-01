using System;
using System.Windows.Forms;

namespace Gerador
{
    public partial class Form1 : Form
    {
        #region Constructor

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Events

        private void Gerar_Click(object sender, EventArgs e)
        {
            Gerar v_Gerar = new Gerar();
            
            string v_CPF = string.Empty;
            string v_CNPJ = string.Empty;
            string v_PIS = string.Empty;

            try
            {
                v_CPF = v_Gerar.gerarDados(Constantes.VALIDA_CPF, Constantes.CPF_LENGTH);
                v_CNPJ = v_Gerar.gerarDados(Constantes.VALIDA_CNPJ, Constantes.CNPJ_LENGTH);
                v_PIS = v_Gerar.gerarDados(Constantes.VALIDA_PIS, Constantes.PIS_LENGTH);

                if (validaResultados(v_CPF, v_CNPJ, v_PIS))
                {
                    tbxCPF.Text = v_CPF;
                    tbxCNPJ.Text = v_CNPJ;
                    tbxPIS.Text = v_PIS;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Methods

        private bool validaResultados(string v_CPF, string v_CNPJ, string v_PIS)
        {
            return (v_CPF != string.Empty && v_CNPJ != string.Empty && v_PIS != string.Empty);
        }

        #endregion
    }
}
