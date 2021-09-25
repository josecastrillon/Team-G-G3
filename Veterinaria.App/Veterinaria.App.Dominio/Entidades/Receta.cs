using System;

namespace Veterinaria.App.Dominio
{
    public class Receta
    {
        public int Id { get; set; }
        public Anotacion anotacion { get; set; }
        public ICollection<Medicamento> Medicamento { get; set; }
    }
}