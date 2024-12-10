using EmprestimosLivros.API.Models;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace EmprestimosLivros.API.Extensions
{
    //usara os atributos do header para preencher os metodos que geram as paginacoes:
    public static class HttpExtensions
    {
        public static void AddPaginationHeader(this HttpResponse response, PaginationHeader header)
        {
            var jsonOptions = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
            response.Headers.Add("Pagination", JsonSerializer.Serialize(header, jsonOptions));
            response.Headers.Add("Access-Control-Expose-Headers", "Pagination");
        }
    }
}
