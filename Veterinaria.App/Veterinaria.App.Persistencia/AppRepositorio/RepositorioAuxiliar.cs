using System.Collections.Generic;
using System;
using System.Linq;
using Veterinaria.App.Dominio;


namespace Veterinaria.App.Persistencia
{
    public class RepositorioAuxiliar : IRepositorioAuxiliar
    {
        
        private readonly AppContexto _appContexto;

            public RepositorioAuxiliar(AppContexto _appContexto)
        {
            this._appContexto = _appContexto; 
        }

        public Auxiliar AddAuxiliar(Auxiliar auxiliar)
        {
            
            var auxiliaragregado = _appContexto.Add(auxiliar);
            _appContexto.SaveChanges();
            return auxiliaragregado.Entity;

        }

        public void DeleteAuxiliar(string documento)
        {
            var auxiliarencontrado = _appContexto.Auxiliares.Where(x => x.documento == documento).FirstOrDefault();
            if (auxiliarencontrado != null){
                _appContexto.Auxiliares.Remove(auxiliarencontrado);
                _appContexto.SaveChanges();
            }


        }

        public IEnumerable<Auxiliar> GetAllAuxiliar()
        {
            return _appContexto.Auxiliares;
        }

        public Auxiliar GetAuxiliar(string documento)
        {
            var auxiliarencontrado = _appContexto.Auxiliares.Where(x => x.documento == documento).FirstOrDefault();
            return auxiliarencontrado;
        }

        public Auxiliar UpdateAuxiliar(Auxiliar auxiliar)
        {
            var auxiliarencontrado = _appContexto.Auxiliares.Where(x => x.documento == auxiliar.documento).FirstOrDefault();
            if (auxiliarencontrado != null)
            {
                auxiliarencontrado.nombre =auxiliar.nombre;
                auxiliarencontrado.apellido = auxiliar.apellido;
                auxiliarencontrado.ciudad = auxiliar.ciudad;
                auxiliarencontrado.direccion = auxiliar.direccion;
                auxiliarencontrado.documento = auxiliar.documento;
                auxiliarencontrado.genero = auxiliar.genero;
                auxiliarencontrado.password = auxiliar.password;
                _appContexto.SaveChanges();
            }
            return auxiliarencontrado;
        }
    }
}