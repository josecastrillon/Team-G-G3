using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Veterinaria.App.Persistencia;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Frontend.Pages
{
    public class AddMascotasModel : PageModel
    {   
        private readonly IRepositorioMascota iRepositorioMascota;
        private readonly IRepositorioPropietario iRepositorioPropietario;

        private readonly IRepositorioTipoMascota iRepositorioTipoMascota;

        public Mascota mascota { get; set; }
        public int Idtipomascota { get; set; }
        public string documentopropietario { get; set; }

        public IEnumerable <SelectListItem> propietarios { get; set; }
        public IEnumerable <SelectListItem> idtipomascota { get; set; }
        public IEnumerable <SelectListItem> tipomascota { get; set; }

        public AddMascotasModel(IRepositorioMascota iRepositorioMascota, IRepositorioTipoMascota iRepositorioTipoMascota, IRepositorioPropietario iRepositorioPropietario)
        {
            this.iRepositorioMascota = iRepositorioMascota;
            this.iRepositorioPropietario = iRepositorioPropietario;
            this.iRepositorioTipoMascota = iRepositorioTipoMascota;
        }
        

        public void OnGet()
        {
            
            mascota = new Mascota();
            
            tipomascota = iRepositorioTipoMascota.GetAllTipoMascota().Select(
                m => new SelectListItem
                {
                    Value = Convert.ToString(m.Id),
                    Text = m.clase,
                    }
                    ).ToList();
            propietarios = iRepositorioPropietario.GetAllPropietario().Select(
                m => new SelectListItem
                {
                    Value = m.documento,
                    Text = m.nombre+" "+ m.apellido,
                    }
                    ).ToList();
       
    }

     public IActionResult OnPost(Mascota mascota, int idtipomascota, string documentopropietario)
        {
            if (ModelState.IsValid)
            {
                TipoMascota tipomascota = iRepositorioTipoMascota.GetTipoMascota(idtipomascota);
                Propietario propietario = iRepositorioPropietario.GetPropietario(documentopropietario);

                try
                {
                    iRepositorioMascota.AddMascota(mascota);
                    mascota.tipoMascota = tipomascota;
                    mascota.propietario = propietario;
                    iRepositorioMascota.UpdateMascota(mascota);
                    return RedirectToPage("./ListMascotas");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return RedirectToPage("../Error");
                }
            }
            else
            {
                return Page();
            }

        }
}

}