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
    public class ListPersonaModel : PageModel
    {
       
        private readonly RepositorioPersona repositorioPersona;
        public IEnumerable<Persona> Personas {get;set;}
 
    public ListPersonaModel(RepositorioPersona repositorioPersona)
    {
        this.repositorioPersona=repositorioPersona;
     }
 
    public void OnGet()
    {
        Personas=repositorioPersona.GetAll();
    }
    }
}
