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
    public partial class frmPropiedades : frmFormGral
    {
        string accion;
        CodGenerico codGenerico = new CodGenerico();

        public frmPropiedades()
        {
            InitializeComponent();

            //CodGenerico codGenerico = new CodGenerico();

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

        private void btnAgregarZona_Click(object sender, EventArgs e)
        {
            frmAgregarBarrio agregarzona = new frmAgregarBarrio();

            agregarzona.cbxLocalidad.SelectedValue = cbxLocalidad.SelectedValue;

            agregarzona.ShowDialog();
        }

        private void btnAgregarTipo_Click(object sender, EventArgs e)
        {
            frmAgregarTipo agregarTipo = new frmAgregarTipo();

            agregarTipo.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool band = false;
            CodGenerico codGenerico = new CodGenerico();

            if (cbxPropietario.Text == "" || txtDireccion.Text == "" || txtTamaño.Text == "" || txtCantHabitac.Text == "" || txtCantBaños.Text == "")
            {
                MessageBox.Show("Por favor llene todos los campos", "ALERTA");
            }
            else
            {
                if (txtIDPropiedad.Text == "")//Insertar
                {
                    try
                    {
                        Propiedad objPropiedad = new Propiedad();

                        objPropiedad.IDPropietario = Convert.ToInt64(cbxPropietario.SelectedValue);
                        objPropiedad.IDBarrio = Convert.ToInt64(cbxBarrio.SelectedValue);
                        objPropiedad.IDTipo = Convert.ToInt64(cbxTipo.SelectedValue);
                        objPropiedad.IDEdificio = Convert.ToInt64(cbxEdificio.SelectedValue);
                        objPropiedad.IDEstado = Convert.ToInt64(cbxEstado.SelectedValue);
                        objPropiedad.Direccion = txtDireccion.Text;
                        objPropiedad.IDLocalidad = Convert.ToInt64(cbxLocalidad.SelectedValue);
                        objPropiedad.Tamaño = txtTamaño.Text;
                        objPropiedad.CantHabitac = txtCantHabitac.Text;
                        objPropiedad.CantBaños = txtCantBaños.Text;

                        if (chkPatio.Checked == true)
                            objPropiedad.Patio = "SI";
                        else
                            objPropiedad.Patio = "NO";

                        if (chkCochera.Checked == true) objPropiedad.Cochera = "SI"; else objPropiedad.Cochera = "NO";
                        if (chkGarage.Checked == true) objPropiedad.Garage = "SI"; else objPropiedad.Garage = "NO";
                        if (chkCocina.Checked == true) objPropiedad.Cocina = "SI"; else objPropiedad.Cocina = "NO";
                        if (chkCocina.Checked == true) objPropiedad.Comedor = "SI"; else objPropiedad.Comedor = "NO";
                        if (chkVistaCalle.Checked == true) objPropiedad.VistaCalle = "SI"; else objPropiedad.VistaCalle = "NO";
                        if (chkGasNatural.Checked == true) objPropiedad.GasNatural = "SI"; else objPropiedad.GasNatural = "NO";
                        if (chkPileta.Checked == true) objPropiedad.Pileta = "SI"; else objPropiedad.Pileta = "NO";
                        if (chkAsador.Checked == true) objPropiedad.Asador = "SI"; else objPropiedad.Asador = "NO";

                        clsPropiedad clsPropied = new clsPropiedad();
                        clsPropied.CrearModificar(objPropiedad);
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("NO SE REGISTRÓ LA PROPIEDAD" + ex2.ToString());
                        band = true;
                    }
                    finally
                    {
                        if (band == false)
                        {
                            MessageBox.Show("LA PROPIEDAD SE REGISTRÓ EXITOSAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (this.TopLevelControl.Name != "frmInicio")
                            {
                                this.Close();
                            }
                        }
                    }
                }
                else//actualizar
                {
                    try
                    {
                        Propiedad objPropiedad = new Propiedad();

                        objPropiedad.IDPropiedad = Convert.ToInt64(txtIDPropiedad.Text);
                        objPropiedad.IDPropietario = Convert.ToInt64(cbxPropietario.SelectedValue);
                        objPropiedad.IDBarrio = Convert.ToInt64(cbxBarrio.SelectedValue);
                        objPropiedad.IDTipo = Convert.ToInt64(cbxTipo.SelectedValue);
                        objPropiedad.IDEdificio = Convert.ToInt64(cbxEdificio.SelectedValue);
                        objPropiedad.IDEstado = Convert.ToInt64(cbxEstado.SelectedValue);
                        objPropiedad.Direccion = txtDireccion.Text;
                        objPropiedad.IDLocalidad = Convert.ToInt64(cbxLocalidad.SelectedValue);
                        objPropiedad.Tamaño = txtTamaño.Text;
                        objPropiedad.CantHabitac = txtCantHabitac.Text;
                        objPropiedad.CantBaños = txtCantBaños.Text;
                        objPropiedad.PisoNro = txtPisoNro.Text;

                        if (chkPatio.Checked == true)
                            objPropiedad.Patio = "SI";
                        else
                            objPropiedad.Patio = "NO";

                        if (chkCochera.Checked == true) objPropiedad.Cochera = "SI"; else objPropiedad.Cochera = "NO";
                        if (chkGarage.Checked == true) objPropiedad.Garage = "SI"; else objPropiedad.Garage = "NO";
                        if (chkCocina.Checked == true) objPropiedad.Cocina = "SI"; else objPropiedad.Cocina = "NO";
                        if (chkCocina.Checked == true) objPropiedad.Comedor = "SI"; else objPropiedad.Comedor = "NO";
                        if (chkVistaCalle.Checked == true) objPropiedad.VistaCalle = "SI"; else objPropiedad.VistaCalle = "NO";
                        if (chkGasNatural.Checked == true) objPropiedad.GasNatural = "SI"; else objPropiedad.GasNatural = "NO";
                        if (chkPileta.Checked == true) objPropiedad.Pileta = "SI"; else objPropiedad.Pileta = "NO";
                        if (chkAsador.Checked == true) objPropiedad.Asador = "SI"; else objPropiedad.Asador = "NO";

                        clsPropiedad clsPropied = new clsPropiedad();
                        clsPropied.CrearModificar(objPropiedad);
                        codGenerico.PropiedadActualizada(dgvDatosPropiedades, Convert.ToInt64(txtIDPropiedad.Text));

                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("NO SE ACTUALIZÓ LA PROPIEDAD" + ex2.ToString());
                        band = true;
                    }
                    finally
                    {
                        if (band == false)
                        {
                            MessageBox.Show("LA PROPIEDAD SE ACTUALIZÓ EXITOSAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            codGenerico.LimpiaCampos(panel1);

                            if (this.TopLevelControl.Name != "frmInicio")
                            {
                                this.Close();
                            }
                        }
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string edificio = "", barrio = "", pisonro = "";
            dgvDatosPropiedades.Rows.Clear();

            clsPropiedad clsPropied = new clsPropiedad();
            List<Propiedad> lstPropied = clsPropied.Listar();

            foreach (var itemP in lstPropied)
            {
                if (itemP.IDEdificio != null) edificio = itemP.Edificio.Nombre; else edificio = "";
                if (itemP.IDBarrio != null) barrio = itemP.Barrio.Nombre; else barrio = "";
                if (itemP.PisoNro == "-") pisonro = ""; else pisonro = " - " + itemP.PisoNro;
                //itemP.Barrio.Localidad.Nombre
                clsLocalidad clsLoc = new clsLocalidad();
                List<Localidad> lstL = clsLoc.ListarXID(itemP.IDLocalidad);

                foreach (var itemL in lstL)
                {
                    this.dgvDatosPropiedades.Rows.Add(itemP.IDPropiedad, itemP.Direccion + " " + pisonro, edificio, barrio, itemL.Nombre, itemP.Tipo.Nombre, itemP.CantHabitac, itemP.Patio, itemP.Asador, itemP.Cochera);
                }
            }
        }

        private void btnAgregarEdificio_Click(object sender, EventArgs e)
        {
            frmAgregarEdificio frmAgregarEdif = new frmAgregarEdificio();
            frmAgregarEdif.ShowDialog();
        }

        private void cbxEdificio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbxTipo.Text != "Casa" || cbxTipo.Text != "Galpon")
            {
                clsEdificio clsEdif = new clsEdificio();
                List<Edificio> lstE = clsEdif.ListarXID(Convert.ToInt64(cbxEdificio.SelectedValue));

                foreach (var item in lstE)
                {
                    cbxLocalidad.SelectedValue = item.IDLocalidad;
                    cbxBarrio.SelectedValue = item.IDBarrio;
                    txtDireccion.Text = item.Direccion;
                }
            }
        }

        private void cbxLocalidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            clsBarrio clsBar = new clsBarrio();
            List<Barrio> lstB = clsBar.ListarXLoc(Convert.ToInt64(cbxLocalidad.SelectedValue));

            if (lstB.Count > 0)
            {
                foreach (var item in lstB)
                {
                    cbxBarrio.DataSource = lstB;
                    cbxBarrio.ValueMember = "IDBarrio";
                    cbxBarrio.DisplayMember = "Nombre";
                }
            }
            else
            {
                cbxBarrio.DataSource = null;
                cbxBarrio.Items.Clear();
            }

        }

        private void pbxSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cbxBarrio_Click(object sender, EventArgs e)
        {
            clsBarrio clsBar = new clsBarrio();
            List<Barrio> lstB = clsBar.ListarXLoc(Convert.ToInt64(cbxLocalidad.SelectedValue));

            foreach (var item in lstB)
            {
                cbxBarrio.DataSource = lstB;
                cbxBarrio.ValueMember = "IDBarrio";
                cbxBarrio.DisplayMember = "Nombre";
            }
        }

        private void btnBuscarPropietario_Click(object sender, EventArgs e)
        {
            frmInqPropGar frmIngPropGar = new frmInqPropGar(frmInicio.Opciones.Propietarios);
            frmIngPropGar.pbxSalir.Visible = true;
            frmIngPropGar.pbxMinimizar.Visible = true;

            frmIngPropGar.ShowDialog();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            CodGenerico codGenerico = new CodGenerico();

            codGenerico.LimpiaCampos(panel1);
        }

        private void dgvDatosPropiedades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CodGenerico codGenerico = new CodGenerico();
            accion = "deshab";
            codGenerico.HabDeshabCampos(panel1, accion);

            if (e.RowIndex > -1)
            {
                Propiedad objPropied = new Propiedad();
                clsPropiedad clsPropied = new clsPropiedad();

                Int64 id = Convert.ToInt64(dgvDatosPropiedades.Rows[e.RowIndex].Cells["Column10"].Value);
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
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            accion = "habilitar";
            CodGenerico codGenerico = new CodGenerico();
            codGenerico.HabDeshabCampos(panel1, accion);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtIDPropiedad.TextLength != 0)
            {
                frmConsAlqXPropied consAlqXPropied = new frmConsAlqXPropied();
                codGenerico.LlenarGrillaPropiedades(consAlqXPropied.dgvAlquileresXPropied, txtIDPropiedad, consAlqXPropied.lblCant, consAlqXPropied.lblMontoRecaudado);

                consAlqXPropied.ShowDialog();
                ////codGenerico.LlenarComboPropiedad(consAlqXPropied.cbxPropiedBusq);

                //consAlqXPropied.cbxPropiedBusq.SelectedIndex = Convert.ToInt32(txtIDPropiedad.Text) - 1;

                //consAlqXPropied.dgvAlquileresXPropied.Rows.Clear();

                //clsAlquiler clsAlq = new clsAlquiler();

                //List<Alquiler> lstAlq = clsAlq.ListarXPropied((Int64)consAlqXPropied.cbxPropiedBusq.SelectedValue);

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

                //    consAlqXPropied.dgvAlquileresXPropied.Rows.Add(item.IDAlquiler, item.Inquilino.NombreYApellido, item.FechaInicioContrato.ToShortDateString(), item.FechaFinContrato.ToShortDateString(), item.MontoAlquiler, Estado);

                //    inCantVecesAlq = consAlqXPropied.dgvAlquileresXPropied.Rows.Count;
                //    inMontoRecaudado = inMontoRecaudado + item.MontoAlquiler;
                //}

                //consAlqXPropied.lblCant.Text = inCantVecesAlq.ToString();
                //consAlqXPropied.lblMontoRecaudado.Text = "$" + inMontoRecaudado.ToString();

                //consAlqXPropied.ShowDialog();

                ////consAlqXPropied.btnBuscar.PerformClick();
            }
            else
            {
                MessageBox.Show("SELECCIONE UNA PROPIEDAD");
            }
            
        }
    }
}
