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
    public class CrearVeterinarioModel : PageModel {
        private readonly IRepositorioVeterinario repositorioVeterinario;
        public Veterinario veterinario{get;set;}
         public CrearVeterinarioModel(IRepositorioVeterinario repositorioVeterinario){
             this.repositorioVeterinario = repositorioVeterinario;
         }
        public void OnGet()
        {
            veterinario= new Veterinario();
        }
        public IActionResult OnPost(Veterinario veterinario){
            Console.WriteLine(veterinario.Nombre);
            repositorioVeterinario.addVeterinario(veterinario);
            return RedirectToPage("./ListaVeterinarios");


        }
    }
}
