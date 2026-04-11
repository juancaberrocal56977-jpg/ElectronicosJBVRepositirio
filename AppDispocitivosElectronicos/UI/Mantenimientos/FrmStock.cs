using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Electronicos.BLL;
using UTN.Winform.Electronicos.Exeptions;

namespace UTN.Winform.Electronicos.UI.Mantenimientos
{
    public partial class FrmStock: Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");

        public FrmStock()
        {
            InitializeComponent();
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {
            //BLLStock stock = new BLLStock();
            //dgvInfoShow.AutoGenerateColumns = true;
            //dgvInfoShow.DataSource = stock.SelectAll();
            refreshGrid();
        }

   public     void refreshGrid()
        {
            BLLStock stock = new BLLStock();
            dgvInfoShow.AutoGenerateColumns = true;
            dgvInfoShow.DataSource = stock.SelectAll();
        }
        public void SeleccionarArchivoPng()
        {

            try
            {
                OpenFileDialog opt = new OpenFileDialog();
                opt.Title = "Seleccione el Documento ";
                opt.SupportMultiDottedExtensions = true;
                opt.DefaultExt = "*.docx";
                opt.Filter = "Archivos de Documentos (*.docx)|*.docx| All files (*.*)|*.*";
                opt.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                opt.FileName = "";

                if (opt.ShowDialog(this) == DialogResult.OK)
                {

                    // Leer todo el archivo de bytes
                    byte[] cadenaBytes = File.ReadAllBytes(opt.FileName);
                    this.pbDocumento.Tag = cadenaBytes;
               //     this.pbDocumentacion.Image = Electronics.Properties.Resources.MSWordAcepted;

                }

            }
            catch (Exception er)
            {
                string msg = "";
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void GenerarImagen()
        {
            string mapeargTexto = "Codigo:   "+txtCodigo.Text+
                "\n Cantidad:   "+ txtCantidad.Text+ 
                "\n Fecha Facturacion:   " + dtpFecha.Value.ToString();

            if (string.IsNullOrWhiteSpace(mapeargTexto))
            {
                MessageBox.Show("Escribe un texto primero");
                return;
            }

            // Crear imagen
            Bitmap bmp = new Bitmap(400, 200);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                Font fuente = new Font("Arial", 20, FontStyle.Bold);
                Brush colorTexto = Brushes.Black;

                // Dibujar texto centrado
                StringFormat formato = new StringFormat();
                formato.Alignment = StringAlignment.Center;
                formato.LineAlignment = StringAlignment.Center;

                g.DrawString(mapeargTexto, fuente, colorTexto,
                    new RectangleF(0, 0, bmp.Width, bmp.Height), formato);
            }

            // Ruta de Descargas
            string rutaDescargas = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                "Downloads"
            );

            string nombreArchivo = "imagen_texto.png";
            string rutaCompleta = Path.Combine(rutaDescargas, nombreArchivo);

            // Guardar imagen
            bmp.Save(rutaCompleta, ImageFormat.Png);

            MessageBox.Show("Imagen guardada en: " + rutaCompleta);
        }
        private void pbDocumento_Click(object sender, EventArgs e)
        {
            GenerarImagen();
            SeleccionarArchivoPng();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
