using EVO.Models;
using Microsoft.EntityFrameworkCore;
using Projeto_EVO.Data;

namespace EVO.Repositories
{
    public class FuncionarioRepository
    {
        private readonly EmpresaContext context;

        public FuncionarioRepository(EmpresaContext dbContext)
        {
            context = dbContext;
        }

        public IEnumerable<Funcionario> ObterTodos(int? departamentoId)
        {
            if (departamentoId == null)
            {
                return context.Funcionarios.Include(x=>x.Departamento).ToList();
            }
            return context.Funcionarios.Where(f=>f.DepartamentoId == departamentoId).Include(x => x.Departamento).ToList();
        }

        public Funcionario ObterPorId(int id)
        {
            return context.Funcionarios.FirstOrDefault(f => f.Id == id);
        }

        public void Adicionar(Funcionario funcionario)
        {
            context.Funcionarios.Add(funcionario);
            context.SaveChanges();
        }

        public void Atualizar(Funcionario funcionario)
        {
            context.Funcionarios.Update(funcionario);
            context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var funcionario = context.Funcionarios.FirstOrDefault(f => f.Id == id);
            if (funcionario != null)
            {
                context.Funcionarios.Remove(funcionario);
                context.SaveChanges();
            }
        }
    }
}
