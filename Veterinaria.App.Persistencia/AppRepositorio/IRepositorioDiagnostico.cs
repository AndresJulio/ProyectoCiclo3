using System.Collections.Generic;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{
    public interface IRepositorioDiagnostico{
        Diagnostico AddDiagnostico(Diagnostico diagnostico);
        Diagnostico EditDiagnostico(Diagnostico diagnostico);
        void RemoveDiagnostico(Mascota mascota);
        IEnumerable <Diagnostico> GetDiagnosticos();
        
    }
}