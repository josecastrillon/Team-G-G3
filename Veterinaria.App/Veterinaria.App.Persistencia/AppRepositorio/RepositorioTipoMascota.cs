using System;
using System.Collections.Generic;
using Veterinaria.App.Dominio;
using System.Linq;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioTipoMascota: IRepositorioTipoMascota
    {
        private readonly AppContexto _appContexto;

        public RepositorioTipoMascota(AppContexto _appContexto)
        {
            this._appContexto = _appContexto;
        }

        public TipoMascota AddTipoMascota(TipoMascota tipomascota)
        {
            
            var tipomascotaagregado = _appContexto.Add(tipomascota);
            _appContexto.SaveChanges();
            return tipomascotaagregado.Entity;

        }

        public void DeleteTipoMascota(int id)
        {
            TipoMascota tipomascotaencontrado = _appContexto.TiposMascotas.Where(x => x.Id == id).FirstOrDefault();
            if (tipomascotaencontrado!=null){
                _appContexto.Remove(tipomascotaencontrado);
                _appContexto.SaveChanges();
            }

        }

        public IEnumerable<TipoMascota> GetAllTipoMascota()
        {
            return _appContexto.TiposMascotas;
        }

        public TipoMascota GetTipoMascota(int id)
        {
            TipoMascota tipomascotaencontrado = _appContexto.TiposMascotas.Where(x => x.Id == id).FirstOrDefault();
            return tipomascotaencontrado;
        }

        public TipoMascota UpdateTipoMascota(TipoMascota tipomascota)
        {
            TipoMascota tipomascotaencontrado = _appContexto.TiposMascotas.Where(x => x.Id == tipomascota.Id).FirstOrDefault();
            if (tipomascotaencontrado != null)
            {
                tipomascotaencontrado.clase = tipomascota.clase;
                _appContexto.SaveChanges();
            }
            
            return tipomascotaencontrado;
        }
    }
}