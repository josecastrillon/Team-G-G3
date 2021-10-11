using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioCita : IRepositorioCita
    {
        private readonly AppContexto _appContexto;

        public RepositorioCita(AppContexto appContexto)
        {
            this._appContexto = appContexto;
        }
        public Cita AddCita(Cita cita)
        {
            var citaagregada = _appContexto.Add(cita).Entity;
            _appContexto.SaveChanges();
            return citaagregada;
        }

        public void DeleteCita(int Id)
        {
            var citaencontrada = _appContexto.Citas.Where(x => x.Id == Id).FirstOrDefault();
            _appContexto.Remove(citaencontrada);
            _appContexto.SaveChanges();
        }

        public IEnumerable<Cita> GetAllCitas()
        {
            return _appContexto.Citas;
        }

        public Cita GetCita(int Id)
        {
            var citaencontrada = _appContexto.Citas.Where(x => x.Id == Id).FirstOrDefault();
            return citaencontrada;
        }

        public Cita UpdateCita(Cita cita)
        {
            var citaencontrada = _appContexto.Citas.Where(x => x.Id == cita.Id).FirstOrDefault();
            if (citaencontrada != null)
            {
                citaencontrada.mascota =cita.mascota;
                citaencontrada.fechaConsulta = cita.fechaConsulta;
                citaencontrada.veterinario = cita.veterinario;
                _appContexto.SaveChanges();
            }
            return citaencontrada;
        }
    }
}