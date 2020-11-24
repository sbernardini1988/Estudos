using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
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

            try
            {
                ContaCorrente conta = new ContaCorrente(987, 332485);
                conta.Titular = new Cliente();

                //
                conta.Titular.Nome = "Gabriela";
                conta.Titular.CPF = "234.543.567.99";
                conta.Titular.Profissao = "Desenvolvedora C#";

                conta.Saldo = 500;

                //conta.Sacar(-10);
                ContaCorrente conta2 = new ContaCorrente(987, 998765);

                conta.Transferir(10000, conta2);

                //Console.WriteLine(gabriela.nome);
                Console.WriteLine(conta.Agencia);
                Console.WriteLine(conta.Numero);
                Console.WriteLine(conta.Titular.Nome);
                Console.WriteLine("O saldo é: " + conta.Saldo);
                Console.WriteLine("total de contas: " + ContaCorrente.TotaldeContas);

                conta.Titular.Nome = "Gabriela Consta";

                //Console.WriteLine(gabriela.nome);
                Console.WriteLine(conta.Titular.Nome);

            }
            catch(TransacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("argumentException:" + ex);
            }

            // instanciando no momento da atribuição. Como titular refere-se a classe Cliente, se não instanciar vai dar objeto nao referenciado.
            

            Console.ReadLine();

        }
    }
}
