using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Txt
{
    class Ler
    {
        public Ler()
        {
            StreamReader sw = new StreamReader("c:\\texto.txt");
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

        }
        public string Conteudo
        {
            get;
            set;
        }
    }
}
