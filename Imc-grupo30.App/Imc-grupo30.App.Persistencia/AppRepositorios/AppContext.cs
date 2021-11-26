using Microsoft.EntityFrameworkCore;
using Imc-grupo30.App.Dominio;
namespace Imc-grupo30.App.Persistencia
{
    public class AppContext: DbContext{
        public DbSet<Persona> Personas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DbImc-grupo30");
            }
        }
    }
}
