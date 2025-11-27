using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Controladores
{
    public class ControllerProducto
    {
        private readonly RepositorioProducto repo = new RepositorioProducto();

        public List<Producto> obtenerTodos()
        {
            return repo.listar();
        }


        public bool guardar(Producto p)
        {
            if (string.IsNullOrWhiteSpace(p.nombre))
            {
                throw new ArgumentException("El nombre del producto es obligatorio.");
            }

            if (p.precioCompra < 0)
            {
                throw new ArgumentException("El precio de compra no puede ser negativo.");
            }

            if (p.precioVenta < 0)
            {
                throw new ArgumentException("El precio de venta no puede ser negativo.");
            }

            if (p.idProducto == 0)
            {
                // Nuevo producto
                return repo.insertar(p);
            }
            else
            {
                // Actualizar producto existente
                return repo.actualizar(p);
            }
        }

        public bool eliminar(int idProducto)
        {
            if (idProducto <= 0)
            {
                throw new ArgumentException("El ID del producto no es válido.");
            }
            return repo.eliminar(idProducto);
        }
    }
}
