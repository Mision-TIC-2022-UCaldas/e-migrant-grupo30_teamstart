using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Emigrant.App.Persistencia.AppRepositorios;
using Emigrant.App.Dominio;
using Microsoft.AspNetCore.Authorization;

 
namespace Emigrant.App.Frontend.Pages
{
        [Authorize]
    public class ListEntidadModel : PageModel
    {

        private readonly RepositorioEntidad repositorioEntidad;
        public IEnumerable<Entidad> Entidad {get;set;}
        [BindProperty]
        public Entidad Entidad1 {get;set;}

        public ListEntidadModel(RepositorioEntidad repositorioEntidad)
        {
            this.repositorioEntidad=repositorioEntidad;
        }

        public void OnGet()
        {
            Entidad=repositorioEntidad.GetAll();
        }

        public IActionResult OnPost()
        {
            if(Entidad1.id>0)
            {
                repositorioEntidad.Delete(Entidad1.id);
            }
            return RedirectToPage("./List");
        }

    }
}
