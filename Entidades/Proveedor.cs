using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Proveedor
    {
        private int idProveedor { get; set; }
        private string nombre { get; set; }
        private string ruc { get; set; }
        private string direccion { get; set; }
        private string estado { get; set; }
        private DateTime fechaRegistro { get; set; }


        //Constructores
        public Proveedor(int idProveedor, string nombre, string ruc, string direccion, string estado, DateTime fechaRegistro)
        {
            this.idProveedor = idProveedor;
            this.nombre = nombre;
            this.ruc = ruc;
            this.direccion = direccion;
            this.estado = estado;
            this.fechaRegistro = fechaRegistro;
        }
        public Proveedor() { }
    }
}
