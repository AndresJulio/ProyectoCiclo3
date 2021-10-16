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
    public class DetalleDueñoModel : PageModel
    {
        private readonly IRepositorioDueño repositorioDueño;
        public Dueño dueño { get; set; }
        public DetalleDueñoModel(RepositorioDueño repositorioDueño){
            this.repositorioDueño = repositorioDueño;
        }
        public void OnGet(int cedula)
        {
            dueño= repositorioDueño.obtenerdueños(cedula);
        }
    }
}
