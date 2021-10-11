
using System.Collections.Generic;
using System;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public interface IRepositorioCita 
    {
        IEnumerable<Cita> GetAllCitas ();
        Cita GetCita (int Id);
        Cita AddCita (Cita cita);

        void  DeleteCita (int Id);
        Cita UpdateCita (Cita cita);

    }
}