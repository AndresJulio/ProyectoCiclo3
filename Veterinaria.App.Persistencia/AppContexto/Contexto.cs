using Microsoft.EntityFrameworkCore;
using Veterinaria.App.Dominio;
namespace Veterinaria.App.Persistencia{
    public class Contexto:DbContext{
        public DbSet<Persona> personas{get; set;}
        public DbSet<Veterinario> veterinarios{get; set;}
        public DbSet<Auxiliar> auxiliares{get; set;}
        public DbSet<Dueño> dueños{get; set;}
        public DbSet<Mascota> mascotas{get; set;}
        public DbSet<Perro> perros{get; set;}
        public DbSet<Gato> gatos{get; set;}
        public DbSet<Cita> citas{get; set;}
        public DbSet<Diagnostico> diagnosticos{get; set;}

         protected override void OnConfiguring(DbContextOptionsBuilder opciones){
            if(!opciones.IsConfigured)
            {
            opciones.UseSqlServer("Data Source= (localdb)\\MSSQLLocalDB;Initial Catalog=Veterinaria");
            }
        }

        
    }
}