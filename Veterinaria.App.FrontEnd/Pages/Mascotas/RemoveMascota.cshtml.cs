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
    public class RemoveMascotaModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota;
        public Mascota mascota;
        public int ID { get; set; }
        public RemoveMascotaModel(IRepositorioMascota repositorioMascota){
            this.repositorioMascota = repositorioMascota;
        }
        public void OnGet(int ID)
        {
            this.ID = ID;
            this.mascota=repositorioMascota.obtenerMascotas(ID);
        }
        public IActionResult OnPost(int ID){
            repositorioMascota.removeMascota(ID);
            return RedirectToPage("./ListaMascotas");
        }
    }
}
