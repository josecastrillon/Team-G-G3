using System.Collections.Generic;
using System;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{


    public interface IRepositorioHorarioVeterinario
    {

        IEnumerable<HorarioVeterinario> GetAllHorarioVeterinarios();

        HorarioVeterinario GetHorarioVeterinario(int Id);
        HorarioVeterinario AddHorarioVeterinario(HorarioVeterinario HorarioVeterinario);

        HorarioVeterinario UpdateHorarioVeterinario(HorarioVeterinario HorarioVeterinario);
        void DeleteHorarioVeterinarios(int Id);

    }

}