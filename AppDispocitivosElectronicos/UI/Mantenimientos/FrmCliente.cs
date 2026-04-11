using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Electronicos.BLL;
using UTN.Winform.Electronicos.BLL.InterfacesBLL;
using UTN.Winform.Electronicos.Entidades;
using UTN.Winform.Electronicos.Entidades.DTO;
using UTN.Winform.Electronicos.Exeptions;

namespace UTN.Winform.Electronicos.UI.Mantenimientos
{
    public partial class FrmCliente: Form
    {
        private static readonly ILog _MyLogControlEventos = log4net.LogManager.GetLogger("MyControlEventos");
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }
         public async void RefreshGrid()
        {

            BLLCliente cliente = new BLLCliente();
            // dgvInfoShow.Rows.Clear();

           
            dgvInfoShow.DataSource =await cliente.GetAllCliente();
            dgvInfoShow.AutoGenerateColumns = true;

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            BLLCliente cliente = new BLLCliente();

            ///invocar el cliente
            Cliente datosCliente = new Cliente();
            ///Mappear datos
           datosCliente.Codigo=txtCod.Text;


            ///Guarda o actualiza si ya existe
            cliente.SaveCliente(datosCliente);
            ///Actualizar el datagrid
            Refresh();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
           

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ///Borro el registro
            BLLCliente cliente = new BLLCliente();
            cliente.DeleteCliente(txtCod.Text);
            ///actualizar datos
            Refresh();
            

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.tlpControlesCliente.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Clear();

                else if (ctrl is ComboBox)
                    ((ComboBox)ctrl).SelectedIndex = -1;

                else if (ctrl is CheckBox)
                    ((CheckBox)ctrl).Checked = false;

                ////Mappear los demas controles
                else if (ctrl is NumericUpDown)
                    ((NumericUpDown)ctrl).Value = 1;

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultarId_Click(object sender, EventArgs e)
        {
            ErrorProvider erp = new ErrorProvider();

           IBLLPadron _BLLPadron = new BLLPadron();
           try
           {
               erp.Clear();

               if (string.IsNullOrEmpty(txtCod.Text))
               {
                   erp.SetError(txtCod, "Id Requerido");
                   txtCod.Focus();
                   return;
               }

               if (txtCod.Text.Trim().Length != 9)
               {
                   erp.SetError(txtCod, "Largo de la Cédula 9 digitos");
                   txtCod.Focus();
                   return;
               }


               // ToDo: Cree La validación que solo permita números en la cédula 

               PadronDTO oPadronDTO = _BLLPadron.GetPersonaById(txtCod.Text.Trim());


               string[] array = oPadronDTO.nombre.Split(' ');

               // 1 nombres y dos apellidos
               if (array.Length == 3)
               {
                   txtNombre.Text = array[0];
                   txtApellido1.Text = array[1];
                   txtApellido2.Text = array[2];
               }

               // 2 nombres y dos apellidos
               if (array.Length == 4)
               {
                   txtNombre.Text = array[0] + " " + array[1];
                   txtApellido1.Text = array[2];
                   txtApellido2.Text = array[3];
               }

               // Ejemplo con varios nombres. 203960070 - ANTONIO MARIA DE LA TRINIDAD RODRIGUEZ CHAVES 
               // 2 nombres y dos apellidos
               // Nota: No se valida apellidos compuestos por ejemplo Maria de la O
               if (array.Length > 4)
               {
                   txtNombre.Text = array[0] + " " + array[1];
                   txtApellido1.Text = array[array.Length-2];
                   txtApellido2.Text = array[array.Length-1];
               }

           }
           catch (Exception er)
           {
               string msg = "";
               _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
               MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

           }


            
        }

        private void dgvInfoShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void pbImagen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opt = new OpenFileDialog();
                opt.Title = "Seleccione la Imagen ";
                opt.SupportMultiDottedExtensions = true;
                opt.DefaultExt = "*.jpg";
                opt.Filter = "Archivos de Imagenes (*.jpg)|*.jpg| All files (*.*)|*.*";
                opt.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                opt.FileName = "";

                if (opt.ShowDialog(this) == DialogResult.OK)
                {

                    //ruta = opt.FileName.Trim();
                    this.pbImagen.ImageLocation = opt.FileName;
                    pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;

                    byte[] cadenaBytes = File.ReadAllBytes(opt.FileName);

                    // Guarla la imagenen Bytes en el Tag de la imagen.
                    pbImagen.Tag = (byte[])cadenaBytes;

                }
            }
            catch (Exception er)
            {
                string msg = "";
                _MyLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
