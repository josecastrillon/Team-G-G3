using System;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Consola
{
    class Program
    {
        public static IRepositorioVeterinario _repoVeterinario = new  RepositorioVeterinario(new Persistencia.AppContexto());

        static void Main(string[] args)
        {
            
            AddVeterinario();
        }

        private static void AddVeterinario (){
                
                Veterinario nveterinario = new Veterinario{

                    documento = "100",
                    nombre="Carlos",
                    apellido="Paez",
                    direccion = "Calle 1 No 2 3",
                    telefono = "5705000",
                    ciudad="Manizales",
                    genero = Genero.masculino,
                    tarjetaProfesional = "tp1"

                };

                _repoVeterinario.AddVeterinario(nveterinario);
            }
    }
}
