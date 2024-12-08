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
    public class LivroRepository : ILivroRepository
    {
        private readonly ControleEmprestimoLivroContext _context;

        public LivroRepository(ControleEmprestimoLivroContext context)
        {
            _context = context;
        }

        public async Task<Livro> Alterar(Livro livro)
        {
            _context.Livro.Update(livro);
            await _context.SaveChangesAsync();
            return livro;
        }


        public async Task<Livro> Excluir(int id)
        {
            var livro = await _context.Livro.FindAsync(id);
            if (livro != null)
            {
                //livro.Excluir();
                _context.Livro.Update(livro);
                await _context.SaveChangesAsync();
                return livro;
            }

            return null;
        }

        public async Task<Livro> Incluir(Livro livro)
        {
            _context.Livro.Add(livro);
            await _context.SaveChangesAsync();
            return livro;
        }

        public async Task<Livro> SelecionarAsync(int id)
        {
            return await _context.Livro.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Livro>> SelecionarTodosAsync()
        {
            return await _context.Livro.ToListAsync();
        }
    }
}
