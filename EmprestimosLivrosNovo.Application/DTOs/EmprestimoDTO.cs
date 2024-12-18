﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimosLivrosNovo.Application.DTOs
{
    public class EmprestimoDTO
    {
        public int Id { get; set; }
        public int? LivroId { get; set; }

        public int? ClienteId { get; set; }

        public DateTime? DataEmprestimo { get; set; }

        public DateTime? DataEntrega { get; set; }

        public bool? Entregue { get; set; }
        //para retornar informacoes adicionais dos clientes/livros:
        public ClienteDTO ClienteDTO { get; set; }
        public LivroDTO LivroDTO { get; set; }
    }
}
