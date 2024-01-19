﻿using EVO.Models;
using Microsoft.EntityFrameworkCore;
using Projeto_EVO.Data;
using Projeto_EVO.Moddels;
using System;

namespace EVO.Repositories
{
    public class DepartamentoRepository
    {
        private readonly EmpresaContext _context;

        public DepartamentoRepository(EmpresaContext context)
        {
            _context = context;
        }

        public Departamento ObterPorId(int id)
        {
            return _context.Departamentos.FirstOrDefault(f => f.Id == id);
        }

        public async Task AdicionarAsync(Departamento departamento)
        {
            _context.Departamentos.Add(departamento);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Departamento>> ObterTodosAsync()
        {
            return await _context.Departamentos.ToListAsync();
        }

        public async Task AtualizarAsync(Departamento departamento)
        {
            _context.Update(departamento);
            await _context.SaveChangesAsync();
        }

        public async Task ExcluirAsync(int id)
        {
            var departamentoParaExcluir = await _context.Departamentos.FindAsync(id);
            if (departamentoParaExcluir != null)
            {
                _context.Departamentos.Remove(departamentoParaExcluir);
                await _context.SaveChangesAsync();
            }
        }
    }
}
