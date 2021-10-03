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
    

    
    public class DetailVeterinariosModel : PageModel
    {
        private readonly IRepositorioVeterinario iRepositorioVeterinario;

        public Veterinario veterinario { get; set; }
        public DetailVeterinariosModel(IRepositorioVeterinario iRepositorioVeterinario){
            this.iRepositorioVeterinario =iRepositorioVeterinario;
        }
        public void OnGet(string documento)
        {
            veterinario = iRepositorioVeterinario.GetVeterinario(documento);
        }
    }
}
