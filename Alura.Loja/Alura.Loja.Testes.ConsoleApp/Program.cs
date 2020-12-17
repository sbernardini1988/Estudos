using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //GravarUsandoAdoNet();
            //GravarUsandoEntity();
            //RecuperarProdutos();
            //ExcluirProdutos();
            //RecuperarProdutos();
            //AtualizarProduto();

            //Console.ReadLine();

            //using (var contexto = new LojaContext())
            //{
            //    //var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
            //    //var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
            //    //loggerFactory.AddProvider(SqlLoggerProvider.Create());

            //    var produtos = contexto.Produtos.ToList();

            //    foreach (var item in produtos)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    foreach (var e in contexto.ChangeTracker.Entries())
            //    {
            //        Console.WriteLine(e.State);
            //    }

            //    var p1 = produtos.First();
            //    p1.Nome = "teste alteração 001";

            //   // contexto.SaveChanges();

            //    Console.WriteLine("============================");
            //    foreach (var item in produtos)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    foreach (var e in contexto.ChangeTracker.Entries())
            //    {
            //        Console.WriteLine(e.State);
            //    }



            //}

            var produto = new Produto();
            produto.Nome = "Pão Frances";
            produto.PrecoUnitario = 0.40;
            produto.Unidade = "Unidade";
            produto.Categoria = "Padaria";


            var compra = new Compra();
            compra.Produto = produto;
            compra.quantidade = 6;
            compra.Preco = produto.PrecoUnitario * compra.quantidade;

            using (var contexto = new LojaContext())
            {
                contexto.Compras.Add(compra);

                contexto.SaveChanges();

            }
        }

        private static void AtualizarProduto()
        {
            GravarUsandoEntity();

            RecuperarProdutos();

            using (var repo = new ProdutoDAOEntity())
            {
                Produto primeiro = repo.Produtos().First();

                primeiro.Nome = "Produto Atualizado";

                repo.Atualizar(primeiro);

                RecuperarProdutos();
            }
        }

        private static void ExcluirProdutos()
        {
            using (var repo = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = repo.Produtos();

                foreach (var item in produtos)
                {
                    repo.Remover(item);
                }
            }
        }

        private static void RecuperarProdutos()
        {
            using (var repo = new ProdutoDAOEntity())
            {
                IList<Produto> produtos = repo.Produtos();
                Console.WriteLine($"Foram encontrados {produtos.Count} produtos.");
                foreach (var item in produtos)
                {
                    Console.WriteLine($"produto = {item.Nome}");
                }
            }
        }

        //private static void GravarUsandoAdoNet()
        //{
        //    Produto p = new Produto();
        //    p.Nome = "Harry Potter e a Ordem da Fênix";
        //    p.Categoria = "Livros";
        //    p.PrecoUnitario = 19.89;

        //    using (var repo = new ProdutoDAO())
        //    {
        //        repo.Adicionar(p);
        //    }
        //}
        private static void GravarUsandoEntity()
        {
            Produto p = new Produto();
            p.Nome = "Harry Potter e a Ordem da Fênix";
            p.Categoria = "Livros";
            p.PrecoUnitario = 19.89;

            using (var contexto = new ProdutoDAOEntity())
            {
                contexto.Adicionar(p);
            }
        }
    }
}
