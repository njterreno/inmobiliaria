namespace Presentacion
{
    partial class frmAgregarEdificio
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblMontoExpensas = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.cbxLocalidad = new ControlesPersonalizados.cbxComboSinModif();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtMontoExpensas = new ControlesPersonalizados.txtSoloNumeros();
            this.txtNombre = new ControlesPersonalizados.txtSoloLetrasConEspacio();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.pbxMinimizar = new System.Windows.Forms.PictureBox();
            this.pbxSalir = new System.Windows.Forms.PictureBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.cbxBarrio = new ControlesPersonalizados.cbxComboSinModif();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardar.Location = new System.Drawing.Point(199, 214);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 35);
            this.btnGuardar.TabIndex = 80;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblMontoExpensas
            // 
            this.lblMontoExpensas.AutoSize = true;
            this.lblMontoExpensas.Location = new System.Drawing.Point(69, 177);
            this.lblMontoExpensas.Name = "lblMontoExpensas";
            this.lblMontoExpensas.Size = new System.Drawing.Size(86, 13);
            this.lblMontoExpensas.TabIndex = 77;
            this.lblMontoExpensas.Text = "Monto Expensas";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(69, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 76;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(69, 108);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 81;
            this.lblDireccion.Text = "Direccion";
            // 
            // cbxLocalidad
            // 
            this.cbxLocalidad.FormattingEnabled = true;
            this.cbxLocalidad.Location = new System.Drawing.Point(190, 70);
            this.cbxLocalidad.Name = "cbxLocalidad";
            this.cbxLocalidad.Size = new System.Drawing.Size(147, 21);
            this.cbxLocalidad.TabIndex = 82;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(69, 73);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 83;
            this.lblLocalidad.Text = "Localidad";
            // 
            // txtMontoExpensas
            // 
            this.txtMontoExpensas.Location = new System.Drawing.Point(190, 174);
            this.txtMontoExpensas.Name = "txtMontoExpensas";
            this.txtMontoExpensas.Size = new System.Drawing.Size(147, 20);
            this.txtMontoExpensas.TabIndex = 84;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(190, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(147, 20);
            this.txtNombre.TabIndex = 85;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(190, 105);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(147, 20);
            this.txtDireccion.TabIndex = 86;
            // 
            // pbxMinimizar
            // 
            this.pbxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMinimizar.Image = global::Presentacion.Properties.Resources.minimizar;
            this.pbxMinimizar.Location = new System.Drawing.Point(432, 6);
            this.pbxMinimizar.Name = "pbxMinimizar";
            this.pbxMinimizar.Size = new System.Drawing.Size(15, 15);
            this.pbxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMinimizar.TabIndex = 75;
            this.pbxMinimizar.TabStop = false;
            this.pbxMinimizar.Click += new System.EventHandler(this.pbxMinimizar_Click);
            // 
            // pbxSalir
            // 
            this.pbxSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSalir.Image = global::Presentacion.Properties.Resources.cerrar;
            this.pbxSalir.Location = new System.Drawing.Point(453, 6);
            this.pbxSalir.Name = "pbxSalir";
            this.pbxSalir.Size = new System.Drawing.Size(15, 15);
            this.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSalir.TabIndex = 74;
            this.pbxSalir.TabStop = false;
            this.pbxSalir.Click += new System.EventHandler(this.pbxSalirAgregarTipo_Click);
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(69, 142);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(34, 13);
            this.lblBarrio.TabIndex = 87;
            this.lblBarrio.Text = "Barrio";
            // 
            // cbxBarrio
            // 
            this.cbxBarrio.FormattingEnabled = true;
            this.cbxBarrio.Location = new System.Drawing.Point(190, 139);
            this.cbxBarrio.Name = "cbxBarrio";
            this.cbxBarrio.Size = new System.Drawing.Size(146, 21);
            this.cbxBarrio.TabIndex = 88;
            // 
            // frmAgregarEdificio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(476, 261);
            this.Controls.Add(this.cbxBarrio);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtMontoExpensas);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.cbxLocalidad);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblMontoExpensas);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pbxMinimizar);
            this.Controls.Add(this.pbxSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarEdificio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarEdificio";
            this.Load += new System.EventHandler(this.frmAgregarEdificio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblMontoExpensas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pbxMinimizar;
        private System.Windows.Forms.PictureBox pbxSalir;
        private System.Windows.Forms.Label lblDireccion;
        private ControlesPersonalizados.cbxComboSinModif cbxLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private ControlesPersonalizados.txtSoloNumeros txtMontoExpensas;
        private ControlesPersonalizados.txtSoloLetrasConEspacio txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblBarrio;
        private ControlesPersonalizados.cbxComboSinModif cbxBarrio;
    }
}