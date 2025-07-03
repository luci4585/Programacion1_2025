using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Models
{
    public class Pelicula
    {
        public string? _id { get; set; }
        public int? id { get; set; }
        public string titulo { get; set; }
        public int duracion { get; set; }
        public string portada { get; set; }
        public double calificacion { get; set; }
        public int? PaisId { get; set; }
        public Pais Pais { get; set; }
        public bool Eliminado { get; set; }
    }
}
