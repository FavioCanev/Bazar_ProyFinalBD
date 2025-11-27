using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MovimientoCaja
    {
        public int idMovimiento { get; set; }
        public int idUsuario { get; set; }
        public string tipo { get; set; }
        public decimal monto { get; set; }
        public DateTime fecha { get; set; }
        //Constructores
        public MovimientoCaja(int idMovimiento, int idUsuario, string tipo, decimal monto, DateTime fecha)
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
