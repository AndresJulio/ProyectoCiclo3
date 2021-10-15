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
    public class DetalleVeterinarioModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario;
        public Veterinario veterinario{get;set;}
        public DetalleVeterinarioModel(IRepositorioVeterinario repositorioVeterinario){
            this.repositorioVeterinario=repositorioVeterinario;
        }
        public void OnGet(int cedula)
        {
            veterinario= repositorioVeterinario.obtenerVeterinario(cedula);
        }
    }
}
