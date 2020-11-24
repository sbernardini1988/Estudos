using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();

            // Testando Inner Exception
            //try
            //{
            //    Metodo();
            //}
            //catch (DivideByZeroException excecao)
            //{
            //    Console.WriteLine(excecao.Message);
            //    Console.WriteLine(excecao.StackTrace);
            //}
            //catch (NullReferenceException excecao)
            //{
            //    Console.WriteLine(excecao.Message);
            //    Console.WriteLine(excecao.StackTrace);
            //}


            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"))
            {
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }
        }

        static void Metodo()
            {
                TestaDivisao(0);
            }

            public static void TestaDivisao(int divisor)
            {
                Dividir(10, divisor);
            }

            public static int Dividir(int numero, int divisor)
            {
            try
            {
                return numero / divisor;
            }
            catch
            {
                throw;
            }    
            }
        }
    
}
