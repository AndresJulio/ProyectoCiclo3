using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{
    public class RepositorioPersona : IRepositorioPersona
    {
        private readonly Contexto _contexto;
        public RepositorioPersona(Contexto _contexto){
            this._contexto = _contexto;
        }
        public Persona addPersona(Persona persona)
        {
            var personaingresada = _contexto.Add(persona).Entity;
            _contexto.SaveChanges();
            return personaingresada;
        }

        public Persona EditarPersona(Persona persona)
        {
            var personaeditada= _contexto.personas.Where(p => p.ID == persona.ID).FirstOrDefault();
            if (personaeditada != null){
                personaeditada.Nombre=persona.Nombre;
                personaeditada.Apellido=persona.Apellido;
                personaeditada.cedula=persona.cedula;
                _contexto.SaveChanges();
            }
            return personaeditada;
        }

        public void Eliminarpersona(int cedula)
        {
             var personaeliminada= _contexto.personas.Where(p => p.cedula==cedula).FirstOrDefault(); 
             if (personaeliminada != null){
                 _contexto.personas.Remove(personaeliminada);
                 _contexto.SaveChanges();
             }
        }

        public IEnumerable<Persona> obtenerpersonas()
        {
            return _contexto.personas;
        }
    }
}