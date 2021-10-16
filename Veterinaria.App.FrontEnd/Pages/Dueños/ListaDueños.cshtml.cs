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
    public class ListaDueñosModel : PageModel
    {
         private readonly IRepositorioDueño RepositorioDueño;
        public IEnumerable<Dueño> dueños;
        public ListaDueñosModel(IRepositorioDueño RepositorioDueño){
            this.RepositorioDueño = RepositorioDueño;
        }
        public void OnGet()
        {
            dueños=RepositorioDueño.getDueños();
        }
    }
}
