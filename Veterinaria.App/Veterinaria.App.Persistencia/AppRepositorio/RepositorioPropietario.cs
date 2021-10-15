using System;
using System.Collections.Generic;
using Veterinaria.App.Dominio;
using System.Linq;

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
            Propietario propietarioencontrado = _appContexto.Propietarios.Where(x => x.documento == documento).FirstOrDefault();
            if (propietarioencontrado!=null){
                _appContexto.Remove(propietarioencontrado);
                _appContexto.SaveChanges();
            }
        }

        public IEnumerable<Propietario> GetAllPropietario()
        {
            return _appContexto.Propietarios;
        }

        public Propietario GetPropietario(string documento)
        {
            Propietario propietarioencontrado = _appContexto.Propietarios.Where(x => x.documento == documento).FirstOrDefault();
            return propietarioencontrado;
        }

        public Propietario UpdatePropietario(Propietario propietario)
        {
            Propietario propietarioencontrado = _appContexto.Propietarios.Where(x => x.documento == propietario.documento).FirstOrDefault();
            if (propietarioencontrado!=null){

                propietarioencontrado.nombre = propietario.nombre;
                propietarioencontrado.apellido = propietario.apellido;
                propietarioencontrado.direccion = propietario.direccion;
                propietarioencontrado.telefono = propietario.telefono;
                propietarioencontrado.ciudad = propietario.ciudad;
                propietarioencontrado.email = propietario.email;
                propietarioencontrado.password = propietario.password;
                propietarioencontrado.genero = propietario.genero;
                _appContexto.SaveChanges();
            }
            
            return propietarioencontrado;
        }


    }
}