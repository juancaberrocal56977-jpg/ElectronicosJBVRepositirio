using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Electronicos.Entidades
{
    internal class Cliente
 
    {
        public string Codigo { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Apellido2 { set; get; }
        public string Correo { set; get; }
        public string Direccion { set; get; }
        public string Provincia { set; get; }
        public string Telefono { set; get; }
        public byte[] Foto { set; get; }
        public bool Estado { set; get; }
        public string Sexo { set; get; }
        public string CodTipoId { set; get; }


    }
}
