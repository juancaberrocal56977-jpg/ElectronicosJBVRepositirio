using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.Entidades;

namespace UTN.Winform.Electronicos.BLL.InterfacesBLL
{
    interface IBLLTipo
    {
        List<TipoDispositivo> GetbyFilter(string pDescripcion);
        TipoDispositivo GetObjectById(string Id);
        Task<IEnumerable<TipoDispositivo>> GetAllObject();
        Task<TipoDispositivo> Save(TipoDispositivo pdatos);
        Task<bool> Delete(string pCodigo);
    }
}
