using log4net;
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

namespace UTN.Winform.Electronicos.DAL
{
    class DALFactura : IDALFactura
    {
        private static readonly ILog _MyLogControlEventos = LogManager.GetLogger("MyControlEventos");
        public EncabezadoFactura SaveFactura(EncabezadoFactura pFactura, string codigoFactura)
        {
            EncabezadoFactura oFacturaEncabezado = null;
            string sqlEncabezado = string.Empty;
            string sqlDetalle = string.Empty;
            string sqlElectronicoProducto = string.Empty;
            SqlCommand cmdFacturaEncabezado = new SqlCommand();
            SqlCommand cmdFacturaDetalle = new SqlCommand();
            SqlCommand cmdElectronico = new SqlCommand();
            List<IDbCommand> listaCommands = new List<IDbCommand>();
            double rows = 0;
            string msg = "";

            // Reenumerar
            pFactura.CodigoFactura = GetNextNumeroFactura();
            pFactura._ListaFacturaDetalle.ForEach(p => p.Codigo = pFactura.CodigoFactura);


            sqlEncabezado = @"  
                             ";

            try
            {
                // Encabezado de factura
                cmdFacturaEncabezado.Parameters.AddWithValue("@CodigoFactura", "");
                cmdFacturaEncabezado.Parameters.AddWithValue("@NumeroFactura", "");
                cmdFacturaEncabezado.Parameters.AddWithValue("@CodCliente", "");
                cmdFacturaEncabezado.Parameters.AddWithValue("@CodVendedor", "");
                cmdFacturaEncabezado.Parameters.AddWithValue("@FechaFacturacion", "");
                cmdFacturaEncabezado.Parameters.AddWithValue("@SubTotal", "");
                cmdFacturaEncabezado.Parameters.AddWithValue("@Iva", "");
                cmdFacturaEncabezado.Parameters.AddWithValue("@Total", "");
                cmdFacturaEncabezado.Parameters.AddWithValue("@Estado", "");
                cmdFacturaEncabezado.Parameters.AddWithValue("@TarjetaCod", "");
                cmdFacturaEncabezado.Parameters.AddWithValue("@DolarCambio", "");
                cmdFacturaEncabezado.Parameters.AddWithValue("@EnvioEmail", "");
                cmdFacturaEncabezado.Parameters.AddWithValue("@XMLFacturacion", "");
                cmdFacturaEncabezado.Parameters.AddWithValue("@Firma", "");
                cmdFacturaEncabezado.Parameters.AddWithValue("@TipoPago", "");
                cmdFacturaEncabezado.Parameters.AddWithValue("@NumeroTipoPago", "");
                cmdFacturaEncabezado.Parameters.AddWithValue("@Documento", "");
                cmdFacturaEncabezado.Parameters.AddWithValue("@TotalDolar", "");

                //cmdFacturaEncabezado.CommandText = sqlEncabezado;
                cmdFacturaEncabezado.CommandType = CommandType.Text;
                // Agregar a la lista de commands
                listaCommands.Add(cmdFacturaEncabezado);


                // Detalle de factura
                sqlDetalle = @" ";

                // Guardar el detalle de la factura y a la vez rebajar el saldo del producto en Electronico
                foreach (DetalleFactura pFacturaDetalle in pFactura._ListaFacturaDetalle)
                {
                    cmdFacturaDetalle = new SqlCommand();
                    cmdFacturaDetalle.Parameters.AddWithValue("@Codigo", "");
                    cmdFacturaDetalle.Parameters.AddWithValue("@CodFacturaEnc", "");
                    cmdFacturaDetalle.Parameters.AddWithValue("@CodDispositivo", "");
                    cmdFacturaDetalle.Parameters.AddWithValue("@Cantidad", "");
                    cmdFacturaDetalle.Parameters.AddWithValue("@Precio", "");
                    cmdFacturaDetalle.Parameters.AddWithValue("@SubTotal", "");
                    cmdFacturaDetalle.Parameters.AddWithValue("@Impuesto", "");
                    cmdFacturaDetalle.Parameters.AddWithValue("@PrecioTotal", "");

                    cmdFacturaDetalle.CommandText = sqlDetalle;
                    cmdFacturaDetalle.CommandType = CommandType.Text;
                    // Agregar a la lista de comandos
                    listaCommands.Add(cmdFacturaDetalle);

                    // Rebajar 
                    cmdElectronico = new SqlCommand();
                    cmdElectronico.Parameters.AddWithValue("@CodDispositivo", pFacturaDetalle.CodDispositivo);
                    cmdElectronico.Parameters.AddWithValue("@Cantidad", pFacturaDetalle.Cantidad);
                    sqlElectronicoProducto = @"Update Producto 
                                       Set Cantidad =  Cantidad - @Cantidad 
                                       Where Codigo = @CodDispositivo";
                    cmdElectronico.CommandText = sqlElectronicoProducto;
                    cmdElectronico.CommandType = CommandType.Text;
                    listaCommands.Add(cmdElectronico);
                }


                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    rows = db.ExecuteNonQuery(listaCommands, IsolationLevel.ReadCommitted);
                }

                // Si devuelve filas quiere decir que se salvo entonces extraerlo

                if (rows == 0)
                {
                    throw new Exception("No se pudo salvar correctamente la factura");
                }
                else
                {
                    oFacturaEncabezado = GetFactura(pFactura.CodigoFactura);
                }

                return oFacturaEncabezado;
            }
            catch (SqlException er)
            {
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(MethodBase.GetCurrentMethod(), er, cmdElectronico));
                throw new CustomException(msg.ToSqlServerDetailError(er));
            }
            catch (Exception er)
            {
                msg = msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod());
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                throw;
            }
        }

        /// <summary>
        /// Extraer un consecutivo para asignar el numero de factura
        ///  Investigue como crear secuencias en SQLServer
        /// http://technet.microsoft.com/es-es/library/ff878091.aspx
        /// CREATE SEQUENCE SecuenciaNoFactura  START WITH 1 INCREMENT BY 1 ;
        /// </summary>
        /// <returns>Num. de factura</returns>
        public int GetNextNumeroFactura()//listo
        {
            DataSet ds = null;
            IDbCommand command = new SqlCommand();
            int numeroFactura = 0;
            string sql = @"SELECT NEXT VALUE FOR SequenceFact";
            string msg = "";
            DataTable dt = null;
            try
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Extraer la tabla 
                dt = ds.Tables[0];
                //Extraer el valor que viene en el DataTable 
                numeroFactura = int.Parse(dt.Rows[0][0].ToString());
                return numeroFactura;
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

        public int GetCurrentNumeroFactura()/////Listo
        {

            DataSet ds = null;
            IDbCommand command = new SqlCommand();
            int numeroFactura = 0;
            string sql = @"SELECT current_value FROM sys.sequences WHERE name = 'SequenceFact'";
            DataTable dt = null;
            string msg = "";
            try
            {

                command.CommandText = sql;
                command.CommandType = CommandType.Text;

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {

                    ds = db.ExecuteReader(command, "query");
                }

                // Extraer la tabla 
                dt = ds.Tables[0];
                //Extraer el valor que viene en el DataTable 
                numeroFactura = int.Parse(dt.Rows[0][0].ToString());
                return numeroFactura;
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

        public double GetTotalFactura(double pNumeroFactura)//cambiar datos
        {

            double sumatoria = 0d;
            string sql = @"  select sum(Cantidad * Precio + Impuesto) from Detalle  f
                             where f.IdFactura = @pNumeroFactura";
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@pNumeroFactura", pNumeroFactura);

            using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
            {
                sumatoria = db.ExecuteScalar(command);
            }

            return sumatoria;
        }


        public EncabezadoFactura GetFactura(double pNumeroFactura)
        {
            string msg = "";
            EncabezadoFactura oFacturaEncabezado = new EncabezadoFactura();
            DataSet ds = null;
            IDALCliente _DALCliente = new DALCliente();
           // IDALTarjeta _DALTarjeta = new DALTarjeta();
            SqlCommand command = new SqlCommand();

            string sql = @"  ";


            sql = @"SELECT        Detalle.Codigo, Detalle.Cantidad, Detalle.Precio, Detalle.SubTotal, Detalle.Impuesto, Detalle.PrecioTotal, Encabezado.CodCliente
FROM            Detalle INNER JOIN
                         Encabezado ON Detalle.CodFacturaEnc = Encabezado.CodigoFactura AND Detalle.Codigo = Encabezado.NumeroFactura ";

            try
            {
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@IdFactura", pNumeroFactura);

                using (IDataBase db = FactoryDatabase.CreateDataBase(FactoryConexion.CreateConnection()))
                {
                    ds = db.ExecuteReader(command, "query");
                }

                // Si devolvió filas
                if (ds.Tables[0].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables[0].Rows[0];
                    oFacturaEncabezado = new EncabezadoFactura()
                    {
                        //EstadoFactura = (bool)dr["EstadoFactura"],
                        //FechaFacturacion = DateTime.Parse(dr["FechaFacturacion"].ToString()),
                        //IdFactura = double.Parse(dr["IdFactura"].ToString()),
                        //TarjetaNumero = dr["IdTarjeta"].ToString(),
                        //_Cliente = _DALCliente.GetClienteById(dr["IdCliente"].ToString()),
                        //_Tarjeta = _DALTarjeta.GetTarjetaById(int.Parse(dr["IdTarjeta"].ToString())),
                        //TipoPago = (int)dr["TipoPago"]
                    };


                    foreach (DataRow rowDetalle in ds.Tables[0].Rows)
                    {
                        DetalleFactura oFacturaDetalle = new DetalleFactura();
                        //oFacturaDetalle.IdElectronico = double.Parse(rowDetalle["IdElectronico"].ToString());
                        //oFacturaDetalle.Cantidad = int.Parse(rowDetalle["Cantidad"].ToString());
                        //oFacturaDetalle.Precio = double.Parse(rowDetalle["Precio"].ToString());
                        //oFacturaDetalle.IdFactura = double.Parse(rowDetalle["IdFactura"].ToString());
                        //// Calcular el Impuesto
                        //oFacturaDetalle.Impuesto = double.Parse(rowDetalle["Impuesto"].ToString());
                        //// Enumerar la secuencia
                        //oFacturaDetalle.Secuencia = int.Parse(rowDetalle["Secuencia"].ToString());
                        //oFacturaDetalle.DescripcionElectronico = rowDetalle["DescripcionElectronico"].ToString();
                        // Agregar
                        oFacturaEncabezado.AddDetalle(oFacturaDetalle);
                    }
                }


                return oFacturaEncabezado;
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

        public EncabezadoFactura SaveFactura(EncabezadoFactura pFactura)
        {
            throw new NotImplementedException();
        }
    }
}

