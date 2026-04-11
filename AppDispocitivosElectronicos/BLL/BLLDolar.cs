using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.DAL;

namespace UTN.Winform.Electronicos.BLL
{
    class BLLDolar
    {
        public double GetVentaDolar()
        { 
            DALDolar dALDolar = new DALDolar();
            return dALDolar.GetVentaDolar();
        }
        }
}
