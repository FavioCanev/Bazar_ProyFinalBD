using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class MetodoPago
    {
        private int idMetodoPago { get; set; }
        private string nombre { get; set; }
        private string descripcion { get; set; }

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
