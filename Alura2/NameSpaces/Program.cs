using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciando cliente primeiro.
            //Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.cpf = "234.543.567.99";
            //gabriela.profissao = "Desenvolvedora C#";

            ContaCorrente conta = new ContaCorrente();

            // instanciando no momento da atribuição. Como titular refere-se a classe Cliente, se não instanciar vai dar objeto nao referenciado.
            conta.titular = new Cliente();

            //
            conta.titular.nome = "Gabriela";
            conta.titular.cpf = "234.543.567.99";
            conta.titular.profissao = "Desenvolvedora C#";

            conta.agencia = 987;
            conta.numero = 9874456;
            conta.DefinirSaldo(500);

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine("O saldo é: " + conta.ObterSaldo());

            conta.titular.nome = "Gabriela Consta";

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);


            Console.ReadLine();

        }
    }
}
