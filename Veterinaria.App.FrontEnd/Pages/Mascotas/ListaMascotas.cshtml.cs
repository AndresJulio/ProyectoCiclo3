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
    public class ListaMascotasModel : PageModel
    {
        private readonly IRepositorioMascota RepositorioMascota;
        public IEnumerable<Mascota> mascotas;
        public ListaMascotasModel(IRepositorioMascota RepositorioMascota){
            this.RepositorioMascota = RepositorioMascota;
        }
        public void OnGet()
        {
            mascotas = RepositorioMascota.getMascotas();
        }
    }
}
