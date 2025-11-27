using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        public int idProducto { get; set; }
        public int idCategoria { get; set; }
        public int idMarca { get; set; }
        public int idProveedor { get; set; }
        public string nombre { get; set; }
        public string caracteristica { get; set; }
        public string unidadMedida { get; set; }
        public decimal precioCompra { get; set; }
        public decimal precioVenta { get; set; }
        public string estado { get; set; }
        public DateTime fechaRegistro { get; set; }

        //Constructores
        public Producto(int idProducto, int idCategoria, int idMarca, int idProveedor, string nombre, string caracteristica, string unidadMedida, decimal precioCompra, decimal precioVenta, string estado, DateTime fechaRegistro)
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
