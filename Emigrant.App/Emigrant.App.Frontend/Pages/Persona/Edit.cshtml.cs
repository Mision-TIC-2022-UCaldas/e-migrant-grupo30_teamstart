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

    public class EditPersonaModel : PageModel
    {
        private readonly RepositorioPersona repositorioPersona;
        [BindProperty]
        public Persona Persona {get;set;}
 
        public EditPersonaModel(RepositorioPersona repositorioPersona)
        {
            this.repositorioPersona=repositorioPersona;
        }
 
        public IActionResult OnGet(int personaId)
        {
            Persona=repositorioPersona.GetPersonaWithId(personaId);
            return Page();
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Persona.id>0)
            {
                Persona = repositorioPersona.Update(Persona);
            }
            return RedirectToPage("./List");
        }



    }
}