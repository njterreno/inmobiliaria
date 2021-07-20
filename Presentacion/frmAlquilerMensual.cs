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
    public partial class frmAlquilerMensual : Form
    {
        public frmAlquilerMensual()
        {
            InitializeComponent();
        }

        private void pbxSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        
    }
}
