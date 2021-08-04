using Agenda.Domain.Contracts.Repositories;
using Agenda.Domain.Entities;
using Agenda.Infra.Context;

namespace Agenda.Infra.Repository
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
