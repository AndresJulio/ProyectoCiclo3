
using System.Collections.Generic;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public interface IRepositorioPersona{
        Persona addPersona(Persona persona);
        void Eliminarpersona(int cedula); 
        IEnumerable<Persona> obtenerpersonas();
        Persona EditarPersona(Persona persona);
        
    }
}