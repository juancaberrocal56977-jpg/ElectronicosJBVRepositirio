using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.BLL.InterfacesBLL;
using UTN.Winform.Electronicos.DAL.InterfacesDAL;
using UTN.Winform.Electronicos.DAL;
using UTN.Winform.Electronicos.Entidades;

namespace UTN.Winform.Electronicos.BLL
{
    class BLLFactura : IBLLFaactura
    {
        public int GetNextNumeroFactura()
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.GetNextNumeroFactura();
        }

        public int GetCurrentNumeroFactura()
        {
            IDALFactura _DALFactura = new DALFactura();
            return _DALFactura.GetCurrentNumeroFactura();
        }

        //public EncabezadoFactura SaveFactura(EncabezadoFactura pFactura)
        //{
        //    IDALFactura _DALFactura = new DALFactura();
        //    //IBLLElectronico _IBLLElectronico = new BLLElectronico();

        //    //// Vuelve a validar que exista en inventario
        //    //foreach (FacturaDetalle oFacturaDetalle in pFactura._ListaFacturaDetalle)
        //    //{
        //    //    _IBLLElectronico.AvabilityStock(oFacturaDetalle.IdElectronico, oFacturaDetalle.Cantidad);
        //    //}


        //    return _DALFactura.SaveFactura(pFactura, pFactura.CodigoFactura);
        //}


        public double GetTotalFactura(double pIdFactura)
        {
            DALFactura _DALFactura = new DALFactura();

            return _DALFactura.GetTotalFactura(pIdFactura);

        }

        public EncabezadoFactura SaveFactura(EncabezadoFactura pFactura)
        {
            throw new NotImplementedException();
        }

        //public async Task<IEnumerable<VentasDTO>> GetTotalVentasXFecha(DateTime pFechaInicial, DateTime pFechaFinal)
        //{
        //    DALFactura _DALFactura = new DALFactura();

        //    return await _DALFactura.GetTotalVentasXFecha(pFechaInicial, pFechaFinal);
        //}
    }
}
