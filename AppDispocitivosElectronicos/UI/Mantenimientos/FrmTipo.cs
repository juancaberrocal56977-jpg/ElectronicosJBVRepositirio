using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Electronicos.BLL;

namespace UTN.Winform.Electronicos.UI.Mantenimientos
{
    public partial class FrmTipo: Form
    {
        public FrmTipo()
        {
            InitializeComponent();
        }

        private void FrmTipo_Load(object sender, EventArgs e)
        {
            this.RefreshGrid();
        }
        #region Metodos Adicionales

        public async void RefreshGrid() { 
          BLLTipoDispositivo tipoDispositivo    =   new BLLTipoDispositivo();
             dgvInfoShow.AutoGenerateColumns=true;
            dgvInfoShow.DataSource =await tipoDispositivo.GetAllObject();
        }
        #endregion

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
            txtCod.Text= string.Empty;
            txtDesc.Text= string.Empty;
            ckActivo.Checked = false;
            ckInactivo .Checked = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
