using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimosLivrosNovo.Infra.Ioc
{
    public static class ClaimsPrincipalExtension
    {
        public static int GetId(this ClaimsPrincipal user)
        {
            return int.Parse(user.FindFirst("id").Value);
        }

        public static string GetEmail(this ClaimsPrincipal email)
        {
            return email.FindFirst("email").Value;
        }
    }
}
