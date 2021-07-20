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
    public partial class frmAgregarBarrio : Form
    {
        public frmAgregarBarrio()
        {
            InitializeComponent();

            CodGenerico codGenerico = new CodGenerico();
            codGenerico.LlenarComboLocalidad(cbxLocalidad);
        }

        private void pbxSalirAgregarZona_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool band = false;

            if (txtBarrio.Text == "" || txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "ALERTA");
            }
            else
            {
                try
                {
                    Barrio barrio = new Barrio();

                    
                    barrio.Nombre = txtBarrio.Text;
                    barrio.IDLocalidad = Convert.ToInt64(cbxLocalidad.SelectedValue);
                    barrio.Descripcion = txtDescripcion.Text;

                    clsBarrio clsZon = new clsBarrio();
                    clsZon.Crear(barrio);
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("NO SE REGISTRÓ EL BARRIO" + ex2.ToString());
                    band = true;
                }
                finally
                {
                    if (band == false)
                    {
                        MessageBox.Show("EL BARRIO SE REGISTRÓ EXITOSAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }
    }
}
