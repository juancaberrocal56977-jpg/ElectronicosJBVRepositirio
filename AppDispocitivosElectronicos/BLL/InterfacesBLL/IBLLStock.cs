using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.Entidades;

namespace UTN.Winform.Electronicos.BLL.InterfacesBLL
{
    interface IBLLStock
    {
        void CREATE(IngresoStock ingresoP);


        #region UPDATE
        void UPDATE(IngresoStock ingresoP);

        #endregion
        #region DELETE
        void DELETE(string Id);
        #endregion

        #region SELECT ALL
        List<IngresoStock> SelectAll();

        #endregion
        #region SELECT BY ID
        IngresoStock SelectById(string Id);

        #endregion
    }
}
