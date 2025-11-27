using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ContactoProveedor
    {
        public int idContacto { get; set; }
        public int idProveedor { get; set; }
        public string contactoNombre { get; set; }
        public string contactoApellido { get; set; }
        public string contactoTelefono { get; set; }

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
