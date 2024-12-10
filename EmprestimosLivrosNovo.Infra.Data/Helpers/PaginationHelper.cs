using EmprestimosLivrosNovo.Domain.Pagination;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimosLivrosNovo.Infra.Data.Helper
{
    public static class PaginationHelper
    {
        //modelo de consulta para gerar a paginacao:
        public static async Task<PagedList<T>> CreateAsync<T>
            (IQueryable<T> source, int pageNumber, int pageSize ) where T : class 
        {
            var count = await source.CountAsync();
            var items = await source.Skip((pageNumber - 1) * pageSize).Take((pageSize)).ToListAsync();
            return new PagedList<T>(items, pageNumber, pageSize, count);
        }
    }
}
