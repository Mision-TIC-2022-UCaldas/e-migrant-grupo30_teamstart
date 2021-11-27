using System.Collections.Generic;
using Emigrant.App.Dominio;
using System.Linq;
using System;


namespace Emigrant.App.Persistencia.AppRepositorios
{
    public class RepositorioPersona
    {
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

        public Persona Update(Persona newPersona){
            var person= _appContext.Personas.Find(newPersona.id);
            if(person != null){
                person.nombre = newPersona.nombre;
                person.apellidos = newPersona.apellidos;
                person.tipodocumento = newPersona.tipodocumento;
                person.numeroidentificacion = newPersona.numeroidentificacion;
                person.paisorigen = newPersona.paisorigen;
                person.fechanacimiento = newPersona.fechanacimiento;
                person.email = newPersona.email;
                person.telefono = newPersona.telefono;
                person.direccionactual = newPersona.direccionactual;
                person.ciudad = newPersona.ciudad;
                person.situacionlaboral = newPersona.situacionlaboral;
                _appContext.SaveChanges();

            }
            return person;
        }

        

        public void Delete(int id)
        {
            var person= _appContext.Personas.Find(id);
            if (person == null)
                return;
            _appContext.Personas.Remove(person);
            _appContext.SaveChanges();    
        }



    }
}