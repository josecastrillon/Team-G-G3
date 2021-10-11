using System;
using System.Collections.Generic;
using System.Linq;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioHorarios : IRepositorioHorarios
    {
        private readonly AppContexto _appContexto;
        public RepositorioHorarios(AppContexto appContexto)
        {
            this._appContexto = appContexto;
        }
        public Horario AddHorario(Horario horario)
        {
            var horarioagregado = _appContexto.Add(horario).Entity;
            _appContexto.SaveChanges();
            Console.WriteLine("horain"+horario.horaInicio);
            return horarioagregado;

        }

        public void DeleteHorario(int id)
        {
            var horarioencontrado = _appContexto.Horarios.Where(x => x.Id == id).FirstOrDefault();
            _appContexto.Horarios.Remove(horarioencontrado);
            _appContexto.SaveChanges();
        }

        public IEnumerable<Horario> GetAllHorarios()
        {
            return _appContexto.Horarios;
        }

        public Horario GetHorario(int id)
        {
            var horarioencontrado = _appContexto.Horarios.Where(x => x.Id == id).FirstOrDefault();
            return horarioencontrado;
        }

        public Horario UpdateHorario(Horario horario)
        {
            var horarioencontrado = _appContexto.Horarios.Where(x => x.Id == horario.Id).FirstOrDefault();
            if (horarioencontrado != null){
                horarioencontrado.horaInicio = horario.horaInicio;
                horarioencontrado.horaFin = horario.horaFin;
                horarioencontrado.diaSemana = horario.diaSemana;
                _appContexto.SaveChanges();
            }
            return horarioencontrado;
        }
    }
}