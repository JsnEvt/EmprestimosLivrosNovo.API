﻿using EmprestimosLivrosNovo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimosLivrosNovo.Domain.Interfaces
{
    public interface IEmprestimoRepository
    {
        Task<Emprestimo> Incluir(Emprestimo emprestimo);
        Task<Emprestimo> Alterar(Emprestimo emprestimo);
        Task<Emprestimo> Excluir(int id);
        Task<Emprestimo> SelecionarAsync(int id);
        Task<IEnumerable<Emprestimo>> SelecionarTodosAsync();
        Task<bool> VerificaDisponibilidade(int LivroId);
    }
}
