using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        public int idEmpleado { get; set; }
        public int idRol { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string dni { get; set; }
        public string telefono { get; set; }
        public decimal sueldo { get; set; }
        public string estado { get; set; }
        public DateTime fechaContratacion { get; set; }

        //Constructores
        public Empleado(int idEmpleado, int idRol, string nombre, string apellidoPaterno, string apellidoMaterno, string dni, string telefono, decimal sueldo, string estado, DateTime fechaContratacion)
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
