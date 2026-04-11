using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Electronicos.BLL;
using ZXing;

namespace UTN.Winform.Electronicos.UI.Mantenimientos
{
    public partial class FrmProducto: Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }



        private void lsbEspecificaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #region Codigo Barras
        public void GuardarQRBarra()
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\codigo.png";
            pbCodigoBarras.Image.Save(ruta, System.Drawing.Imaging.ImageFormat.Png);
            MessageBox.Show("Código guardado");
        }
        public void CrearMiCodigoBarras()
        {
            // 🔹 Tus 3 strings
            string Cod = txtCod.Text;
            string Color =txtColor.Text;
            string Precio =txtPrecio.Text;

            // 🔹 Unir los 3 strings
            string datosCodigoBarras = Cod + "|" + Color + "|" + Precio;

            // 🔹 Crear el generador de código de barras
            BarcodeWriter writer = new BarcodeWriter()
            {
                Format = BarcodeFormat.CODE_128, // tipo de código
                Options = new ZXing.Common.EncodingOptions
                {
                    Width = 300,
                    Height = 100,
                    Margin = 10
                }
            };

            // 🔹 Generar imagen
            Bitmap barcodeImage = writer.Write(datosCodigoBarras);

            // 🔹 Mostrar en PictureBox
            pbCodigoBarras.Image = barcodeImage;
        }
        #endregion

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            CargarGrid();

        }
        #region Metodos Adiccionales

        public void Validaciones()
        {

        }
        public void CargaCombos()
        {

        }

        public async void CargarGrid()
        {
            BLLProductos productos = new BLLProductos();
            dgvInfoShow.AutoGenerateColumns = true;
            dgvInfoShow.DataSource = await productos.GetAllObject();
        }


        #endregion


        #region Crud Productos

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

        }



        #endregion

    }
}
