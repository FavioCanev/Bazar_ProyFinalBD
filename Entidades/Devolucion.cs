using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Devolucion
    {
        public int idDevolucion { get; set; }
        public int idVenta { get; set; }
        public int idEmpleado { get; set; }
        public DateTime fecha { get; set; }
        public string motivo { get; set; }
        public decimal montoDevuelto { get; set; }
        //Constructores
        public Devolucion(int idDevolucion, int idVenta, int idEmpleado, DateTime fecha, string motivo, decimal montoDevuelto)
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
