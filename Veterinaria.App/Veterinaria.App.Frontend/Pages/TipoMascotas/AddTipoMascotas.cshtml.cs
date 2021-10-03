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

    public class AddTipoMascotasModel : PageModel
    {
    private readonly IRepositorioTipoMascota iRepositorioTipoMascota;

    public TipoMascota tipomascota { get;set;}

    public AddTipoMascotasModel (IRepositorioTipoMascota iRepositorioTipoMascota)
    {
        this.iRepositorioTipoMascota = iRepositorioTipoMascota;
    }
        public void OnGet()
        {
            tipomascota = new TipoMascota();
        }
        public IActionResult Onpost(TipoMascota tipomascota)
        
        {
            try{
                iRepositorioTipoMascota.AddTipoMascota(tipomascota);
                return RedirectToPage("./AddTipoMascotas");
            }

            catch{
                return RedirectToPage("./Error");
            }
        }
    }
}
