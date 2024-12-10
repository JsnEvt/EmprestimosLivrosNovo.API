﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimosLivrosNovo.Domain.Pagination
{
    public class PagedList<T> : List<T>
    {
        public int CurrentPage {  get; set; }
        public int TotalPages { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }

        public PagedList(IEnumerable<T> items, int pageNumber, int pageSize, int count)
        {
            CurrentPage = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            PageSize = pageSize;
            TotalCount = count;
            AddRange(items);
        }

        //este construtor retorna DIRETAMENTE os dados que ja temos retornado em alguns metodos.
        //este construtor nao fara os calculos como feito acima, na linha 19:
        public PagedList(IEnumerable<T> items, int currentPage, int totalPages, int pageSize, int totalCount) 
        {
            CurrentPage = currentPage;
            TotalPages = totalPages;
            PageSize = pageSize;
            TotalCount = totalCount;
            AddRange(items);
        }
    }
}
