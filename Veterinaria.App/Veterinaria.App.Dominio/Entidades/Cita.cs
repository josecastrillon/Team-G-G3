using System;

namespace Veterinaria.App.Dominio
{
    public class Cita
    {
        public int Id { get; set; }
        public DateTime fechaConsulta { get; set; }
        public Mascota mascota { get; set; }

        public Veterinario veterinario { get; set; }

    }
}