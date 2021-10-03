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
    public class ListPropietariosModel : PageModel
    {
private readonly IRepositorioPropietario iRepositorioPropietario;

        public IEnumerable<Propietario> propietarios;
        public ListPropietariosModel(IRepositorioPropietario iRepositorioPropietario)
        {
            this.iRepositorioPropietario= iRepositorioPropietario;
        }
        public void OnGet()
        {
            propietarios = iRepositorioPropietario.GetAllPropietario();
        }
    }
    
}
