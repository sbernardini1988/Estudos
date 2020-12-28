using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static CasaDoCodigo.DataService;

namespace CasaDoCodigo.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto> , IProdutoRepository
    {
        public ProdutoRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public IList<Produto> GetProdutos()
        {
           return dbSets.ToList();
        }

        public void SaveProdutos(List<Livros> livros)
        {
            foreach (var item in livros)
            {
                if(!dbSets.Where(p => p.Codigo == item.Codigo).Any())
                {
                    
                    dbSets.Add(new Produto(item.Codigo, item.Nome, item.Preco));
                }
                
            }
            contexto.SaveChanges();
        }
    }
    public class Livros
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

    }
}
