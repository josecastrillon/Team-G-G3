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
    public class DetailPropietariosModel : PageModel
    {
        public Propietario propietario;
        private readonly IRepositorioPropietario iRepositorioPropietario;

        public DetailPropietariosModel (IRepositorioPropietario iRepositorioPropietario)
        {
            this.iRepositorioPropietario = iRepositorioPropietario;
        }
        public void OnGet(string documento)
        {
            propietario = iRepositorioPropietario.GetPropietario(documento);
        }
    }
}
