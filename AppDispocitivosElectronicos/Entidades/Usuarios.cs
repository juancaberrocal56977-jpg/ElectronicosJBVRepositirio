using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Electronicos.Entidades
{
    internal class Usuarios
    {
        public string Login { set; get; }
        public int IdRol { set; get; }
        public string Password { set; get; }
        public bool Estado { set; get; }
        //falta nombre
        public string Nombre { get; set; }

    }
}
