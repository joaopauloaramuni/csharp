using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace Txt
{
    class Gravar
    {
        public Gravar(string gravar)
        {
            StreamWriter sw = new StreamWriter("c:\\texto.txt");
            sw.Write(gravar);
            sw.Close();
        }
    
    }
}
