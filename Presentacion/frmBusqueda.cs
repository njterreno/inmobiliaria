using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmBusqueda : Form
    {
        public frmBusqueda()
        {
            InitializeComponent();
        }

        private void pbxSalirBusqueda_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxMinimizarBusqueda_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmInqPropGar Inq = new frmInqPropGar(frmInicio.Opciones.Garantes);
            Inq.StartPosition = FormStartPosition.CenterParent;
            Inq.pbxSalir.Visible = true;
            Inq.pbxMinimizar.Visible = true;
            Inq.ShowDialog();
        }
    }
}
