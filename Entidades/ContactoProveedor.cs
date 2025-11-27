using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class ContactoProveedor
    {
        private int idContacto { get; set; }
        private int idProveedor { get; set; }
        private string contactoNombre { get; set; }
        private string contactoApellido { get; set; }
        private string contactoTelefono { get; set; }

        //Constructores 

        public ContactoProveedor(int idContacto, int idProveedor, string contactoNombre, string contactoApellido, string contactoTelefono)
        {
            this.idContacto = idContacto;
            this.idProveedor = idProveedor;
            contactoNombre = contactoNombre;
            contactoApellido = contactoApellido;
            contactoTelefono = contactoTelefono;
        }
        public ContactoProveedor()
        {
        }
    }
}
