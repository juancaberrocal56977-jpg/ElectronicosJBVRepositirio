using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.BLL.InterfacesBLL;
using UTN.Winform.Electronicos.DAL;
using UTN.Winform.Electronicos.Entidades.DTO;

namespace UTN.Winform.Electronicos.BLL
{
    class BLLPadron:IBLLPadron
    {
        public PadronDTO GetPersonaById(string pIdCliente)
        {
            DALPadron padron = new DALPadron();

            return padron.GetPersonaById(pIdCliente);
        }
    }
}
