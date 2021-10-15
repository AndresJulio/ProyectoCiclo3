using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.FrontEnd
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
            services.AddRazorPages();
            services.AddSingleton<IRepositorioPersona>(new RepositorioPersona(new Contexto()));
            services.AddSingleton<IRepositorioVeterinario>(new RepositorioVeterinario(new Contexto()));
            services.AddSingleton<IRepositorioAuxiliar>(new RepositorioAuxiliar(new Contexto()));
            services.AddSingleton<IRepositorioDueño>(new RepositorioDueño(new Contexto()));
            services.AddSingleton<IRepositorioMascota>(new RepositorioMascota(new Contexto()));
            services.AddSingleton<IRepositorioPerro>(new RepositorioPerro(new Contexto()));
            services.AddSingleton<IRepositorioGato>(new RepositorioGato(new Contexto()));
            services.AddSingleton<IRepositorioCita>(new RepositorioCita(new Contexto()));
            services.AddSingleton<IRepositorioDiagnostico>(new RepositorioDiagnostico(new Contexto()));
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

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
