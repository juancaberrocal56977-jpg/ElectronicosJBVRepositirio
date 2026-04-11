using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Electronicos.UI.Informacion;
using UTN.Winform.Electronicos.UI.Mantenimientos;
using UTN.Winform.Electronicos.UI.Proceso_Facturacion;

namespace UTN.Winform.Electronicos.UI.Principal
{
    public partial class FrmElectronicos : Form
    {
        public FrmElectronicos()
        {
            InitializeComponent();
        }

        private void FrmElectronicos_Load(object sender, EventArgs e)
        {
            tsdtime.Text = DateTime.Now.ToString();
        }

        private void mToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmModelo frmModelo = new FrmModelo();
            frmModelo.ShowDialog();
        }

        private void tsmiMarcasElectronicos_Click(object sender, EventArgs e)
        {
            FrmMarca frmMarca = new FrmMarca();
            frmMarca.ShowDialog();
        }

        private void tsmiProcesoFacturacion_Click(object sender, EventArgs e)
        {
            FrmFacturacion  fact1= new FrmFacturacion();
        
               fact1.ShowDialog();
        
        }

        private void tsmiClienteElectronico_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.ShowDialog();
        }

        private void tsmiProductoElectronicos_Click(object sender, EventArgs e)
        {
            FrmProducto frmProducto = new FrmProducto();
             frmProducto.ShowDialog();

        }
        private void tsmiTipo_Click(object sender, EventArgs e)
        {
            FrmTipo frmTipo = new FrmTipo();    
            frmTipo.ShowDialog();   

        }

        private void tsmiStock_Click(object sender, EventArgs e)
        {
            FrmStock frmStock = new FrmStock();
            frmStock.ShowDialog();
        }

        private void tsmiAcercaDeInfo_Click(object sender, EventArgs e)
        {
            FrmAcercaDe frmAcercaDe = new FrmAcercaDe();
            frmAcercaDe.ShowDialog();
        }

        #region Reportes Electronicos
        private void tsmiRP_Click(object sender, EventArgs e)
        {

        }

        private void tsmiRF_Click(object sender, EventArgs e)
        {

        }

        private void tsmiRC_Click(object sender, EventArgs e)
        {

        }

        private void tsmiRV_Click(object sender, EventArgs e)
        {

        }

        #endregion

     
    }
}
     