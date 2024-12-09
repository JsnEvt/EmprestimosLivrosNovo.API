using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmprestimosLivrosNovo.Application.DTOs
{
    public class ClienteDTO
    {
        public int ClienteId { get; set; }

        [Required]
        [StringLength(14)]
        [Unicode(false)]
        [MinLength(14)]
        public string Cpf { get; set; }

        [Required]

        [StringLength(100)]
        [Unicode(false)]
        public string Nome { get; set; }

        [Required]

        [StringLength(50)]
        [Unicode(false)]
        public string Endereco { get; set; }

        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Cidade { get; set; }

        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string Bairro { get; set; }

        [Required]
        [StringLength(3)]
        public string Numero { get; set; }

        [StringLength(14)]
        public string TelefoneCelular { get; set; }

        [StringLength(14)]
        public string TelefoneFixo { get; set; }
    }
}
