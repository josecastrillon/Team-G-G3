using System.Collections.Generic;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public interface IRepositorioAuxiliar
    {
        IEnumerable<Auxiliar> GetAllAuxiliar();

        Auxiliar AddAuxiliar(Auxiliar auxiliar );

        Auxiliar UpdateAuxiliar(Auxiliar auxiliar);

        void DeleteAuxiliar (string documento);

        Auxiliar GetAuxiliar(string documento);


    }
}