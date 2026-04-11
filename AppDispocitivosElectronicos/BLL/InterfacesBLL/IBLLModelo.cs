using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.Entidades;

namespace UTN.Winform.Electronicos.BLL.InterfacesBLL
{
    interface IBLLModelo
    {
        List<Modelo> GetClienteByFilter(string pDescripcion);
        Modelo GetObjectById(string Id);
        Task<IEnumerable<Modelo>> GetAllObject();
        Task<Modelo> Save(Modelo pdatos);
        Task<bool> Delete(string pCodigo);

    }
}
