using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace HD
{
    class HD
    {
        ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"c:\"");
       
        public string HDEspacoLivre()
        {
            disk.Get();
            double livre = Convert.ToDouble(disk["FreeSpace"]);
            livre = livre / 1024 / 1024 / 1024;
            string resposta = "Espaço Livre = " + (int)livre + " GB";

            return resposta;
        }

        public string HDEspacoOcupado()
        {
            disk.Get();
            double total = Convert.ToDouble(disk["Size"]);
            total = total / 1024 / 1024 / 1024;
            double livre = Convert.ToDouble(disk["FreeSpace"]);
            livre = livre / 1024 / 1024 / 1024;
            string resposta = "Espaço Usado = " + (int)(total - livre) + " GB";

            return resposta;
        }

        public string HDSerial()
        {
            disk.Get();
            string serial = disk["VolumeSerialNumber"].ToString();
            string resposta = "Serial = " + serial;

            return resposta;
        }

        public string HDCapacidade()
        {
            disk.Get();
            double tam = Convert.ToDouble(disk["Size"]);
            tam = tam / 1024 / 1024 / 1024;
            string resposta = "Espaço Total = " + (int)tam + " GB";

            return resposta;
        }
    }
}
