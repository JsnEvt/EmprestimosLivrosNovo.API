﻿using EmprestimosLivros.API.Extensions;
using EmprestimosLivros.API.Models;
using EmprestimosLivrosNovo.Application.DTOs;
using EmprestimosLivrosNovo.Application.Interfaces;
using EmprestimosLivrosNovo.Infra.Ioc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmprestimosLivros.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ClienteController : Controller
    {
        private readonly IClienteService _clienteService;
        private readonly IUsuarioService _usuarioService;

        public ClienteController(IClienteService clienteService, IUsuarioService usuarioService)
        {
            _clienteService = clienteService;
            _usuarioService = usuarioService;
        }

        [HttpPost]

        public async Task<ActionResult> Incluir(ClienteDTO clienteDTO)
        {
            var clienteDTOIncluido = await _clienteService.Incluir(clienteDTO);  
            if(clienteDTOIncluido == null)
            {
                return BadRequest("Ocorreu um erro ao incluir o cliente");
            }
            return Ok("Cliente incluído com sucesso");
        }

        [HttpPut]
        public async Task<ActionResult> Alterar(ClienteDTO clienteDTO)
        {
            var clienteDTOAlterado = await _clienteService.Alterar(clienteDTO);
            if (clienteDTOAlterado == null)
            {
                return BadRequest("Ocorreu um erro ao alterar o cliente");
            }
            return Ok("Cliente alterado com sucesso");
        }

        [HttpDelete]
        public async Task<ActionResult> Excluir(int id)
        {
            //para identificacao se o usuario e um administrador:
            var userId = User.GetId(); //O User e obtido na claim da geracao do token
            var usuario = await _usuarioService.SelecionarAsync(userId);

            if (!usuario.IsAdmin)
            {
                return Unauthorized("Voce não tem permissão para excluir o cliente");
            }

            var clienteDTOExcluido = await _clienteService.Excluir(id);
            if (clienteDTOExcluido == null)
            {
                return BadRequest("Ocorreu um erro ao excluir o cliente");
            }
            return Ok("Cliente excluído com sucesso");
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Selecionar(int id)
        {
            var clienteDTO = await _clienteService.SelecionarAsync(id);
            if (clienteDTO == null)
            {
                return NotFound("Cliente não encontrado.");
            }
            return Ok(clienteDTO);
        }

        [HttpGet]
        public async Task<ActionResult> SelecionarTodos([FromQuery]PaginationParams paginationParams) 
            //FromQuery para passar os parametros baseado na consulta
            //Essas informacoes vai no header da aplicacao.
        
        {
            var clienteDTO = await _clienteService.SelecionarTodosAsync
                (paginationParams.PageNumber, paginationParams.PageSize);

            Response.AddPaginationHeader(new PaginationHeader
                (clienteDTO.CurrentPage, clienteDTO.PageSize, clienteDTO.TotalCount, clienteDTO.TotalPages));

            return Ok(clienteDTO);
        }
    }
}
