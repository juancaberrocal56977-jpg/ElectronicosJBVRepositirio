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
using UTN.Winform.Electronicos.BLL.InterfacesBLL;
using UTN.Winform.Electronicos.BLL;
using UTN.Winform.Electronicos.Exeptions;
using log4net;
using UTN.Winform.Electronicos.Entidades;

namespace UTN.Winform.Electronicos.UI.Filtros
{
    public partial class FrmClienteFiltros : Form
    {

        private static readonly ILog _myLogControlEventos =
log4net.LogManager.GetLogger("MyControlEventos");
        internal Cliente ClienteN { get; private set; } = null;
        public FrmClienteFiltros()
        {
            InitializeComponent();
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDatos.RowCount > 0 && dgvDatos.SelectedRows.Count > 0)
                {
                    if (dgvDatos.CurrentCell.Selected)
                    {
                        this.ClienteN = dgvDatos.SelectedRows[0].DataBoundItem as Cliente;
                        this.DialogResult = DialogResult.OK;
                    }
                }
            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void toolStripBtnBuscar_Click(object sender, EventArgs e)
        {

            IBLLCliente clienteFiltrado = new BLLCliente();
            string filtro = string.Empty;

            try
            {
                filtro = this.txtFiltro.Text;
                filtro = filtro.Replace(' ', '%');
                filtro = "%" + filtro + "%";
                this.dgvDatos.AutoGenerateColumns = false;
                this.dgvDatos.DataSource = clienteFiltrado.GetClienteByFilter(filtro);

            }
            catch (Exception er)
            {
                string msg = "";
                _myLogControlEventos.ErrorFormat("Error {0}", msg.ToExceptionDetail(er, MethodBase.GetCurrentMethod()));
                MessageBox.Show("Se ha producido el siguiente error: " + er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            txtFiltro.Text=string.Empty;
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmClienteFiltros_Load(object sender, EventArgs e)
        {
            dgvDatos.AutoGenerateColumns = true;
            //dgvDatos.RowTemplate.Height = 60;
            //dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

            BLLProductos productos = new BLLProductos();
            dgvDatos.DataSource = productos.GetAllObject();
        }
    }
}
