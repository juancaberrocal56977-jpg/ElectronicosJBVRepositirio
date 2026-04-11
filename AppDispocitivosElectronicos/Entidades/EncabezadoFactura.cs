using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace UTN.Winform.Electronicos.Entidades
{
    internal class EncabezadoFactura
    {
        public int CodigoFactura { set; get; }
        public int NumeroFactura { set; get; }
        public string CodCliente { set; get; }
        public string CodVendedor { set; get; }
        public DateTime FechaFacturacion { set; get; }
        public double SubTotal { set; get; }
        public double Iva { set; get; }
        public double Total { set; get; }
        public bool Estado { set; get; }
        public string TarjetaCod { set; get; }
        public double DolarCambio { set; get; }
        public bool EnvioEmail { set; get; }
        public Xml XMLFacturacion { set; get; }
        public byte[] Firma { set; get; }
        public string TipoPago { set; get; }
        public string NumeroTipoPago { set; get; }
        public string Documento { set; get; }
        public double TotalDolar { set; get; }


        public List<DetalleFactura> _ListaFacturaDetalle { get; } = new List<DetalleFactura>();

        public void AddDetalle(DetalleFactura pFacturaDetalle) => _ListaFacturaDetalle.Add(pFacturaDetalle);

        public double GetSubTotal() => _ListaFacturaDetalle.Sum(p => p.Cantidad * p.Precio);

        public double GetImpuesto() => _ListaFacturaDetalle.Sum(p => p.Impuesto);

    }
}
