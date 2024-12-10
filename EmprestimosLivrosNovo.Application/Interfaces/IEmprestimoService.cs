using EmprestimosLivrosNovo.Application.DTOs;
using EmprestimosLivrosNovo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimosLivrosNovo.Application.Interfaces
{
    public interface IEmprestimoService
    {
        Task<EmprestimoDTO> Incluir(EmprestimoPOSTDTO emprestimoPOSTDTO);
        Task<EmprestimoDTO> Alterar(EmprestimoDTO emprestimoDTO);
        Task<EmprestimoDTO> Excluir(int id);
        Task<EmprestimoDTO> SelecionarAsync(int id);
        Task<IEnumerable<EmprestimoDTO>> SelecionarTodosAsync();
        Task<bool> VerificaDisponibilidadeAsync(int LivroId);
    }
}
