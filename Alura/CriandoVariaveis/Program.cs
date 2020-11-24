using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando variáveis");

            int idade;
            idade = 32;
            Console.WriteLine($"Minha idade é: {idade}");

            double salario = 11.500;

            int salarioEmInteiro;

            salarioEmInteiro = (int)salario;

            Console.WriteLine("O salario é: " + salarioEmInteiro);

            char ascii = (char)62;
            Console.WriteLine($"conforme a ascii table o valor é: {ascii}");

            
            string cursos = "- c#" +
                "- java" +
                "- python";
            Console.WriteLine("lista de string com + exibem na msm linha. Ex: " );
            Console.WriteLine(cursos);

            string cursos2 =
 @" - c#
 - java
 - python";
            Console.WriteLine("lista de string com @ exibem quebra de linha. Ex: " );
            Console.WriteLine(cursos2);


            Console.WriteLine("finalizado. Tecle enter para sair.");
            Console.ReadLine();
        }
    }
}
