using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {
        private readonly Contexto _contexto;
        public RepositorioVeterinario(Contexto _contexto){
            this._contexto = _contexto;
        }
        public Veterinario addVeterinario(Veterinario veterinario)
        {
            var VeterinarioAdd= _contexto.Add(veterinario).Entity;
            _contexto.SaveChanges();
            return VeterinarioAdd;
        }

        public Veterinario editVeterinario(Veterinario veterinario)
        {
             var Veterinarioencontrado= _contexto.veterinarios.Where(x => x.Nombre==veterinario.Nombre).FirstOrDefault();
             if (Veterinarioencontrado!=null){
                 Veterinarioencontrado.Nombre=veterinario.Nombre;
                 Veterinarioencontrado.Apellido=veterinario.Apellido;
                 Veterinarioencontrado.cedula=veterinario.cedula;
                 Veterinarioencontrado.Tarjeta_Profesional=veterinario.Tarjeta_Profesional;
                 Veterinarioencontrado.Jornada_Laboral=veterinario.Jornada_Laboral;
                 _contexto.SaveChanges();
             }
             return Veterinarioencontrado;
        }

        public IEnumerable<Veterinario> getVeterinarios()
        {
            return _contexto.veterinarios;
        }

        public void removeVeterinario(int cedula)
        {
            var VeterinarioDel= _contexto.veterinarios.Where(x => x.cedula==cedula).FirstOrDefault();
            if (VeterinarioDel!=null){
                _contexto.veterinarios.Remove(VeterinarioDel);
                _contexto.SaveChanges();
            }
        }
    }
}