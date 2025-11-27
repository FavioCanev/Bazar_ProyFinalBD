using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proveedor
    {
        public int idProveedor { get; set; }
        public string nombre { get; set; }
        public string ruc { get; set; }
        public string direccion { get; set; }
        public string estado { get; set; }
        public DateTime fechaRegistro { get; set; }


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
