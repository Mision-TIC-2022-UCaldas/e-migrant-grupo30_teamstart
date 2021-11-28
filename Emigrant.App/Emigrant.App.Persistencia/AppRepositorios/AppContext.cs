using Microsoft.EntityFrameworkCore;
using Emigrant.App.Dominio;
 
namespace Emigrant.App.Persistencia
{
    public class AppContext: DbContext{
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Entidad> Entidades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Grupo30_Teamstart");
            }
        }
    }
}

