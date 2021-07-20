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
using System.IO;

namespace Presentacion
{
    public partial class frmConsAlqXPropied : frmFormGral
    {
        public frmConsAlqXPropied()
        {
            InitializeComponent();

            CodGenerico codGenerico = new CodGenerico();

            string accion = "deshab";
            codGenerico.HabDeshabCampos(panel1, accion);

            codGenerico.LlenarComboPropiedad(cbxPropiedBusq);

            //codGenerico.LlenarComboBarrio(cbxBarrio);
            codGenerico.LlenarComboTipo(cbxTipo);
            codGenerico.LlenarComboEstado(cbxEstado);
            codGenerico.LlenarComboEdificio(cbxEdificio);
            codGenerico.LlenarComboLocalidad(cbxLocalidad);


            clsPropietario clsPropiet = new clsPropietario();

            List<Propietario> Lista = clsPropiet.Listar();

            cbxPropietario.DataSource = Lista;
            cbxPropietario.ValueMember = "IDPropietario";
            cbxPropietario.DisplayMember = "NombreYApellido";

            clsBarrio clsBar = new clsBarrio();
            List<Barrio> lstB = clsBar.ListarXLoc(Convert.ToInt64(cbxLocalidad.SelectedValue));

            foreach (var item in lstB)
            {
                cbxBarrio.DataSource = lstB;
                cbxBarrio.ValueMember = "IDBarrio";
                cbxBarrio.DisplayMember = "Nombre";
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtIDPropiedad.TextLength != 0)
            {
                CodGenerico codGnerico = new CodGenerico();
                codGnerico.LlenarGrillaPropiedades(dgvAlquileresXPropied, txtIDPropiedad, lblCant, lblMontoRecaudado);
            }
            //dgvAlquileresXPropied.Rows.Clear();

            //clsAlquiler clsAlq = new clsAlquiler();

            //List<Alquiler> lstAlq = clsAlq.ListarXPropied((Int64)cbxPropiedBusq.SelectedValue);

            //string Estado;
            //int inCantVecesAlq = 0;
            //int inMontoRecaudado = 0;

            //foreach (var item in lstAlq)
            //{
            //    if (DateTime.Today >= item.FechaFinContrato)
            //    {
            //        Estado = "FINALIZADO";
            //    }
            //    else
            //    {
            //        Estado = "EN PROCESO";
            //    }

            //    dgvAlquileresXPropied.Rows.Add(item.IDAlquiler, item.Inquilino.NombreYApellido, item.FechaInicioContrato.ToShortDateString(), item.FechaFinContrato.ToShortDateString(), item.MontoAlquiler, Estado);

            //    inCantVecesAlq = dgvAlquileresXPropied.Rows.Count;
            //    inMontoRecaudado = inMontoRecaudado + item.MontoAlquiler;
            //}

            //lblCant.Text = inCantVecesAlq.ToString();
            //lblMontoRecaudado.Text = "$" + inMontoRecaudado.ToString();
        }

        private void pbxSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cbxPropiedBusq_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtIDPropiedad.Text = cbxPropiedBusq.SelectedValue.ToString();

            CodGenerico codGenerico = new CodGenerico();
            string accion = "deshab";
            codGenerico.HabDeshabCampos(panel1, accion);


            clsPropiedad clsPropied = new clsPropiedad();

            Int64 id = Convert.ToInt64(cbxPropiedBusq.SelectedValue);
            List<Propiedad> lstP = clsPropied.ListarXID(id);

            foreach (Propiedad itemP in lstP)
            {
                txtIDPropiedad.Text = itemP.IDPropiedad.ToString();
                cbxPropietario.SelectedValue = itemP.IDPropietario;
                cbxTipo.SelectedValue = itemP.IDTipo;
                txtDireccion.Text = itemP.Direccion;
                cbxLocalidad.SelectedValue = itemP.IDLocalidad;

                if (itemP.IDEdificio != null) cbxEdificio.SelectedValue = itemP.IDEdificio; else cbxEdificio.Text = "";

                if (itemP.IDBarrio != null) cbxBarrio.SelectedValue = itemP.IDBarrio; else cbxBarrio.Text = "";

                txtPisoNro.Text = itemP.PisoNro;
                cbxEstado.SelectedValue = itemP.IDEstado;
                txtTamaño.Text = itemP.Tamaño;
                txtCantHabitac.Text = itemP.CantHabitac;
                txtCantBaños.Text = itemP.CantBaños;

                if (itemP.Patio == "SI") chkPatio.Checked = true; else chkPatio.Checked = false;
                if (itemP.Cochera == "SI") chkCochera.Checked = true; else chkCochera.Checked = false;
                if (itemP.Garage == "SI") chkGarage.Checked = true; else chkGarage.Checked = false;
                if (itemP.Cocina == "SI") chkCocina.Checked = true; else chkCocina.Checked = false;
                if (itemP.Comedor == "SI") chkComedor.Checked = true; else chkComedor.Checked = false;
                if (itemP.VistaCalle == "SI") chkVistaCalle.Checked = true; else chkVistaCalle.Checked = false;
                if (itemP.GasNatural == "SI") chkGasNatural.Checked = true; else chkGasNatural.Checked = false;
                if (itemP.Pileta == "SI") chkPileta.Checked = true; else chkPileta.Checked = false;
                if (itemP.Asador == "SI") chkAsador.Checked = true; else chkAsador.Checked = false;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            dsConsultaPropiedades ds = new dsConsultaPropiedades();
            int filas = dgvAlquileresXPropied.Rows.Count;

            for (int i = 0; i <= filas-1; i++)
            {
                ds.Tables[0].Rows.Add
                (new object[]{ dgvAlquileresXPropied[1,i].Value.ToString(),
                    dgvAlquileresXPropied[2,i].Value.ToString(),
                    dgvAlquileresXPropied[3,i].Value.ToString(),
                    dgvAlquileresXPropied[4,i].Value.ToString(),
                    dgvAlquileresXPropied[5,i].Value.ToString()
                });
            }

            rptConsultaPropiedades rpt = new rptConsultaPropiedades();
            frmReporte frm = new frmReporte();
            rpt.SetDataSource(ds);
            frm.crvVisor.ReportSource = rpt;
            frm.crvVisor.Refresh();

            frm.Show();
        }
    }
}
