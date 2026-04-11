using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Electronicos.Entidades
{
    internal class IngresoStock
    {
        public string CodigoStock { set; get; }
        public string Cantidad { set; get; }
        public int CodFactura { set; get; }
        public string Observaciones { set; get; }
        public bool Estado { set; get; }
        public DateTime Fecha { set; get; }
        public string CodigoProducto { set; get; }
        public string TipoEntradaSalida { set; get; }
        public byte[] Documento { set; get; }


    }
}
