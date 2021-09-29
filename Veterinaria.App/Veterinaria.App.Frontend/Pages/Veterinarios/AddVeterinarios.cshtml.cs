using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Veterinaria.App.Persistencia;
using Veterinaria.App.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Veterinaria.App.Frontend.Pages
{
    public class AddVeterinariosModel : PageModel
    {

        private readonly IRepositorioVeterinario iRepositorioVeterinario;

        public AddVeterinariosModel (IRepositorioVeterinario iRepositorioVeterinario){
            this.iRepositorioVeterinario = iRepositorioVeterinario;
        }
        public Veterinario veterinario { get; set; }
        public void OnGet()
        {
            veterinario = new Veterinario ();
        }

        public IActionResult Onpost (Veterinario veterinario){

            try{

                iRepositorioVeterinario.AddVeterinario(veterinario);
                return RedirectToPage("./AddVeterinarios");
            }
            catch{
                return RedirectToPage("./Error");
            }
        }
    }
}
