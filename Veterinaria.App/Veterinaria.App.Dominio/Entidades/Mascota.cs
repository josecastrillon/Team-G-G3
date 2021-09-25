using System;

namespace Veterinaria.App.Dominio
{
    public class Mascota
    {
        public int Id { get; set; }
        public String nombre { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public Propietario propietario { get; set; }
        public TipoMascota tipoMascota { get; set; }
    }
}