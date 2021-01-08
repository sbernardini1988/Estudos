using Produtos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos.Repositorio
{
    public interface IProdutoRepository
    {
        void AddProdutos(List<Produto> produtos);

        Produto AddProduto(Produto produto);

        Produto GetProduto(long codigo);

        IList<Produto> GetProdutos();
    }
}
