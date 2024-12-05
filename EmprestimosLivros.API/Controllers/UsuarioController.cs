using EmprestimosLivros.API.Models;
using EmprestimosLivrosNovo.Application.DTOs;
using EmprestimosLivrosNovo.Application.Interfaces;
using EmprestimosLivrosNovo.Domain.Account;

using Microsoft.AspNetCore.Mvc;

namespace EmprestimosLivros.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IAuthenticate _authenticateService;
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IAuthenticate authenticateService, IUsuarioService usuarioService)
        {
            _authenticateService = authenticateService;
            _usuarioService = usuarioService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserToken>> Incluir(UsuarioDTO usuarioDTO)
        {
            if (usuarioDTO == null)
            {
                return BadRequest("Dados inválidos");
            }
            var emailExiste = await _authenticateService.UserExists(usuarioDTO.Email);

            if (emailExiste)
            {
                return BadRequest("Este e-mail já possui cadastro.");
            }

            var usuario = await _usuarioService.Incluir(usuarioDTO);
            if (usuario == null)
            {
                return BadRequest("Ocorreu um erro ao cadastrar.");
            }

            var token = _authenticateService.GenerateToken(usuario.Id, usuario.Email);
            return new UserToken
            {
                Token = token,
            };
        }
    }
}
//        [HttpPost("register")]
//        public async Task<ActionResult<UserToken>> Incluir(UsuarioDTO usuarioDTO)
//        {
//            return View();
//        }
//    }
//}
