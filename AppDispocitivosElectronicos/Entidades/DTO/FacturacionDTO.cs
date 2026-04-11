using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace UTN.Winform.Electronicos.Entidades.DTO
{
    internal class FacturacionDTO
    {

        ////Detalle 
        ///
        public string Codigo { set; get; }
        public string CodFactura { set; get; }
        public string CodDispositivo { set; get; }
        public int Cantidad { set; get; }
        public double Precio { set; get; }
        public double Impuesto { set; get; }
        public double PrecioTotal { set; get; }
        public double SubTotal { set; get; }


        ///Encabezado

        public int CodigoFactura { set; get; }
        public string NumeroFactura { set; get; }
        public string CodCliente { set; get; }
        public string CodVendedor { set; get; }
        public DateTime FechaFacturacion { set; get; }
      //  public double SubTotal { set; get; }
        public double Iva { set; get; }
        public double Total { set; get; }
        public double DolarSubTotal { set; get; }
        public double DolarIva { set; get; }
        public double DolarTotal { set; get; }
        public bool EnvioEmail { set; get; }
        public Xml XMLFacturacion { set; get; }
        public byte[] Firma { set; get; }
        public string TipoPago { set; get; }
        public string NumeroTipoPago { set; get; }

    }
}
