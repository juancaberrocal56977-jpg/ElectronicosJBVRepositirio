using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.DAL;
using UTN.Winform.Electronicos.DAL.InterfacesDAL;
using UTN.Winform.Electronicos.Entidades;

namespace UTN.Winform.Electronicos.BLL.InterfacesBLL
{
    class BLLModelo : IBLLModelo
    {
        public Task<bool> Delete(string pCodigo)
        {
            IDALModelo modelo = new DALModelo();

            return modelo.Delete(pCodigo);
        }

        public Task<IEnumerable<Modelo>> GetAllObject()
        {
            IDALModelo modelo = new DALModelo();
        
            return modelo.GetAllObject();
        }

        public List<Modelo> GetClienteByFilter(string pDescripcion)
        {
            throw new NotImplementedException();
        }

        public Modelo GetObjectById(string Id)
        {
            throw new NotImplementedException();
        }

        public Task<Modelo> Save(Modelo pdatos)
        {
            throw new NotImplementedException();
        }
    }
}
