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

        
        [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var funcionarios = await _service.GetAllAsync();

            return Ok(funcionarios);
        }

        
        [HttpGet("{id}")]
        public async Task<IActionResult> BuscarPorId(int id)
        {
            var funcionario = await _service.GetByIdAsync(id);

            if (funcionario == null)
                return NotFound();

            return Ok(funcionario);
        }

        
        [HttpPost]
        public async Task<IActionResult> Criar(FuncionarioInputDto dto)
        {
            var funcionario = await _service.CreateAsync(dto);

            return StatusCode(201, funcionario);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(
            int id,
            FuncionarioInputDto dto)
        {
            var funcionario = await _service.UpdateAsync(id, dto);

            if (funcionario == null)
                return NotFound();

            return Ok(funcionario);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Excluir(int id)
        {
            await _service.DeleteAsync(id);

            return NoContent();
        }
    }
}