using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodigoGenerico;
using Datos;
using Negocio;

namespace Presentacion
{
    public partial class frmAgregarEdificio : Form
    {
        public frmAgregarEdificio()
        {
            InitializeComponent();
        }

        private void pbxSalirAgregarTipo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool band = false;

            if (txtNombre.Text == "" || txtDireccion.Text == "" || txtMontoExpensas.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "ALERTA");
            }
            else
            {
                try
                {
                    Edificio edificio = new Edificio();

                    edificio.Nombre = txtNombre.Text;
                    edificio.Direccion = txtDireccion.Text;
                    edificio.IDLocalidad = cbxLocalidad.SelectedIndex + 1;
                    edificio.IDBarrio = Convert.ToInt64(cbxBarrio.SelectedValue);
                    edificio.MontoExpensas = Convert.ToInt32(txtMontoExpensas.Text);

                    clsEdificio clsEdif = new clsEdificio();
                    clsEdif.Crear(edificio);
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("NO SE REGISTRÓ EL EDIFICIO" + ex2.ToString());
                    band = true;
                }
                finally
                {
                    if (band == false)
                    {
                        MessageBox.Show("EL EDIFICIO SE REGISTRÓ EXITOSAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }

        private void frmAgregarEdificio_Load(object sender, EventArgs e)
        {
            CodGenerico codGenerico = new CodGenerico();

            codGenerico.LlenarComboLocalidad(cbxLocalidad);

            codGenerico.LlenarComboBarrio(cbxBarrio);
        }

        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
