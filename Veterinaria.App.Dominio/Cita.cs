using System;

namespace Veterinaria.App.Dominio
{
    public class Cita{
        public int ID{get; set; }
        public string Ciudad{get; set; }
        public string Telefono{get; set; }
        public Auxiliar Auxiliar{get; set; }
        public Veterinario Veterinaria{get; set; }
        public Mascota Mascota{get; set; }

    }
}