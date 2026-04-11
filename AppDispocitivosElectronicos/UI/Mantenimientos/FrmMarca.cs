using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using UTN.Winform.Electronicos.BLL;
using UTN.Winform.Electronicos.Entidades;
using UTN.Winform.Electronicos.Exeptions;

namespace UTN.Winform.Electronicos.UI.Mantenimientos
{
    public partial class FrmMarca: Form
    {
        ErrorProvider errorProvider= new ErrorProvider();
        public FrmMarca()
        {
            InitializeComponent();
        }

        private void dgvInfoShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region Metodos Adiccionales
        public void RefreshGrid()
        {
            BLLMarca bLLMarca = new BLLMarca();
            dgvInfoShow.AutoGenerateColumns = true;
            dgvInfoShow.DataSource = bLLMarca.SeleccionarTodos();
        }


        public void Validaciones()
        {
            if (txtCod.Text.Equals(""))
            {
                errorProvider.SetError(txtCod,"El codigo es requerido para la marca");
            }
            if (txtCod.Text.Equals(""))
            {
                errorProvider.SetError(txtDesc, "El dato es requerido para la marca");
            }


        }
        #endregion
        private void FrmMarca_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }
        #region CRUD Metodos
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            BLLMarca marca = new BLLMarca();
            Marcas marca1 = new Marcas();


            marca1.Codigo=txtCod.Text;
            marca1.Descripcion = txtDesc.Text;
            if (ckActivo.Checked)
            {
                marca1.Estado = true;
            }
            if (ckInactivo.Checked)
            {
                marca1.Estado = false;
            }

            Validaciones();   
            marca.Gueardar(marca1);

            txtCod.Text = string.Empty;
            txtDesc.Text = string.Empty;
            RefreshGrid();


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Marcas oMarcObj = null;

            if (this.dgvInfoShow.SelectedRows.Count > 0)
            {
                // Cambiar de estado

                oMarcObj = this.dgvInfoShow.SelectedRows[0].DataBoundItem as Marcas;
                this.txtCod.Text = oMarcObj.Codigo;
                this.txtDesc.Text = oMarcObj.Descripcion;

                this.ckActivo.Checked = oMarcObj.Estado == true;
                this.ckInactivo.Checked = oMarcObj.Estado == false;



            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BLLMarca marca = new BLLMarca();
            marca.Eliminar(txtCod.Text);
            this.RefreshGrid();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvInfoShow.DataSource=string.Empty;
            txtCod.Text=string.Empty;
            txtDesc.Text=string.Empty;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

            #endregion 
    }
}
