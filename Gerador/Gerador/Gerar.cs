using System;
using System.Windows.Forms;

namespace Gerador
{
    class Gerar
    {
        #region Members

        string num = string.Empty;
        Random rnd = new Random();

        #endregion

        #region Methods
       
        public string gerarDados(int p_control, int p_length)
        {
            num = string.Empty;
            do
            {
                num += rnd.Next().ToString();
                if (num.Length > p_length)
                    num = num.Substring(0, p_length);
            } while (num.Length != p_length);
            
            switch (p_control)
            {
                case Constantes.VALIDA_CPF:
                    try
                    {
                        ValidarCPF v_validaCPF = new ValidarCPF();
                        if (v_validaCPF.validarCPF(num)) return num;
                        else return gerarDados(p_control, p_length);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                case Constantes.VALIDA_CNPJ:
                    try
                    {
                        ValidarCNPJ v_validaCNPJ = new ValidarCNPJ();
                        if (v_validaCNPJ.validarCNPJ(num)) return num;
                        else return gerarDados(p_control, p_length);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    break;

                case Constantes.VALIDA_PIS:
                    try
                    {
                        ValidarPIS v_validaPIS = new ValidarPIS();
                        if (v_validaPIS.validarPIS(num)) return num;
                        else return gerarDados(p_control, p_length);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;

                default: break;
            }
            return string.Empty;
        }
        #endregion
    }
}
