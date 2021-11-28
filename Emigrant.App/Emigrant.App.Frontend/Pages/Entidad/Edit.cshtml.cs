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
    public class EditEntidadModel : PageModel
    {
        private readonly RepositorioEntidad repositorioEntidad;
        [BindProperty]
        public Entidad Entidad {get;set;}
 
        public EditEntidadModel(RepositorioEntidad repositorioEntidad)
        {
            this.repositorioEntidad=repositorioEntidad;
        }
 
        public IActionResult OnGet(int EntidadId)
        {
            Entidad=repositorioEntidad.GetEntidadWithId(EntidadId);
            return Page();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Entidad.id>0)
            {
                Entidad = repositorioEntidad.Update(Entidad);
            }
            return RedirectToPage("./List");
        }



    }
}