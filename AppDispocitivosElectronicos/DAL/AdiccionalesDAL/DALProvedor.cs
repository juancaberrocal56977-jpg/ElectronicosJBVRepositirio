using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.Entidades;
using UTN.Winform.Electronicos.Exeptions;
using UTN.Winform.Electronicos.Persistencia;
using UTN.Winform.Electronicos.Utils;

namespace UTN.Winform.Electronicos.DAL.AdiccionalesDAL
{
    class DALProvedor
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");

        public List<Provincia> GetAllInformacion()
        {
            string msg = "";
            IDataReader reader = null;
            List<Provincia> lista = new List<Provincia>();
            SqlCommand command = new SqlCommand();

            string sql = @" select * from  Provincia WITH (NOLOCK)  ";
            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            try
            {
                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    reader = db.ExecuteReader(command);

                    while (reader.Read())
                    {
                        Provincia oProvincia = new Provincia();
                        oProvincia.IdProvincia = int.Parse(reader["IdProvincia"].ToString());
                        oProvincia.Descripcion = reader["Descripcion"].ToString();
                        lista.Add(oProvincia);
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
    }
}
