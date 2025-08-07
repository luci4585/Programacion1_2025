using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WindowsForms.Models;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.EntityFrameworkCore.Design;

namespace WindowsForms.DataContex
{
    public class CineContext : DbContext
    {
        //Define DbSet properties for each entity type
        public virtual DbSet<Pelicula> Peliculas { get; set; }
        public virtual DbSet<Pais> Paises { get; set; }

        public CineContext() 
        { 

        }
        public CineContext(DbContextOptions<CineContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the database connection string here
            if (!optionsBuilder.IsConfigured)
            {
                //creamos una cadena de conexión para el mysql local
                string cnn = "server=127.0.0.1;database=cinecontext;user=root;password=;SslMode=none;";
                optionsBuilder.UseMySql(cnn, ServerVersion.AutoDetect(cnn));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pais>().HasData(
                new Pais { Id = 1, Nombre = "Estados Unidos", Eliminado = false },
                new Pais { Id = 2, Nombre = "Reino Unido", Eliminado = false },
                new Pais { Id = 3, Nombre = "Alemania", Eliminado = false },
                new Pais { Id = 4, Nombre = "Francia", Eliminado = false },
                new Pais { Id = 5, Nombre = "Italia", Eliminado = false },
                new Pais { Id = 6, Nombre = "España", Eliminado = false },
                new Pais { Id = 7, Nombre = "Japón", Eliminado = false },
                new Pais { Id = 8, Nombre = "Canadá", Eliminado = false },
                new Pais { Id = 9, Nombre = "Australia", Eliminado = false },
                new Pais { Id = 10, Nombre = "México", Eliminado = false }
            );
            // Datos semilla para 10 películas
            modelBuilder.Entity<Pelicula>().HasData(

                new Pelicula 
                { 
                  _id = "1", id = 1, 
                  titulo = "El Padrino", 
                  duracion = 175, 
                  portada = "https://ejemplo.com/portadas/el_padrino.jpg", 
                  calificacion = 9.2, 
                  Eliminado = false,
                  PaisId = 6,
                },

                new Pelicula 
                { 
                  _id = "2", id = 2, 
                  titulo = "Pulp Fiction", 
                  duracion = 154, 
                  portada = "https://ejemplo.com/portadas/pulp_fiction.jpg", 
                  calificacion = 8.9, 
                  Eliminado = false,
                  PaisId = 8,
                },
                new Pelicula 
                { 
                  _id = "3", id = 3, 
                  titulo = "Forrest Gump", 
                  duracion = 142, 
                  portada = "https://ejemplo.com/portadas/forrest_gump.jpg", 
                  calificacion = 8.8, 
                  Eliminado = false,
                  PaisId = 6,
                },
                new Pelicula 
                { 
                  _id = "4", id = 4, 
                  titulo = "La lista de Schindler", 
                  duracion = 195, 
                  portada = "https://ejemplo.com/portadas/schindler.jpg", 
                  calificacion = 8.9, 
                  Eliminado = false,
                  PaisId = 2,
                },
                new Pelicula 
                { 
                  _id = "5", id = 5, 
                  titulo = "El Señor de los Anillos: El Retorno del Rey",
                  duracion = 201, portada = "https://ejemplo.com/portadas/lotr_rey.jpg",
                  calificacion = 8.9, 
                  Eliminado = false,
                  PaisId = 6
                },
                new Pelicula 
                { 
                  _id = "6", id = 6, 
                  titulo = "Inception", 
                  duracion = 148, 
                  portada = "https://ejemplo.com/portadas/inception.jpg", 
                  calificacion = 8.8, 
                  Eliminado = false,
                  PaisId = 6
                },
                new Pelicula 
                { 
                  _id = "7", id = 7, 
                  titulo = "Fight Club", 
                  duracion = 139, 
                  portada = "https://ejemplo.com/portadas/fight_club.jpg", 
                  calificacion = 8.8, 
                  Eliminado = false,
                  PaisId = 8
                },
                new Pelicula 
                { 
                  _id = "8", id = 8, 
                  titulo = "Interstellar", 
                  duracion = 169, 
                  portada = "https://ejemplo.com/portadas/interstellar.jpg", 
                  calificacion = 8.6, 
                  Eliminado = false,
                  PaisId = 8
                },
                new Pelicula 
                { 
                  _id = "9", id = 9, 
                  titulo = "Gladiator", 
                  duracion = 155, 
                  portada = "https://ejemplo.com/portadas/gladiator.jpg", 
                  calificacion = 8.5, 
                  Eliminado = false,
                  PaisId = 2
                },
                new Pelicula 
                { 
                  _id = "10", id = 10, 
                  titulo = "Matrix", 
                  duracion = 136, 
                  portada = "https://ejemplo.com/portadas/matrix.jpg", 
                  calificacion = 8.7, 
                  Eliminado = false,
                  PaisId = 2
                }

            );
            // Datos semilla para 10 países


            //configuramos las querys para que no se muestren los eliminados
            modelBuilder.Entity<Pelicula>().HasQueryFilter(p => !p.Eliminado);
            modelBuilder.Entity<Pais>().HasQueryFilter(p => !p.Eliminado);
        }
    }
}
