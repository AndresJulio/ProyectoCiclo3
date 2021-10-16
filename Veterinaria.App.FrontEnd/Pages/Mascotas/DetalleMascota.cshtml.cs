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
    public class DetalleMascotaModel : PageModel
    {
        private readonly IRepositorioMascota repositoriomascota;
        public Mascota mascota{get;set;}
        public DetalleMascotaModel(IRepositorioMascota repositoriomascota){
            this.repositoriomascota = repositoriomascota;
        }
        public void OnGet(int ID)
        {
            mascota= repositoriomascota.obtenerMascotas(ID);
        }
    }
}
