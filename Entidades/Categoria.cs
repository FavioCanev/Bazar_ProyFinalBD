using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Categoria
    {
        private int idCategoria { get; set; }
        private string nombre { get; set; }
        private string descripcion { get; set; }
        private bool estado { get; set; }

        // Constructores
        public Categoria(int idCategoria, string nombre, string descripcion, bool estado)
        {
            this.idCategoria = idCategoria;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.estado = estado;
        }
        public Categoria() { }
    }
}
