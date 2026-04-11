using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.Entidades.BCCR;

namespace UTN.Winform.Electronicos.DAL
{
    class DALDolar
    {
        public double GetVentaDolar()
        {
            double tipoCambioVenta = 1;
            ServiceBCCR services = new ServiceBCCR();
            List<Dolar> cambioDolar = services.GetDolar(DateTime.Today, DateTime.Today,
            "v").ToList();
            if (cambioDolar != null)
            {
                tipoCambioVenta = cambioDolar[0].Monto;
            }
            return tipoCambioVenta;
        }
    }
}
