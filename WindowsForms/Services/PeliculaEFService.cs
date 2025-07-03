using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using WindowsForms.Models;
using WindowsForms.DataContex;
using Microsoft.EntityFrameworkCore;

namespace WindowsForms.Services
{
    public class PeliculaEFService
    {
        public async Task<List<Pelicula>?> GetAllAsync()
        {
            using (CineContext cine = new CineContext())
            {
                return await cine.Peliculas.Include(p=>p.Pais).ToListAsync();
            }
        }
        public async Task<bool> DeleteAsync(int? id)
        {
            using (CineContext cine = new CineContext())
            {
                var peliculaABorrar = await cine.Peliculas.FindAsync(id);
                peliculaABorrar.Eliminado = true; //marcamos la película como eliminada
                cine.Peliculas.Update(peliculaABorrar);
                var resultado = await cine.SaveChangesAsync();
                if (resultado > 0)
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
            using (CineContext cine = new CineContext())
            {
                cine.Peliculas.Update(pelicula);
                var resultado = await cine.SaveChangesAsync();
                if (resultado > 0)
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
            using (CineContext cine = new CineContext())
            {
               cine.Peliculas.Add(pelicula);
                var resultado = await cine.SaveChangesAsync();
                if (resultado > 0)
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
