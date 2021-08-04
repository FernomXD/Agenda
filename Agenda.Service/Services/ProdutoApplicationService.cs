using Agenda.Common.Dto;
using Agenda.Domain.Contracts.ApplicationService;
using Agenda.Domain.Contracts.Repositories;
using Agenda.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Service.Services
{
    public class ProdutoApplicationService : IProdutoApplicationService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoApplicationService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<Produto> CriarProduto(ProdutoDto dto)
        {
            var produto = new Produto { Nome = dto.Nome};
            await _produtoRepository.Add(produto);

            return produto;
        }
    }
}
