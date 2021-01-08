using Produtos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos.Repositories
{
    public interface ISetorRepository
    {
        IList<Setor> GetSetores();

        Setor AddSetor(string setor);

        Setor GetSetor(string setor);


    }
}
