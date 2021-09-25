using System;

namespace Veterinaria.App.Dominio
{
    public class Horario
    {
        public int Id { get; set; }
        public DateTime horaInicio { get; set; }
        public DateTime horaFin { get; set; }
    }
}