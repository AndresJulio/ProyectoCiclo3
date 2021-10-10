using System.Collections.Generic;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Veterinaria{
    public interface IRepositorioCita{
        Cita AddCita(Cita cita);
        Cita EditCita(Cita cita);
        void RemoveCita(Mascota mascota);
        IEnumerable <Cita> GetCitas();
        
    }
}
