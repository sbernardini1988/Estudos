using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            double valorInvestido = 1000;

            int contador = 1;

            while (contador <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine($"O valor investido no {contador} mes é de: R$" + valorInvestido);
                //contador = contador + 1; 
                //contador += 1;
                contador++;
            }

            Console.ReadLine();
        }
    }
}
