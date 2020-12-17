using Alura.ListaLeitura.App.View;
using Alura.ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Alura.ListaLeitura.App.Model;

namespace Alura.ListaLeitura.App.Controllers
{
    public class LivrosController : Controller
    {
        public IEnumerable<Livro> Livros { get; set; }
        public string Detalhes(int id)
        {
            var repo = new LivroRepositorioCSV();
            var livro = repo.Todos.First(l => l.Id == id);
            return livro.Detalhes();
        }
        public IActionResult ParaLer()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.ParaLer.Livros;
            return View("lista");

        }

        public IActionResult Lendo()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lendo.Livros;
            return View("lista");
        }

        public IActionResult Lidos()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lidos.Livros;
            return View("lista");
        }

        public string Teste()
        {
            return "teste frameWork mvc!";
        }
     }
}

//public static Task Lidos(HttpContext context)
//{
//    var _repo = new LivroRepositorioCSV();
//    var conteudoArquivo = HtmlUtils.CarregaArquivoHTML("Lidos");

//    foreach (var item in _repo.Lidos.Livros)
//    {
//        conteudoArquivo = conteudoArquivo.Replace("#NOVOITEM#", $"<li>{item.Titulo} - {item.Autor}</li>#NOVOITEM#");
//    }

//    conteudoArquivo = conteudoArquivo.Replace("#NOVOITEM#", "");

//    return context.Response.WriteAsync(conteudoArquivo);
//}