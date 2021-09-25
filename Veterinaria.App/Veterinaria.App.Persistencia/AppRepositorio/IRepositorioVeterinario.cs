using System.Collections.Generic;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public interface IRepositorioVeterinario
    {
        IEnumerable<Veterinario> GetAllVeterinario();

        Veterinario AddVeterinario(Veterinario veterinario );

        Veterinario UpdateVeterinario(Veterinario veterinario);

        void DeleteVeterinario (string documento);

        Veterinario GetVeterinario(Veterinario veterinario);


    }
}