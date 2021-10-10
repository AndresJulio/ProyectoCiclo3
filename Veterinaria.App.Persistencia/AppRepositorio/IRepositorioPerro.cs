using System.Collections.Generic;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{
    public interface IRepositorioPerro{
        Perro addPerro(Perro perro);
        Perro editPerro(Perro perro);
        void removePerro(string Nombre);
        IEnumerable <Perro> getPerro();

    }
}