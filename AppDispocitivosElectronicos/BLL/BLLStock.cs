using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Electronicos.Persistencia;
using UTN.Winform.Electronicos.Entidades;
using UTN.Winform.Electronicos.BLL.InterfacesBLL;
using UTN.Winform.Electronicos.DAL;

namespace UTN.Winform.Electronicos.BLL
{
    class BLLStock:IBLLStock
    {
        public  void CREATE(IngresoStock ingresoP)
        {
            DALStock stock = new DALStock();

            if (ingresoP.CodigoStock != null)
            
                if (Existe(ingresoP.CodigoStock))
                {
                    //MessageBox.Show("El usuario ya existe");
                stock.UPDATE(ingresoP);
                }
                else
                {
                   stock.CREATE(ingresoP);
                }
            }
        private bool Existe(string identificacion)
        {
            DALStock stock = new DALStock();

            IngresoStock usuario = stock.SelectById(identificacion);
            if (usuario != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region UPDATE
        public  void UPDATE(IngresoStock ingresoP)
        {
            DALStock stock = new DALStock();
            stock.UPDATE(ingresoP);
        }
        #endregion
        #region DELETE
        public  void DELETE(string Id)
        {
            DALStock stock = new DALStock();
             stock.DELETE(Id);
        }
        #endregion

        #region SELECT ALL
        public  List<IngresoStock> SelectAll()
        {
           DALStock stock = new DALStock();
            return stock.SelectAll();
        }
        #endregion
        #region SELECT BY ID
        public  IngresoStock SelectById(string Id)
        {
            DALStock stock = new DALStock();
            return stock.SelectById(Id);
        }
        #endregion
    }
}
