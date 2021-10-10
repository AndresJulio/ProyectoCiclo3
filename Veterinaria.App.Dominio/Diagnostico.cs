using System;

namespace Veterinaria.App.Dominio
{
    public class Diagnostico{
        public int ID { get; set; }
        public string HistoriaClinical { get; set; }
        public string Anotacion{get; set; }
        public string Formula{get; set; }
        public Cita Cita{get; set; }

    }
}