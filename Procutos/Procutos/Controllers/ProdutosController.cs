using Microsoft.AspNetCore.Mvc;
using Produtos.Models;
using Produtos.Repositories;
using Produtos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoRepository _repo;

        public ProdutosController(IProdutoRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult ListProdutos()
        {
            var lista = _repo.GetProdutos().ToList();
            return Ok(lista);
        }
    }
}
