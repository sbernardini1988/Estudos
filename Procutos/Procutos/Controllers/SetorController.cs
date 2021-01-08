using Microsoft.AspNetCore.Mvc;
using Produtos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Produtos.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class SetorController : ControllerBase
    {
        private readonly ISetorRepository _repo;

        public SetorController(ISetorRepository repo)
        {
            _repo = repo;
        }

        public IActionResult GetSetores()
        {
            var setor = _repo.GetSetores().ToList();
            return Ok(setor);
        }
    }
}
