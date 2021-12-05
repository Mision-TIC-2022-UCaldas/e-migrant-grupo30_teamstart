using System.Collections.Generic;
using Emigrant.App.Dominio;
using System.Linq;
using System;
 
namespace Emigrant.App.Persistencia.AppRepositorios
{
    public class RepositorioPersona
    {
        List<Persona> Personas;
        private readonly AppContext _appContext = new AppContext();   
       public IEnumerable<Persona> GetAll()
       {
           return _appContext.Personas;
        }

 
        public Persona GetPersonaWithId(int id){
            return _appContext.Personas.Find(id);
        }

        public Persona Create(Persona newPersona)
        {
          var addPersona = _appContext.Personas.Add(newPersona);
            _appContext.SaveChanges();
            return addPersona.Entity;
        }
    }
}
