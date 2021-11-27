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
    public class FormPersonaModel : PageModel
    {

        private readonly RepositorioPersona repositorioPersona;
        [BindProperty]
        public Persona Persona {get;set;}

        public FormPersonaModel(RepositorioPersona repositorioPersonas)
        {
            this.repositorioPersona=repositorioPersonas;
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
            Persona = repositorioPersona.Create(Persona);            
            return RedirectToPage("./List");
        }

    }
}