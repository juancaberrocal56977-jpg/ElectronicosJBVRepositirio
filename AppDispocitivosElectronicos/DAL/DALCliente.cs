using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.Entidades;
using UTN.Winform.Electronicos.Persistencia;
using log4net;
using UTN.Winform.Electronicos.DAL.InterfacesDAL;
using UTN.Winform.Electronicos.Utils;
using UTN.Winform.Electronicos.Exeptions;

namespace UTN.Winform.Electronicos.DAL
{
    class DALCliente:IDALCliente
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        public async Task<bool> DeleteCliente(string pId)
        {
            String msg = "";
            bool retorno = false;
            double rows = 0d;
            SqlCommand command = new SqlCommand();
            try
            {

                string sql = @"Delete from  Cliente   Where (Codigo = @Codigo) ";

                command.Parameters.AddWithValue("@Codigo", pId);

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

        public async Task<IEnumerable<Cliente>> GetAllClienteX()
        {

            List<Cliente> lista = new List<Cliente>();
            SqlCommand command = new SqlCommand();
            string msg = "";
            try
            {

                string sql = @" select * from  Cliente WITH (NOLOCK)  ";

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    DataTable dt = await db.ExecuteReaderAsync(command, "T");

                    // Iterar en todas las filas 
                    foreach (DataRow dr in dt.Rows)
                    {

                        // Mapearlas
                        Cliente oCliente = new Cliente();
                        oCliente.Codigo = dr["Codigo"].ToString();
                        oCliente.Nombre = dr["Nombre"].ToString();
                        oCliente.Apellido = dr["Apellido"].ToString();
                        oCliente.Apellido2 = dr["Apellido2"].ToString();
                        oCliente.Correo = dr["Correo"].ToString();
                        oCliente.Direccion = dr["Direccion"].ToString();
                        oCliente.Provincia = dr["Provincia"].ToString();
                        oCliente.Telefono = dr["Telefono"].ToString();
                        //       oCliente.Foto = (byte[])dr["Foto"];
                        oCliente.Estado = bool.Parse(dr["Estado"].ToString());
                        oCliente.Sexo = dr["Sexo"].ToString();
                        oCliente.CodTipoId = dr["CodTipoId"].ToString();

                        lista.Add(oCliente);
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
        }

        public async Task<IEnumerable<Cliente>> GetAllCliente()
        {

            List<Cliente> lista = new List<Cliente>();
            SqlCommand command = new SqlCommand();
            string msg = "";
            try
            {
                string sql = @"usp_SELECT_Cliente_All";

                command.CommandText = sql;
                command.CommandType = CommandType.StoredProcedure;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    using (SqlDataReader dr = await db.ExecuteReaderAsync(command))
                    {
                        // Iterar en todas las filas 
                        while (await dr.ReadAsync())
                        {

                            // Mapearlas
                            Cliente oCliente = new Cliente();
                            oCliente.Codigo = dr["Codigo"].ToString();
                            oCliente.Nombre = dr["Nombre"].ToString();
                            oCliente.Apellido = dr["Apellido"].ToString();
                            oCliente.Apellido2 = dr["Apellido2"].ToString();
                            oCliente.Correo = dr["Correo"].ToString();
                            oCliente.Direccion = dr["Direccion"].ToString();
                            oCliente.Provincia = dr["Provincia"].ToString();
                            oCliente.Telefono = dr["Telefono"].ToString();
                     //       oCliente.Foto = (byte[])dr["Foto"];
                            oCliente.Estado = bool.Parse(dr["Estado"].ToString());
                            oCliente.Sexo = dr["Sexo"].ToString();
                            oCliente.CodTipoId = dr["CodTipoId"].ToString();



                            lista.Add(oCliente);
                        }
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
        }
        public List<Cliente> GetClienteByFilter(string pDescripcion)
        {
            DataSet ds = null;
            List<Cliente> lista = new List<Cliente>();
            SqlCommand command = new SqlCommand();
            string msg = "";
            try
            {
                string sql = @" select * from  Cliente WITH (NOLOCK) 
                                Where Nombre+Apellido+Apellido2 like @filtro ";
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
                        Cliente oCliente = new Cliente();
                        oCliente.Codigo = dr["Codigo"].ToString();
                        oCliente.Nombre = dr["Nombre"].ToString();
                        oCliente.Apellido = dr["Apellido"].ToString();
                        oCliente.Apellido2 = dr["Apellido2"].ToString();
                        oCliente.Correo = dr["Correo"].ToString();
                        oCliente.Direccion = dr["Direccion"].ToString();
                        oCliente.Provincia = dr["Provincia"].ToString();
                        oCliente.Telefono = dr["Telefono"].ToString();
                       // oCliente.Foto = (byte[])dr["Foto"];
                        oCliente.Estado = bool.Parse(dr["Estado"].ToString());
                        oCliente.Sexo = dr["Sexo"].ToString();
                        oCliente.CodTipoId = dr["CodTipoId"].ToString();

                        lista.Add(oCliente);
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
        }

        public Cliente GetClienteById(string pIdCliente)
        {
            DataSet ds = null;
            Cliente oCliente = null;
            SqlCommand command = new SqlCommand();
            string msg = "";
            try
            {
                string sql = @" select * from  Cliente Where Codigo = @Codigo ";
                command.Parameters.AddWithValue("@IdCliente", pIdCliente);
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
                        oCliente = new Cliente();

                        oCliente.Codigo = dr["Codigo"].ToString();
                        oCliente.Nombre = dr["Nombre"].ToString();
                        oCliente.Apellido = dr["Apellido"].ToString();
                        oCliente.Apellido2 = dr["Apellido2"].ToString();
                        oCliente.Correo = dr["Correo"].ToString();
                        oCliente.Direccion = dr["Direccion"].ToString();
                        oCliente.Provincia = dr["Provincia"].ToString();
                        oCliente.Telefono = dr["Telefono"].ToString();
                   //     oCliente.Foto = (byte[])dr["Foto"];
                        oCliente.Estado = bool.Parse(dr["Estado"].ToString());
                        oCliente.Sexo = dr["Sexo"].ToString();
                        oCliente.CodTipoId = dr["CodTipoId"].ToString();


                    }
                }

                return oCliente;
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


        public async Task<Cliente> SaveCliente(Cliente pCliente)
        {
            string msg = "";
            Cliente oCliente = null;
            SqlCommand command = new SqlCommand();
            // Insert
            string sql = @"usp_INSERT_Cliente";
            try
            {
                command.Parameters.AddWithValue("@Codigo", pCliente.Codigo);
                command.Parameters.AddWithValue("@Nombre", pCliente.Nombre);
                command.Parameters.AddWithValue("@Apellido", pCliente.Apellido);
                command.Parameters.AddWithValue("@Apellido2", pCliente.Apellido2);
                command.Parameters.AddWithValue("@Coreo", pCliente.Correo);
                command.Parameters.AddWithValue("@Direccion", pCliente.Direccion);
                command.Parameters.AddWithValue("@Telefono", pCliente.Telefono);
                command.Parameters.AddWithValue("@Foto", pCliente.Foto);
                command.Parameters.AddWithValue("@Provincia", pCliente.Provincia);
                command.Parameters.AddWithValue("@Estado", pCliente.Estado);
                command.Parameters.AddWithValue("@Sexo", pCliente.Sexo);
                command.Parameters.AddWithValue("@CodTipoId", pCliente.CodTipoId);

                command.CommandText = sql;
                command.CommandType = CommandType.StoredProcedure;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);

                    // Si devuelve filas quiere decir que se salvo entonces extraerlo
                    if (rows > 0)
                        oCliente = this.GetClienteById(pCliente.Codigo);
                }

                return oCliente;

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

        public async Task<Cliente> UpdateCliente(Cliente pCliente)
        {
            string msg = "";
            string sql = @"usp_UPDATE_Cliente";
            int rows = 0;
            SqlCommand command = new SqlCommand();
            Cliente oCliente = new Cliente();
            try
            {
                command.Parameters.AddWithValue("@Codigo", pCliente.Codigo);
                command.Parameters.AddWithValue("@Nombre", pCliente.Nombre);
                command.Parameters.AddWithValue("@Apellido", pCliente.Apellido);
                command.Parameters.AddWithValue("@Apellido2", pCliente.Apellido2);
                command.Parameters.AddWithValue("@Coreo", pCliente.Correo);
                command.Parameters.AddWithValue("@Direccion", pCliente.Direccion);
                command.Parameters.AddWithValue("@Telefono", pCliente.Telefono);
                command.Parameters.AddWithValue("@Foto", pCliente.Foto);
                command.Parameters.AddWithValue("@Provincia", pCliente.Provincia);
                command.Parameters.AddWithValue("@Estado", pCliente.Estado);
                command.Parameters.AddWithValue("@Sexo", pCliente.Sexo);
                command.Parameters.AddWithValue("@CodTipoId", pCliente.CodTipoId);

                command.CommandText = sql;
                command.CommandType = CommandType.StoredProcedure;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    oCliente = this.GetClienteById(pCliente.Codigo);

                return oCliente;

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
