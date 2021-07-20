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
using System.Diagnostics;


namespace Presentacion
{
    public partial class frmInqPropGar : frmFormGral
    {
        string accion;

        public frmInqPropGar(frmInicio.Opciones opc)
        {
            InitializeComponent();

            switch (opc)
            {
                case frmInicio.Opciones.Inquilinos:
                    lblTitulo.Text = "INQUILINOS";
                    break;
                case frmInicio.Opciones.Propietarios:
                    lblTitulo.Text = "PROPIETARIOS";
                    break;
                case frmInicio.Opciones.Garantes:
                    lblTitulo.Text = "GARANTES";
                    txtMontoSueldo.Visible = true;
                    lblMontoSueldo.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarLocalidad agregarloc = new frmAgregarLocalidad();

            agregarloc.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (lblTitulo.Text == "INQUILINOS")
            {
                if (txtDNIBusq.Text != "" | txtNomYApeBusq.Text != "")
                {
                    if (txtDNIBusq.Text != "")
                    {
                        dgvDatosInqPropGar.Rows.Clear();

                        clsInquilino clsInquilino = new clsInquilino();
                        List<Inquilino> lstIxDNI = clsInquilino.LeerInqXDNI(txtDNIBusq.Text);
                        //List<Inquilino> lstIxDNI = clsInquilino.Buscar(txtNomYApeBusq.Text, Convert.ToInt32(txtDNIBusq.Text), cbxLocalidad.Text);

                        foreach (var itemI in lstIxDNI)
                        {
                            this.dgvDatosInqPropGar.Rows.Add(itemI.IDInquilino, itemI.NombreYApellido, itemI.DNI, itemI.Telefono, itemI.CorreoElectronico, itemI.Direccion, itemI.Localidad.Nombre);
                        }
                    }
                    else if (txtNomYApeBusq.Text != "")
                    {
                        dgvDatosInqPropGar.Rows.Clear();

                        clsInquilino clsInquilino = new clsInquilino();
                        List<Inquilino> lstIxNomYApe = clsInquilino.LeerInquilinoXNombre(txtNomYApeBusq.Text);

                        foreach (var itemI in lstIxNomYApe)
                        {
                            this.dgvDatosInqPropGar.Rows.Add(itemI.IDInquilino, itemI.NombreYApellido, itemI.DNI, itemI.Telefono, itemI.CorreoElectronico, itemI.Direccion, itemI.Localidad.Nombre);
                        }
                    }
                    else
                    {
                        dgvDatosInqPropGar.Rows.Clear();

                        clsInquilino clsInquilino = new clsInquilino();
                        List<Inquilino> lstIxDNI = clsInquilino.LeerInqXID(Convert.ToInt32(txtDNIBusq.Text));

                        foreach (var itemI in lstIxDNI)
                        {
                            this.dgvDatosInqPropGar.Rows.Add(itemI.IDInquilino, itemI.NombreYApellido, itemI.DNI, itemI.Telefono, itemI.CorreoElectronico, itemI.Direccion, itemI.Localidad.Nombre);
                        }
                    }
                }
            }
            else if (lblTitulo.Text == "PROPIETARIOS")
            {
                if (txtDNIBusq.Text != "" | txtNomYApeBusq.Text != "")
                {
                    if (txtDNIBusq.Text != "")
                    {
                        dgvDatosInqPropGar.Rows.Clear();

                        clsPropietario clsPropietario = new clsPropietario();
                        List<Propietario> lstPxDNI = clsPropietario.LeerPropietXDNI(txtDNIBusq.Text);

                        foreach (var itemP in lstPxDNI)
                        {
                            this.dgvDatosInqPropGar.Rows.Add(itemP.IDPropietario, itemP.NombreYApellido, itemP.DNI, itemP.Telefono, itemP.CorreoElectronico, itemP.Direccion, itemP.Localidad.Nombre);
                        }
                    }
                    else if (txtNomYApeBusq.Text != "")
                    {
                        dgvDatosInqPropGar.Rows.Clear();

                        clsPropietario clsPropietario = new clsPropietario();
                        List<Propietario> lstPxNomYApe = clsPropietario.LeerPropietXNombre(txtNomYApeBusq.Text);

                        foreach (var itemP in lstPxNomYApe)
                        {
                            this.dgvDatosInqPropGar.Rows.Add(itemP.IDPropietario, itemP.NombreYApellido, itemP.DNI, itemP.Telefono, itemP.CorreoElectronico, itemP.Direccion, itemP.Localidad.Nombre);
                        }
                    }
                    else
                    {
                        dgvDatosInqPropGar.Rows.Clear();

                        clsPropietario clsPropietario = new clsPropietario();
                        List<Propietario> lstPxDNI = clsPropietario.LeerPropietXDNI(txtDNIBusq.Text);

                        foreach (var itemP in lstPxDNI)
                        {
                            this.dgvDatosInqPropGar.Rows.Add(itemP.IDPropietario, itemP.NombreYApellido, itemP.DNI, itemP.Telefono, itemP.CorreoElectronico, itemP.Direccion, itemP.Localidad.Nombre);
                        }
                    }
                }
            }
            else
            {
                if (txtDNIBusq.Text != "" | txtNomYApeBusq.Text != "")
                {
                    if (txtDNIBusq.Text != "")
                    {
                        dgvDatosInqPropGar.Rows.Clear();

                        clsGarante clsGarante = new clsGarante();
                        List<Garante> lstGxID = clsGarante.LeerGarXID(Convert.ToInt32(txtDNIBusq.Text));

                        foreach (var itemG in lstGxID)
                        {
                            this.dgvDatosInqPropGar.Rows.Add(itemG.IDGarante, itemG.NombreYApellido, itemG.DNI, itemG.Telefono, itemG.CorreoElectronico, itemG.Direccion, itemG.Localidad.Nombre);
                        }
                    }
                    else if (txtNomYApeBusq.Text != "")
                    {
                        dgvDatosInqPropGar.Rows.Clear();

                        clsGarante clsGarante = new clsGarante();
                        List<Garante> lstGxNomYApe = clsGarante.LeerGaranteXNombre(txtNomYApeBusq.Text);

                        foreach (var itemG in lstGxNomYApe)
                        {
                            this.dgvDatosInqPropGar.Rows.Add(itemG.IDGarante, itemG.NombreYApellido, itemG.DNI, itemG.Telefono, itemG.CorreoElectronico, itemG.Direccion, itemG.Localidad.Nombre);
                        }
                    }
                    else
                    {
                        dgvDatosInqPropGar.Rows.Clear();

                        clsGarante clsGarante = new clsGarante();
                        List<Garante> lstGxID = clsGarante.LeerGarXID(Convert.ToInt32(txtDNIBusq.Text));

                        foreach (var itemG in lstGxID)
                        {
                            this.dgvDatosInqPropGar.Rows.Add(itemG.IDGarante, itemG.NombreYApellido, itemG.DNI, itemG.Telefono, itemG.CorreoElectronico, itemG.Direccion, itemG.Localidad.Nombre);
                        }
                    }
                }
            }


            //dgvDatosInqPropGar.Rows.Clear();

            //clsInquilino Inquilino = new clsInquilino();

            //List<Inquilino> Lista = Inquilino.Listar();
            //foreach (Inquilino I in Lista)
            //{
            //    this.dgvDatosInqPropGar.Rows.Add(I.NombreYApellido, I.DNI, I.Telefono, I.CorreoElectronico, I.Direccion, I.Localidad.Nombre);
            //}
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CodGenerico codGenerico = new CodGenerico();

            if (lblTitulo.Text == "INQUILINOS")
            {
                bool band = false;

                if (txtNomYApe.Text == "" || txtDNI.Text == "" || txtFechaNac.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtCorreoElectronico.Text == "" || cbxLocalidad.Text == "")
                {
                    MessageBox.Show("Por favor llene todos los campos", "ALERTA");
                }
                else
                {
                    if (!txtCorreoElectronico.Text.Contains("@") || !txtCorreoElectronico.Text.Contains(".com"))
                    {
                        MessageBox.Show("Correo electrónico inválido", "ALERTA");
                    }
                    else
                    {
                        clsInquilino clsInq = new clsInquilino();

                        List<Inquilino> lstIxDNI = clsInq.LeerInqXDNI(txtDNI.Text);

                        if ((lstIxDNI.Count == 0) || (lstIxDNI.Count == 1 && Convert.ToInt64(txtID.Text) == lstIxDNI[0].IDInquilino))
                        {
                            if (txtID.Text == "")//Insertar
                            {
                                try
                                {
                                    Inquilino objInq = new Inquilino();

                                    objInq.NombreYApellido = txtNomYApe.Text.ToUpper();
                                    objInq.DNI = txtDNI.Text;
                                    objInq.FechaNac = Convert.ToDateTime(txtFechaNac.Text);
                                    objInq.Telefono = Convert.ToInt64(txtTelefono.Text);
                                    objInq.CorreoElectronico = txtCorreoElectronico.Text;
                                    objInq.Direccion = txtDireccion.Text.ToUpper();
                                    objInq.IDLocalidad = Convert.ToInt64(cbxLocalidad.SelectedValue);


                                    //clsInquilino clsInq = new clsInquilino();
                                    clsInq.CrearModificar(objInq);
                                    //codGenerico.InquilinoActualizado(dgvDatosInqPropGar, Convert.ToInt32(txtID.Text));
                                }
                                catch (Exception ex2)
                                {
                                    MessageBox.Show("NO SE REGISTRÓ EL INQUILINO" + ex2.ToString());
                                    band = true;
                                }
                                finally
                                {
                                    if (band == false)
                                    {
                                        MessageBox.Show("EL INQUILINO SE REGISTRÓ EXITOSAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        codGenerico.LimpiaCampos(panel1);

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
                                    //clsInquilino clsInq = new clsInquilino();
                                    Inquilino objInq = new Inquilino();

                                    objInq.IDInquilino = Convert.ToInt64(txtID.Text);
                                    objInq.NombreYApellido = txtNomYApe.Text.ToUpper();
                                    objInq.DNI = txtDNI.Text;
                                    objInq.FechaNac = Convert.ToDateTime(txtFechaNac.Text);
                                    objInq.Telefono = Convert.ToInt64(txtTelefono.Text);
                                    objInq.CorreoElectronico = txtCorreoElectronico.Text;
                                    objInq.Direccion = txtDireccion.Text.ToUpper();
                                    objInq.IDLocalidad = Convert.ToInt64(cbxLocalidad.SelectedValue);

                                    clsInq.CrearModificar(objInq);

                                    codGenerico.InquilinoActualizado(dgvDatosInqPropGar, Convert.ToInt32(txtID.Text));
                                }
                                catch (Exception ex2)
                                {
                                    MessageBox.Show("NO SE ACTUALIZÓ EL INQUILINO" + ex2.ToString());
                                    band = true;
                                }
                                finally
                                {
                                    if (band == false)
                                    {
                                        MessageBox.Show("EL INQUILINO SE ACTUALIZÓ EXITOSAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        codGenerico.LimpiaCampos(panel1);

                                        if (this.TopLevelControl.Name != "frmInicio")
                                        {
                                            this.Close();
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("EL DNI YA ESTÁ REGISTRADO EN LA BASE DE DATOS", "ALERTA");
                        }
                    }
                }
            }
            else if (lblTitulo.Text == "PROPIETARIOS")
            {
                bool band = false;

                if (txtNomYApe.Text == "" || txtDNI.Text == "" || txtFechaNac.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtCorreoElectronico.Text == "" || cbxLocalidad.Text == "")
                {
                    MessageBox.Show("Por favor llene todos los campos", "ALERTA");
                }
                else
                {
                    if (!txtCorreoElectronico.Text.Contains("@") || !txtCorreoElectronico.Text.Contains(".com"))
                    {
                        MessageBox.Show("Correo electrónico inválido", "ALERTA");
                    }
                    else
                    {
                        clsPropietario clsPropiet = new clsPropietario();

                        List<Propietario> lstPxDNI = clsPropiet.LeerPropietXDNI(txtDNI.Text);

                        if ((lstPxDNI.Count == 0) || (lstPxDNI.Count == 1 && Convert.ToInt64(txtID.Text) == lstPxDNI[0].IDPropietario))
                        {
                            if (txtID.Text == "")//Insertar
                            {
                                try
                                {
                                    Propietario objProp = new Propietario();

                                    objProp.NombreYApellido = txtNomYApe.Text.ToUpper();
                                    objProp.IDLocalidad = Convert.ToInt64(cbxLocalidad.SelectedValue);
                                    objProp.DNI = txtDNI.Text;
                                    objProp.FechaNac = Convert.ToDateTime(txtFechaNac.Text);
                                    objProp.Telefono = Convert.ToInt64(txtTelefono.Text);
                                    objProp.CorreoElectronico = txtCorreoElectronico.Text;
                                    objProp.Direccion = txtDireccion.Text.ToUpper();

                                    clsPropiet.CrearModificar(objProp);
                                }
                                catch (Exception ex2)
                                {
                                    MessageBox.Show("NO SE REGISTRÓ EL PROPIETARIO" + ex2.ToString());
                                    band = true;
                                }
                                finally
                                {
                                    if (band == false)
                                    {
                                        MessageBox.Show("EL PROPIETARIO SE REGISTRÓ EXITOSAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        codGenerico.LimpiaCampos(panel1);

                                        this.Close();
                                    }
                                }
                            }
                            else//actualizar
                            {
                                try
                                {
                                    clsPropietario clsProp = new clsPropietario();
                                    Propietario objProp = new Propietario();

                                    objProp.IDPropietario = Convert.ToInt64(txtID.Text);
                                    objProp.NombreYApellido = txtNomYApe.Text.ToUpper();
                                    objProp.IDLocalidad = Convert.ToInt64(cbxLocalidad.SelectedValue);
                                    objProp.DNI = txtDNI.Text;
                                    objProp.FechaNac = Convert.ToDateTime(txtFechaNac.Text);
                                    objProp.Telefono = Convert.ToInt64(txtTelefono.Text);
                                    objProp.CorreoElectronico = txtCorreoElectronico.Text;
                                    objProp.Direccion = txtDireccion.Text.ToUpper();

                                    clsProp.CrearModificar(objProp);
                                    codGenerico.PropietarioActualizado(dgvDatosInqPropGar, Convert.ToInt32(txtID.Text));
                                }
                                catch (Exception ex2)
                                {
                                    MessageBox.Show("NO SE ACTUALIZÓ EL PROPIETARIO" + ex2.ToString());
                                    band = true;
                                }
                                finally
                                {
                                    if (band == false)
                                    {
                                        MessageBox.Show("EL PROPIETARIO SE ACTUALIZÓ EXITOSAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        codGenerico.LimpiaCampos(panel1);

                                        if (this.TopLevelControl.Name != "frmInicio")
                                        {
                                            this.Close();
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("EL DNI YA ESTÁ REGISTRADO EN LA BASE DE DATOS", "ALERTA");
                        }
                    }
                }
            }
            else
            {
                bool band = false;

                if (txtNomYApe.Text == "" || txtDNI.Text == "" || txtFechaNac.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtCorreoElectronico.Text == "" || cbxLocalidad.Text == "" || txtMontoSueldo.Text == "")
                {
                    MessageBox.Show("Por favor llene todos los campos", "ALERTA");
                }
                else
                {
                    if (!txtCorreoElectronico.Text.Contains("@") || !txtCorreoElectronico.Text.Contains(".com"))
                    {
                        MessageBox.Show("Correo electrónico inválido", "ALERTA");
                    }
                    else
                    {
                        clsGarante clsGar = new clsGarante();

                        List<Garante> lstGxDNI = clsGar.LeerGarXDNI(txtDNI.Text);

                        if ((lstGxDNI.Count == 0) || (lstGxDNI.Count == 1 && Convert.ToInt64(txtID.Text) == lstGxDNI[0].IDGarante))
                        {
                            if (Convert.ToInt32(txtMontoSueldo.Text) >= 20000)
                            {
                                if (txtID.Text == "")//Insertar
                                {
                                    try
                                    {
                                        Garante objGar = new Garante();

                                        objGar.NombreYApellido = txtNomYApe.Text.ToUpper();
                                        objGar.DNI = txtDNI.Text;
                                        objGar.FechaNac = Convert.ToDateTime(txtFechaNac.Text);
                                        objGar.Telefono = Convert.ToInt64(txtTelefono.Text);
                                        objGar.CorreoElectronico = txtCorreoElectronico.Text;
                                        objGar.Direccion = txtDireccion.Text.ToUpper();
                                        objGar.IDLocalidad = Convert.ToInt64(cbxLocalidad.SelectedValue);
                                        objGar.MontoSueldo = Convert.ToInt32(txtMontoSueldo.Text);


                                        clsGar.CrearModificar(objGar);
                                        //codGenerico.InquilinoActualizado((dgvDatosInqPropGar, txtID.Text);
                                    }
                                    catch (Exception ex2)
                                    {
                                        MessageBox.Show("NO SE REGISTRÓ EL GARANTE" + ex2.ToString());
                                        band = true;
                                    }
                                    finally
                                    {
                                        if (band == false)
                                        {
                                            MessageBox.Show("EL GARANTE SE REGISTRÓ EXITOSAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            codGenerico.LimpiaCampos(panel1);
                                            this.Close();
                                        }
                                    }
                                }
                                else//actualizar
                                {
                                    try
                                    {
                                        Garante objGar = new Garante();

                                        objGar.IDGarante = Convert.ToInt64(txtID.Text);
                                        objGar.NombreYApellido = txtNomYApe.Text.ToUpper();
                                        objGar.IDLocalidad = Convert.ToInt64(cbxLocalidad.SelectedValue);
                                        objGar.DNI = txtDNI.Text;
                                        objGar.FechaNac = Convert.ToDateTime(txtFechaNac.Text);
                                        objGar.Telefono = Convert.ToInt64(txtTelefono.Text);
                                        objGar.CorreoElectronico = txtCorreoElectronico.Text;
                                        objGar.Direccion = txtDireccion.Text.ToUpper();
                                        objGar.IDLocalidad = Convert.ToInt64(cbxLocalidad.SelectedValue);
                                        objGar.MontoSueldo = Convert.ToInt64(txtMontoSueldo.Text);

                                        clsGar.CrearModificar(objGar);
                                        codGenerico.GaranteActualizado(dgvDatosInqPropGar, Convert.ToInt32(txtID.Text));
                                    }
                                    catch (Exception ex2)
                                    {
                                        MessageBox.Show("NO SE ACTUALIZÓ EL GARANTE" + ex2.ToString());
                                        band = true;
                                    }
                                    finally
                                    {
                                        if (band == false)
                                        {
                                            MessageBox.Show("EL GARANTE SE ACTUALIZÓ EXITOSAMENTE", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            codGenerico.LimpiaCampos(panel1);

                                            if (this.TopLevelControl.Name != "frmInicio")
                                            {
                                                this.Close();
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("EL MONTO DEL SUELDO NO PUEDE SER MENOR A $20.000", "ALERTA");
                            }
                        }
                        else
                        {
                            MessageBox.Show("EL DNI YA ESTÁ REGISTRADO EN LA BASE DE DATOS", "ALERTA");
                        }
                    }
                }
            }
        }

        private void Inquilinos_Load(object sender, EventArgs e)
        {
            CodGenerico codGenerico = new CodGenerico();

            codGenerico.LlenarComboLocalidad(cbxLocalidad);

            codGenerico.LlenarComboLocalidad(cbxLocalidadBusq);
            cbxLocalidadBusq.SelectedIndex = -1;
        }

        private void pbxSalirBusqueda_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxMinimizarBusqueda_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            accion = "habilitar";
            CodGenerico codGenerico = new CodGenerico();
            codGenerico.HabDeshabCampos(panel1, accion);

            if (lblTitulo.Text == "INQUILINOS")
            {
                if (dgvDatosInqPropGar.Rows != null)
                {
                    int i = dgvDatosInqPropGar.CurrentRow.Index;

                    Inquilino objInq = new Inquilino();
                    clsInquilino clsInq = new clsInquilino();
                    List<Inquilino> lstI = clsInq.LeerInqXID(Convert.ToInt32(dgvDatosInqPropGar.Rows[i].Cells["Column7"].Value));
                    foreach (Inquilino itemI in lstI)
                    {
                        txtID.Text = itemI.IDInquilino.ToString();
                        txtNomYApe.Text = itemI.NombreYApellido;
                        txtDNI.Text = itemI.DNI.ToString();
                        txtFechaNac.Text = itemI.FechaNac.ToString();
                        txtTelefono.Text = itemI.Telefono.ToString();
                        txtCorreoElectronico.Text = itemI.CorreoElectronico;
                        txtDireccion.Text = itemI.Direccion;

                        clsLocalidad Loc = new clsLocalidad();
                        List<Localidad> lstLoc = Loc.ListarXID(Convert.ToInt64(itemI.IDLocalidad));
                        foreach (Localidad itemL in lstLoc)
                        {
                            cbxLocalidad.Text = itemL.Nombre;
                        }
                    }
                }
            }
            else if (lblTitulo.Text == "PROPIETARIOS")
            {
                if (dgvDatosInqPropGar.Rows != null)
                {
                    int i = dgvDatosInqPropGar.CurrentRow.Index;

                    Propietario objProp = new Propietario();
                    clsPropietario clsProp = new clsPropietario();
                    List<Propietario> lstP = clsProp.LeerPropietXID(Convert.ToInt32(dgvDatosInqPropGar.Rows[i].Cells["Column7"].Value));
                    foreach (Propietario itemP in lstP)
                    {
                        txtID.Text = itemP.IDPropietario.ToString();
                        txtNomYApe.Text = itemP.NombreYApellido;
                        txtDNI.Text = itemP.DNI.ToString();
                        txtFechaNac.Text = itemP.FechaNac.ToString();
                        txtTelefono.Text = itemP.Telefono.ToString();
                        txtCorreoElectronico.Text = itemP.CorreoElectronico;
                        txtDireccion.Text = itemP.Direccion;

                        clsLocalidad Loc = new clsLocalidad();
                        List<Localidad> lstLoc = Loc.ListarXID(Convert.ToInt64(itemP.IDLocalidad));
                        foreach (Localidad itemL in lstLoc)
                        {
                            cbxLocalidad.Text = itemL.Nombre;
                        }
                    }
                }
            }
            else
            {
                if (dgvDatosInqPropGar.Rows != null)
                {
                    int i = dgvDatosInqPropGar.CurrentRow.Index;

                    Garante objGar = new Garante();
                    clsGarante clsGar = new clsGarante();
                    List<Garante> lstG = clsGar.LeerGarXID(Convert.ToInt32(dgvDatosInqPropGar.Rows[i].Cells["Column7"].Value));
                    foreach (Garante itemG in lstG)
                    {
                        txtID.Text = itemG.IDGarante.ToString();
                        txtNomYApe.Text = itemG.NombreYApellido;
                        txtDNI.Text = itemG.DNI.ToString();
                        txtFechaNac.Text = itemG.FechaNac.ToString();
                        txtTelefono.Text = itemG.Telefono.ToString();
                        txtCorreoElectronico.Text = itemG.CorreoElectronico;
                        txtDireccion.Text = itemG.Direccion;
                        txtMontoSueldo.Text = itemG.MontoSueldo.ToString();

                        clsLocalidad Loc = new clsLocalidad();
                        List<Localidad> lstLoc = Loc.ListarXID(Convert.ToInt64(itemG.IDLocalidad));
                        foreach (Localidad itemL in lstLoc)
                        {
                            cbxLocalidad.Text = itemL.Nombre;
                        }
                    }
                }
            }
        }

        private void dgvDatosInqPropGar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CodGenerico codGenerico = new CodGenerico();
            accion = "deshab";
            codGenerico.HabDeshabCampos(panel1, accion);

            if (e.RowIndex > -1)
            {
                if (lblTitulo.Text == "INQUILINOS")
                {
                    Inquilino objInq = new Inquilino();
                    clsInquilino clsInq = new clsInquilino();

                    Int64 id = Convert.ToInt64(dgvDatosInqPropGar.Rows[e.RowIndex].Cells["Column7"].Value);
                    List<Inquilino> lstI = clsInq.LeerInqXID(id);
                    //NuevoSocio.CargarTxt(Convert.ToInt32(dgvInfoSocios.Rows[i].Cells[0].Value.ToString()));

                    foreach (Inquilino itemI in lstI)
                    {
                        txtNomYApe.Text = itemI.NombreYApellido;
                        txtDNI.Text = itemI.DNI.ToString();
                        txtFechaNac.Text = itemI.FechaNac.ToString();
                        txtTelefono.Text = itemI.Telefono.ToString();
                        txtCorreoElectronico.Text = itemI.CorreoElectronico;
                        txtDireccion.Text = itemI.Direccion;
                        cbxLocalidad.Text = itemI.Localidad.Nombre;
                    }
                }
                else if (lblTitulo.Text == "PROPIETARIOS")
                {
                    Propietario objProp = new Propietario();
                    clsPropietario clsProp = new clsPropietario();

                    Int64 id = Convert.ToInt64(dgvDatosInqPropGar.Rows[e.RowIndex].Cells["Column7"].Value);
                    List<Propietario> lstP = clsProp.LeerPropietXID(id);
                    //NuevoSocio.CargarTxt(Convert.ToInt32(dgvInfoSocios.Rows[i].Cells[0].Value.ToString()));

                    foreach (Propietario itemP in lstP)
                    {
                        txtNomYApe.Text = itemP.NombreYApellido;
                        txtDNI.Text = itemP.DNI.ToString();
                        txtFechaNac.Text = itemP.FechaNac.ToString();
                        txtTelefono.Text = itemP.Telefono.ToString();
                        txtCorreoElectronico.Text = itemP.CorreoElectronico;
                        txtDireccion.Text = itemP.Direccion;
                        cbxLocalidad.Text = itemP.Localidad.Nombre;
                    }
                }
                else
                {
                    Garante objGar = new Garante();
                    clsGarante clsGar = new clsGarante();

                    Int64 id = Convert.ToInt64(dgvDatosInqPropGar.Rows[e.RowIndex].Cells["Column7"].Value);
                    List<Garante> lstG = clsGar.LeerGarXID(id);
                    //NuevoSocio.CargarTxt(Convert.ToInt32(dgvInfoSocios.Rows[i].Cells[0].Value.ToString()));

                    foreach (Garante itemG in lstG)
                    {
                        txtNomYApe.Text = itemG.NombreYApellido;
                        txtDNI.Text = itemG.DNI.ToString();
                        txtFechaNac.Text = itemG.FechaNac.ToString();
                        txtTelefono.Text = itemG.Telefono.ToString();
                        txtCorreoElectronico.Text = itemG.CorreoElectronico;
                        txtDireccion.Text = itemG.Direccion;
                        cbxLocalidad.Text = itemG.Localidad.Nombre;
                        txtMontoSueldo.Text = itemG.MontoSueldo.ToString();
                    }
                }
            }
        }

        private void cbxLocalidad_Click(object sender, EventArgs e)
        {
            CodGenerico codGenerico = new CodGenerico();

            codGenerico.LlenarComboLocalidad(cbxLocalidad);
        }

        private void btnEnviarNotif_Click(object sender, EventArgs e)
        {
            Process.Start("http://api.whatsapp.com/send?phone=54" + txtNumTelNotif.Text + "&text=" + "Usted adeuda alquileres. Los plazos de pago son del 1 al 10 de cada mes.");
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            CodGenerico codGenerico = new CodGenerico();

            codGenerico.LimpiaCampos(panel1);
        }
    }
}
