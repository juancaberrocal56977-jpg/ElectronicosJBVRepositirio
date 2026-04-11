using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTN.Winform.Electronicos.Entidades
{
    internal class DetalleFactura
    {
        public int Codigo { set; get; }
        public int CodFacturaEnc { set; get; }
        public string CodDispositivo { set; get; }
        public int Cantidad { set; get; }
        public double Precio { set; get; }
        public double SubTotal { set; get; }
        public double Impuesto { set; get; }
        public double PrecioTotal { set; get; }






    }
}
