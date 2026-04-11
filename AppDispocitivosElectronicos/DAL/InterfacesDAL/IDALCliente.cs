using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.Entidades;

namespace UTN.Winform.Electronicos.DAL.InterfacesDAL
{
    interface IDALCliente
    {
        List<Cliente> GetClienteByFilter(string pDescripcion);
        Cliente GetClienteById(string pId);
        Task<IEnumerable<Cliente>> GetAllCliente();
        Task<Cliente> SaveCliente(Cliente pCliente);
        Task<Cliente> UpdateCliente(Cliente pCliente);
        Task<bool> DeleteCliente(string pId);
    }
}
