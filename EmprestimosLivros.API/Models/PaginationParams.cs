using System.ComponentModel.DataAnnotations;

namespace EmprestimosLivros.API.Models
{
    public class PaginationParams
    {
        [Range(1, int.MaxValue)]
        public int PageNumber { get; set; }
        [Range(1, 25, ErrorMessage ="O máximo de itens por página é 25.")]
        public int PageSize { get; set; }
    }
}
