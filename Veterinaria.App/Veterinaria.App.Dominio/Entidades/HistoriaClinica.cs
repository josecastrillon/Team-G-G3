using System;

namespace Veterinaria.App.Dominio
{
    public class HistoriaClinica
    {
        public int Id { get; set; }
        public Mascota mascota { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaActualizacion { get; set; }
    }
}