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
    public class AddPropietariosModel : PageModel
    {
        private readonly IRepositorioPropietario iRepositorioPropietario;

        public Propietario propietario;

        public AddPropietariosModel (IRepositorioPropietario iRepositorioPropietario)
        {
            this.iRepositorioPropietario = iRepositorioPropietario;
        }
        public void OnGet()
        {
            propietario = new Propietario ();
        }

        public IActionResult Onpost (Propietario propietario)
        {
            try{
                iRepositorioPropietario.AddPropietario(propietario);
            return RedirectToPage("./AddPropietarios");
            }
            catch{
                return RedirectToPage("../Error");
            }
        }
    }
}
