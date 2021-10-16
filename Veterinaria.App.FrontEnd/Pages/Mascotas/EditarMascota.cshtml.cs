using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.FrontEnd
{
    public class EditarMascotaModel : PageModel
    {
       private readonly IRepositorioMascota repositorioMascota;
       private readonly IRepositorioDueño repositorioDueños;
        public Mascota mascota{get;set;}
        public Dueño dueño{get;set;}
        public IEnumerable<SelectListItem> dueños{get;set;}
        public int CedulaDueño{ get; set;}
        public EditarMascotaModel(IRepositorioMascota repositorioMascota, IRepositorioDueño repositorioDueños){
            this.repositorioMascota = repositorioMascota;
            this.repositorioDueños = repositorioDueños;
            
        }
        public void OnGet(int ID)
        {
            mascota= repositorioMascota.obtenerMascotas(ID);
            dueños= repositorioMascota.obtenerDueños().Select(

                m => new SelectListItem {
                    
                    Text = m.Nombre+" "+m.Apellido,
                    Value = Convert.ToString(m.cedula)
                    
                }
            ).ToList();
        }
        public IActionResult OnPost(Mascota mascota, int CedulaDueño){
            Console.WriteLine(mascota.ID);
            repositorioMascota.editMascota(mascota);
            dueño= repositorioDueños.obtenerdueños(CedulaDueño);
            mascota.Dueño=dueño;
            repositorioMascota.editMascota(mascota);
            return RedirectToPage("./ListaMascotas");


        }
    }
}
