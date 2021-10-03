using System;
using System.Collections.Generic;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public interface IRepositorioPropietario 
    {

        IEnumerable<Propietario> GetAllPropietario();

        Propietario AddPropietario (Propietario propietario);
        Propietario UpdatePropietario (Propietario propietario);
        void DeletePropietario (string documento);
        Propietario GetPropietario (string documento);
    }
}