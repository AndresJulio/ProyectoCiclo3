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
    public class EditarDueñoModel : PageModel
    {
        private readonly IRepositorioDueño repositorioDueño;
        public Dueño dueño{get;set;}
        public EditarDueñoModel(IRepositorioDueño repositorioDueño){
            this.repositorioDueño=repositorioDueño;
        }
        public void OnGet(int cedula)
        {
           
            dueño= repositorioDueño.obtenerdueños(cedula);
        }
        public IActionResult OnPost(Dueño dueño){
            Console.WriteLine(dueño.cedula);
            repositorioDueño.editDueño(dueño);
            return RedirectToPage("./ListaDueños");


        }
    }
}
