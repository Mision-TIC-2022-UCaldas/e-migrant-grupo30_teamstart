using System.Collections.Generic;
using Emigrant.App.Dominio;
using System.Linq;
using System;


namespace Emigrant.App.Persistencia.AppRepositorios
{
    public class RepositorioEntidad
    {
        private readonly AppContext _appContext = new AppContext();
 
        public IEnumerable<Entidad> GetAll()
        {
            return _appContext.Entidades;
        }
 
        public Entidad GetEntidadWithId(int id){
            return _appContext.Entidades.Find(id);
        }

        public Entidad Create(Entidad newEntidad)
        {
            var addEntidad = _appContext.Entidades.Add(newEntidad);
            _appContext.SaveChanges();
            return addEntidad.Entity;
        }
 public Entidad Update(Entidad newEntidad){
            var Entidad= _appContext.Entidades.Find(newEntidad.id);
            if(Entidad != null){
                Entidad.razón_social = newEntidad.razón_social;
                Entidad.nit = newEntidad.nit;
                Entidad.direccion = newEntidad.direccion;
                Entidad.ciudad = newEntidad.ciudad;
                Entidad.telefono = newEntidad.telefono;
                Entidad.direccion_electronica = newEntidad.direccion_electronica;
                Entidad.pagina_web = newEntidad.pagina_web;
                Entidad.sector = newEntidad.sector;
                Entidad.tipo_servicio = newEntidad.tipo_servicio;
               
                _appContext.SaveChanges();

            }
            return Entidad;
        }

        

        public void Delete(int id)
        {
            var Entidad= _appContext.Entidades.Find(id);
            if (Entidad == null)
                return;
            _appContext.Entidades.Remove(Entidad);
            _appContext.SaveChanges();    
        }

        


    }
}