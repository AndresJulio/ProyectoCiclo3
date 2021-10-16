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
        public Contexto contexto;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            contexto=new Contexto();
            services.AddRazorPages();
            services.AddSingleton<IRepositorioPersona>(new RepositorioPersona(contexto));
            services.AddSingleton<IRepositorioVeterinario>(new RepositorioVeterinario(contexto));
            services.AddSingleton<IRepositorioAuxiliar>(new RepositorioAuxiliar(contexto));
            services.AddSingleton<IRepositorioDueño>(new RepositorioDueño(contexto));
            services.AddSingleton<IRepositorioMascota>(new RepositorioMascota(contexto));
            services.AddSingleton<IRepositorioPerro>(new RepositorioPerro(contexto));
            services.AddSingleton<IRepositorioGato>(new RepositorioGato(contexto));
            services.AddSingleton<IRepositorioCita>(new RepositorioCita(contexto));
            services.AddSingleton<IRepositorioDiagnostico>(new RepositorioDiagnostico(contexto));
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
