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
    class DALModelo : IDALModelo
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

                string sql = @"Delete from  Modelo   Where (Codigo = @Codigo) ";

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

        public async Task<IEnumerable<Modelo>> GetAllObject()
        {

            List<Modelo> lista = new List<Modelo>();
            SqlCommand command = new SqlCommand();
            string msg = "";
            try
            {
                string sql = @"usp_SELECT_Modelo_All";

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

                            Modelo oModelo = new Modelo();
                            oModelo.Codigo = dr["Codigo"].ToString();
                            oModelo.Descripcion = dr["Descripcion"].ToString();
                            lista.Add(oModelo);

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

        public List<Modelo> GetObjectByFilter(string pDescripcion)
        {
            throw new NotImplementedException();
        }

        public Modelo GetObjectById(string pCod)
        {
            throw new NotImplementedException();
        }

        public Task<Modelo> Save(Modelo pDatosObj)
        {
            throw new NotImplementedException();
        }

        public Task<Modelo> Update(Modelo pDatosObj)
        {
            throw new NotImplementedException();
        }
    }
}
