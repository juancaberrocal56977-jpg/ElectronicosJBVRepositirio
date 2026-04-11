using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.Entidades;

namespace UTN.Winform.Electronicos.BLL.InterfacesBLL
{
    interface IBLLFaactura
    {
        EncabezadoFactura SaveFactura(EncabezadoFactura pFactura);
        int GetNextNumeroFactura();

        int GetCurrentNumeroFactura();

    //    Task<IEnumerable<VentasDTO>> GetTotalVentasXFecha(DateTime pFechaInicial, DateTime pFechaFinal);

    }
}
