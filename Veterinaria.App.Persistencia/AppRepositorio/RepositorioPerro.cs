using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{
    public class RepositorioPerro : IRepositorioPerro
    {
        private readonly Contexto _contexto;
        public RepositorioPerro(Contexto _contexto){
            this._contexto = _contexto;
        }
        public Perro addPerro(Perro perro)
        {
            var PerroAdd= _contexto.Add(perro).Entity;
            _contexto.SaveChanges();
            return PerroAdd;
        }

        public Perro editPerro(Perro perro)
        {
            var Perroeditado= _contexto.perros.Where(x => x.Nombre==perro.Nombre).FirstOrDefault();
            if (Perroeditado!=null){
                Perroeditado.Nombre=perro.Nombre;
                Perroeditado.Edad=perro.Edad;
                Perroeditado.Dueño=perro.Dueño;
                Perroeditado.Comida=perro.Comida;
                
                _contexto.SaveChanges();
            }
            return Perroeditado;
        }

        public IEnumerable<Perro> getPerro()
        {
            return _contexto.perros;
        }

        public void removePerro(string Nombre)
        {
            var PerroDel= _contexto.perros.Where(x => x.Nombre==Nombre).FirstOrDefault();
            if (PerroDel!=null){
                _contexto.perros.Remove(PerroDel);
                _contexto.SaveChanges();
            }
        }
    }
}