using AutoMapper;
using EmprestimosLivrosNovo.Application.DTOs;
using EmprestimosLivrosNovo.Application.Interfaces;
using EmprestimosLivrosNovo.Domain.Entities;
using EmprestimosLivrosNovo.Domain.Interfaces;
using EmprestimosLivrosNovo.Domain.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimosLivrosNovo.Application.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _repository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async  Task<ClienteDTO> Alterar(ClienteDTO clienteDTO)
        {
            var cliente = _mapper.Map<Cliente>(clienteDTO);
            var clienteAlterado = await _repository.Alterar(cliente);
            return _mapper.Map<ClienteDTO>(clienteAlterado);
            
        }

        public async Task<ClienteDTO> Excluir(int id)
        {
            var clienteExcluido = await _repository.Excluir(id);
            return _mapper.Map<ClienteDTO>(clienteExcluido);
        }

        public async Task<ClienteDTO> Incluir(ClienteDTO clienteDTO)
        {
            var cliente = _mapper.Map<Cliente>(clienteDTO);
            var clienteIncluido = await _repository.Incluir(cliente);
            return _mapper.Map<ClienteDTO>(clienteIncluido);
        }

        public async Task<PagedList<ClienteDTO>> SelecionarTodosAsync(int pageNumber, int pageSize)
        {
            var clientes = await _repository.SelecionarTodosAsync(pageNumber, pageSize);
            var clientesDTO = _mapper.Map<IEnumerable<ClienteDTO>>(clientes);
            return new PagedList<ClienteDTO>(clientesDTO, pageNumber, pageSize, clientes.TotalCount);
        }

        public async Task<ClienteDTO> SelecionarAsync(int id)
        {
            var cliente = await _repository.SelecionarAsync(id);
            return _mapper.Map<ClienteDTO>(cliente);
        }
    }
}
