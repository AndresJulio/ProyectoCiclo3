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
    public class EliminarDueñoModel : PageModel
    {
         private readonly IRepositorioDueño repositorioDueño;
        public Dueño dueño;
        public int cedula { get; set; }
        public EliminarDueñoModel(IRepositorioDueño repositorioDueño){
            this.repositorioDueño = repositorioDueño;
        }
        public void OnGet(int cedula)
        {
            this.cedula = cedula;
            this.dueño=repositorioDueño.obtenerdueños(cedula);
        }
        public IActionResult OnPost(int cedula){
            repositorioDueño.removeDueño(cedula);
            return RedirectToPage("./ListaDueños");
        }
    }
}
