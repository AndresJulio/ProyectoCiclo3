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
    public class DetalleAuxiliarModel : PageModel
    {
        private readonly IRepositorioAuxiliar repositorioauxiliar;
        public Auxiliar auxiliar{get;set;}
        public DetalleAuxiliarModel(IRepositorioAuxiliar repositorioauxiliar){
            this.repositorioauxiliar=repositorioauxiliar;
        }
        public void OnGet(int cedula)
        {
            auxiliar= repositorioauxiliar.obtenerauxiliares(cedula);
        }
    }
}
