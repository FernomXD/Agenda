using Agenda.Common.Dto;
using Agenda.Domain.Entities;
using System.Threading.Tasks;

namespace Agenda.Domain.Contracts.ApplicationService
{
    public interface IProdutoApplicationService
    {
        Task<Produto> CriarProduto(ProdutoDto nome);
    }
}
