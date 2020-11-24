using System;

namespace Propriedades
{
    public class ContaCorrente
    {
        private Cliente titular;
        public Cliente Titular {get; set;}
        public int Agencia { get;  }
        public int Numero { get;  }

        public int TotalSaqueNaoPermitido { get; private set; }
        public int TotalTransferenciaNaoPermitida { get; private set; }

        public static int TotaldeContas { get; private set; }
        private double _saldo; 
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public ContaCorrente(int agencia , int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
            }
            Agencia = agencia;
            Numero = numero;
            TotaldeContas++;

        }
       
        public void Sacar(double valor)
        {
            if(valor <= 0)
            {
                throw new ArgumentException("O valor deve ser maior que zero.", nameof(valor));
            }

            if (_saldo < valor)
            {
                TotalSaqueNaoPermitido++;
                throw new SaldoInsuficienteException(_saldo, valor); 
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;

        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("O valora ser transferido deve ser maior que zero.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                TotalTransferenciaNaoPermitida++;
                throw new TransacaoFinanceiraException("Operacao não realizada", ex);
            }
            contaDestino.Depositar(valor);
            
        }

    }
}
