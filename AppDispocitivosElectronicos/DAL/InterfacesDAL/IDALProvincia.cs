using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.Entidades;

namespace UTN.Winform.Electronicos.DAL.InterfacesDAL
{
    interface IDALProvincia
    {
        List<Provincia> GetAll();
        Provincia GetById(int pId);
        Provincia Save(Provincia pBodega);
        Provincia Update(Provincia pBodega);
        bool Delete(int pId);
    }
}
