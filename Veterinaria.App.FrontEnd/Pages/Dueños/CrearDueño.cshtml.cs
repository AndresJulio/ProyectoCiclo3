using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.FrontEnd
{
    public class CrearDueñoModel : PageModel
    {
        private readonly IRepositorioDueño repositorioDueño;
        public Dueño dueño{get;set;}
         public CrearDueñoModel(IRepositorioDueño repositorioDueño){
             this.repositorioDueño = repositorioDueño;
         }
        public void OnGet()
        {
            dueño= new Dueño();
        }
        public IActionResult OnPost(Dueño dueño){
            Console.WriteLine(dueño.Nombre);
            repositorioDueño.addDueño(dueño);
            return RedirectToPage("./ListaDueños");


        }
    }
}
