using System;
using System.Collections.Generic;
using Veterinaria.App.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota
    {
        private readonly AppContexto _appContexto;

        public RepositorioMascota(AppContexto _appContexto)
        {
            this._appContexto= _appContexto;
        }

        public Mascota AddMascota(Mascota mascota)
        {
            var mascotaagregada = _appContexto.Add(mascota).Entity;
            _appContexto.SaveChanges();
            return mascotaagregada;
        }

        public void DeleteMascotas(int Id)
        {
            Mascota mascotaencontrada = _appContexto.Mascotas.Where(c => c.Id == Id).FirstOrDefault();
            if(mascotaencontrada != null)
            {
                _appContexto.Remove(mascotaencontrada);
                _appContexto.SaveChanges();

            }
        }

        public IEnumerable<Mascota> GetAllMascotas()
        {
            return _appContexto.Mascotas.Include("propietario").Include("tipoMascota");
        }

        public Mascota GetMascota(int Id)
        {
            Mascota mascotaencontrada = _appContexto.Mascotas.Where(c => c.Id == Id).Include("propietario").Include("tipoMascota").FirstOrDefault();
            return mascotaencontrada;
        }

        public Mascota UpdateMascota(Mascota mascota)
        {
            Console.WriteLine("valor id "+mascota.Id);
            Mascota mascotaencontrada = _appContexto.Mascotas.Where(c => c.Id == mascota.Id).FirstOrDefault();
            Console.WriteLine("entre a update pero no al if");
            
            if (mascotaencontrada != null)
            {
                Console.WriteLine("Entre actualizar");
                mascotaencontrada.nombre = mascota.nombre;
                mascotaencontrada.fechaNacimiento = mascota.fechaNacimiento;
                mascotaencontrada.propietario = mascota.propietario;
                mascotaencontrada.tipoMascota= mascota.tipoMascota;
                _appContexto.SaveChanges();
            }
            
            return mascotaencontrada;
        }
    }
}