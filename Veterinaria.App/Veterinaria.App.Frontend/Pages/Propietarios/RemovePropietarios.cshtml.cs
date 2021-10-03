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
    public class RemovePropietariosModel : PageModel
    {
        private readonly IRepositorioPropietario iRepositorioPropietario;
        public Propietario propietario { get; set; }
        
        public RemovePropietariosModel(IRepositorioPropietario iRepositorioPropietario)
        {
            this.iRepositorioPropietario = iRepositorioPropietario;
        }
        public void OnGet(string documento)
        {
            propietario = iRepositorioPropietario.GetPropietario(documento);
        }

        public IActionResult Onpost (Propietario propietario)
        {
            iRepositorioPropietario.DeletePropietario(propietario.documento);
            return RedirectToPage("./ListPropietarios");
        }
    }
}
