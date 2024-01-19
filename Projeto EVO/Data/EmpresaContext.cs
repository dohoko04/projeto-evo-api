using EVO.Models;
using Microsoft.EntityFrameworkCore;
using Projeto_EVO.Moddels;

namespace Projeto_EVO.Data
{
    public class EmpresaContext : DbContext
    {
        public DbSet <Departamento> Departamentos { get; set; }
        public DbSet <Funcionario> Funcionarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=123456;Persist Security Info=True;User ID=hideki02;Initial Catalog=Evo;Data Source=HIDEKI;TrustServerCertificate=Yes");
        }
    }
}
