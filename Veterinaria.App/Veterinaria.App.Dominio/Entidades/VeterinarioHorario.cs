using System;

namespace Veterinaria.App.Dominio
{
    public class VeterinarioHorario
    {
        public int Id { get; set; }
        public Horario horario { get; set; }
        public Veterinario veterinario { get; set; }
    }

}