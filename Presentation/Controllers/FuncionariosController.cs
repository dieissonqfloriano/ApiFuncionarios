using Application.DTOs;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/funcionarios")]
    public class FuncionariosController : ControllerBase
    {
        private readonly IFuncionarioService _service;

        public FuncionariosController(IFuncionarioService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Criar(FuncionarioInputDto dto)
        {
            var funcionario = await _service.CreateAsync(dto);

            return StatusCode(201, funcionario);
        }
    }
}
