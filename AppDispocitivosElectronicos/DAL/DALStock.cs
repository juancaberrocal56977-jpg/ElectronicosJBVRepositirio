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
using UTN.Winform.Electronicos.DAL.InterfacesDAL;

namespace UTN.Winform.Electronicos.DAL
{
    class DALStock : IDALStock
    {
        public  void CREATE(IngresoStock ingresoP)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                  
                    var command = new SqlCommand("usp_INSERT_IngresoStock");
                    command.Parameters.AddWithValue("@CodigoStock", ingresoP.CodigoStock);
                    command.Parameters.AddWithValue("@Cantidad", ingresoP.Cantidad);
                    command.Parameters.AddWithValue("@CodFactura", ingresoP.CodFactura);
                    command.Parameters.AddWithValue("@Observaciones", ingresoP.Observaciones);
                    command.Parameters.AddWithValue("@Estado", ingresoP.Estado);
                    command.Parameters.AddWithValue("@Fecha", ingresoP.Fecha);
                    command.Parameters.AddWithValue("@CodigoProducto", ingresoP.CodigoProducto);
                    command.Parameters.AddWithValue("@TipoEntradaSalida", ingresoP.TipoEntradaSalida);
                    command.Parameters.AddWithValue("@Documento", ingresoP.Documento);


                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        #region UPDATE
        public  void UPDATE(IngresoStock ingresoP)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_UPDATE_IngresoStock");
                    command.Parameters.AddWithValue("@CodigoStock", ingresoP.CodigoStock);
                    command.Parameters.AddWithValue("@Cantidad", ingresoP.Cantidad);
                    command.Parameters.AddWithValue("@CodFactura", ingresoP.CodFactura);
                    command.Parameters.AddWithValue("@Observaciones", ingresoP.Observaciones);
                    command.Parameters.AddWithValue("@Estado", ingresoP.Estado);
                    command.Parameters.AddWithValue("@Fecha", ingresoP.Fecha);
                    command.Parameters.AddWithValue("@CodigoProducto", ingresoP.CodigoProducto);
                    command.Parameters.AddWithValue("@TipoEntradaSalida", ingresoP.TipoEntradaSalida);
                    command.Parameters.AddWithValue("@Documento", ingresoP.Documento);

                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        #endregion
        #region DELETE
        public  void DELETE(string Id)
        {
            try
            {
                //Receta de cocina
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                   
                    var command = new SqlCommand("usp_DELETE_IngresoStock_ByID");
                    command.Parameters.AddWithValue("@CodigoStock", Id);
                   
                    command.CommandType = CommandType.StoredProcedure;
                    db.ExecuteNonQuery(command);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        #endregion

        #region SELECT ALL
        public  List<IngresoStock> SelectAll()
        {
            try
            {

                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_IngresoStock_All");
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "IngresoStock");
                }

                List<IngresoStock> lista = new List<IngresoStock>();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                       // IngresoStock oUsuario2 = new IngresoStock();

                        IngresoStock oIngresoStock = new IngresoStock();
                        oIngresoStock.CodigoStock = dr["CodigoStock"].ToString();
                        oIngresoStock.Cantidad = dr["Cantidad"].ToString();
                        oIngresoStock.CodFactura = int.Parse(dr["CodFactura"].ToString());
                        oIngresoStock.Observaciones = dr["Observaciones"].ToString();
                        oIngresoStock.Estado = bool.Parse(dr["Estado"].ToString());
                        oIngresoStock.Fecha = DateTime.Parse(dr["Fecha"].ToString());
                        oIngresoStock.CodigoProducto = dr["CodigoProducto"].ToString();
                        oIngresoStock.TipoEntradaSalida = dr["TipoEntradaSalida"].ToString();
                        oIngresoStock.Documento = (byte[])dr["Documento"];
                        lista.Add(oIngresoStock);

                        lista.Add(oIngresoStock);
                    }
                }
                return lista;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return null;
            }

        }
        #endregion
        #region SELECT BY ID
        public  IngresoStock SelectById(string Id)
        {
            try
            {
                DataSet ds = null;
                using (var db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var command = new SqlCommand("usp_SELECT_IngresoStock_ByID ");
                    command.Parameters.AddWithValue("@CodigoStock", Id);
                    command.CommandType = CommandType.StoredProcedure;
                    ds = db.ExecuteReader(command, "IngresoStock");
                }

                //Se crea el dataTable
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataTable dt = ds.Tables[0];
                    IngresoStock oIngresoStock = new IngresoStock();
                    //oUsuarios.Identificacion = dt.Rows[0]["Identificacion"].ToString();
                    oIngresoStock.CodigoStock = dt.Rows[0]["CodigoStock"].ToString();
                    oIngresoStock.Cantidad = dt.Rows[0] ["Cantidad"].ToString();
                    oIngresoStock.CodFactura = int.Parse(dt.Rows[0]["CodFactura"].ToString());
                    oIngresoStock.Observaciones = dt.Rows[0]["Observaciones"].ToString();
                    oIngresoStock.Estado = bool.Parse(dt.Rows[0]["Estado"].ToString());
                    oIngresoStock.Fecha = DateTime.Parse(dt.Rows[0]["Fecha"].ToString());
                    oIngresoStock.CodigoProducto = dt.Rows[0]["CodigoProducto"].ToString();
                    oIngresoStock.TipoEntradaSalida = dt.Rows[0]["TipoEntradaSalida"].ToString();
                    oIngresoStock.Documento = (byte[])dt.Rows[0]["Documento"];

                    return oIngresoStock;
                }
                return null;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return null;
            }
        }
        #endregion
    }
}
