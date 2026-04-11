using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.DAL.InterfacesDAL;
using UTN.Winform.Electronicos.Entidades;
using UTN.Winform.Electronicos.Exeptions;
using UTN.Winform.Electronicos.Persistencia;
using UTN.Winform.Electronicos.Utils;
using log4net;
using System.Collections;
using System.Security.Cryptography;

namespace UTN.Winform.Electronicos.DAL
{
    class DALProducto : IDALProducto
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        public async Task<bool> Delete(string pCod)
        {

            String msg = "";
            bool retorno = false;
            double rows = 0d;
            SqlCommand command = new SqlCommand();
            try
            {

                string sql = @"Delete from  Producto   Where (Codigo = @Codigo) ";

                command.Parameters.AddWithValue("@Codigo", pCod);

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    retorno = true;

                return retorno;
            }
            catch (SqlException er)
            {
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, command));
                throw new CustomException(msg.ToSqlServerDetailError(er));
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        public async Task<IEnumerable<Productos>> GetAllObject()
        {
            List<Productos> listaProducto = new List<Productos>();
            SqlCommand command = new SqlCommand();
            string msg = "";
            try
            {
                string sql = @"usp_SELECT_Producto_All";

                command.CommandText = sql;
                command.CommandType = CommandType.StoredProcedure;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    using (SqlDataReader dr = await db.ExecuteReaderAsync(command))
                    {
                        // Iterar en todas las filas 
                        while (await dr.ReadAsync())
                        {

                            Productos oProducto = new Productos();
                            oProducto.Codigo = dr["Codigo"].ToString();
                            oProducto.Nombre = dr["Nombre"].ToString();
                            oProducto.CodTipoDispositivo = dr["CodTipoDispositivo"].ToString();
                            oProducto.CodMarca = dr["CodMarca"].ToString();
                            oProducto.CodModelo = dr["CodModelo"].ToString();
                            oProducto.CodProvedor = dr["CodProvedor"].ToString();
                            oProducto.Color = dr["Color"].ToString();
                            oProducto.Caracteristicas = dr["Caracteristicas"].ToString();
                            oProducto.Foto = (byte[])dr["Foto"];
                            oProducto.Cantidad = int.Parse(dr["Cantidad"].ToString());
                            oProducto.Extras = dr["Extras"].ToString();
                            oProducto.Precio = double.Parse(dr["Precio"].ToString());
                            oProducto.DocumentoEspecificaciones = (byte[])dr["DocumentoEspecificaciones"];
                            oProducto.CogigoBarra = (byte[])dr["CogigoBarra"];
                            listaProducto.Add(oProducto);

                        }
                    }

                }
                return listaProducto;
            }
            catch (SqlException er)
            {
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, command));
                throw new CustomException(msg.ToSqlServerDetailError(er));
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        public List<Productos> GetObjectByFilter(string pDescripcion)
        {
            DataSet ds = null;
            List<Productos> lista = new List<Productos>();
            SqlCommand command = new SqlCommand();
            string msg = "";
            try
            {
                string sql = @"select * from  Producto WITH (NOLOCK) 
                                Where Cantidad+Codigo+Nombre like @filtro ";
                command.Parameters.AddWithValue("@filtro", pDescripcion);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si devolvió filas
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Iterar en todas las filas y Mapearlas
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                     Productos   oProducto = new Productos();


                        oProducto.Codigo = dr["Codigo"].ToString();
                        oProducto.Nombre = dr["Nombre"].ToString();
                        oProducto.CodTipoDispositivo = dr["CodTipoDispositivo"].ToString();
                        oProducto.CodMarca = dr["CodMarca"].ToString();
                        oProducto.CodModelo = dr["CodModelo"].ToString();
                        oProducto.CodProvedor = dr["CodProvedor"].ToString();
                        oProducto.Color = dr["Color"].ToString();
                        oProducto.Caracteristicas = dr["Caracteristicas"].ToString();
                        oProducto.Foto = (byte[])dr["Foto"];
                        oProducto.Cantidad = int.Parse(dr["Cantidad"].ToString());
                        oProducto.Extras = dr["Extras"].ToString();
                        oProducto.Precio = double.Parse(dr["Precio"].ToString());
                        oProducto.DocumentoEspecificaciones = (byte[])dr["DocumentoEspecificaciones"];
                        oProducto.CogigoBarra = (byte[])dr["CogigoBarra"];

                        lista.Add(oProducto);
                    }
                }

                return lista;
            }
            catch (SqlException er)
            {
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, command));
                throw new CustomException(msg.ToSqlServerDetailError(er));
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
            throw new NotImplementedException();
        }

        public Productos GetObjectById(string pCod)
        {
            DataSet ds = null;
            Productos oProducto = null;
            SqlCommand command = new SqlCommand();
            string msg = "";
            try
            {
                string sql = @" select * from  Producto Where Codigo = @Codigo ";
                command.Parameters.AddWithValue("@Codigo", pCod);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si devolvió filas
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Iterar en todas las filas y Mapearlas
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        oProducto = new Productos();

                      
                            oProducto.Codigo = dr["Codigo"].ToString();
                            oProducto.Nombre = dr["Nombre"].ToString();
                            oProducto.CodTipoDispositivo = dr["CodTipoDispositivo"].ToString();
                            oProducto.CodMarca = dr["CodMarca"].ToString();
                            oProducto.CodModelo = dr["CodModelo"].ToString();
                            oProducto.CodProvedor = dr["CodProvedor"].ToString();
                            oProducto.Color = dr["Color"].ToString();
                            oProducto.Caracteristicas = dr["Caracteristicas"].ToString();
                            oProducto.Foto = (byte[])dr["Foto"];
                            oProducto.Cantidad = int.Parse(dr["Cantidad"].ToString());
                            oProducto.Extras = dr["Extras"].ToString();
                            oProducto.Precio = double.Parse(dr["Precio"].ToString());
                            oProducto.DocumentoEspecificaciones = (byte[])dr["DocumentoEspecificaciones"];
                            oProducto.CogigoBarra = (byte[])dr["CogigoBarra"];



                        }
                    }

                return oProducto;
            }
            catch (SqlException er)
            {
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, command));
                throw new CustomException(msg.ToSqlServerDetailError(er));
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        public async Task<Productos> Save(Productos pDatosObj)
        {
            string msg = "";
            string sql = @"usp_UPDATE_Producto";
            int rows = 0;
            SqlCommand command = new SqlCommand();
            Productos oProductosMetodo = new Productos();
            try
            {
                command.Parameters.AddWithValue("@Codigo", pDatosObj.Codigo);
                command.Parameters.AddWithValue("@Nombre", pDatosObj.Nombre);
                command.Parameters.AddWithValue("@CodTipoDispositivo", pDatosObj.CodTipoDispositivo);
                command.Parameters.AddWithValue("@CodMarca", pDatosObj.CodMarca);
                command.Parameters.AddWithValue("@CodModelo", pDatosObj.CodModelo);
                command.Parameters.AddWithValue("@CodProvedor", pDatosObj.CodProvedor);
                command.Parameters.AddWithValue("@Color", pDatosObj.Color);
                command.Parameters.AddWithValue("@Caracteristicas", pDatosObj.Caracteristicas);
                command.Parameters.AddWithValue("@Foto", pDatosObj.Foto);
                command.Parameters.AddWithValue("@Cantidad", pDatosObj.Cantidad);
                command.Parameters.AddWithValue("@Extras", pDatosObj.Extras);
                command.Parameters.AddWithValue("@Precio", pDatosObj.Precio);
                command.Parameters.AddWithValue("@DocumentoEspecificaciones", pDatosObj.DocumentoEspecificaciones);
                command.Parameters.AddWithValue("@CogigoBarra", pDatosObj.CogigoBarra);

                command.CommandText = sql;
                command.CommandType = CommandType.StoredProcedure;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oProductosMetodo = this.GetObjectById(pDatosObj.Codigo);

                return oProductosMetodo;

            }
            catch (SqlException er)
            {
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, command));
                throw new CustomException(msg.ToSqlServerDetailError(er));
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        public async Task<Productos> Update(Productos pDatosObj)
        {
            string msg = "";
            string sql = @"usp_UPDATE_Producto";
            int rows = 0;
            SqlCommand command = new SqlCommand();
            Productos oProductosMetodo = new Productos();
            try
            {
                command.Parameters.AddWithValue("@Codigo", pDatosObj.Codigo);
                command.Parameters.AddWithValue("@Nombre", pDatosObj.Nombre);
                command.Parameters.AddWithValue("@CodTipoDispositivo", pDatosObj.CodTipoDispositivo);
                command.Parameters.AddWithValue("@CodMarca", pDatosObj.CodMarca);
                command.Parameters.AddWithValue("@CodModelo", pDatosObj.CodModelo);
                command.Parameters.AddWithValue("@CodProvedor", pDatosObj.CodProvedor);
                command.Parameters.AddWithValue("@Color", pDatosObj.Color);
                command.Parameters.AddWithValue("@Caracteristicas", pDatosObj.Caracteristicas);
                command.Parameters.AddWithValue("@Foto", pDatosObj.Foto);
                command.Parameters.AddWithValue("@Cantidad", pDatosObj.Cantidad);
                command.Parameters.AddWithValue("@Extras", pDatosObj.Extras);
                command.Parameters.AddWithValue("@Precio", pDatosObj.Precio);
                command.Parameters.AddWithValue("@DocumentoEspecificaciones", pDatosObj.DocumentoEspecificaciones);
                command.Parameters.AddWithValue("@CogigoBarra", pDatosObj.CogigoBarra);

                command.CommandText = sql;
                command.CommandType = CommandType.StoredProcedure;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oProductosMetodo = this.GetObjectById(pDatosObj.Codigo);

                return oProductosMetodo;

            }
            catch (SqlException er)
            {
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, command));
                throw new CustomException(msg.ToSqlServerDetailError(er));
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }
    }
}
