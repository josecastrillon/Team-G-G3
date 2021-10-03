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
    public class ListTiposMascotasModel : PageModel
    {

        private readonly IRepositorioTipoMascota iRepositorioTipoMascota;

        public IEnumerable<TipoMascota> tipomascotas;
        public ListTiposMascotasModel(IRepositorioTipoMascota iRepositorioTipoMascota)
        {
            this.iRepositorioTipoMascota= iRepositorioTipoMascota;
        }
        public void OnGet()
        {
            tipomascotas = iRepositorioTipoMascota.GetAllTipoMascota();
        }
    }
}
