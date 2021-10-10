using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{
    public class RepositorioGato : IRepositorioGato
    {
        private readonly Contexto _contexto;
        public RepositorioGato(Contexto _contexto){
            this._contexto = _contexto;
        }
        public Gato addGato(Gato gato)
        {
            var GatoAdd= _contexto.Add(gato).Entity;
            _contexto.SaveChanges();
            return GatoAdd;
        }

        public Gato editGato(Gato gato)
        {
            var Gatoeditado= _contexto.gatos.Where(x => x.Nombre==gato.Nombre).FirstOrDefault();
            if (Gatoeditado!=null){
                Gatoeditado.Nombre=gato.Nombre;
                Gatoeditado.Edad=gato.Edad;
                Gatoeditado.Dueño=gato.Dueño;
                Gatoeditado.Comida=gato.Comida;
                _contexto.SaveChanges();
            }
            return Gatoeditado;
        }

        public IEnumerable<Gato> getGato()
        {
            return _contexto.gatos;
        }

        public void removeGato(string Nombre)
        {
            var GatoDel= _contexto.gatos.Where(x => x.Nombre==Nombre).FirstOrDefault();
            if (GatoDel!=null){
                _contexto.gatos.Remove(GatoDel);
                _contexto.SaveChanges();
            }
        }
    }
}