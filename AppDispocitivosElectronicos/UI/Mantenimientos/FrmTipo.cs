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
using UTN.Winform.Electronicos.Entidades;

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
        public async void Opcion1 (){
             BLLTipoDispositivo dispositivo = new BLLTipoDispositivo();
        TipoDispositivo diS = new TipoDispositivo();
            ////Validaciones
            if (string.IsNullOrEmpty(txtCod.Text))
            {
                MessageBox.Show("Dato del codigo del tipo requerido" + MessageBoxIcon.Error);
            }
            if (string.IsNullOrEmpty(txtDesc.Text))
            {
                MessageBox.Show("Dato del Nombre del tipo requerido" + MessageBoxIcon.Error);
            }
                diS.Codigo = txtCod.Text;
                diS.Nombre = txtDesc.Text;
                if (this.ckActivo.Checked)
                    diS.Estado = true;
                if (this.ckInactivo.Checked)
                    diS.Estado = false;


                await dispositivo.Save(diS);

                Refrescar();
            }
        private  void btnAceptar_Click(object sender, EventArgs e)
        {

            Opcion1();
         
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            TipoDispositivo obj = null;

            if (this.dgvInfoShow.SelectedRows.Count > 0)
            {
                // Cambiar de estado

                obj = this.dgvInfoShow.SelectedRows[0].DataBoundItem as TipoDispositivo;
                this.txtCod.Text = obj.Codigo;
                this.txtDesc.Text = obj.Nombre;

                this.ckActivo.Checked = obj.Estado == true;
                this.ckInactivo.Checked = obj.Estado == false;



            }

        }
        public async void Refrescar()
        {
            BLLTipoDispositivo dispositivo = new BLLTipoDispositivo();
            dgvInfoShow.AutoGenerateColumns = true;
            dgvInfoShow.DataSource= await dispositivo.GetAllObject();

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            BLLTipoDispositivo  dispositivo= new BLLTipoDispositivo();
            dispositivo.Delete(txtCod.Text);

            //refrescar
            Refrescar();
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
