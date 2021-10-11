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

    public class AddHorariosModel : PageModel
    {
    private readonly IRepositorioHorarios iRepositorioHorarios;

    public Horario horario { get;set;}

    public AddHorariosModel (IRepositorioHorarios iRepositorioHorarios)
    {
        this.iRepositorioHorarios = iRepositorioHorarios;
    }
        public void OnGet()
        {
            horario = new Horario();
        }
        public IActionResult Onpost(Horario horario)
        
        {
            try{
                Console.WriteLine("hora inicio"+horario.horaInicio);
                iRepositorioHorarios.AddHorario(horario);
                return RedirectToPage("./AddHorarios");
            }

            catch{
                return RedirectToPage("./Error");
            }
        }
    }
}