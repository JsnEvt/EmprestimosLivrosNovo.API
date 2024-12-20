﻿using EmprestimosLivrosNovo.Application.DTOs;
using EmprestimosLivrosNovo.Domain.Entities;
using EmprestimosLivrosNovo.Domain.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimosLivrosNovo.Application.Interfaces
{
    public interface IClienteService
    {
        Task<ClienteDTO> Incluir(ClienteDTO clienteDTO);
        Task<ClienteDTO> Alterar(ClienteDTO clienteDTO);
        Task<ClienteDTO> Excluir(int id);
        Task<ClienteDTO> SelecionarAsync(int id);
        Task<PagedList<ClienteDTO>> SelecionarTodosAsync(int pageNumber, int pageSize);
    }
}
