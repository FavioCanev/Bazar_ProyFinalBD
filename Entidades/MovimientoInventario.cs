using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MovimientoInventario
    {
        public int idMovimiento { get; set; }
        public int idProducto { get; set; }
        public int idUsuario { get; set; }
        public string tipoMovimiento { get; set; } // "Entrada" o "Salida"
        public int cantidad { get; set; }
        public string motivo { get; set; }
        public DateTime fecha { get; set; }

        //Constructores
        public MovimientoInventario (int idMovimiento, int idProducto, int idUsuario, string tipoMovimiento, int cantidad, string motivo, DateTime fecha)
        {
            this.idMovimiento = idMovimiento;
            this.idProducto = idProducto;
            this.idUsuario = idUsuario;
            this.tipoMovimiento = tipoMovimiento;
            this.cantidad = cantidad;
            this.motivo = motivo;
            this.fecha = fecha;
        }
        public MovimientoInventario() { }
    }
}
