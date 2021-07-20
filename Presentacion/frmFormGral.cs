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
    public partial class frmFormGral : Form
    {
        public frmFormGral()
        {
            InitializeComponent();
        }

        private void btnCerrarInquilino_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
