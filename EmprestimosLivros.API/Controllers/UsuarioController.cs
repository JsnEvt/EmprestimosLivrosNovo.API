using EmprestimosLivros.API.Models;
using EmprestimosLivrosNovo.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace EmprestimosLivros.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        [HttpPost("register")]
        public async Task<ActionResult<UserToken>> Incluir(UsuarioDTO usuarioDTO)
        {
            return View();
        }
    }
}
