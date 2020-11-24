using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propriedades
{
    class TransacaoFinanceiraException : Exception
    {
        public TransacaoFinanceiraException()
        {

        }

        public TransacaoFinanceiraException(string mensagem) : base(mensagem)
        {

        }

        public TransacaoFinanceiraException(string mensagem , Exception excecaoInterna) : base(mensagem, excecaoInterna)
        {

        }
    }
}
