using System;

namespace Veterinaria.App.Dominio
{
    public class Anotacion
    {
                public int Id {get; set;}
                public HistoriaClinica historiaClinica {get; set;}
                public String descripcion {get; set;}

                public DateTime fechaCracion {get; set;}
    }
}