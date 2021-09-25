using System;
using System.Collections.Generic;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioVeterinario: IRepositorioVeterinario
    {
        private readonly AppContexto _appContexto;

        public RepositorioVeterinario(AppContexto _appContexto)
        {
            this._appContexto = _appContexto;
        }

        public Veterinario AddVeterinario(Veterinario veterinario)
        {
            
            var medicoagregado = _appContexto.Add(veterinario);
            _appContexto.SaveChanges();
            return medicoagregado.Entity;

        }

        public void DeleteVeterinario(string documento)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Veterinario> GetAllVeterinario()
        {
            throw new NotImplementedException();
        }

        public Veterinario GetVeterinario(Veterinario veterinario)
        {
            throw new NotImplementedException();
        }

        public Veterinario UpdateVeterinario(Veterinario veterinario)
        {
            throw new NotImplementedException();
        }
    }
}