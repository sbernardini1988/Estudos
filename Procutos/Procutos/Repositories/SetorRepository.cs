using Produtos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos.Repositories
{
    public class SetorRepository : BaseRepository<Setor>, ISetorRepository
    {
        public SetorRepository(ProdutosContext contexto) : base(contexto)
        {
        }
        public Setor AddSetor(string setor)
        {
            var setorBase = GetSetor(setor);
            if (setorBase == null)
            {
                dbSets.Add(new Setor(setor));
                contexto.SaveChanges();
                return GetSetor(setor);
            }
            return GetSetor(setor);
        }

        public Setor GetSetor(string setor)
        {
            return dbSets.Where(s => s.Descricao.ToUpper() == setor.ToUpper()).SingleOrDefault();
        }

        public IList<Setor> GetSetores()
        {
            return dbSets.ToList();
        }
    }
}
