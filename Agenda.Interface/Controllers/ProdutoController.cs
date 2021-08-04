using Agenda.Common.Dto;
using Agenda.Domain.Contracts.ApplicationService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Agenda.Interface.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoApplicationService _produtoAppService;

        public ProdutoController(IProdutoApplicationService produtoAppService)
        {
            _produtoAppService = produtoAppService;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Adicionar(ProdutoDto dto)
        {
            var response = await _produtoAppService.CriarProduto(dto);
            return Created("api/clientes", response);
        }
    }
}