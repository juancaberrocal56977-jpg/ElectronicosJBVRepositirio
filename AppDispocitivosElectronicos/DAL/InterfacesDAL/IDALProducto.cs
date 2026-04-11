using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.Entidades;

namespace UTN.Winform.Electronicos.DAL.InterfacesDAL
{
    interface IDALProducto
    {

        List<Productos> GetObjectByFilter(string pDescripcion);
        Productos GetObjectById(string pCod);
        Task<IEnumerable<Productos>> GetAllObject();
        Task<Productos> Save(Productos pDatosObj);
        Task<Productos> Update(Productos pDatosObj);
        Task<bool> Delete(string pCod);
    }
}
