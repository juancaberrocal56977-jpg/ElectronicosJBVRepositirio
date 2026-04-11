using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.Winform.Electronicos.BLL.InterfacesBLL;

namespace UTN.Winform.Electronicos.UI.Mantenimientos
{
    public partial class FrmModelo: Form
    {
        public FrmModelo()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
        public async void RefreshGrid()
        {
            BLLModelo modelo = new BLLModelo();
            dgvInfoShow.DataSource = await modelo.GetAllObject();
                dgvInfoShow.AutoGenerateColumns = true;       
        }
        private void FrmModelo_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
