using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(double saldo , double valorSaque)
            : this("O valor do saque " + valorSaque + " é menor que o saldo " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque; 
        }

        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }
    }
}
