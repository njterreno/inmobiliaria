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

namespace Presentacion
{
    public partial class frmAgregarTipo : Form
    {
        public frmAgregarTipo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool band = false;

            if (txtTipo.Text == "" || txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "ALERTA");
            }
            else
            {
                try
                {
                    Tipo tipo = new Tipo();

                    tipo.Nombre = txtTipo.Text;
                    tipo.Descripcion = txtDescripcion.Text;

                    clsTipo clsTip = new clsTipo();
                    clsTip.Crear(tipo);
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("NO SE REGISTRÓ EL TIPO" + ex2.ToString());
                    band = true;
                }
                finally
                {
                    if (band == false)
                    {
                        MessageBox.Show("EL TIPO SE REGISTRÓ EXITOSAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }

        private void pbxSalirAgregarTipo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
