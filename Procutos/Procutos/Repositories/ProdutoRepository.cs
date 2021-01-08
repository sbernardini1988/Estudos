using Microsoft.EntityFrameworkCore;
using Produtos.Models;
using Produtos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        private readonly ICategoriaRepository _categoria;
        private readonly IMarcaRepository _marca;
        public ProdutoRepository(ProdutosContext contexto, ICategoriaRepository categoria,
            IMarcaRepository marca) : base(contexto)
        {
            _categoria = categoria;
            _marca = marca;
        }

        public IList<Produto> GetProdutos()
        {
            return dbSets.Include(p => p.Categoria).ThenInclude(s => s.Setor).Include(m => m.Marca).ToList();
        }

        public void AddProdutos(List<Produto> produtos)
        {
            foreach (var item in produtos)
            {
                if (!dbSets.Where(p => p.Codigo == item.Codigo).Any())
                {
                    var categoria = _categoria.GetCategoria(item.Categoria.Descricao);

                    var marcaBase = _marca.GetMarca(item.Marca.Descricao);
                    if (marcaBase == null)
                    {
                        marcaBase = _marca.AddMarca(item.Marca.Descricao);
                    }

                    if (categoria.Descricao == null)
                    {
                       var categoriaBase = _categoria.AddCategoria(item.Categoria.Descricao, item.Categoria.Setor.Descricao);
                        
                       dbSets.Add(new Produto(item.Codigo, item.Nome, categoriaBase, marcaBase, item.PrecoUnitario, item.Unidade ));
                       contexto.SaveChanges();
                    }
                    dbSets.Add(new Produto(item.Codigo, item.Nome, item.Categoria, marcaBase, item.PrecoUnitario, item.Unidade));
                    contexto.SaveChanges();
                }
            }
        }

        public Produto AddProduto(Produto produto)
        {
            var produtoBase = GetProduto(produto.Codigo);
            if (produtoBase == null)
            {
                var categoria = _categoria.GetCategoria(produto.Categoria.Descricao);

                if (categoria.Descricao == null)
                {
                    var categoriaBase = _categoria.AddCategoria(produto.Categoria.Descricao, produto.Categoria.Setor.Descricao);
                    dbSets.Add(new Produto(produto.Codigo, produto.Nome, categoriaBase, produto.Marca, produto.PrecoUnitario, produto.Unidade));
                    contexto.SaveChanges();
                    return GetProduto(produto.Codigo);
                }
                dbSets.Add(new Produto(produto.Codigo, produto.Nome, produto.Categoria, produto.Marca, produto.PrecoUnitario, produto.Unidade));
                contexto.SaveChanges();
                return GetProduto(produto.Codigo);
            }
            return produtoBase;
        }
        public Produto GetProduto(long codigo)
        {
            return dbSets.Where(p => p.Codigo == codigo).SingleOrDefault();
        }
    }
    
}
