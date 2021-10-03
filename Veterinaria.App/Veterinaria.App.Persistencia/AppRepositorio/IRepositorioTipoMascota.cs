
using System.Collections.Generic;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public interface IRepositorioTipoMascota
    {
        IEnumerable<TipoMascota> GetAllTipoMascota();

        TipoMascota AddTipoMascota(TipoMascota tipomascota );

        TipoMascota UpdateTipoMascota(TipoMascota tipomascota);

        void DeleteTipoMascota (int Id);

        TipoMascota GetTipoMascota(int Id);


    }
}