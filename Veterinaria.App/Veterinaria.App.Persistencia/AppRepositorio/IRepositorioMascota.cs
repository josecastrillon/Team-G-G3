using System.Collections.Generic;
using System;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{


    public interface IRepositorioMascota
    {

        IEnumerable<Mascota> GetAllMascotas();

        Mascota GetMascota(int Id);
        Mascota AddMascota(Mascota mascota);

        Mascota UpdateMascota(Mascota mascota);
        void DeleteMascotas(int Id);

    }

}