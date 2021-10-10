using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;


namespace Veterinaria.App.Persistencia{
    public class RepositorioDiagnostico : IRepositorioDiagnostico
    {
         private readonly Contexto _contexto;
        public RepositorioDiagnostico(Contexto _contexto){
            this._contexto = _contexto;
        }
        public Diagnostico AddDiagnostico(Diagnostico diagnostico)
        {
            var DiagnosticoAdd= _contexto.Add(diagnostico).Entity;
            _contexto.SaveChanges();
            return DiagnosticoAdd;
        }

        public Diagnostico EditDiagnostico(Diagnostico diagnostico)
        {
            var Diagnosticoeditado= _contexto.diagnosticos.Where(x => x.Cita.Mascota==diagnostico.Cita.Mascota).FirstOrDefault();
            if (Diagnosticoeditado!=null){
                Diagnosticoeditado.HistoriaClinical=diagnostico.HistoriaClinical;
                Diagnosticoeditado.Anotacion=diagnostico.Anotacion;
                Diagnosticoeditado.Formula=diagnostico.Formula;
                Diagnosticoeditado.Cita=diagnostico.Cita;
                _contexto.SaveChanges();
            }
            return Diagnosticoeditado;
        }

        public IEnumerable<Diagnostico> GetDiagnosticos()
        {
            return _contexto.diagnosticos;
        }

        public void RemoveDiagnostico(Mascota mascota)
        {
            var DiagnosticoDel= _contexto.diagnosticos.Where(x => x.Cita.Mascota==mascota).FirstOrDefault();
            if (DiagnosticoDel!=null){
                _contexto.diagnosticos.Remove(DiagnosticoDel);
                _contexto.SaveChanges();
            }
        }
    }
}