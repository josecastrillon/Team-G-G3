using System.Collections.Generic;
using System;
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
            throw new NotImplementedException();
        }

        public IEnumerable<Auxiliar> GetAllAuxiliar()
        {
            throw new NotImplementedException();
        }

        public Auxiliar GetAuxiliar(Auxiliar auxiliar)
        {
            throw new NotImplementedException();
        }

        public Auxiliar UpdateAuxiliar(Auxiliar auxiliar)
        {
            throw new NotImplementedException();
        }
    }
}