using System.Collections.Generic;
using Emigrant.App.Dominio;
using System.Linq;
using System;
 
namespace Emigrant.App.Persistencia.AppRepositorios
{
    public class RepositorioPersona
    {
        List<Persona> personas;
 
    public RepositorioPersona()
        {
            personas= new List<Persona>()
            {
                
 
            };
        }
 
        public IEnumerable<Persona> GetAll()
        {
            return personas;
        }
 
        public Persona GetPersonaWithId(int id){
            return personas.SingleOrDefault(b => b.id == id);
        }
    }
}
