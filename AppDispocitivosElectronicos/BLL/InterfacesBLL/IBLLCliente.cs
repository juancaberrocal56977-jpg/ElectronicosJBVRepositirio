using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.Entidades;

namespace UTN.Winform.Electronicos.BLL.InterfacesBLL
{
    interface IBLLCliente
    {
        List<Cliente> GetClienteByFilter(string pDescripcion);
        Cliente GetClienteById(string pIdCliente);
        Task<IEnumerable<Cliente>> GetAllCliente();
        Task<Cliente> SaveCliente(Cliente pCliente);
        Task<bool> DeleteCliente(string pId);

    }
}
