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
    public class PaisEFService
    {
        public async Task<List<Pais>?> GetAllAsync()
        {
            using (TareaCineContext cine = new TareaCineContext())
            {
                return await cine.Paises.ToListAsync();
            }
        }
        public async Task<bool> DeleteAsync(int? id)
        {
            using (TareaCineContext cine = new TareaCineContext())
            {
                var paisABorrar = await cine.Paises.FindAsync(id);
                paisABorrar.Eliminado = true; //marcamos la película como eliminada
                cine.Paises.Update(paisABorrar);
                var resultado = await cine.SaveChangesAsync();
                if (resultado > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al eliminar el país");
                }
            }
        }
        public async Task<bool> UpdateAsync(Pais pais)
        {
            using (TareaCineContext cine = new TareaCineContext())
            {
                cine.Paises.Update(pais);
                var resultado = await cine.SaveChangesAsync();
                if (resultado > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al actualizar el país");
                }
            }
        }
        public async Task<bool> AddAsync(Pais pais)
        {
            using (TareaCineContext cine = new TareaCineContext())
            {
               cine.Paises.Add(pais);
                var resultado = await cine.SaveChangesAsync();
                if (resultado > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Error al agregar el país");
                }
            }
        }

    }
}
