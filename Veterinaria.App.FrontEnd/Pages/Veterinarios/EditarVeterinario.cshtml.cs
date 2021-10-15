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
    public class EditarVeterinarioModel : PageModel
    {
        private readonly IRepositorioVeterinario repositorioVeterinario;
        public Veterinario veterinario{get;set;}
        public EditarVeterinarioModel(IRepositorioVeterinario repositorioVeterinario){
            this.repositorioVeterinario=repositorioVeterinario;
        }
        public void OnGet(int cedula)
        {
           
            veterinario= repositorioVeterinario.obtenerVeterinario(cedula);
        }
        public IActionResult OnPost(Veterinario veterinario){
            Console.WriteLine(veterinario.cedula);
            repositorioVeterinario.editVeterinario(veterinario);
            return RedirectToPage("./ListaVeterinarios");


        }
    }
}
