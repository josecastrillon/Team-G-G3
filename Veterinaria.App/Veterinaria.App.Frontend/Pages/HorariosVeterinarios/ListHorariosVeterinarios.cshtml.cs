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
    public class ListHorariosVeterinariosModel : PageModel
    {
        private readonly IRepositorioHorarioVeterinario iRepositorioHorarioVeterinario;

        public IEnumerable<HorarioVeterinario> horariosveterinarios;
        public ListHorariosVeterinariosModel(IRepositorioHorarioVeterinario iRepositorioHorarioVeterinario)
        {
            this.iRepositorioHorarioVeterinario = iRepositorioHorarioVeterinario;
        }
        public void OnGet()
        {
           horariosveterinarios = iRepositorioHorarioVeterinario.GetAllHorarioVeterinarios();
        }
    }
}
