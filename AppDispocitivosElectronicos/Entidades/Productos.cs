using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Electronicos.Entidades
{
    internal class Productos
    {
        public string Codigo { set; get; }
        public string Nombre { set; get; }
        public string CodTipoDispositivo { set; get; }
        public string CodMarca { set; get; }
        public string CodModelo { set; get; }
        public string CodProvedor { set; get; }
        public string Color { set; get; }
        public string Caracteristicas { set; get; }
        public byte[] Foto { set; get; }
        public int Cantidad { set; get; }
        public string Extras { set; get; }
        public double Precio { set; get; }
        public byte[] DocumentoEspecificaciones { set; get; }
        public byte[] CogigoBarra { set; get; }


    }
}
