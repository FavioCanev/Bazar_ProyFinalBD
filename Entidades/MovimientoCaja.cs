using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class MovimientoCaja
    {
        private int idMovimiento { get; set; }
        private int idUsuario { get; set; }
        private string tipo { get; set; }
        private double monto { get; set; }
        private DateTime fecha { get; set; }
        //Constructores
        public MovimientoCaja(int idMovimiento, int idUsuario, string tipo, double monto, DateTime fecha)
        {
            this.idMovimiento = idMovimiento;
            this.idUsuario = idUsuario;
            this.tipo = tipo;
            this.monto = monto;
            this.fecha = fecha;
        }
        public MovimientoCaja() { }
    }
}
