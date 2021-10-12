using System;
using System.Collections.Generic;
using Veterinaria.App.Dominio;
using System.Linq;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioVeterinario: IRepositorioVeterinario
    {
        private readonly AppContexto _appContexto;
        private readonly Security security;

        public RepositorioVeterinario(AppContexto _appContexto)
        {
            this._appContexto = _appContexto;
            security = new Security ();
        }

        public Veterinario AddVeterinario(Veterinario veterinario)
        {
            String pass= veterinario.password;
            pass = security.GetMD5Hash(pass);
            veterinario.password = pass;
            var medicoagregado = _appContexto.Add(veterinario);
            _appContexto.SaveChanges();
            return medicoagregado.Entity;

        }

        public void DeleteVeterinario(string documento)
        {
            Veterinario veterinarioencontrado = _appContexto.Veterinarios.Where(x => x.documento == documento).FirstOrDefault();
            if (veterinarioencontrado!=null){
                _appContexto.Remove(veterinarioencontrado);
                _appContexto.SaveChanges();
            }

        }

        public IEnumerable<Veterinario> GetAllVeterinario()
        {
            return _appContexto.Veterinarios;
        }

        public Veterinario GetVeterinario(string documento)
        {
            Veterinario veterinarioencontrado = _appContexto.Veterinarios.Where(x => x.documento == documento).FirstOrDefault();
            return veterinarioencontrado;
        }

        public Veterinario UpdateVeterinario(Veterinario veterinario)
        {
            Veterinario veterinarioencontrado = _appContexto.Veterinarios.Where(x => x.Id == veterinario.Id).FirstOrDefault();
            if (veterinarioencontrado != null)
            {
                veterinarioencontrado.nombre = veterinario.nombre;
                veterinarioencontrado.apellido = veterinario.apellido;
                veterinarioencontrado.direccion = veterinario.direccion;
                veterinarioencontrado.telefono = veterinario.telefono;
                veterinarioencontrado.ciudad = veterinario.ciudad;
                veterinarioencontrado.password = veterinario.password;
                veterinarioencontrado.genero = veterinario.genero;
                veterinarioencontrado.tarjetaProfesional = veterinario.tarjetaProfesional;
                _appContexto.SaveChanges();
            }
            
            return veterinarioencontrado;
        }
    }
}