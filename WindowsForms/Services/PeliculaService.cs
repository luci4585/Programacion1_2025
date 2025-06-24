using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using WindowsForms.Models;

namespace WindowsForms.Services
{
    public class PeliculaService
    {
        string url = "https://cinesoftware-8275.restdb.io/rest/peliculas?apikey=510a2b7336a80665cf49419b623d4c4132ab0";

        public async Task<List<Pelicula>?> GetAllAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<Pelicula>>();
                }
                else
                {
                    throw new Exception("Error al obtener las películas");
                }
            }
        }
        public async Task<bool> DeleteAsync(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://cinesoftware-8275.restdb.io/rest/peliculas/{id}?apikey=510a2b7336a80665cf49419b623d4c4132ab0";

                var response = await client.DeleteAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al eliminar la película");
                }
            }
        }
        public async Task<bool> UpdateAsync(Pelicula pelicula)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://cinesoftware-8275.restdb.io/rest/peliculas/{pelicula._id}?apikey=510a2b7336a80665cf49419b623d4c4132ab0";
                var response = await client.PutAsJsonAsync(url, pelicula);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al actualizar la película");
                }
            }
        }
        public async Task<bool> AddAsync(Pelicula pelicula)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync(url, pelicula);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al agregar la película");
                }
            }
        }

    }
}
