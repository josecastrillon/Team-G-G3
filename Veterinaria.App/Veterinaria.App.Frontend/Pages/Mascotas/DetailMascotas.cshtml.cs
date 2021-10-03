using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Veterinaria.App.Persistencia;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Frontend.Pages
{

    public class DetailMascotasModel : PageModel
    {
        public Mascota mascota { get; set; }
        private readonly IRepositorioMascota iRepositorioMascota;

        public DetailMascotasModel (RepositorioMascota iRepositorioMascota)
        {
            this.iRepositorioMascota = iRepositorioMascota;
        }

        public void OnGet(int id)
        {
            mascota = iRepositorioMascota.GetMascota(id);
        }
    }
}
