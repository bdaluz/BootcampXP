using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSmartphone.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Obtendo informações do aplicativo {nomeApp} na AppStore...");
            Console.WriteLine($"Instalando aplicativo {nomeApp} v16.5.1");
            Console.WriteLine($"{nomeApp} Instalado com sucesso.");
        }
    }
}