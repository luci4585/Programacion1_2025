using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using WindowsForms.Models;
using MySql.Data.MySqlClient;

namespace WindowsForms.Services
{
    public class PeliculaADOService
    {
        //connectionstring a mysql user root pass root
        string connectionString = "server=127.0.0.1;user=root;password=;database=programacion|_2025;";

        public async Task<List<Pelicula>?> GetAllAsync()
        {
            //obtenemos con ado.net desde mysql local con un MySqlConnection
            using (var connection = new MySqlConnection(connectionString))
            {
                await connection.OpenAsync();
                var command = new MySqlCommand("SELECT * FROM peliculas", connection);
                var reader = await command.ExecuteReaderAsync();
                List<Pelicula> peliculas = new List<Pelicula>();
                while (await reader.ReadAsync())
                {
                    Pelicula pelicula = new Pelicula
                    {
                        id = Convert.ToInt32(reader["id"]),
                        titulo = reader["titulo"].ToString(),
                        duracion = Convert.ToInt32(reader["duracion"]),
                        portada = reader["portada"].ToString(),
                        calificacion = Convert.ToDouble(reader["calificacion"])
                    };
                    peliculas.Add(pelicula);
                }
                return peliculas;
            }
        }
        public async Task<bool> DeleteAsync(string id)
        {
            return false;
        }
        public async Task<bool> UpdateAsync(Pelicula pelicula)
        {
            return false;
            
        }
        public async Task<bool> AddAsync(Pelicula pelicula)
        {
            return false;
        }

    }
}
