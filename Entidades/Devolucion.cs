using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Devolucion
    {
        private int idDevolucion { get; set; }
        private int idVenta { get; set; }
        private int idEmpleado { get; set; }
        private DateTime fecha { get; set; }
        private string motivo { get; set; }
        private double montoDevuelto { get; set; }
        //Constructores
        public Devolucion(int idDevolucion, int idVenta, int idEmpleado, DateTime fecha, string motivo, double montoDevuelto)
        {
            this.idDevolucion = idDevolucion;
            this.idVenta = idVenta;
            this.idEmpleado = idEmpleado;
            this.fecha = fecha;
            this.motivo = motivo;
            this.montoDevuelto = montoDevuelto;
        }
        public Devolucion() { }
    }
}
