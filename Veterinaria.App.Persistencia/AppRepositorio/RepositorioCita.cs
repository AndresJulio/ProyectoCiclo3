using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;


namespace Veterinaria.App.Persistencia{
    public class RepositorioCita : IRepositorioCita
    {
        private readonly Contexto _contexto;
        public RepositorioCita(Contexto _contexto){
            this._contexto = _contexto;
        }
        public Cita AddCita(Cita cita)
        {
            var CitaAdd= _contexto.Add(cita).Entity;
            _contexto.SaveChanges();
            return CitaAdd;
        }

        public Cita EditCita(Cita cita)
        {
            var Citaeditada= _contexto.citas.Where(x => x.Mascota==cita.Mascota).FirstOrDefault();
            if (Citaeditada!=null){
                Citaeditada.Ciudad=cita.Ciudad;
                Citaeditada.Telefono=cita.Telefono;
                Citaeditada.Auxiliar=cita.Auxiliar;
                Citaeditada.Veterinaria=cita.Veterinaria;
                Citaeditada.Mascota=cita.Mascota;
                _contexto.SaveChanges();
            }
            return Citaeditada;
        }
        

        public IEnumerable<Cita> GetCitas()
        {
            return _contexto.citas;
        }

        public void RemoveCita(Mascota mascota)
        {
            var CitaDel= _contexto.citas.Where(x => x.Mascota==mascota).FirstOrDefault();
            if (CitaDel!=null){
                _contexto.citas.Remove(CitaDel);
                _contexto.SaveChanges();
            }
        }
    }
}