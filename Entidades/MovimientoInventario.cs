using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class MovimientoInventario
    {
        private int idMovimiento { get; set; }
        private int idProducto { get; set; }
        private int idUsuario { get; set; }
        private string tipoMovimiento { get; set; } // "Entrada" o "Salida"
        private int cantidad { get; set; }
        private string motivo { get; set; }
        private DateTime fecha { get; set; }

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
