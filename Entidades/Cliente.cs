using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Cliente
    {
        private int idCliente { get; set; }
        private string nombre { get; set; }
        private string apellidoPaterno { get; set; }
        private string apellidoMaterno { get; set; }
        private string dni { get; set; }
        private string telefono { get; set; }

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
