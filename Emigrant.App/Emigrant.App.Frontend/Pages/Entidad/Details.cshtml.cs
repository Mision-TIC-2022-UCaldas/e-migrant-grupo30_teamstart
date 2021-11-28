using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Emigrant.App.Persistencia.AppRepositorios;
using Emigrant.App.Dominio;


namespace Emigrant.App.Frontend.Pages
{
    public class DetailsEntidadModel : PageModel
    {
       private readonly RepositorioEntidad repositorioEntidad;
              public Entidad Entidad {get;set;}
 
        public DetailsEntidadModel(RepositorioEntidad repositorioEntidad)
       {
            this.repositorioEntidad=repositorioEntidad;
       }
 
        public IActionResult OnGet(int EntidadId)
        {
                Entidad=repositorioEntidad.GetEntidadWithId(EntidadId);
                return Page();
 
        }
    }
}
