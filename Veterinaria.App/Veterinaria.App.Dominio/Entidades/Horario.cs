using System;
using System.ComponentModel.DataAnnotations;

namespace Veterinaria.App.Dominio
{
    public class Horario
    {
        public int Id { get; set; }
        public DiaSemana diaSemana { get; set; }
        
        public DateTime horaInicio { get; set; }
        
        public DateTime horaFin { get; set; }
        

        
    }
}