using EmprestimosLivrosNovo.Domain.Entities;
using EmprestimosLivrosNovo.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EmprestimosLivrosNovo.Infra.Data
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ControleEmprestimoLivroContext _context;

        public ClienteRepository(ControleEmprestimoLivroContext context)
        {
            _context = context;
        }

        public async Task<Cliente> Alterar(Cliente cliente)
        {
            _context.Cliente.Update(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }


        public async Task<Cliente> Excluir(int id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente != null)
            {
                //cliente.Excluir();
                _context.Cliente.Update(cliente);
                await _context.SaveChangesAsync();
                return cliente;
            }

            return null;
        }

        public async Task<Cliente> Incluir(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task<Cliente> SelecionarAsync(int id)
        {
            return await _context.Cliente.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Cliente>> SelecionarTodosAsync()
        {
            return await _context.Cliente.ToListAsync();
        }
    }
}