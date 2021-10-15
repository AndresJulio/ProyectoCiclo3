using System.Collections.Generic;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{
    public interface IRepositorioVeterinario{
        Veterinario addVeterinario(Veterinario veterinario);
        Veterinario editVeterinario(Veterinario veterinario);
        void removeVeterinario(int cedula);
        IEnumerable <Veterinario> getVeterinarios();
        Veterinario obtenerVeterinario(int cedula);

    }
}