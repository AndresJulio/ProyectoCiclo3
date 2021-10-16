using System.Collections.Generic;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public interface IRepositorioAuxiliar{
        Persona addAuxiliar(Auxiliar auxiliar);
        void EliminarAuxiliar(int cedula); 
        IEnumerable<Auxiliar> obtenerauxiliares();
        Auxiliar EditarAuxiliar(Auxiliar auxiliar);
        Auxiliar obtenerauxiliares(int cedula);
        
    }
}