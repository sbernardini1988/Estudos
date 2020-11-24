using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApendendoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000;

            double fatorRendimento = 1.0036;

            Console.WriteLine("Rendimento mensal..."); 

            for(int contador = 1; contador <= 12; contador++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine($"O valor investido no {contador} mes é de: R$" + valorInvestido);

            }

            Console.WriteLine("RendimentoAnual..."); 

            for(int contadorAno = 1; contadorAno <=5; contadorAno++)
            {
                for (int contador = 1; contador <= 12; contador++)
                {
                    valorInvestido *= fatorRendimento;
                    
                }
                fatorRendimento += 0.0010; 
            }

            Console.WriteLine("Ao termino do investimento de 5 anos você terá: R$" + valorInvestido); 

            Console.ReadLine();
        }

    }
}
