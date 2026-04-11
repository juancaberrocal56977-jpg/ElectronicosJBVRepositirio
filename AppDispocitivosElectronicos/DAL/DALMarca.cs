using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTN.Winform.Electronicos.Entidades;
using UTN.Winform.Electronicos.Persistencia;

namespace UTN.Winform.Electronicos.DAL
{
    class DALMarca
    {
        public void Editar(Marca pMarca)
        {
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                var command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = @"usp_UPDATE_Marca";

                command.Parameters.AddWithValue("@Codigo", pMarca.Codigo);
                command.Parameters.AddWithValue("@Descripcion", pMarca.Descripcion);
                command.Parameters.AddWithValue("@Estado", pMarca.Estado);
                db.ExecuteNonQuery(command);
            }
        }

        public void Eliminar(string id)
        {

            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                var command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Codigo", id);

                command.CommandText = @"usp_DELETE_Marca_ByID";
                db.ExecuteNonQuery(command);
            }
        }

        public void Insertar(Marca pMarca)
        {
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                var command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = @"usp_INSERT_Marca";

                command.Parameters.AddWithValue("@Codigo", pMarca.Codigo);
                command.Parameters.AddWithValue("@Descripcion", pMarca.Descripcion);
                command.Parameters.AddWithValue("@Estado", pMarca.Estado);
                db.ExecuteNonQuery(command);
            }
        }

        public Marca SeleccionarPorId(string id)
        {
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                var command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = @"usp_SELECT_Marca_ByID";
                command.Parameters.AddWithValue("@Codigo", id);

                var dr = db.ExecuteReader(command);
                // Read retorna true si hay resultados              
                while (dr.Read())
                {
                    Marca oMarcas = new Marca();

                    oMarcas.Codigo = dr["Codigo"].ToString();
                    oMarcas.Descripcion = dr["Descripcion"].ToString();
                    oMarcas.Estado = bool.Parse(dr["Estado"].ToString());


                    return oMarcas;
                }
                return null;
            }
        }

        public List<Marca> SeleccionarTodos()
        {
            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                var command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = @"usp_SELECT_Marca_All";

                List<Marca> lista = new List<Marca>();
                var reader = db.ExecuteReader(command);
                // Read retorna true si hay resultados              
                while (reader.Read())
                {
                    Marca marcaObj = new Marca();
                    marcaObj.Codigo = reader["Codigo"].ToString();
                    marcaObj.Descripcion = reader["Descripcion"].ToString();
                 
                    marcaObj.Estado = bool.Parse(reader["Estado"].ToString());

                    lista.Add(marcaObj);
                }

                return lista;
            }
        }
    }

}
