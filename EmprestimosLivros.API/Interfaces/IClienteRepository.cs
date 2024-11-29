using EmprestimosLivros.API.Models;

namespace EmprestimosLivros.API.Interfaces
{
    public interface IClienteRepository
    {
        void Incluir(Cliente cliente);
        void Alterar(Cliente cliente);
        void Excluir(int id);
        Task<Cliente> SelecionarPorId(int id);
        Task<IEnumerable<Cliente>> SelectionarTodos();
    }
}
