using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Empleado
    {
        private int idEmpleado { get; set; }
        private int idRol { get; set; }
        private string nombre { get; set; }
        private string apellidoPaterno { get; set; }
        private string apellidoMaterno { get; set; }
        private string dni { get; set; }
        private string telefono { get; set; }
        private double sueldo { get; set; }
        private string estado { get; set; }
        private DateTime fechaContratacion { get; set; }

        //Constructores
        public Empleado(int idEmpleado, int idRol, string nombre, string apellidoPaterno, string apellidoMaterno, string dni, string telefono, double sueldo, string estado, DateTime fechaContratacion)
        {
            this.idEmpleado = idEmpleado;
            this.idRol = idRol;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.dni = dni;
            this.telefono = telefono;
            this.sueldo = sueldo;
            this.estado = estado;
            this.fechaContratacion = fechaContratacion;
        }

        public Empleado() { }

    }
}
