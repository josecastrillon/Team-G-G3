using System;

namespace Veterinaria.App.Dominio
{
    public class Veterinario:Persona
    {
               public ICollection<Horario> Horario { get; set; } 
    }
}