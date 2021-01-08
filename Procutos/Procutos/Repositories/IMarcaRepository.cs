using Produtos.Models;
using System.Collections.Generic;

namespace Produtos.Repositories
{
    public interface IMarcaRepository
    {
        Marca AddMarca(string descricao);

        IList<Marca> GetMarcas();

        Marca GetMarca(string descricao);
    }
}
