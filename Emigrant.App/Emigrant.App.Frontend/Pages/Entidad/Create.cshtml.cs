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

    public class FormEntidadModel : PageModel
    {

        private readonly RepositorioEntidad repositorioEntidad;
        [BindProperty]
        public Entidad Entidad {get;set;}

        public FormEntidadModel(RepositorioEntidad repositorioEntidad)
        {
            this.repositorioEntidad=repositorioEntidad;
        }

        public void OnGet()
        {
 
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }            
            Entidad = repositorioEntidad.Create(Entidad);            
            return RedirectToPage("./List");
        }

    }
}