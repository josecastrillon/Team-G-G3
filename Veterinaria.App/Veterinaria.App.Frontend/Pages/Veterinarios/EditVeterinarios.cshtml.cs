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
    public class EditVeterinariosModel : PageModel
    {

        private readonly IRepositorioVeterinario iRepositorioVeterinario;
        public Veterinario veterinario {get; set; }

        public EditVeterinariosModel (IRepositorioVeterinario iRepositorioVeterinario){
            this.iRepositorioVeterinario = iRepositorioVeterinario;
        }
        public void OnGet(string documento)
        {
            veterinario = iRepositorioVeterinario.GetVeterinario(documento);
        }

        public IActionResult Onpost (Veterinario veterinario)
        {
            try {
                iRepositorioVeterinario.UpdateVeterinario(veterinario);
                return RedirectToPage("./ListVeterinarios");
            }

            catch{
                return RedirectToPage("../Error");
            }

        }
    }
}
