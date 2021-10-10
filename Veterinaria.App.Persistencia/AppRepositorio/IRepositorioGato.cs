using System.Collections.Generic;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{
    public interface IRepositorioGato{
        Gato addGato(Gato gato);
        Gato editGato(Gato gato);
        void removeGato(string Nombre);
        IEnumerable <Gato> getGato();

    }
}