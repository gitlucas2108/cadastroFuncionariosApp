using Microsoft.EntityFrameworkCore;

namespace cadastroFuncionarios.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }




    }
}
