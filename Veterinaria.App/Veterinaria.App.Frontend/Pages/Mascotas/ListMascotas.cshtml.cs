using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Veterinaria.App.Persistencia;
using Veterinaria.App.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace Veterinaria.App.Frontend.Pages
{
    public class ListMascotasModel : PageModel
    {

        private readonly IRepositorioMascota iRepositorioMascota;

        public IEnumerable<Mascota> mascotas;
        public ListMascotasModel(IRepositorioMascota iRepositorioMascota)
        {
            this.iRepositorioMascota = iRepositorioMascota;
        }
        public void OnGet()
        {
           mascotas = iRepositorioMascota.GetAllMascotas();
        }
    }
}
