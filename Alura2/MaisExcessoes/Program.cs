using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaisExcessoes
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();

            Console.ReadLine();

            private static void CarregarContas()
            {
                LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");

                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();

                leitor.Fechar();
            }

        }
    }
}
