using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        //getters y setters como propiedades auto implementadas
        public int idUsuario {  get; set; } 
        public string nombreUsuario { get; set; }
        public string contrasenaUsuario { get; set; }
        public int idEmpleado { get; set; }
        public string bloqueado {  get; set; }
        public DateTime fechaCreacion { get; set; }

        public Usuario(int idUsuario, string nombreUsuario, string contrasenaUsuario, int idEmpleado, string bloqueado, DateTime fechaCreacion)
        {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.contrasenaUsuario = contrasenaUsuario;
            this.idEmpleado = idEmpleado;
            this.bloqueado = bloqueado;
            this.fechaCreacion = fechaCreacion;
        }
        public Usuario() { }
    }
}
