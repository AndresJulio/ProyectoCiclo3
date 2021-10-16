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
    public class EditarAuxiliarModel : PageModel
    {
        private readonly IRepositorioAuxiliar repositorioAuxiliar;
        public Auxiliar auxiliar{get;set;}
        public EditarAuxiliarModel(IRepositorioAuxiliar repositorioAuxiliar){
            this.repositorioAuxiliar = repositorioAuxiliar;
        }
        public void OnGet(int cedula)
        {
            auxiliar= repositorioAuxiliar.obtenerauxiliares(cedula);
        }
        public IActionResult OnPost(Auxiliar auxiliar){
            Console.WriteLine(auxiliar.cedula);
            repositorioAuxiliar.EditarAuxiliar(auxiliar);
            return RedirectToPage("./ListaAuxiliares");


        }
    }
}
