using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.Entidades;

namespace UTN.Winform.Electronicos.DAL.InterfacesDAL
{
    interface IDALTipo
    {
        List<TipoDispositivo> GetObjectByFilter(string pDescripcion);
        TipoDispositivo GetObjectById(string pCod);
        Task<IEnumerable<TipoDispositivo>> GetAllObject();
        Task<TipoDispositivo> Save(TipoDispositivo pDatosObj);
        Task<TipoDispositivo> Update(TipoDispositivo pDatosObj);
        Task<bool> Delete(string pCod);
    }
}
