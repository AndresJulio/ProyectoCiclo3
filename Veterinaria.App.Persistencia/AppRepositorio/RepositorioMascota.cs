using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{
    public class RepositorioMascota : IRepositorioMascota
    {
        private readonly Contexto _contexto;
        public RepositorioMascota(Contexto _contexto){
            this._contexto = _contexto;
        }
        public Mascota addMascota(Mascota mascota)
        {
           var MascotaAdd= _contexto.Add(mascota).Entity;
            _contexto.SaveChanges();
            return MascotaAdd;
        }

        public Mascota editMascota(Mascota mascota)
        {
            var Mascotaeditada= _contexto.mascotas.Where(x => x.Nombre==mascota.Nombre).FirstOrDefault();
            if (Mascotaeditada!=null){
                Mascotaeditada.Nombre=mascota.Nombre;
                Mascotaeditada.Edad=mascota.Edad;
                Mascotaeditada.Dueño=mascota.Dueño;
                _contexto.SaveChanges();
            
            }
            return Mascotaeditada;
        }

        public IEnumerable<Mascota> getMascotas()
        {
            return _contexto.mascotas;
        }

        public void removeMascota(string Nombre)
        {
            var MascotaDel= _contexto.mascotas.Where(x => x.Nombre==Nombre).FirstOrDefault();
            if (MascotaDel!=null){
                _contexto.mascotas.Remove(MascotaDel);
                _contexto.SaveChanges();
            }
        }
    }
}