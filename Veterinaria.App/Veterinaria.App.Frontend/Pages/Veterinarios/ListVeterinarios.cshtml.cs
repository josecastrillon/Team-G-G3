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
    public class ListVeterinariosModel : PageModel
    {

        private readonly IRepositorioVeterinario iRepositorioVeterinario;
        public IEnumerable<Veterinario> veterinarios;

        public ListVeterinariosModel(IRepositorioVeterinario iRepositorioVeterinario)
        {
            this.iRepositorioVeterinario = iRepositorioVeterinario;
        }
        public void OnGet()
        {
            veterinarios = iRepositorioVeterinario.GetAllVeterinario();
        }
    }
}
