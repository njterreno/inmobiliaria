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
    public partial class frmAlquileres : frmFormGral
    {
        string accion;
        bool tildar = true;
        string[] valor;

        public frmAlquileres()
        {
            InitializeComponent();

            //llena los cbx
            clsPropiedad clsPropied = new clsPropiedad();

            List<Propiedad> Lista = clsPropied.Listar();

            cbxPropiedad.DataSource = Lista;
            cbxPropiedad.ValueMember = "IDPropiedad";
            cbxPropiedad.DisplayMember = "Direccion";


            clsInquilino clsInq = new clsInquilino();

            List<Inquilino> Lista2 = clsInq.Listar();

            cbxInquilino.DataSource = Lista2;
            cbxInquilino.ValueMember = "IDInquilino";
            cbxInquilino.DisplayMember = "NombreYApellido";

            clsGarante clsGar = new clsGarante();

            List<Garante> Lista3 = clsGar.Listar();

            cbxGarante1.DataSource = Lista3;
            cbxGarante1.ValueMember = "IDGarante";
            cbxGarante1.DisplayMember = "NombreYApellido";

            //cbxGarante2.DataSource = Lista3;
            //cbxGarante2.ValueMember = "IDGarante";
            //cbxGarante2.DisplayMember = "NombreYApellido";

            //para que aparezca el propietario de la propiedad del cbx
            List<Propiedad> lstPropied = clsPropied.ListarXID(Convert.ToInt64(cbxPropiedad.SelectedValue));

            foreach (var itemPropied in lstPropied)
            {
                clsPropietario clsPropiet = new clsPropietario();

                List<Propietario> lstPropiet = clsPropiet.ListarXPropied(Convert.ToInt64(itemPropied.IDPropietario));

                foreach (var itemPropiet in lstPropiet)
                {
                    txtPropiet.Text = itemPropiet.NombreYApellido;
                }
            }

            //elimina de la lista el garante del cbx del garante 1 para que no aparezca en el cbx del garante 2
            Lista3.RemoveAt(cbxGarante1.SelectionStart);

            cbxGarante2.DataSource = Lista3;
            cbxGarante2.ValueMember = "IDGarante";
            cbxGarante2.DisplayMember = "NombreYApellido";
        }

        private void btnGenerarContrato_Click(object sender, EventArgs e)
        {
            frmGenerarContrato generarcontrato = new frmGenerarContrato();
            generarcontrato.ShowDialog();
        }

        private void btnBuscarPropiedad_Click(object sender, EventArgs e)
        {
            frmPropiedades frmPropied = new frmPropiedades();
            frmPropied.pbxSalir.Visible = true;
            frmPropied.pbxMinimizar.Visible = true;
            frmPropied.ShowDialog();
        }

        private void btnBuscarInquilino_Click(object sender, EventArgs e)
        {
            frmInqPropGar frmInqPropGar = new frmInqPropGar(frmInicio.Opciones.Inquilinos);
            frmInqPropGar.pbxSalir.Visible = true;
            frmInqPropGar.pbxMinimizar.Visible = true;
            frmInqPropGar.ShowDialog();
        }

        private void btnBuscarGarantes_Click(object sender, EventArgs e)
        {
            frmInqPropGar frmInqPropGar = new frmInqPropGar(frmInicio.Opciones.Garantes);
            frmInqPropGar.pbxSalir.Visible = true;
            frmInqPropGar.pbxMinimizar.Visible = true;
            frmInqPropGar.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool band = false;
            CodGenerico codGenerico = new CodGenerico();

            if (cbxPropiedad.Text == "" || cbxInquilino.Text == "" || cbxGarante1.Text == "" || cbxGarante2.Text == "" || txtMontoAlquiler.Text == "")
            {
                MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS E INGRESAR LOS DATOS CORRECTAMENTE", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                if (txtIDAlquiler.Text == "")//Insertar
                {
                    try
                    {
                        Alquiler objAlq = new Alquiler();

                        objAlq.IDPropiedad = Convert.ToInt64(cbxPropiedad.SelectedValue);
                        objAlq.IDInquilino = Convert.ToInt64(cbxInquilino.SelectedValue);
                        objAlq.IDGarante1 = Convert.ToInt64(cbxGarante1.SelectedValue);
                        objAlq.IDGarante2 = Convert.ToInt64(cbxGarante2.SelectedValue);
                        objAlq.Fecha = Convert.ToDateTime(dtpFecha.Text);
                        objAlq.FechaInicioContrato = Convert.ToDateTime(dtpFechaInicioContrato.Text);
                        objAlq.FechaFinContrato = Convert.ToDateTime(dtpFechaFinContrato.Text);
                        objAlq.MontoAlquiler = Convert.ToInt32(txtMontoAlquiler.Text);

                        clsAlquiler clsAlq = new clsAlquiler();
                        clsAlq.CrearModificar(objAlq);
                        GenerarCuotas(objAlq);
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("NO SE REGISTRÓ EL ALQUILER " + ex2.ToString());
                        band = true;
                    }
                    finally
                    {
                        if (band == false)
                        {
                            MessageBox.Show("EL ALQUILER SE REGISTRÓ EXITOSAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else//actualizar
                {
                    try
                    {
                        Alquiler objAlq = new Alquiler();

                        objAlq.IDAlquiler = Convert.ToInt64(txtIDAlquiler.Text);
                        objAlq.IDPropiedad = Convert.ToInt64(cbxPropiedad.SelectedValue);
                        objAlq.IDInquilino = Convert.ToInt64(cbxInquilino.SelectedValue);
                        objAlq.IDGarante1 = Convert.ToInt64(cbxGarante1.SelectedValue);
                        objAlq.IDGarante2 = Convert.ToInt64(cbxGarante2.SelectedValue);
                        objAlq.Fecha = Convert.ToDateTime(dtpFecha.Text);
                        objAlq.FechaInicioContrato = Convert.ToDateTime(dtpFechaInicioContrato.Text);
                        objAlq.FechaFinContrato = Convert.ToDateTime(dtpFechaFinContrato.Text);
                        objAlq.MontoAlquiler = Convert.ToInt32(txtMontoAlquiler.Text);
                        
                        
                        clsAlquiler clsAlq = new clsAlquiler();
                        clsAlq.CrearModificar(objAlq);
                        codGenerico.AlquilerActualizado(dgvDatosAlquileres, Convert.ToInt64(txtIDAlquiler.Text));

                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("NO SE ACTUALIZÓ EL ALQUILER" + ex2.ToString());
                        band = true;
                    }
                    finally
                    {
                        if (band == false)
                        {
                            MessageBox.Show("EL ALQUILER SE ACTUALIZÓ EXITOSAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            dgvDatosAlquileres.Rows.Clear();

            clsAlquiler clsAlq = new clsAlquiler();
            List<Alquiler> lstAlq = clsAlq.Listar();
            //List<Inquilino> lstIxDNI = clsInquilino.Buscar(txtNomYApeBusq.Text, Convert.ToInt32(txtDNIBusq.Text), cbxLocalidad.Text);

            foreach (var itemA in lstAlq)
            {
                string pisonro;
                if (itemA.Propiedad.PisoNro == "-") pisonro = ""; else pisonro = " - " + itemA.Propiedad.PisoNro;

                this.dgvDatosAlquileres.Rows.Add(itemA.IDAlquiler, itemA.Propiedad.Direccion + " " + pisonro, itemA.Inquilino.NombreYApellido, itemA.FechaInicioContrato.ToShortDateString(), itemA.FechaFinContrato.ToShortDateString(), "$ " + itemA.MontoAlquiler);
            }
            //clsInquilino clsInq = new clsInquilino();


            //List<Inquilino> lstI = clsInq.LeerInqXID(itemA.IDAlquiler);
            //foreach (var itemI in lstI)
            //{
            //    clsPropiedad clsPropied = new clsPropiedad();

            //    List<Propiedad> lstP = clsPropied.ListarXID(itemA.IDPropiedad);

            //    foreach (var itemP in lstP)
            //    {
            //this.dgvDatosAlquileres.Rows.Add(itemA.IDAlquiler, itemP.Direccion + itemP.PisoNro, itemI.NombreYApellido, itemA.FechaInicioContrato.ToShortDateString(), itemA.FechaFinContrato.ToShortDateString(), "$ " + itemA.MontoAlquiler);
            //}


        }

        private void cbxGarante1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            clsGarante clsGar = new clsGarante();

            List<Garante> Lista3 = clsGar.Listar();

            Lista3.RemoveAt(cbxGarante1.SelectedIndex);

            cbxGarante2.DataSource = Lista3;
            cbxGarante2.ValueMember = "IDGarante";
            cbxGarante2.DisplayMember = "NombreYApellido";

        }

        private void dtpFechaInicioContrato_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaFinContrato.Value = dtpFechaInicioContrato.Value.AddYears(2);
            dtpFechaFinContrato.Value = dtpFechaFinContrato.Value.AddDays(-1);
        }

        private void cbxInquilino_Click(object sender, EventArgs e)
        {
            clsInquilino clsInq = new clsInquilino();
            List<Inquilino> Lista2 = clsInq.Listar();

            cbxInquilino.DataSource = Lista2;
            cbxInquilino.ValueMember = "IDInquilino";
            cbxInquilino.DisplayMember = "NombreYApellido";
        }

        private void cbxGarante1_Click(object sender, EventArgs e)
        {
            clsGarante clsGar = new clsGarante();

            List<Garante> Lista3 = clsGar.Listar();

            cbxGarante1.DataSource = Lista3;
            cbxGarante1.ValueMember = "IDGarante";
            cbxGarante1.DisplayMember = "NombreYApellido";
        }

        private void cbxPropiedad_Click(object sender, EventArgs e)
        {
            clsPropiedad clsPropied = new clsPropiedad();

            List<Propiedad> Lista = clsPropied.Listar();

            cbxPropiedad.DataSource = Lista;
            cbxPropiedad.ValueMember = "IDPropiedad";
            cbxPropiedad.DisplayMember = "Direccion";
        }

        private void cbxPropiedad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            clsPropiedad clsPropied = new clsPropiedad();
            List<Propiedad> lstPropied = clsPropied.ListarXID(Convert.ToInt64(cbxPropiedad.SelectedValue));

            foreach (var itemPropied in lstPropied)
            {
                clsPropietario clsPropiet = new clsPropietario();

                List<Propietario> lstPropiet = clsPropiet.ListarXPropied(Convert.ToInt64(itemPropied.IDPropietario));

                foreach (var itemPropiet in lstPropiet)
                {
                    txtPropiet.Text = itemPropiet.NombreYApellido;
                }
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            CodGenerico codGenerico = new CodGenerico();

            codGenerico.LimpiaCampos(panel1);
        }

        private void dgvDatosAlquileres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CodGenerico codGenerico = new CodGenerico();
            accion = "deshab";
            codGenerico.HabDeshabCampos(panel1, accion);

            if (e.RowIndex > -1)
            {
                Alquiler objPropied = new Alquiler();
                clsAlquiler clsAlq = new clsAlquiler();

                Int64 id = Convert.ToInt64(dgvDatosAlquileres.Rows[e.RowIndex].Cells["Column6"].Value);
                List<Alquiler> lstAlq = clsAlq.ListarXID(id);

                foreach (Alquiler itemAlq in lstAlq)
                {
                    cbxPropiedad.SelectedValue = itemAlq.IDPropiedad;

                    clsPropietario clsPropiet = new clsPropietario();

                    List<Propietario> lstPropiet = clsPropiet.ListarXPropied(Convert.ToInt64(itemAlq.Propiedad.IDPropietario));

                    foreach (var itemPropiet in lstPropiet)
                    {
                        txtPropiet.Text = itemPropiet.NombreYApellido;
                    }

                    txtIDAlquiler.Text = itemAlq.IDAlquiler.ToString();
                    //txtPropiet.Text = itemAlq.Propiedad.Propietario.NombreYApellido;
                    cbxInquilino.SelectedValue = itemAlq.IDInquilino;
                    cbxGarante1.SelectedValue = itemAlq.IDGarante1;
                    cbxGarante2.SelectedValue = itemAlq.IDGarante2;
                    dtpFecha.Value = itemAlq.Fecha;
                    dtpFechaInicioContrato.Value = itemAlq.FechaInicioContrato;
                    dtpFechaFinContrato.Value = itemAlq.FechaFinContrato;
                    txtMontoAlquiler.Text = itemAlq.MontoAlquiler.ToString();

                    dgvCobroAlquileres.Rows.Clear();

                    clsCuotaMensual objCuotaMensual = new clsCuotaMensual();

                    List<CuotaMensual> lstCM = objCuotaMensual.ListarXIDAlq(itemAlq.IDAlquiler);
                    foreach (var itemCM in lstCM)
                    {
                        //if (itemCM.Pago == "SI") tildar = true; else tildar = false;
                        if (itemCM.Pago == "SI") tildar = true; else tildar = false;
                        //if (itemCM.Pago == "SI") row.Cells["Column9"].Value = true;

                        
                        DateTime periodo = (DateTime)itemCM.Periodo;
                        string per = periodo.Month + "/" + periodo.Year;

                        //DateTime per = (DateTime)itemCM.Periodo;
                        int MontoRecargo = 0;

                        if (itemCM.Pago == "NO")                        
                        {  
                            if (periodo.Month == DateTime.Now.Month && periodo.Year == DateTime.Now.Year)
                            {
                                int diasmes = DateTime.DaysInMonth(DateTime.Today.Year, DateTime.Today.Month);
                                if (diasmes > 10)
                                {
                                    MontoRecargo = diasmes - 10 * ((1 * (int)itemCM.Monto) / 100);
                                    //        int MontoTotal = MontoRecargo + (int)itemCM.Monto;

                                    //        //objCuotaMensual.Montos(itemCM.IDCuotaMensual, MontoRecargo, MontoTotal);
                                }
                            }
                        }
                        
                        dgvCobroAlquileres.Rows.Add(itemCM.IDCuotaMensual, itemCM.Numero, per, tildar, itemCM.FechaPago, itemCM.Monto, MontoRecargo, itemCM.MontoTotal);
                    }
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            accion = "habilitar";
            CodGenerico codGenerico = new CodGenerico();
            codGenerico.HabDeshabCampos(panel1, accion);
        }

        private void GenerarCuotas(Alquiler objAlq)
        {
            CuotaMensual cuotaMensual = new CuotaMensual();
            clsCuotaMensual clsCuotaMensual = new clsCuotaMensual();

            cuotaMensual.IDAlquiler = objAlq.IDAlquiler;

            int MontoAlquiler = (objAlq.MontoAlquiler / 24);

            for (int i = 1; i <= 24; i++)
            {
                if (i <= 6)
                {
                    cuotaMensual.Monto = MontoAlquiler;
                    //string periodo = DateTime.Today.AddMonths(i).ToString();
                    cuotaMensual.Periodo = DateTime.Today.AddMonths(i);
                    cuotaMensual.Numero = i;
                }

                if (i > 6 & i <= 12)
                {
                    cuotaMensual.Monto = MontoAlquiler;
                    cuotaMensual.Periodo = DateTime.Today.AddMonths(i);
                    cuotaMensual.Numero = i;
                }

                if (i > 12 & i <= 18)
                {
                    cuotaMensual.Monto = MontoAlquiler;
                    cuotaMensual.Periodo = cuotaMensual.Periodo = DateTime.Today.AddMonths(i);
                    cuotaMensual.Numero = i;
                }

                if (i > 18 & i <= 24)
                {
                    cuotaMensual.Monto = MontoAlquiler;
                    cuotaMensual.Periodo = cuotaMensual.Periodo = DateTime.Today.AddMonths(i);
                    cuotaMensual.Numero = i;
                }

                clsCuotaMensual.Crear(cuotaMensual);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvCobroAlquileres.Rows.Count; i++)
            {
                //int i = dgvCobroAlquileres.CurrentRow.Index;
                //txtIDSocio.Text = dgvDatosSocios.Rows[i].Cells[3].Value.ToString();

                clsCuotaMensual objCuotaMensual = new clsCuotaMensual();
                List<CuotaMensual> lstCM = objCuotaMensual.ListarXID(Convert.ToInt64(dgvCobroAlquileres.Rows[i].Cells["Column7"].Value));
                CuotaMensual cuotaMensual = new CuotaMensual();

                var chk = Convert.ToBoolean(dgvCobroAlquileres.Rows[i].Cells["Column9"].Value);
                string fecha = (string)dgvCobroAlquileres.Rows[i].Cells["Column11"].Value;
                int MontoRecargo = (int)dgvCobroAlquileres.Rows[i].Cells["Column13"].Value;

                if (chk == true && fecha == null)
                {   
                    foreach (var itemCM in lstCM)
                    {
                        cuotaMensual.IDCuotaMensual = itemCM.IDCuotaMensual;
                        cuotaMensual.Pago = "SI";
                        cuotaMensual.FechaPago = DateTime.Today.ToShortDateString();
                        cuotaMensual.MontoRecargo = MontoRecargo;
                        cuotaMensual.MontoTotal = itemCM.Monto + MontoRecargo;

                        objCuotaMensual.Pago(cuotaMensual);
                    }
                }


                if (chk == false && fecha != null)
                {
                    foreach (var itemCM in lstCM)
                    {
                        cuotaMensual.IDCuotaMensual = itemCM.IDCuotaMensual;
                        cuotaMensual.Pago = "NO";
                        cuotaMensual.FechaPago = null;

                        objCuotaMensual.Pago(cuotaMensual);
                    }
                }
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            clsAlquiler clsAlq = new clsAlquiler();
            List<Alquiler> lstAlq = clsAlq.ListarXID(Convert.ToInt64(txtIDAlquiler.Text));

            frmGenerarContrato frmGenCont = new frmGenerarContrato();

            string contrato = frmGenCont.txtContrato.Text;
            foreach (var item in lstAlq)
            {
                valor = item.Propiedad.Direccion.Split(' ');

                contrato = contrato.Replace("[LOCALIDAD]", "Villa Maria");
                contrato = contrato.Replace("[DIA]", item.FechaInicioContrato.Day.ToString());
                contrato = contrato.Replace("[MES]", item.FechaInicioContrato.Month.ToString());
                contrato = contrato.Replace("[AÑO]", item.FechaInicioContrato.Year.ToString());
                contrato = contrato.Replace("[CALLE]", valor[0]);
                contrato = contrato.Replace("[NUMERO]", valor[1]);
            }


            //var u = usuario.TraerPorInquilino(usuarioAlquiler);

            rptContrato rpt = new rptContrato();
            rpt.SetParameterValue("Contrato", contrato.ToString());
            frmReporte frm = new frmReporte();
            frm.crvVisor.ReportSource = rpt;
            frm.crvVisor.Refresh();

            frm.Show();
        }
    }
}
