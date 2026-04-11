using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTN.Winform.Electronicos.UI.Filtros
{
    public partial class FrmFiltroCliente: Form
    {
        public FrmFiltroCliente()
        {
            InitializeComponent();
        }

        private void toolStripBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripBtnBuscar_Click(object sender, EventArgs e)
        {
        
        }

        private void toolStripBtnNuevo_Click(object sender, EventArgs e)
        {
            txtFiltro.Text = string.Empty;
            dgvDatos.Rows.Clear();
        }
    }
}
