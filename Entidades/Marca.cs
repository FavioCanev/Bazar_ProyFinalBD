using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Marca
    {
        public int idMarca { get; set; }
        public string nombre { get; set; }

        //Constructores
        public Marca(int idMarca, string nombre)
        {
            this.idMarca = idMarca;
            this.nombre = nombre;
        }
        public Marca() { }
    }
}
