using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Veterinaria.App.Persistencia;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Veterinaria.App.Frontend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages(
                options => {
                    options.Conventions.AuthorizeFolder("/Veterinarios");
                    options.Conventions.AuthorizeFolder("/Mascotas");
                    options.Conventions.AuthorizeFolder("/Horarios");
                    options.Conventions.AuthorizeFolder("/HorariosVeterinarios");
                    options.Conventions.AuthorizeFolder("/Propietarios");
                    options.Conventions.AuthorizeFolder("/TipoMascotas");
                }
            );
            AppContexto _contexto = new AppContexto();
            services.AddSingleton<IRepositorioVeterinario>(new RepositorioVeterinario(_contexto));
            services.AddSingleton<IRepositorioMascota>(new RepositorioMascota(_contexto));
            services.AddSingleton<IRepositorioTipoMascota>(new RepositorioTipoMascota(_contexto));
            services.AddSingleton<IRepositorioPropietario>(new RepositorioPropietario(_contexto));
            services.AddSingleton<IRepositorioHorarios>(new RepositorioHorarios(_contexto));
            services.AddSingleton<IRepositorioHorarioVeterinario>(new RepositorioHorarioVeterinario(_contexto));
            services.AddSingleton<IRepositorioAuxiliar>(new RepositorioAuxiliar(_contexto));
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name:"default",
                    pattern:"{controllor=Conference}/{action=Index}/{id?}"
                );
                endpoints.MapRazorPages();
            });
        }
    }
}
