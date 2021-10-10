using System.Collections.Generic;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia{
    public interface IRepositorioDueño{
        Dueño addDueño(Dueño dueño);
        Dueño editDueño(Dueño dueño);
        void removeDueño(int cedula);
        IEnumerable <Dueño> getDueños();

    }
}