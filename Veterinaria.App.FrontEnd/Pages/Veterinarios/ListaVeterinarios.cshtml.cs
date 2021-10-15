using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace MyApp.Namespace
{
    public class ListaVeterinariosModel : PageModel
    {
        private readonly IRepositorioVeterinario RepositorioVeterinario;
        public IEnumerable<Veterinario> veterinarios;
        public ListaVeterinariosModel(IRepositorioVeterinario RepositorioVeterinario){
            this.RepositorioVeterinario = RepositorioVeterinario;
        }
        public void OnGet()
        {
            veterinarios= RepositorioVeterinario.getVeterinarios();
        }
    }
}
