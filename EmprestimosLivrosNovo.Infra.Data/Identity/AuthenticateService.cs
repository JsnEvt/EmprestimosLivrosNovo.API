using EmprestimosLivrosNovo.Domain.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimosLivrosNovo.Infra.Data.Identity
{
    public class AuthenticateService : IAuthenticate
    {
        private readonly ControleEmprestimoLivroContext _context;
        private readonly IConfiguration _configuration;

<<<<<<< HEAD
        public AuthenticateService(ControleEmprestimoLivroContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

=======
>>>>>>> dcda9d8e1ddfadb10d94a93e13fc0e9791649612
        public async Task<bool> AuthenticateAsync(string email, string senha)
        {
            var usuario = await _context.Usuario.Where(x => x.Email.ToLower() == email.ToLower()).FirstOrDefaultAsync();
            if(usuario == null)
            {
                return false;
            }
            using var hmac = new HMACSHA512(usuario.PasswordSalt);
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(senha));
            for (int x = 0; x < computedHash.Length; x++)
            {
                if(computedHash[x] != usuario.PasswordHash[x]) return false;
            }
            return true;
        }

        public string GenerateToken(int id, string email)
        {
            var claims = new[]
            {
                new Claim("id", id.ToString()),
                new Claim("email", email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var privateKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["jwt:secretKey"]));
            var credentials = new SigningCredentials(privateKey, SecurityAlgorithms.HmacSha256);

            var expiration = DateTime.UtcNow.AddMinutes(10);
            
            JwtSecurityToken token = new JwtSecurityToken(
                issuer: _configuration["jwt:issuer"],
                audience: _configuration["jwt:audience"],
                claims: claims,
                expires: expiration,
                signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<bool> UserExists(string email)
        {
            var usuario = await _context.Usuario.Where(x => x.Email.ToLower() == email.ToLower()).FirstOrDefaultAsync();
            if (usuario == null)
            {
                return false;
            }
            return true;
        }
    }
}
