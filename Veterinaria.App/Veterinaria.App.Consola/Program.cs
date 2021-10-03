using System;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Consola
{
    class Program
    {
        public static IRepositorioTipoMascota _repoTipoMascota = new  RepositorioTipoMascota(new Persistencia.AppContexto());

        static void Main(string[] args)
        {
            
            //AddVeterinario();
            AddTipoMascota();
        }

        private static void AddTipoMascota (){
                
                TipoMascota ntipomascota = new TipoMascota{

                    clase ="gato",

                };

                _repoTipoMascota.AddTipoMascota(ntipomascota);
            }
    }
}
