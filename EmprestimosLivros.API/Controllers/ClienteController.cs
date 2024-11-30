using EmprestimosLivros.API.Interfaces;
using EmprestimosLivros.API.Models;
using EmprestimosLivros.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EmprestimosLivros.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        public readonly IClienteRepository _clienteRepository;

        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            return Ok(await _clienteRepository.SelectionarTodos());
        }

        [HttpPost]
        public async Task<ActionResult> CadastrarCliente(Cliente cliente)
        {
            _clienteRepository.Incluir(cliente);
            if (await _clienteRepository.SaveAllAsync())
            {
                return Ok("Cliente cadastrado com sucesso!");
            }
            return BadRequest("Ocorreu um erro ao salvar o cliente.");
        }

        [HttpPut]
        public async Task<ActionResult> AlterarCliente(Cliente cliente)
        {
            _clienteRepository.Alterar(cliente);
            if (await _clienteRepository.SaveAllAsync())
            {
                return Ok("Cliente alterado com sucesso!");
            }
            return BadRequest("Ocorreu um erro ao alterar o cliente.");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> ExcluirCliente(int id)
        {
            var cliente = await _clienteRepository.SelecionarPorId(id);

            if (cliente == null)
            {
                return NotFound("Cliente não encontrado.");
            }

            _clienteRepository.Excluir(cliente);

            if (await _clienteRepository.SaveAllAsync())
            {
                return Ok("Cliente excluído com sucesso");
            }
            return BadRequest("Ocorreu um erro ao excluir o cliente");
        }
        [HttpGet("{id}")]
        public async Task<ActionResult>SelecionarCliente(int id)
        {
            var cliente = await _clienteRepository.SelecionarPorId(id);
            if(cliente == null)
            {
                return NotFound("Cliente não encontrado");
            }
            return Ok(cliente);
        }
    }
}
