﻿using EmprestimosLivrosNovo.Domain.Entities;
using EmprestimosLivrosNovo.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmprestimosLivrosNovo.Infra.Data.Repositories
{
    public class EmprestimoRepository : IEmprestimoRepository
    {
        private readonly ControleEmprestimoLivroContext _context;

        public EmprestimoRepository(ControleEmprestimoLivroContext context)
        {
            _context = context;
        }

        public async Task<Emprestimo> Alterar(Emprestimo emprestimo)
        {
            _context.Emprestimo.Update(emprestimo);
            await _context.SaveChangesAsync();
            return emprestimo;
        }


        public async Task<Emprestimo> Excluir(int id)
        {
            var emprestimo = await _context.Emprestimo.FindAsync(id);
            if (emprestimo != null)
            {
                _context.Emprestimo.Remove(emprestimo);
                await _context.SaveChangesAsync();
                return emprestimo;
            }

            return null;
        }

        public async Task<Emprestimo> Incluir(Emprestimo emprestimo)
        {
            _context.Emprestimo.Add(emprestimo);
            await _context.SaveChangesAsync();
            return emprestimo;
        }

        public async Task<Emprestimo> SelecionarAsync(int id)
        {
            //AsNoTracking - para nao rastrear a entidade e causar conflitos na hora das atualizacoes de informacoes:
            return await _context.Emprestimo.Include(x => x.Cliente).Include(x => x.Livro).AsNoTracking().Where(x => x.id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Emprestimo>> SelecionarTodosAsync()
        {
            //para retornar as informacoes complementares do livro/cliente:
            return await _context.Emprestimo.Include(x => x.Cliente).Include(x => x.Livro).ToListAsync();

        }

        public async Task<bool> VerificaDisponibilidade(int LivroId)
        {
           var existeEmprestimo = await  _context.Emprestimo
                .Where(x => x.LivroId == LivroId && x.entregue == false).AnyAsync();
            return !existeEmprestimo;
        }
    }

}
