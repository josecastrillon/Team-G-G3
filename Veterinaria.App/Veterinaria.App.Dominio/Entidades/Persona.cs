using System;

namespace Veterinaria.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        public String documento { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String direccion { get; set; }
        public String telefono { get; set; }
        public String ciudad { get; set; }
        public String password { get; set; }
        public String tarjetaProfesional { get; set; }
        public Genero genero { get; set; }
    }
}