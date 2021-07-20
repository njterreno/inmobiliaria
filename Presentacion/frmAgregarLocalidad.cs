using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Negocio;
using CodigoGenerico;

namespace Presentacion
{
    public partial class frmAgregarLocalidad : Form
    {
        public frmAgregarLocalidad()
        {
            InitializeComponent();

            clsProvincia prov = new clsProvincia();

            List<Provincia> Lista = prov.Listar();

            cbxProvincia.Items.Clear();
            cbxProvincia.DataSource = Lista;
            cbxProvincia.ValueMember = "IDProvincia";
            cbxProvincia.DisplayMember = "nombre";
        }

        private void pbxSalirAgregarLocalidad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxMinimizarAgregarLocalidad_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodPos.Text != "" || txtLocalidad.Text != "")
            {
                bool band = false;

                try
                {
                    Localidad objLoc = new Localidad();

                    objLoc.CodigoPostal = Convert.ToInt32(txtCodPos.Text);
                    objLoc.Nombre = txtLocalidad.Text.ToUpper();
                    objLoc.IDProvincia = Convert.ToInt64(cbxProvincia.SelectedValue);

                    clsLocalidad clsLoc = new clsLocalidad();
                    clsLoc.CrearModificar(objLoc);
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("NO SE AGREGÓ LA LOCALIDAD" + ex2.ToString());
                    band = true;
                }
                finally
                {
                    if (band == false)
                    {
                        MessageBox.Show("LA LOCALIDAD SE AGREGÓ EXITOSAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos", "ALERTA");
            }

            this.Close();
        }
    }
}
