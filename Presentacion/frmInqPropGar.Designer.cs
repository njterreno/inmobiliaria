namespace Presentacion
{
    partial class frmInqPropGar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNomYApe = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreoElec = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDirec = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblNomYApeBusq = new System.Windows.Forms.Label();
            this.lblDNIBusq = new System.Windows.Forms.Label();
            this.txtNomYApeBusq = new System.Windows.Forms.TextBox();
            this.txtDNIBusq = new System.Windows.Forms.TextBox();
            this.dgvDatosInqPropGar = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtTelefono = new ControlesPersonalizados.txtSoloNumeros();
            this.txtDNI = new ControlesPersonalizados.txtSoloNumeros();
            this.txtNomYApe = new ControlesPersonalizados.txtSoloLetrasConEspacio();
            this.cbxLocalidad = new ControlesPersonalizados.cbxComboSinModif();
            this.pbxMinimizar = new System.Windows.Forms.PictureBox();
            this.pbxSalir = new System.Windows.Forms.PictureBox();
            this.lblMontoSueldo = new System.Windows.Forms.Label();
            this.txtMontoSueldo = new ControlesPersonalizados.txtSoloNumeros();
            this.txtFechaNac = new System.Windows.Forms.DateTimePicker();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblLocalidadBusq = new System.Windows.Forms.Label();
            this.cbxLocalidadBusq = new ControlesPersonalizados.cbxBusqueda();
            this.txtNumTelNotif = new ControlesPersonalizados.txtSoloNumeros();
            this.lblNotif = new System.Windows.Forms.Label();
            this.btnEnviarNotif = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosInqPropGar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbxLocalidadBusq);
            this.panel2.Controls.Add(this.lblLocalidadBusq);
            this.panel2.Controls.Add(this.dgvDatosInqPropGar);
            this.panel2.Controls.Add(this.txtDNIBusq);
            this.panel2.Controls.Add(this.txtNomYApeBusq);
            this.panel2.Controls.Add(this.lblDNIBusq);
            this.panel2.Controls.Add(this.lblNomYApeBusq);
            this.panel2.Controls.SetChildIndex(this.btnDarDeBaja, 0);
            this.panel2.Controls.SetChildIndex(this.btnModificar, 0);
            this.panel2.Controls.SetChildIndex(this.btnBuscar, 0);
            this.panel2.Controls.SetChildIndex(this.lblTitulo, 0);
            this.panel2.Controls.SetChildIndex(this.lblNomYApeBusq, 0);
            this.panel2.Controls.SetChildIndex(this.lblDNIBusq, 0);
            this.panel2.Controls.SetChildIndex(this.txtNomYApeBusq, 0);
            this.panel2.Controls.SetChildIndex(this.txtDNIBusq, 0);
            this.panel2.Controls.SetChildIndex(this.dgvDatosInqPropGar, 0);
            this.panel2.Controls.SetChildIndex(this.lblLocalidadBusq, 0);
            this.panel2.Controls.SetChildIndex(this.cbxLocalidadBusq, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEnviarNotif);
            this.panel1.Controls.Add(this.lblNotif);
            this.panel1.Controls.Add(this.txtNumTelNotif);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.txtFechaNac);
            this.panel1.Controls.Add(this.txtMontoSueldo);
            this.panel1.Controls.Add(this.lblMontoSueldo);
            this.panel1.Controls.Add(this.pbxMinimizar);
            this.panel1.Controls.Add(this.pbxSalir);
            this.panel1.Controls.Add(this.cbxLocalidad);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtDNI);
            this.panel1.Controls.Add(this.txtNomYApe);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.lblLocalidad);
            this.panel1.Controls.Add(this.lblDirec);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txtCorreoElectronico);
            this.panel1.Controls.Add(this.lblCorreoElec);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.lblFechaNac);
            this.panel1.Controls.Add(this.lblDNI);
            this.panel1.Controls.Add(this.lblNomYApe);
            this.panel1.Controls.SetChildIndex(this.btnLimpiarCampos, 0);
            this.panel1.Controls.SetChildIndex(this.lblNomYApe, 0);
            this.panel1.Controls.SetChildIndex(this.lblDNI, 0);
            this.panel1.Controls.SetChildIndex(this.lblFechaNac, 0);
            this.panel1.Controls.SetChildIndex(this.lblTelefono, 0);
            this.panel1.Controls.SetChildIndex(this.lblCorreoElec, 0);
            this.panel1.Controls.SetChildIndex(this.txtCorreoElectronico, 0);
            this.panel1.Controls.SetChildIndex(this.txtDireccion, 0);
            this.panel1.Controls.SetChildIndex(this.btnGuardar, 0);
            this.panel1.Controls.SetChildIndex(this.lblDirec, 0);
            this.panel1.Controls.SetChildIndex(this.lblLocalidad, 0);
            this.panel1.Controls.SetChildIndex(this.btnAgregar, 0);
            this.panel1.Controls.SetChildIndex(this.txtNomYApe, 0);
            this.panel1.Controls.SetChildIndex(this.txtDNI, 0);
            this.panel1.Controls.SetChildIndex(this.txtTelefono, 0);
            this.panel1.Controls.SetChildIndex(this.cbxLocalidad, 0);
            this.panel1.Controls.SetChildIndex(this.pbxSalir, 0);
            this.panel1.Controls.SetChildIndex(this.pbxMinimizar, 0);
            this.panel1.Controls.SetChildIndex(this.lblMontoSueldo, 0);
            this.panel1.Controls.SetChildIndex(this.txtMontoSueldo, 0);
            this.panel1.Controls.SetChildIndex(this.txtFechaNac, 0);
            this.panel1.Controls.SetChildIndex(this.txtID, 0);
            this.panel1.Controls.SetChildIndex(this.txtNumTelNotif, 0);
            this.panel1.Controls.SetChildIndex(this.lblNotif, 0);
            this.panel1.Controls.SetChildIndex(this.btnEnviarNotif, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBuscar.Location = new System.Drawing.Point(685, 4);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnDarDeBaja
            // 
            this.btnDarDeBaja.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnDarDeBaja.FlatAppearance.BorderSize = 0;
            this.btnDarDeBaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Size = new System.Drawing.Size(0, 16);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLimpiarCampos.FlatAppearance.BorderSize = 0;
            this.btnLimpiarCampos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // lblNomYApe
            // 
            this.lblNomYApe.AutoSize = true;
            this.lblNomYApe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomYApe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNomYApe.Location = new System.Drawing.Point(30, 70);
            this.lblNomYApe.Name = "lblNomYApe";
            this.lblNomYApe.Size = new System.Drawing.Size(123, 16);
            this.lblNomYApe.TabIndex = 0;
            this.lblNomYApe.Text = "Nombre y Apellido ";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDNI.Location = new System.Drawing.Point(30, 108);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(31, 16);
            this.lblDNI.TabIndex = 1;
            this.lblDNI.Text = "DNI";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFechaNac.Location = new System.Drawing.Point(30, 149);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(117, 16);
            this.lblFechaNac.TabIndex = 2;
            this.lblFechaNac.Text = "Fecha Nacimiento";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTelefono.Location = new System.Drawing.Point(30, 190);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(62, 16);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblCorreoElec
            // 
            this.lblCorreoElec.AutoSize = true;
            this.lblCorreoElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoElec.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCorreoElec.Location = new System.Drawing.Point(30, 231);
            this.lblCorreoElec.Name = "lblCorreoElec";
            this.lblCorreoElec.Size = new System.Drawing.Size(119, 16);
            this.lblCorreoElec.TabIndex = 4;
            this.lblCorreoElec.Text = "Correo Electrónico";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(155, 230);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(147, 20);
            this.txtCorreoElectronico.TabIndex = 22;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(155, 271);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(147, 20);
            this.txtDireccion.TabIndex = 23;
            // 
            // lblDirec
            // 
            this.lblDirec.AutoSize = true;
            this.lblDirec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirec.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDirec.Location = new System.Drawing.Point(30, 272);
            this.lblDirec.Name = "lblDirec";
            this.lblDirec.Size = new System.Drawing.Size(65, 16);
            this.lblDirec.TabIndex = 17;
            this.lblDirec.Text = "Dirección";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLocalidad.Location = new System.Drawing.Point(30, 316);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(68, 16);
            this.lblLocalidad.TabIndex = 18;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblNomYApeBusq
            // 
            this.lblNomYApeBusq.AutoSize = true;
            this.lblNomYApeBusq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomYApeBusq.ForeColor = System.Drawing.Color.Black;
            this.lblNomYApeBusq.Location = new System.Drawing.Point(255, 10);
            this.lblNomYApeBusq.Name = "lblNomYApeBusq";
            this.lblNomYApeBusq.Size = new System.Drawing.Size(130, 16);
            this.lblNomYApeBusq.TabIndex = 20;
            this.lblNomYApeBusq.Text = "Nombre/Apellido ";
            // 
            // lblDNIBusq
            // 
            this.lblDNIBusq.AutoSize = true;
            this.lblDNIBusq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNIBusq.ForeColor = System.Drawing.Color.Black;
            this.lblDNIBusq.Location = new System.Drawing.Point(438, 10);
            this.lblDNIBusq.Name = "lblDNIBusq";
            this.lblDNIBusq.Size = new System.Drawing.Size(34, 16);
            this.lblDNIBusq.TabIndex = 20;
            this.lblDNIBusq.Text = "DNI";
            // 
            // txtNomYApeBusq
            // 
            this.txtNomYApeBusq.Location = new System.Drawing.Point(257, 27);
            this.txtNomYApeBusq.Name = "txtNomYApeBusq";
            this.txtNomYApeBusq.Size = new System.Drawing.Size(121, 20);
            this.txtNomYApeBusq.TabIndex = 20;
            // 
            // txtDNIBusq
            // 
            this.txtDNIBusq.Location = new System.Drawing.Point(399, 27);
            this.txtDNIBusq.Name = "txtDNIBusq";
            this.txtDNIBusq.Size = new System.Drawing.Size(121, 20);
            this.txtDNIBusq.TabIndex = 21;
            // 
            // dgvDatosInqPropGar
            // 
            this.dgvDatosInqPropGar.AllowUserToAddRows = false;
            this.dgvDatosInqPropGar.AllowUserToDeleteRows = false;
            this.dgvDatosInqPropGar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatosInqPropGar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatosInqPropGar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatosInqPropGar.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvDatosInqPropGar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatosInqPropGar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosInqPropGar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatosInqPropGar.ColumnHeadersHeight = 27;
            this.dgvDatosInqPropGar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatosInqPropGar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDatosInqPropGar.EnableHeadersVisualStyles = false;
            this.dgvDatosInqPropGar.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvDatosInqPropGar.Location = new System.Drawing.Point(33, 60);
            this.dgvDatosInqPropGar.Name = "dgvDatosInqPropGar";
            this.dgvDatosInqPropGar.ReadOnly = true;
            this.dgvDatosInqPropGar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosInqPropGar.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatosInqPropGar.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDatosInqPropGar.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatosInqPropGar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosInqPropGar.Size = new System.Drawing.Size(752, 495);
            this.dgvDatosInqPropGar.TabIndex = 22;
            this.dgvDatosInqPropGar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosInqPropGar_CellContentClick);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ID";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            this.Column7.Width = 49;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 92;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DNI";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telefono";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 98;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Correo Electronico";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 176;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Direccion";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 104;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Localidad";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 104;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::Presentacion.Properties.Resources.signo_mas;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(279, 313);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(30, 23);
            this.btnAgregar.TabIndex = 789;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(155, 189);
            this.txtTelefono.MaxLength = 13;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(147, 20);
            this.txtTelefono.TabIndex = 21;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(155, 108);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(147, 20);
            this.txtDNI.TabIndex = 11;
            // 
            // txtNomYApe
            // 
            this.txtNomYApe.Location = new System.Drawing.Point(155, 69);
            this.txtNomYApe.Name = "txtNomYApe";
            this.txtNomYApe.Size = new System.Drawing.Size(147, 20);
            this.txtNomYApe.TabIndex = 8;
            // 
            // cbxLocalidad
            // 
            this.cbxLocalidad.FormattingEnabled = true;
            this.cbxLocalidad.Location = new System.Drawing.Point(155, 315);
            this.cbxLocalidad.Name = "cbxLocalidad";
            this.cbxLocalidad.Size = new System.Drawing.Size(121, 21);
            this.cbxLocalidad.TabIndex = 10;
            this.cbxLocalidad.Click += new System.EventHandler(this.cbxLocalidad_Click);
            // 
            // pbxMinimizar
            // 
            this.pbxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMinimizar.Image = global::Presentacion.Properties.Resources.minimizar;
            this.pbxMinimizar.Location = new System.Drawing.Point(273, 5);
            this.pbxMinimizar.Name = "pbxMinimizar";
            this.pbxMinimizar.Size = new System.Drawing.Size(15, 15);
            this.pbxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMinimizar.TabIndex = 791;
            this.pbxMinimizar.TabStop = false;
            this.pbxMinimizar.Visible = false;
            this.pbxMinimizar.Click += new System.EventHandler(this.pbxMinimizarBusqueda_Click);
            // 
            // pbxSalir
            // 
            this.pbxSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSalir.Image = global::Presentacion.Properties.Resources.cerrar;
            this.pbxSalir.Location = new System.Drawing.Point(294, 5);
            this.pbxSalir.Name = "pbxSalir";
            this.pbxSalir.Size = new System.Drawing.Size(15, 15);
            this.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSalir.TabIndex = 790;
            this.pbxSalir.TabStop = false;
            this.pbxSalir.Visible = false;
            this.pbxSalir.Click += new System.EventHandler(this.pbxSalirBusqueda_Click);
            // 
            // lblMontoSueldo
            // 
            this.lblMontoSueldo.AutoSize = true;
            this.lblMontoSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoSueldo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMontoSueldo.Location = new System.Drawing.Point(30, 360);
            this.lblMontoSueldo.Name = "lblMontoSueldo";
            this.lblMontoSueldo.Size = new System.Drawing.Size(91, 16);
            this.lblMontoSueldo.TabIndex = 792;
            this.lblMontoSueldo.Text = "Monto Sueldo";
            this.lblMontoSueldo.Visible = false;
            // 
            // txtMontoSueldo
            // 
            this.txtMontoSueldo.Location = new System.Drawing.Point(155, 359);
            this.txtMontoSueldo.MaxLength = 6;
            this.txtMontoSueldo.Name = "txtMontoSueldo";
            this.txtMontoSueldo.Size = new System.Drawing.Size(147, 20);
            this.txtMontoSueldo.TabIndex = 793;
            this.txtMontoSueldo.Visible = false;
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaNac.Location = new System.Drawing.Point(155, 149);
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(147, 20);
            this.txtFechaNac.TabIndex = 794;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(105, 29);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 796;
            this.txtID.Visible = false;
            // 
            // lblLocalidadBusq
            // 
            this.lblLocalidadBusq.AutoSize = true;
            this.lblLocalidadBusq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidadBusq.ForeColor = System.Drawing.Color.Black;
            this.lblLocalidadBusq.Location = new System.Drawing.Point(557, 8);
            this.lblLocalidadBusq.Name = "lblLocalidadBusq";
            this.lblLocalidadBusq.Size = new System.Drawing.Size(77, 16);
            this.lblLocalidadBusq.TabIndex = 24;
            this.lblLocalidadBusq.Text = "Localidad";
            // 
            // cbxLocalidadBusq
            // 
            this.cbxLocalidadBusq.FormattingEnabled = true;
            this.cbxLocalidadBusq.Items.AddRange(new object[] {
            "y35eygetg",
            "wetwretger",
            "gwrgwrgwr",
            "egrwegwr"});
            this.cbxLocalidadBusq.Location = new System.Drawing.Point(541, 26);
            this.cbxLocalidadBusq.Name = "cbxLocalidadBusq";
            this.cbxLocalidadBusq.Size = new System.Drawing.Size(121, 21);
            this.cbxLocalidadBusq.TabIndex = 25;
            // 
            // txtNumTelNotif
            // 
            this.txtNumTelNotif.Location = new System.Drawing.Point(94, 443);
            this.txtNumTelNotif.Name = "txtNumTelNotif";
            this.txtNumTelNotif.Size = new System.Drawing.Size(147, 20);
            this.txtNumTelNotif.TabIndex = 797;
            // 
            // lblNotif
            // 
            this.lblNotif.AutoSize = true;
            this.lblNotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotif.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNotif.Location = new System.Drawing.Point(79, 424);
            this.lblNotif.Name = "lblNotif";
            this.lblNotif.Size = new System.Drawing.Size(174, 16);
            this.lblNotif.TabIndex = 798;
            this.lblNotif.Text = "NOTIFICACION DE DEUDA";
            // 
            // btnEnviarNotif
            // 
            this.btnEnviarNotif.Location = new System.Drawing.Point(130, 469);
            this.btnEnviarNotif.Name = "btnEnviarNotif";
            this.btnEnviarNotif.Size = new System.Drawing.Size(75, 23);
            this.btnEnviarNotif.TabIndex = 799;
            this.btnEnviarNotif.Text = "ENVIAR";
            this.btnEnviarNotif.UseVisualStyleBackColor = true;
            this.btnEnviarNotif.Click += new System.EventHandler(this.btnEnviarNotif_Click);
            // 
            // frmInqPropGar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Name = "frmInqPropGar";
            this.Load += new System.EventHandler(this.Inquilinos_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosInqPropGar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblCorreoElec;
        public System.Windows.Forms.Label lblTelefono;
        public System.Windows.Forms.Label lblFechaNac;
        public System.Windows.Forms.Label lblDNI;
        public System.Windows.Forms.Label lblNomYApe;
        public System.Windows.Forms.Label lblLocalidad;
        public System.Windows.Forms.Label lblDirec;
        public System.Windows.Forms.Label lblDNIBusq;
        public System.Windows.Forms.Label lblNomYApeBusq;
        public System.Windows.Forms.TextBox txtDNIBusq;
        public System.Windows.Forms.TextBox txtNomYApeBusq;
        public System.Windows.Forms.DataGridView dgvDatosInqPropGar;
        public System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private ControlesPersonalizados.txtSoloNumeros txtTelefono;
        private ControlesPersonalizados.txtSoloNumeros txtDNI;
        private ControlesPersonalizados.txtSoloLetrasConEspacio txtNomYApe;
        public System.Windows.Forms.PictureBox pbxMinimizar;
        public System.Windows.Forms.PictureBox pbxSalir;
        private ControlesPersonalizados.txtSoloNumeros txtMontoSueldo;
        public System.Windows.Forms.Label lblMontoSueldo;
        private System.Windows.Forms.DateTimePicker txtFechaNac;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private ControlesPersonalizados.cbxComboSinModif cbxLocalidad;
        public System.Windows.Forms.Label lblLocalidadBusq;
        private ControlesPersonalizados.cbxBusqueda cbxLocalidadBusq;
        private System.Windows.Forms.Button btnEnviarNotif;
        public System.Windows.Forms.Label lblNotif;
        private ControlesPersonalizados.txtSoloNumeros txtNumTelNotif;


    }
}