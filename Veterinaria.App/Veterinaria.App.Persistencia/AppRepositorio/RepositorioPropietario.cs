using System;
using System.Collections.Generic;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioPropietario : IRepositorioPropietario
    {
        private readonly AppContexto _appContexto;

        public RepositorioPropietario(AppContexto _appContexto)
        {
            this._appContexto = _appContexto;

        }

        public Propietario AddPropietario(Propietario propietario)
        {

            var Propietarioagregado = _appContexto.Add(propietario);
            _appContexto.SaveChanges();
            return Propietarioagregado.Entity;

        }

        public void DeletePropietario(string documento)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Propietario> GetAllPropietario()
        {
            throw new NotImplementedException();
        }

        public Propietario GetPropietario(Propietario propietario)
        {
            throw new NotImplementedException();
        }

        public Propietario UpdatePropietario(Propietario propietario)
        {
            throw new NotImplementedException();
        }


    }
}