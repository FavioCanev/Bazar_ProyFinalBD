using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Rol
    {
        private int idRol { get; set; }
        private string nombre { get; set; }
        private string descripcion { get; set; }
        private DateTime fechaCreacion { get; set; }

        //Constructores
        public Rol(int idRol, string nombre, string descripcion, DateTime fechaCreacion)
        {
            this.idRol = idRol;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.fechaCreacion = fechaCreacion;
        }

        public Rol(){}

    }
}
