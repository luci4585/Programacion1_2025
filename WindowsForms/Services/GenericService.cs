using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms.DataContex;
using WindowsForms.Interfaces;

namespace WindowsForms.Services
{
    internal class GenericService<T> : IGenericService<T> where T : class
    {
        
        public Task<T?> AddAsync(T? entity)
        {
            using (CineContext context = new CineContext())
            {
                if (entity == null)
                {
                    throw new ArgumentNullException(nameof(entity), "Entity cannot be null");
                }
                context.Set<T>().Add(entity);
                var result = context.SaveChangesAsync();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("No se pudo insertar el registro");
                }
            }
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>?> GetAllAsync(string? filtro)
        {
            throw new NotImplementedException();
        }

        public Task<T?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T? entity)
        {
            throw new NotImplementedException();
        }
    }
}
