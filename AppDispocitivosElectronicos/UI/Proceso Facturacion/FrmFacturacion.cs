using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Electronicos.BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using UTN.Winform.Electronicos.UI.Filtros;
using UTN.Winform.Electronicos.Entidades;
using log4net;
using UTN.Winform.Electronicos.Utils;
using System.Reflection;
using System.Drawing.Printing;
using System.Net.NetworkInformation;

namespace UTN.Winform.Electronicos.UI.Proceso_Facturacion
{
    public partial class FrmFacturacion : Form
    {
        PrintDocument printDoc = new PrintDocument();
        string facturaTexto = "";
        string rutaPDF = "";
        private static readonly ILog _myLogControlEventos =
  log4net.LogManager.GetLogger("MyControlEventos");
        private bool dibujando = false;
        private byte[] firmaBytes = null;
        private Point puntoAnterior;
        Bitmap lienzo;
        Graphics g;

        public FrmFacturacion()
        {
            InitializeComponent();
        }
      
        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            BLLDolar dolar = new BLLDolar();
            tsslDolar.Text = (dolar.GetVentaDolar().ToString());

            ObtenerDolar();
            Firmar();
        }
        #region PDF
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Courier New", 12);
            Brush brush = Brushes.Black;

            e.Graphics.DrawString(facturaTexto, font, brush, 100, 100);
        }
        public void creadDoc()
        {
            string cliente = "Juan";
            string producto = "Name";
            string cantidad = 1.ToString();
            string precio = 1000.ToString();

            double total = Convert.ToInt16(cantidad) * Convert.ToDouble(precio);

            string fecha = DateTime.Now.ToString("yyyyMMdd_HHmmss");

            facturaTexto =
                "         FACTURA\n" +
                "---------------------------------\n" +
                "Cliente: " + cliente + "\n" +
                "Producto: " + producto + "\n" +
                "Cantidad: " + cantidad + "\n" +
                "Precio: $" + precio + "\n" +
                "---------------------------------\n" +
                "TOTAL: $" + total + "\n";

            printDoc.PrintPage += new PrintPageEventHandler(PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDoc;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }


        #endregion
        public void GridInfo()
        {

        }
        public void ObtenerDolar()
        {
            BLLDolar dolar = new BLLDolar();

            //string valor =( Double.Parse(txtPrecioTotal.Text) / dolar.GetVentaDolar()).ToString();
            //txtDolarTotal.Text= valor;
        }

        public void Validaciones()
        {

        }

        public void TranferenciaInfo()
        {

        }
     
        #region CRUD
        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            pbfirmaUsuario.Image = new Bitmap(pbfirmaUsuario.Width, pbfirmaUsuario.Height);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void gbDetalle_Enter(object sender, EventArgs e)
        {


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ObtenerDolar();
            creadDoc();
            GuardarEnDescargas();
            /////Firma
            //pbfirmaUsuario.Image.Save("firma.png", System.Drawing.Imaging.ImageFormat.Png);
            //this.GuardarEnDescargas();
            //////Firma obtenida
            //OpenFileDialog abrir = new OpenFileDialog();
            //abrir.Filter = "Imagenes|*.png;*.jpg;*.jpeg;*.bmp";

            //if (abrir.ShowDialog() == DialogResult.OK)
            //{
            //    // Mostrar en PictureBox
            //    using (var temp = new Bitmap(abrir.FileName))
            //    {
            //        pbfirmaUsuario.Image = new Bitmap(temp);
            //    }

            //    // Guardar en byte[]
            //    firmaBytes = ObtenerBytesDesdeArchivo(abrir.FileName);

            /////Crer FActura Detalle y encabezado


        }



        #region Firma Creacion 
        public void Firmar()
        {
            pbfirmaUsuario.Image = new Bitmap(pbfirmaUsuario.Width, pbfirmaUsuario.Height);
            pbfirmaUsuario.BackColor = System.Drawing.Color.White;

            pbfirmaUsuario.MouseDown += pbfirmaUsuario_MouseDown;
            pbfirmaUsuario.MouseMove += pbfirmaUsuario_MouseMove;
            pbfirmaUsuario.MouseUp += pbfirmaUsuario_MouseUp;
        }
        public void FirmaGuardarr()
        {
            try
            {
                string ruta = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    "Downloads",
                    "Dibujo.png"
                );

                lienzo.Save(ruta, ImageFormat.Png);

                MessageBox.Show("Imagen guardada en Descargas");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }

        }
     
        private byte[] ObtenerBytesDesdeArchivo(string ruta)
        {
            return File.ReadAllBytes(ruta);
        }
        private void GuardarEnDescargas()
        {
            try
            {
                if (pbfirmaUsuario.Image == null)
                {
                    MessageBox.Show("No hay firma para guardar.");
                    return;
                }

                // Ruta de Descargas
                string rutaDescargas = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                    "Downloads"
                );

                // Nombre del archivo
                string nombreArchivo = "Firma_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";
                string rutaCompleta = Path.Combine(rutaDescargas, nombreArchivo);

                // Crear una nueva imagen con fondo blanco
                Bitmap bmp = new Bitmap(pbfirmaUsuario.Image.Width, pbfirmaUsuario.Image.Height);

                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.White); // Fondo blanco
                    g.DrawImage(pbfirmaUsuario.Image, 0, 0); // Dibujar la firma encima
                }

                // Guardar la imagen final
                bmp.Save(rutaCompleta, ImageFormat.Png);

                MessageBox.Show("Firma guardada en: " + rutaCompleta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
            //try
            //{
            //    // Ruta de Descargas del usuario
            //    string rutaDescargas = Path.Combine(
            //        Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
            //        "Downloads"
            //    );

            //    // Nombre del archivo con fecha y hora
            //    string nombreArchivo = "Firma_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";

            //    string rutaCompleta = Path.Combine(rutaDescargas, nombreArchivo);

            //    // Guardar imagen
            //    pbfirmaUsuario.BackColor = SystemColors.GradientActiveCaption;
            //    pbfirmaUsuario.Image.Save(rutaCompleta, ImageFormat.Png);

            //    MessageBox.Show("Firma guardada en: " + rutaCompleta);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al guardar: " + ex.Message);
            //}
        }
        private void pbfirmaUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            dibujando = true;
            puntoAnterior = e.Location;
        }

        private void pbfirmaUsuario_MouseMove(object sender, MouseEventArgs e)
        {
            if (dibujando)
            {
                using (Graphics g = Graphics.FromImage(pbfirmaUsuario.Image))
                {
                    g.DrawLine(Pens.Black, puntoAnterior, e.Location);
                }
                pbfirmaUsuario.Invalidate();
                puntoAnterior = e.Location;
            }
        }

        private void pbfirmaUsuario_MouseUp(object sender, MouseEventArgs e)
        {
            dibujando = false;

        }

        #endregion

        #region XMLDocumento

        #endregion

        #region PDf

        #endregion

        #region Reporte 

        #endregion


        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }





        private void tsbtnBuscarProducto_Click(object sender, EventArgs e)
        {
            FrmFiltroProducto ofrmFiltroElectronico = new FrmFiltroProducto();
            Productos oElectronico = null;
            try
            {
                ofrmFiltroElectronico.ShowDialog();

                if (ofrmFiltroElectronico.DialogResult == DialogResult.OK)
                {
                    oElectronico = ofrmFiltroElectronico.Productos;

                    ///Mapeo de datos al contrario
                    txtCodDispositivoD.Text=oElectronico.CodTipoDispositivo;
                    txtPrecioD.Text = oElectronico.Precio.ToString();
                    nudCantidadD.Value = oElectronico.Cantidad;
                    //txtDescripcionElectronico.Text = oElectronico.DescripcionElectronico;
                    //this.mskCodigoProduto.Text = oElectronico.IdElectronico.ToString();
                    //this.txtPrecio.Text = oElectronico.Precio.ToString();
                    //this.txtExistencia.Text = oElectronico.Cantidad.ToString();
                    //this.mskCantidad.Focus();
                }
            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat(UtilError.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbtnBuscarCliente_Click(object sender, EventArgs e)
        {
            /*  frmFiltroElectronico ofrmFiltroElectronico = new frmFiltroElectronico();
          Electronico oElectronico = null;
          try
          {
              ofrmFiltroElectronico.ShowDialog();

              if (ofrmFiltroElectronico.DialogResult == DialogResult.OK)
              {
                  oElectronico = ofrmFiltroElectronico._Electronico;
                  txtDescripcionElectronico.Text = oElectronico.DescripcionElectronico;
                  this.mskCodigoProduto.Text = oElectronico.IdElectronico.ToString();
                  this.txtPrecio.Text = oElectronico.Precio.ToString();
                  this.txtExistencia.Text = oElectronico.Cantidad.ToString();
                  this.mskCantidad.Focus();
              }
          }
          catch (Exception er)
          {
              StringBuilder msg = new StringBuilder();
              msg.AppendFormat(UtilError.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
              _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
              MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }*/
        }

        private void tsBtnBuscarVendedor_Click(object sender, EventArgs e)
        {
            /*  frmFiltroElectronico ofrmFiltroElectronico = new frmFiltroElectronico();
          Electronico oElectronico = null;
          try
          {
              ofrmFiltroElectronico.ShowDialog();

              if (ofrmFiltroElectronico.DialogResult == DialogResult.OK)
              {
                  oElectronico = ofrmFiltroElectronico._Electronico;
                  txtDescripcionElectronico.Text = oElectronico.DescripcionElectronico;
                  this.mskCodigoProduto.Text = oElectronico.IdElectronico.ToString();
                  this.txtPrecio.Text = oElectronico.Precio.ToString();
                  this.txtExistencia.Text = oElectronico.Cantidad.ToString();
                  this.mskCantidad.Focus();
              }
          }
          catch (Exception er)
          {
              StringBuilder msg = new StringBuilder();
              msg.AppendFormat(UtilError.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod(), er));
              _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToString());
              MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }*/
        }

        private void tsbtnCorreoDocumentosEnvio_Click(object sender, EventArgs e)
        {
            string email= "juancaberrocal56977@gmail.com";
            //MessageBox.Show("tiene q configurar el correo !!!! ");
            String cuentaCorreoElectronico = "juancaberrocal56977@gmail.com";
            String contrasenaGeneradaXGmail = "";
            string correoDestinatario = email;  //;

            MailMessage mensaje = new MailMessage();
            mensaje.IsBodyHtml = true;
            mensaje.Subject = "Su factura Electronica ";
            mensaje.Body = "Adjunto su factura electronica ";
            mensaje.From = new MailAddress(cuentaCorreoElectronico);
            mensaje.To.Add(correoDestinatario); //Correo del destinatario
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential(cuentaCorreoElectronico, contrasenaGeneradaXGmail);
            smtp.EnableSsl = true;
            // Adjuntar un archivo
            Attachment attachment = new Attachment(tstxtRutaArchivoCorreo.Text);
            Attachment attachment2 = new Attachment("");
            mensaje.Attachments.Add(attachment);
            mensaje.Attachments.Add(attachment2);
            smtp.Send(mensaje);

            MessageBox.Show("La factura ha sido enviada al correo", "Atención");

        }


        private void tstxtRutaArchivoCorreo_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Title = "Seleccionar archivo";
            abrir.Filter = "Todos los archivos (*.*)|*.*";

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                tstxtRutaArchivoCorreo.Text = abrir.FileName;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}