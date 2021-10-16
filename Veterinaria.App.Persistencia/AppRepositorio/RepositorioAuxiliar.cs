using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{
    public class RepositorioAuxiliar : IRepositorioAuxiliar
    {
        private readonly Contexto _contexto;
        public RepositorioAuxiliar(Contexto _contexto){
            this._contexto = _contexto;
        }
        public Persona addAuxiliar(Auxiliar auxiliar)
        {
            var AuxiliarAdd= _contexto.Add(auxiliar).Entity;
            _contexto.SaveChanges();
            return AuxiliarAdd;
        }

        public Auxiliar EditarAuxiliar(Auxiliar auxiliar)
        {
            var Auxiliarencontrado= _contexto.auxiliares.Where(x => x.Nombre==auxiliar.Nombre).FirstOrDefault();
            if (Auxiliarencontrado!=null){
                Auxiliarencontrado.Nombre=auxiliar.Nombre;
                Auxiliarencontrado.Apellido=auxiliar.Apellido;
                Auxiliarencontrado.cedula=auxiliar.cedula;
                Auxiliarencontrado.Jornada_Laboral=auxiliar.Jornada_Laboral;
                _contexto.SaveChanges();

            }
            return Auxiliarencontrado;
        }

        public void EliminarAuxiliar(int cedula)
        {
            var AuxiliarDel= _contexto.auxiliares.Where(x => x.cedula==cedula).FirstOrDefault();
            if (AuxiliarDel!=null){
                _contexto.auxiliares.Remove(AuxiliarDel);
                _contexto.SaveChanges();
            }
        }

        public IEnumerable<Auxiliar> obtenerauxiliares()
        {
            return _contexto.auxiliares;
        }

        public Auxiliar obtenerauxiliares(int cedula)
        {
            var Auxiliarobtenido= _contexto.auxiliares.Where(x => x.cedula==cedula).FirstOrDefault();
            return Auxiliarobtenido;
        }
    }

}