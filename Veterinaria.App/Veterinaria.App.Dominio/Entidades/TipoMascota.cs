using System;
using System.ComponentModel.DataAnnotations;

namespace Veterinaria.App.Dominio
{
    public class TipoMascota
    {
        public int Id { get; set; }
        [Required(ErrorMessage="El campo es obligatorio")]
        public String clase { get; set; }
    }
}