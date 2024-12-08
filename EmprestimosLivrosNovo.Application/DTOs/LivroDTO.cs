using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimosLivrosNovo.Application.DTOs
{
    public class LivroDTO
    {
        public int Id { get; set; }
        [MaxLength(50, ErrorMessage ="O nome do livro deve ter até 50 caracteres.")]
        [Required(ErrorMessage ="O campo nome é obrigatório.")]
        public string Nome { get; set; }
        [MaxLength(50, ErrorMessage = "O nome do autor deve ter até 200 caracteres.")]
        [Required(ErrorMessage = "O campo autor é obrigatório.")]
        public string Autor { get; set; }
        [MaxLength(200, ErrorMessage = "O nome do editora deve ter até 50 caracteres.")]
        [Required(ErrorMessage = "O campo editora é obrigatório.")]
        public string Editora { get; set; }
        [Required(ErrorMessage = "O ano de publicãção é obrigatório.")]
        public DateTime AnoPublicacao { get; set; }
        [MaxLength(50, ErrorMessage = "O edição deve ter até 50 caracteres.")]
        [Required(ErrorMessage = "O campo edição é obrigatório.")]
        public string Edicao { get; set; }
    }
}
