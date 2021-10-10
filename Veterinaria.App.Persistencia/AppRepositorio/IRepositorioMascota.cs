using System.Collections.Generic;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{
    public interface IRepositorioMascota{
        Mascota addMascota(Mascota mascota);
        Mascota editMascota(Mascota mascota);
        void removeMascota(string Nombre);
        IEnumerable <Mascota> getMascotas();

    }
}