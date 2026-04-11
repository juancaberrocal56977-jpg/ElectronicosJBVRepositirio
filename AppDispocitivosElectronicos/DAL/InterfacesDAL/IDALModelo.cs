using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.Entidades;

namespace UTN.Winform.Electronicos.DAL.InterfacesDAL
{
    interface IDALModelo
    {
        List<Modelo> GetObjectByFilter(string pDescripcion);
        Modelo GetObjectById(string pCod);
        Task<IEnumerable<Modelo>> GetAllObject();
        Task<Modelo> Save(Modelo pDatosObj);
        Task<Modelo> Update(Modelo pDatosObj);
        Task<bool> Delete(string pCod);
    }
}
