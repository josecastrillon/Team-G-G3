using System.Collections.Generic;
using System;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public interface IRepositorioHorarios 
    {
        IEnumerable<Horario> GetAllHorarios();
        Horario AddHorario (Horario horario);
        void DeleteHorario (int id);

        Horario GetHorario (int id);
        Horario UpdateHorario (Horario horario);
    }
}