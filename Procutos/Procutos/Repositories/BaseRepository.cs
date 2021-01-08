using Microsoft.EntityFrameworkCore;
using Produtos.Models;

namespace Produtos.Repositories
{
    public class BaseRepository<T> where T : BaseModel
    {
        protected readonly ProdutosContext contexto;
        protected readonly DbSet<T> dbSets;

        public BaseRepository(ProdutosContext contexto)
        {
            this.contexto = contexto;
            dbSets = contexto.Set<T>();
        }

    }
}
