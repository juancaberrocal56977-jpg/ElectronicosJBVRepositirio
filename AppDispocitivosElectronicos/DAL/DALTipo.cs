using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.DAL.InterfacesDAL;
using UTN.Winform.Electronicos.Entidades;
using UTN.Winform.Electronicos.Exeptions;
using UTN.Winform.Electronicos.Persistencia;
using UTN.Winform.Electronicos.Utils;
using log4net;

namespace UTN.Winform.Electronicos.DAL
{
    class DALTipo : IDALTipo
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

                string sql = @"Delete from  TipoDispositivo   Where (Codigo = @Codigo) ";


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
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TipoDispositivo>> GetAllObject()
        {

            List<TipoDispositivo> lista = new List<TipoDispositivo>();
            SqlCommand command = new SqlCommand();
            string msg = "";
            try
            {
                string sql = @" select * from  TipoDispositivo WITH (NOLOCK)  ";

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    using (SqlDataReader reader = await db.ExecuteReaderAsync(command))
                    {
                        // Iterar en todas las filas 
                        while (await reader.ReadAsync())
                        {

                            // Mapearlas

                            TipoDispositivo oTipoDispositivo = new TipoDispositivo();
                            oTipoDispositivo.Codigo = reader["Codigo"].ToString();
                            oTipoDispositivo.Nombre = reader["Nombre"].ToString();
                            oTipoDispositivo.Estado = bool.Parse(reader["Estado"].ToString());
                            lista.Add(oTipoDispositivo);


                            
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

        public List<TipoDispositivo> GetObjectByFilter(string pDescripcion)
        {

            DataSet ds = null;
            List<TipoDispositivo> lista = new List<TipoDispositivo>();
            SqlCommand command = new SqlCommand();
            string msg = "";
            try
            {
                string sql = @" select * from  Cliente WITH (NOLOCK) 
                                Where Nombre+Apellido1+Apellido2 like @filtro ";
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
                        TipoDispositivo oCliente = new TipoDispositivo();
                        //oCliente.IdCliente = dr["IdCliente"].ToString();
                        //oCliente.Nombre = dr["Nombre"].ToString();
                        //oCliente.Apellido1 = dr["Apellido1"].ToString();
                        //oCliente.Apellido2 = dr["Apellido2"].ToString();
                        //oCliente.FechaNacimiento = DateTime.Parse(dr["FechaNacimiento"].ToString());
                        //oCliente.IdProvincia = (int)dr["IdProvincia"];
                        //oCliente.Sexo = (int)dr["Sexo"];

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

        public TipoDispositivo GetObjectById(string pCod)
        {
            DataSet ds = null;
            TipoDispositivo oTipoDispositivo = null;
            SqlCommand command = new SqlCommand();
            string msg = "";
            try
            {
                string sql = @"Select  Codigo,Nombre,Estado  from  TipoDispositivo   Where (Codigo = @Codigo) ";
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
                        oTipoDispositivo = new TipoDispositivo();
                        oTipoDispositivo.Codigo = dr["Codigo"].ToString();
                        oTipoDispositivo.Nombre = dr["Nombre"].ToString();
                        oTipoDispositivo.Estado = bool.Parse(dr["Estado"].ToString());
                    }
                }

                return oTipoDispositivo;
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

        public async Task<TipoDispositivo> Save(TipoDispositivo pDatosObj)
        {
            string msg = "";
            TipoDispositivo DispositivoS = null;
            SqlCommand command = new SqlCommand();
            // Insert
            string sql = @"Insert into TipoDispositivo(Codigo,Nombre,Estado) values (@Codigo,@Nombre,@Estado)";
            try
            {
                command.Parameters.AddWithValue("@Codigo", pDatosObj.Codigo);
                command.Parameters.AddWithValue("@Nombre", pDatosObj.Nombre);
                command.Parameters.AddWithValue("@Estado", pDatosObj.Estado);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    var rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);

                    // Si devuelve filas quiere decir que se salvo entonces extraerlo
                    if (rows > 0)
                        DispositivoS = this.GetObjectById(pDatosObj.Codigo);
                }

                return DispositivoS;

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

        public async Task<TipoDispositivo> Update(TipoDispositivo pDatosObj)
        {
            string msg = "";
           string sql = @"Update  TipoDispositivo
	        Set 	Nombre =  @Nombre  ,
	        Estado =  @Estado  
	        Where (Codigo =  @Codigo)";
                    int rows = 0;
            SqlCommand command = new SqlCommand();
            TipoDispositivo dispositivoA = new TipoDispositivo();
            try
            {
                command.Parameters.AddWithValue("@Codigo", pDatosObj.Codigo);
                command.Parameters.AddWithValue("@Nombre", pDatosObj.Nombre);
                command.Parameters.AddWithValue("@Estado", pDatosObj.Estado);
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    rows = await db.ExecuteNonQueryAsync(command, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo
                if (rows > 0)
                    dispositivoA = this.GetObjectById(pDatosObj.Codigo);

                return dispositivoA;

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
