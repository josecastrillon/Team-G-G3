using System;
using System.ComponentModel.DataAnnotations;

namespace Veterinaria.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }
        [Required(ErrorMessage="El campo es obligatorio"),Range(0,int.MaxValue,ErrorMessage="La cedula debe ser mayor que 0"),RegularExpression(@"^\S*$",ErrorMessage="No se admiten espacios")]
        public String documento { get; set; }
        [Required(ErrorMessage="El campo es obligatorio")]
        public String nombre { get; set; }
        [Required(ErrorMessage="El campo es obligatorio")]
        public String apellido { get; set; }
        [Required(ErrorMessage="El campo es obligatorio")]
        public String direccion { get; set; }
        [Required(ErrorMessage="El campo es obligatorio")]
        public String telefono { get; set; }
        [Required(ErrorMessage="El campo es obligatorio")]
        public String ciudad { get; set; }
        [Required(ErrorMessage="El campo es obligatorio"), DataType(DataType.Password)]
        public String password { get; set; }
        [Required(ErrorMessage="El campo es obligatorio")]
        
        public Genero genero { get; set; }
    }
}