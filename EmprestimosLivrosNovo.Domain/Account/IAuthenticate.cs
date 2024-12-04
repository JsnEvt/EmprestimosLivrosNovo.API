using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimosLivrosNovo.Domain.Account
{
    public interface IAuthenticate
    {
        Task<bool> AuthenticateAsync(string email, string senha);
        Task<bool> UserExists(string email);
        public string GenerateToken(int id, string email);
    }
}
