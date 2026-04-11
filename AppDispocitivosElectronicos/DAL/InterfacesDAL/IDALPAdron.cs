using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.Entidades.DTO;

namespace UTN.Winform.Electronicos.DAL.InterfacesDAL
{
    interface IDALPadron
    {
        PadronDTO GetPersonaById(string pIdCliente);
    }
}
