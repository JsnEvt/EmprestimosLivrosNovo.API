using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EmprestimosLivrosNovo.Application.DTOs
{
    public class EmprestimoPOSTDTO
    {
        [Required(ErrorMessage = "O cliente é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O identificador do cliente é inválido.")]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "O livro é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "O identificador do livro é inválido.")]
        public int LivroId { get; set; }
        [Required(ErrorMessage = "A data de entrega é obrigatória")]
        public DateTime DataEntrega { get; set; }

        //adicionando atributos para complementar a conversao/elementos
        //de EmprestimosPOSTDTO para EmprestimoDTO:
        //como nao e uma informacao que o usuario nao ira definir, usamos:
        [JsonIgnore]
        public DateTime? DataEmprestimo { get; set; }
        [JsonIgnore]
        public bool Entregue { get; set; }
    }
}
