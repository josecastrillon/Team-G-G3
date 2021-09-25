using Microsoft.EntityFrameworkCore;
using Veterinaria.App.Dominio;

namespace Veterinaria.App.Persistencia
{
    public class AppContexto : DbContext
    {

        public DbSet<Anotacion> Anotaciones { get; set; }
        public DbSet<Auxiliar> Auxiliares { get; set; }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<HistoriaClinica> HistoriasClinicas { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Propietario> Propietarios { get; set; }
        public DbSet<Receta> Recetas { get; set; }
        public DbSet<TipoMascota> TiposMascotas { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB; Initial Catalog = ClinicaVeterinaria");
        }

    }
}