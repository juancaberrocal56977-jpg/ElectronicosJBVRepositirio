using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Electronicos.BLL;
using UTN.Winform.Electronicos.BLL.InterfacesBLL;
using UTN.Winform.Electronicos.DAL.InterfacesDAL;
using UTN.Winform.Electronicos.Entidades;
using UTN.Winform.Electronicos.Exeptions;

namespace UTN.Winform.Electronicos.UI.Mantenimientos
{
    public partial class frmMantenimientoProvincia: Form
    {
        private static readonly ILog _myLogControlEventos =
log4net.LogManager.GetLogger("MyControlEventos");
        public frmMantenimientoProvincia()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void frmMantenimientoProvincia_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}",
msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " +
er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void LoadData()
        {
            IBLLProvincias bllProvincia = new BLLProvincia();

            try
            {
                // Cambiar el estado 
              //  this.ChangeState(EstadoMantenimiento.Ninguno);
                // Configuracion del DataGridView para que se vea bien la imagen. 
                dgvDatos.AutoGenerateColumns = false;
                // dgvDatos.RowTemplate.Height = 100; 
                dgvDatos.AutoSizeColumnsMode =
DataGridViewAutoSizeColumnsMode.DisplayedCells;
                // Cargar el DataGridView 
                this.txtProvincia.Text = bllProvincia.GetProvinciaFromInternet(2).ToString();
            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}",
msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " +
er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                BLLProvincia bllProvincia = new BLLProvincia();
                Provincia provincia =
bllProvincia.GetProvinciaFromInternet(Convert.ToInt16(this.txtProvincia.Text));
                if (provincia == null)
                {
//                    MessageBox.Show($"Error el código {txtProvincia.Text} NO 
//existe", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    return;
                }
                this.txtProvincia.Text = provincia.IdProvincia.ToString();
                this.txtDescripcion.Text = provincia.Descripcion;
            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}",
msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " +
er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void brnEditar_Click(object sender, EventArgs e)
        {
            this.txtProvincia.Enabled = false;
            this.txtDescripcion.Enabled = true;
            this.btnAceptar.Enabled = true;
            this.btnCancelar.Enabled = true;
            txtDescripcion.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtProvincia.Enabled = true;
            this.txtDescripcion.Enabled = true;
            this.btnAceptar.Enabled = true;
            this.btnCancelar.Enabled = true;
            txtProvincia.Focus();
        }
    }
}
