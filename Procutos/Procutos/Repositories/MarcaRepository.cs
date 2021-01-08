using Produtos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos.Repositories
{
    public class MarcaRepository : BaseRepository<Marca>, IMarcaRepository
    {
        public MarcaRepository(ProdutosContext contexto) : base(contexto)
        {

        }
        public Marca AddMarca(string descricao)
        {
            var marcaBase = GetMarca(descricao);

            if (marcaBase == null)
            {
                dbSets.Add(new Marca(descricao));
                contexto.SaveChanges();
                return GetMarca(descricao);
            }
            return marcaBase;

        }

        public Marca GetMarca(string descricao)
        {
            return dbSets.Where(m => m.Descricao.ToUpper() == descricao.ToUpper()).SingleOrDefault();
        }

        public IList<Marca> GetMarcas()
        {
            return dbSets.ToList();
        }
    }
}
