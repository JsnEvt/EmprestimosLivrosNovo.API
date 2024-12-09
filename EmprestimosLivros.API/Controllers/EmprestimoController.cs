using EmprestimosLivrosNovo.Application.DTOs;
using EmprestimosLivrosNovo.Application.Interfaces;
using EmprestimosLivrosNovo.Infra.Ioc;
using Microsoft.AspNetCore.Mvc;

namespace EmprestimosLivros.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmprestimoController : Controller
    {
        private readonly IEmprestimoService _emprestimoService;

        public EmprestimoController(IEmprestimoService emprestimoService)
        {
            _emprestimoService = emprestimoService;
        }

        [HttpPost]

        public async Task<ActionResult> Incluir(EmprestimoPOSTDTO emprestimoPOSTDTO)
        {
            emprestimoPOSTDTO.DataEmprestimo = DateTime.Now;
            emprestimoPOSTDTO.Entregue = false;
            var emprestimoDTOIncluido = await _emprestimoService.Incluir(emprestimoPOSTDTO);
            if (emprestimoDTOIncluido == null)
            {
                return BadRequest("Ocorreu um erro ao incluir o emprestimo");
            }
            return Ok("Emprestimo incluído com sucesso");
        }

        [HttpPut]
        public async Task<ActionResult> Alterar(EmprestimoPUTDTO emprestimoPUTDTO)
        {
            var emprestimoDTO = await _emprestimoService.SelecionarAsync(emprestimoPUTDTO.Id);
            if (emprestimoDTO == null)
            {
                return NotFound("Empréstimo não encontrado");
            }

            emprestimoDTO.DataEntrega = emprestimoPUTDTO.DataEntrega;
            emprestimoDTO.Entregue = emprestimoPUTDTO.Entregue;

            var emprestimoDTOAlterado = await _emprestimoService.Alterar(emprestimoDTO);
            if (emprestimoDTOAlterado == null)
            {
                return BadRequest("Ocorreu um erro ao alterar o emprestimo");
            }
            return Ok("Emprestimo alterado com sucesso");
        }

        [HttpDelete]
        public async Task<ActionResult> Excluir(int id)
        {
            var emprestimoDTOExcluido = await _emprestimoService.Excluir(id);
            if (emprestimoDTOExcluido == null)
            {
                return BadRequest("Ocorreu um erro ao excluir o emprestimo");
            }
            return Ok("Emprestimo excluído com sucesso");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Selecionar(int id)
        {
            var emprestimoDTO = await _emprestimoService.SelecionarAsync(id);
            if (emprestimoDTO == null)
            {
                return NotFound("Emprestimo não encontrado.");
            }
            return Ok(emprestimoDTO);
        }

        [HttpGet]
        public async Task<ActionResult> SelecionarTodos()
        {
            var emprestimoDTO = await _emprestimoService.SelecionarTodosAsync();
            return Ok(emprestimoDTO);
        }
    }
}
