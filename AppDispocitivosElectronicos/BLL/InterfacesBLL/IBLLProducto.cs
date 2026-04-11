using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.Entidades;

namespace UTN.Winform.Electronicos.BLL.InterfacesBLL
{
    interface IBLLProducto
    {
        List<Productos> GetByFilter(string pDescripcion);
        Productos GetObjectById(string Id);
        Task<IEnumerable<Productos>> GetAllObject();
        Task<Productos> Save(Productos pdatos);
        Task<bool> Delete(string pCodigo);
    }
}
