using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Veterinaria.App.Persistencia;
using Veterinaria.App.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.App.Frontend.Pages
{
    public class ListHorariosModel : PageModel
    {

        private readonly IRepositorioHorarios iRepositorioHorarios;

        public IEnumerable<Horario> horarios;
        public ListHorariosModel(IRepositorioHorarios iRepositorioHorarios)
        {
            this.iRepositorioHorarios = iRepositorioHorarios;
        }
        public void OnGet()
        {
           horarios = iRepositorioHorarios.GetAllHorarios();
        }
    }
}
