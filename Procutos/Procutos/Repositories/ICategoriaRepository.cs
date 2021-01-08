using Produtos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos.Repositories
{
    public interface ICategoriaRepository
    {
        Categoria AddCategoria(string categoria, string setor);

        IList<Categoria> GetCategorias();

        Categoria GetCategoria(string descricao);


    }
}
