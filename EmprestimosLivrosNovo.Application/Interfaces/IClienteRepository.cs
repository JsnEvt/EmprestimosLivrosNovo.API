using EmprestimosLivrosNovo.Domain.Entities;

namespace EmprestimosLivros.API.Interfaces
{
    public interface IClienteRepository
    {
        void Incluir(Cliente cliente);
        void Alterar(Cliente cliente);
        void Excluir(Cliente cliente);
        Task<Cliente> SelecionarPorId(int id);
        Task<IEnumerable<Cliente>> SelectionarTodos();
        Task<bool> SaveAllAsync();
    }
}
