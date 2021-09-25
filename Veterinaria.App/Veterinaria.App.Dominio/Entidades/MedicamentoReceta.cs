using System;

namespace Veterinaria.App.Dominio
{
    public class MedicamentoReceta
    {
        public int Id { get; set; }
        public Medicamento medicamento { get; set; }
        public Receta receta { get; set; }
    }
}