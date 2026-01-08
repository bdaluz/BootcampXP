using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSmartphone.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Obtendo informações do aplicativo {nomeApp} na PlayStore...");
            Console.WriteLine($"Instalando aplicativo {nomeApp} v18.1");
            Console.WriteLine($"{nomeApp} Instalado com sucesso.");
        }
    }
}
