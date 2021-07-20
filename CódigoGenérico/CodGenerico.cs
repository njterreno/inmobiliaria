using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Negocio;
using System.Windows.Forms;


namespace CodigoGenerico
{
    public partial class CodGenerico
    {
        public void LlenarComboLocalidad(ComboBox cbx)
        {
            clsLocalidad loc = new clsLocalidad();

            List<Localidad> Lista = loc.Listar();

            cbx.DataSource = Lista;
            cbx.ValueMember = "IDLocalidad";
            cbx.DisplayMember = "Nombre";
        }

        public void LimpiaCampos(Panel pnl)
        {
            foreach (TextBox item in pnl.Controls.OfType<TextBox>())
            {
                item.Text = "";
            }

            foreach (ComboBox item in pnl.Controls.OfType<ComboBox>())
            {
                item.SelectedIndex = 0;
            }

            foreach (DateTimePicker item in pnl.Controls.OfType<DateTimePicker>())
            {
                item.Text = DateTime.Now.ToShortDateString();
            }

            foreach (CheckBox item in pnl.Controls.OfType<CheckBox>())
            {
                item.Checked = false;
            }
        }

        public void InquilinoActualizado(DataGridView dgv, int ID)
        {
            dgv.Rows.Clear();

            //txtIDSocio.Text = dgvDatosSocios.Rows[i].Cells[3].Value.ToString();

            Inquilino objInq = new Inquilino();
            clsInquilino clsInq = new clsInquilino();
            List<Inquilino> lstIxDNI = clsInq.LeerInqXID(Convert.ToInt32(ID));

            foreach (var itemI in lstIxDNI)
            {
                dgv.Rows.Add(itemI.IDInquilino, itemI.NombreYApellido, itemI.DNI, itemI.Telefono, itemI.CorreoElectronico, itemI.Direccion, itemI.Localidad.Nombre);
            }
        }

        public void PropietarioActualizado(DataGridView dgv, int id)
        {
            dgv.Rows.Clear();

            //txtIDSocio.Text = dgvDatosSocios.Rows[i].Cells[3].Value.ToString();

            Propietario objProp = new Propietario();
            clsPropietario clsProp = new clsPropietario();
            List<Propietario> lstPxDNI = clsProp.LeerPropietXID(Convert.ToInt32(id));

            foreach (var itemP in lstPxDNI)
            {
                dgv.Rows.Add(itemP.IDPropietario, itemP.NombreYApellido, itemP.DNI, itemP.Telefono, itemP.CorreoElectronico, itemP.Direccion, itemP.Localidad.Nombre);
            }
        }

        public void GaranteActualizado(DataGridView dgv, int id)
        {
            dgv.Rows.Clear();

            //txtIDSocio.Text = dgvDatosSocios.Rows[i].Cells[3].Value.ToString();

            Garante objGar = new Garante();
            clsGarante clsGar = new clsGarante();
            List<Garante> lstGxDNI = clsGar.LeerGarXID(Convert.ToInt32(id));

            foreach (var itemG in lstGxDNI)
            {
                dgv.Rows.Add(itemG.IDGarante, itemG.NombreYApellido, itemG.DNI, itemG.Telefono, itemG.CorreoElectronico, itemG.Direccion, itemG.Localidad.Nombre);
            }
        }

        public void HabDeshabCampos(Panel pnl, string accion)
        {
            if (accion == "habilitar")
            {
                foreach (Control item in pnl.Controls)
                {
                    item.Enabled = true;
                }
            }
            else
            {
                foreach (Control item in pnl.Controls)
                {
                    if (item.Name != "pbxSalir" || item.Name == "pbxMinimizar")
                    {
                        item.Enabled = false;
                    }
                }
            }
        }

        public void LlenarComboBarrio(ComboBox cbx)
        {
            clsBarrio clsBarrio = new clsBarrio();

            List<Barrio> Lista = clsBarrio.Listar();

            cbx.DataSource = Lista;
            cbx.ValueMember = "IDBarrio";
            cbx.DisplayMember = "Nombre";
        }

        public void LlenarComboTipo(ComboBox cbx)
        {
            clsTipo clsTip = new clsTipo();

            List<Tipo> Lista = clsTip.Listar();

            cbx.DataSource = Lista;
            cbx.ValueMember = "IDTipo";
            cbx.DisplayMember = "Nombre";
        }

        public void LlenarComboEdificio(ComboBox cbx)
        {
            clsEdificio clsEdif = new clsEdificio();

            List<Edificio> Lista = clsEdif.Listar();

            cbx.DataSource = Lista;
            cbx.ValueMember = "IDEdificio";
            cbx.DisplayMember = "Nombre";
        }

        public void LlenarComboEstado(ComboBox cbx)
        {
            clsEstado clsEst = new clsEstado();

            List<Estado> Lista = clsEst.Listar();

            cbx.DataSource = Lista;
            cbx.ValueMember = "IDEstado";
            cbx.DisplayMember = "Nombre";
        }

        public void LlenarComboPropiedad(ComboBox cbx)
        {
            clsPropiedad clsPropied = new clsPropiedad();

            List<Propiedad> Lista = clsPropied.Listar();

            cbx.DataSource = Lista;
            cbx.ValueMember = "IDPropiedad";
            cbx.DisplayMember = "Direccion";
        }

        public void PropiedadActualizada(DataGridView dgv, Int64 id)
        {
            dgv.Rows.Clear();

            clsPropiedad clsPropied = new clsPropiedad();
            List<Propiedad> lstPropiedxID = clsPropied.ListarXID(Convert.ToInt64(id));

            foreach (var itemPropied in lstPropiedxID)
            {
                clsLocalidad clsLoc = new clsLocalidad();
                List<Localidad> lstL = clsLoc.ListarXID(itemPropied.IDLocalidad);

                string pisonro;
                if (itemPropied.PisoNro == "-") pisonro = ""; else pisonro = " - " + itemPropied.PisoNro;

                foreach (var itemL in lstL)
                {
                    dgv.Rows.Add(itemPropied.IDPropiedad, itemPropied.Direccion + " " + pisonro, itemPropied.Edificio.Nombre, itemPropied.Barrio.Nombre, itemL.Nombre, itemPropied.Tipo.Nombre, itemPropied.CantHabitac, itemPropied.Patio, itemPropied.Asador, itemPropied.Cochera);
                }
            }
        }

        public void AlquilerActualizado(DataGridView dgv, Int64 id)
        {
            dgv.Rows.Clear();

            clsAlquiler clsAlq = new clsAlquiler();
            List<Alquiler> lstAlqxID = clsAlq.ListarXID(Convert.ToInt64(id));

            foreach (var itemA in lstAlqxID)
            {
                string pisonro;
                if (itemA.Propiedad.PisoNro == "-") pisonro = ""; else pisonro = " - " + itemA.Propiedad.PisoNro;

                dgv.Rows.Add(itemA.IDAlquiler, itemA.Propiedad.Direccion + " " + pisonro, itemA.Inquilino.NombreYApellido, itemA.FechaInicioContrato.ToShortDateString(), itemA.FechaFinContrato.ToShortDateString(), "$ " + itemA.MontoAlquiler);
            }
        }

        public void LlenarGrillaPropiedades(DataGridView dgv, TextBox txtID, Label lblCant, Label lblMonto)
        {
            dgv.Rows.Clear();

            clsAlquiler clsAlq = new clsAlquiler();

            List<Alquiler> lstAlq = clsAlq.ListarXPropied(Convert.ToInt64(txtID.Text));

            string Estado;
            int inCantVecesAlq = 0;
            int inMontoRecaudado = 0;

            foreach (var item in lstAlq)
            {
                if (DateTime.Today >= item.FechaFinContrato)
                {
                    Estado = "FINALIZADO";
                }
                else
                {
                    Estado = "EN PROCESO";
                }

                dgv.Rows.Add(item.IDAlquiler, item.Inquilino.NombreYApellido, item.FechaInicioContrato.ToShortDateString(), item.FechaFinContrato.ToShortDateString(), item.MontoAlquiler, Estado);

                inCantVecesAlq = dgv.Rows.Count;
                inMontoRecaudado = inMontoRecaudado + item.MontoAlquiler;
            }

            lblCant.Text = inCantVecesAlq.ToString();
            lblMonto.Text = "$" + inMontoRecaudado.ToString();
        }
    }
}
