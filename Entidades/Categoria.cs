using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        public int idCategoria { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public bool estado { get; set; }

        // Constructores
        public Categoria(int idCategoria, string nombre, string descripcion, bool estado)
        {
            this.idCategoria = idCategoria;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.estado = estado;
        }
        public Categoria()
        {
        }
    }
}
