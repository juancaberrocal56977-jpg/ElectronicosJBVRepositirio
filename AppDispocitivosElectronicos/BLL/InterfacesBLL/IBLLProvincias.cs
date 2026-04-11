using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.Entidades;

namespace UTN.Winform.Electronicos.BLL.InterfacesBLL
{
    interface IBLLProvincias
    {
        List<Provincia> GetAll();
        Provincia GetById(int pId);
        Provincia Save(Provincia pProvincia);
        Provincia GetProvinciaFromInternet(int pId);
        bool Delete(int pId);
    }
}
