using EVO.InputModels;
using EVO.Repositories;
using Microsoft.AspNetCore.Mvc;
using Projeto_EVO.Data;
using Projeto_EVO.Moddels;

namespace EVO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        private readonly DepartamentoRepository _repository;

        public DepartamentoController()
        {
            var context = new EmpresaContext();
            _repository = new DepartamentoRepository(context);
        }

        [HttpPost("Adicionar")]
        public async Task<IActionResult> Adicionar(DepartamentoInputModel departamento)
        {
            var model = new Departamento();
            model.Name = departamento.Name;
            model.Sigla = departamento.Sigla;
            await _repository.AdicionarAsync(model);
            return Ok();
        }

        [HttpGet("Todos")]
        public async Task<IEnumerable<Departamento>> ObterTodos()
        {
            return await _repository.ObterTodosAsync();
        }

        [HttpPut("Atualizar/{id}")]
        public async Task<IActionResult> Atualizar(DepartamentoInputModel departamento, int id)
        {
            var model = new Departamento();
            model.Id = id;
            model.Name = departamento.Name;
            model.Sigla = departamento.Sigla;
            await _repository.AtualizarAsync(model);
            return Ok();
        }

        [HttpGet("Encontrar/{id}")]
        public IActionResult ObterPorId(int id)
        {
            var departamento = _repository.ObterPorId(id);

            if (departamento == null)
            {
                return NotFound();
            }

            return Ok(departamento);
        }

        [HttpDelete("Excluir/{id}")]
        public async Task<IActionResult> Excluir(int id)
        {
            await _repository.ExcluirAsync(id);
            return Ok();
        }
    }
}
