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
    public class ListaAuxiliaresModel : PageModel
    {
        private readonly IRepositorioAuxiliar RepositorioAuxiliar;
        public IEnumerable<Auxiliar> auxiliares;
        public ListaAuxiliaresModel(IRepositorioAuxiliar RepositorioAuxiliar){
            this.RepositorioAuxiliar = RepositorioAuxiliar;
        }
        public void OnGet()
        {
            auxiliares= RepositorioAuxiliar.obtenerauxiliares();
        }
    }
}
