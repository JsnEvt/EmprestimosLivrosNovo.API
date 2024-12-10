using EmprestimosLivrosNovo.Domain.Entities;
using EmprestimosLivrosNovo.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimosLivrosNovo.Infra.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    { 
        private readonly ControleEmprestimoLivroContext _context;

    public UsuarioRepository(ControleEmprestimoLivroContext context)
    {
        _context = context;
    }

    public async Task<Usuario> Alterar(Usuario usuario)
    {
        _context.Usuario.Update(usuario);
        await _context.SaveChangesAsync();
        return usuario;
    }


    public async Task<Usuario> Excluir(int id)
    {
        var usuario = await _context.Usuario.FindAsync(id);
        if (usuario != null)
        {
            //Usuario.Excluir();
            _context.Usuario.Update(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }

        return null;
    }

        public async Task<bool> ExisteUsuarioCadastradoAsync()
        {
            return await _context.Usuario.AnyAsync();
        }

        public async Task<Usuario> Incluir(Usuario usuario)
    {
        _context.Usuario.Add(usuario);
        await _context.SaveChangesAsync();
        return usuario;
    }

    public async Task<Usuario> SelecionarAsync(int id)
    {
        return await _context.Usuario.Where(x => x.Id == id).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<Usuario>> SelecionarTodosAsync()
    {
        return await _context.Usuario.ToListAsync();
    }
}
}
