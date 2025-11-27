using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class Producto
    {
        private int idProducto { get; set; }
        private int idCategoria { get; set; }
        private int idMarca { get; set; }
        private int idProveedor { get; set; }
        private string nombre { get; set; }
        private string caracteristica { get; set; }
        private string unidadMedida { get; set; }
        private double precioCompra { get; set; }
        private double precioVenta { get; set; }
        private string estado { get; set; }
        private DateTime fechaRegistro { get; set; }

        //Constructores
        public Producto(int idProducto, int idCategoria, int idMarca, int idProveedor, string nombre, string caracteristica, string unidadMedida, double precioCompra, double precioVenta, string estado, DateTime fechaRegistro)
        {
            this.idProducto = idProducto;
            this.idCategoria = idCategoria;
            this.idMarca = idMarca;
            this.idProveedor = idProveedor;
            this.nombre = nombre;
            this.caracteristica = caracteristica;
            this.unidadMedida = unidadMedida;
            this.precioCompra = precioCompra;
            this.precioVenta = precioVenta;
            this.estado = estado;
            this.fechaRegistro = fechaRegistro;
        }
        public Producto() { }
    }
}
