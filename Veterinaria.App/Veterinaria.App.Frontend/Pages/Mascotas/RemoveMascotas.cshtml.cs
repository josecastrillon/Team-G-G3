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
    public class RemoveMascotasModel : PageModel
    {
        private readonly IRepositorioMascota iRepositorioMascota;

        public Mascota mascota { get; set; }
        public RemoveMascotasModel(IRepositorioMascota iRepositorioMascota)
        {
            this.iRepositorioMascota = iRepositorioMascota;
        }
        public void OnGet(int id)
        {
             mascota = iRepositorioMascota.GetMascota(id);
        }

        public IActionResult Onpost (Mascota mascota){

            
                iRepositorioMascota.DeleteMascotas(mascota.Id);
                return RedirectToPage("./ListMascotas");
            
            
            
        }
    }
}
