using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Electronicos.Entidades;
using UTN.Winform.Electronicos.Persistencia;

namespace UTN.Winform.Electronicos.DAL.InterfacesDAL
{
    interface IDALStock
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
