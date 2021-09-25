using System;

namespace Veterinaria.App.Dominio
{
    public class Receta
    {
        public int Id { get; set; }
        public Anotacion anotacion { get; set; }
    }
}