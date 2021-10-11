using System;
using System.Collections.Generic;
using Veterinaria.App.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioHorarioVeterinario : IRepositorioHorarioVeterinario
    {
        private readonly AppContexto _appContexto;

        public RepositorioHorarioVeterinario(AppContexto _appContexto)
        {
            this._appContexto= _appContexto;
        }

        public HorarioVeterinario AddHorarioVeterinario(HorarioVeterinario HorarioVeterinario)
        {
            var HorarioVeterinarioagregada = _appContexto.Add(HorarioVeterinario).Entity;
            _appContexto.SaveChanges();
            return HorarioVeterinarioagregada;
        }

        public void DeleteHorarioVeterinarios(int Id)
        {
            HorarioVeterinario HorarioVeterinarioencontrada = _appContexto.HorariosVeterinarios.Where(c => c.Id == Id).FirstOrDefault();
            if(HorarioVeterinarioencontrada != null)
            {
                _appContexto.Remove(HorarioVeterinarioencontrada);
                _appContexto.SaveChanges();

            }
        }

        public IEnumerable<HorarioVeterinario> GetAllHorarioVeterinarios()
        {
            return _appContexto.HorariosVeterinarios.Include("propietario").Include("horario");
        }

        public HorarioVeterinario GetHorarioVeterinario(int Id)
        {
            HorarioVeterinario HorarioVeterinarioencontrada = _appContexto.HorariosVeterinarios.Where(c => c.Id == Id).Include("propietario").Include("horario").FirstOrDefault();
            return HorarioVeterinarioencontrada;
        }

        public HorarioVeterinario UpdateHorarioVeterinario(HorarioVeterinario HorarioVeterinario)
        {
            
            HorarioVeterinario HorarioVeterinarioencontrada = _appContexto.HorariosVeterinarios.Where(c => c.Id == HorarioVeterinario.Id).FirstOrDefault();
            
            
            if (HorarioVeterinarioencontrada != null)
            {
                
                HorarioVeterinarioencontrada.veterinario = HorarioVeterinario.veterinario;
                HorarioVeterinarioencontrada.horario = HorarioVeterinario.horario;
                _appContexto.SaveChanges();
            }
            
            return HorarioVeterinarioencontrada;
        }
    }
}