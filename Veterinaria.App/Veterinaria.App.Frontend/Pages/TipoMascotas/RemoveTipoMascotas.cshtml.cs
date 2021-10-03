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
    public class RemoveTipoMascotasModel : PageModel
    {
        public TipoMascota tipomascota { get; set; }
        private readonly IRepositorioTipoMascota iRepositorioTipoMascota;
        public RemoveTipoMascotasModel(IRepositorioTipoMascota iRepositorioTipoMascota)
        {
            this.iRepositorioTipoMascota = iRepositorioTipoMascota;
        }
        public void OnGet(int id)
        {
            tipomascota = iRepositorioTipoMascota.GetTipoMascota(id);
        }

        public IActionResult Onpost (TipoMascota tipomascota)
        {
            iRepositorioTipoMascota.DeleteTipoMascota(tipomascota.Id);
            return RedirectToPage("./ListTipoMascotas");
        }
    }
}
