using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rol
    {
        public int idRol { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaCreacion { get; set; }

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
