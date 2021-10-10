using System;

namespace Veterinaria.App.Dominio
{
    public class Mascota{
        public int ID{get; set; }
        public string Nombre{get; set; }
        public string Edad{get; set; }
        public Dueño Dueño{get; set; }


    }
}