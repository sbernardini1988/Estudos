using Produtos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos.Repositories
{
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        private readonly ISetorRepository _setor;
        public CategoriaRepository(ProdutosContext contexto, ISetorRepository setor) : base(contexto)
        {
            _setor = setor;
        }

        public Categoria AddCategoria(string categoria, string setor)
        {
            var categoriaBase = GetCategoria(categoria);
            
            if (categoriaBase == null)
            {
                _setor.AddSetor(setor);
                var setorBase = _setor.GetSetor(setor);
                dbSets.Add(new Categoria(categoria, setorBase));
                contexto.SaveChanges();
                return GetCategoria(categoria);
            }
            return GetCategoria(categoria);
              
        }

        public Categoria GetCategoria(string descricao)
        {
            return dbSets.Where(c => c.Descricao.ToUpper() == descricao.ToUpper()).SingleOrDefault();
        }

        public IList<Categoria> GetCategorias()
        {
            return dbSets.ToList();
        }

        
    }


 }

