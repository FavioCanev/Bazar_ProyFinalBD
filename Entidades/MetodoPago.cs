using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MetodoPago
    {
        public int idMetodoPago { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        //Constructores
        public MetodoPago(int idMetodoPago, string nombre, string descripcion)
        {
            this.idMetodoPago = idMetodoPago;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
        public MetodoPago() { }
    }
}
