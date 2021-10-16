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
    public class CrearAuxiliarModel : PageModel
    {
       private readonly IRepositorioAuxiliar repositorioAuxiliar;
        public Auxiliar auxiliar{get;set;}
        public CrearAuxiliarModel(IRepositorioAuxiliar repositorioAuxiliar){
            this.repositorioAuxiliar = repositorioAuxiliar;
        }
        public void OnGet()
        {
            auxiliar= new Auxiliar();
        }
        public IActionResult OnPost(Auxiliar auxiliar){
            
            repositorioAuxiliar.addAuxiliar(auxiliar);
            return RedirectToPage("./ListaAuxiliares");


        }
    }
}
