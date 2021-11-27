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
    public class DetailsPersonaModel : PageModel
    {
       private readonly RepositorioPersona repositorioPersonas;
              public Persona Persona {get;set;}
 
        public DetailsPersonaModel(RepositorioPersona repositorioPersonas)
       {
            this.repositorioPersonas=repositorioPersonas;
       }
 
        public IActionResult OnGet(int personaId)
        {
                Persona=repositorioPersonas.GetPersonaWithId(personaId);
                return Page();
 
        }
    }
}
