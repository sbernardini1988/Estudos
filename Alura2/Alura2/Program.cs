using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela =  new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;

            Console.WriteLine("Nome: " + contaDaGabriela.titular);
            Console.WriteLine("Agencia: " + contaDaGabriela.agencia);
            Console.WriteLine("Conta: " + contaDaGabriela.numero);
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);
            //saque

            Console.WriteLine("Saldo antes saque: " + contaDaGabriela.saldo);
            bool resultadoSaque = contaDaGabriela.Sacar(100);
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);
            Console.WriteLine("Saque: " + resultadoSaque);

            ContaCorrente contaBruno = new ContaCorrente();

            contaBruno.titular = "Bruno";
            Console.WriteLine("Saldo Bruno: " + contaBruno.saldo);

            bool tranferencia = contaDaGabriela.Transferir(100, contaBruno);
            Console.WriteLine("Saldo Bruno: " + contaBruno.saldo);
            Console.WriteLine("Saldo Gabriela: " + contaDaGabriela.saldo);



            Console.ReadLine();
        }
    }
}
