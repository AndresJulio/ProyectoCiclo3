using System.Collections.Generic;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public interface IRepositorioAuxiliar{
        Persona addAuxiliar(Auxiliar auxiliar);
        void EliminarAuxiliar(int cedula); 
        IEnumerable<Persona> obtenerauxiliares();
        Persona EditarAuxiliar(Auxiliar auxiliar);
        
    }
}