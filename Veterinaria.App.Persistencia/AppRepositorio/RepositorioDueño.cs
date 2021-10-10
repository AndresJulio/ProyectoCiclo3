using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{
    public class RepositorioDueño : IRepositorioDueño
    {
        private readonly Contexto _contexto;
        public RepositorioDueño(Contexto _contexto){
            this._contexto = _contexto;
        }
        public Dueño addDueño(Dueño dueño)
        {
            var DueñoAdd=_contexto.Add(dueño).Entity;
            _contexto.SaveChanges();
            return DueñoAdd;
        }

        public Dueño editDueño(Dueño dueño)
        {
            var Dueñoencontrado= _contexto.dueños.Where(x => x.Nombre==dueño.Nombre).FirstOrDefault();
            if (Dueñoencontrado!=null){
                Dueñoencontrado.Nombre=dueño.Nombre;
                Dueñoencontrado.Apellido=dueño.Apellido;
                Dueñoencontrado.cedula=dueño.cedula;
                Dueñoencontrado.Ciudad=dueño.Ciudad;
                Dueñoencontrado.Telefono=dueño.Telefono;

                _contexto.SaveChanges();
            }
            return Dueñoencontrado;
        }

        public IEnumerable<Dueño> getDueños()
        {
            return _contexto.dueños;
        }

        public void removeDueño(int cedula)
        {
            var DueñoDel= _contexto.dueños.Where(x => x.cedula==cedula).FirstOrDefault();
            if (DueñoDel!=null){
                _contexto.dueños.Remove(DueñoDel);
                _contexto.SaveChanges();
            }
        }
    }

}