using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Veterinaria.App.Persistencia;
using Veterinaria.App.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Veterinaria.App.Frontend.Veterinarios
{
    public class RemoveVeterinariosModel : PageModel
    {
        private readonly IRepositorioVeterinario iRepositorioVeterinario;

        public RemoveVeterinariosModel (IRepositorioVeterinario iRepositorioVeterinario){
            this.iRepositorioVeterinario = iRepositorioVeterinario;
        }
        public Veterinario veterinario { get; set; }
        public void OnGet(string documento)
        {
            veterinario= iRepositorioVeterinario.GetVeterinario(documento);
        }

        public IActionResult Onpost (Veterinario veterinario){

            
                iRepositorioVeterinario.DeleteVeterinario(veterinario.documento);
                return RedirectToPage("./ListVeterinarios");
            
            
            
        }
    }
}
