using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public string dni { get; set; }
        public string telefono { get; set; }

        //Constructores
        public Cliente(int idCliente, string nombre, string apellidoPaterno, string apellidoMaterno, string dni, string telefono)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.apellidoPaterno = apellidoPaterno;
            this.apellidoMaterno = apellidoMaterno;
            this.dni = dni;
            this.telefono = telefono;
        }
        public Cliente() { }
    }
}
