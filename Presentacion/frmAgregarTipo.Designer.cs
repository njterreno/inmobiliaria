namespace Presentacion
{
    partial class frmAgregarTipo
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.pbxMinimizarAgregarZona = new System.Windows.Forms.PictureBox();
            this.pbxSalirAgregarTipo = new System.Windows.Forms.PictureBox();
            this.txtTipo = new ControlesPersonalizados.txtSoloLetrasConEspacio();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizarAgregarZona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalirAgregarTipo)).BeginInit();
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
            this.btnGuardar.Location = new System.Drawing.Point(190, 214);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 35);
            this.btnGuardar.TabIndex = 73;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(161, 105);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(207, 55);
            this.txtDescripcion.TabIndex = 71;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(69, 107);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(63, 13);
            this.lblLocalidad.TabIndex = 70;
            this.lblLocalidad.Text = "Descripcion";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(69, 61);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 69;
            this.lblTipo.Text = "Tipo";
            // 
            // pbxMinimizarAgregarZona
            // 
            this.pbxMinimizarAgregarZona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMinimizarAgregarZona.Image = global::Presentacion.Properties.Resources.minimizar;
            this.pbxMinimizarAgregarZona.Location = new System.Drawing.Point(432, 6);
            this.pbxMinimizarAgregarZona.Name = "pbxMinimizarAgregarZona";
            this.pbxMinimizarAgregarZona.Size = new System.Drawing.Size(15, 15);
            this.pbxMinimizarAgregarZona.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMinimizarAgregarZona.TabIndex = 68;
            this.pbxMinimizarAgregarZona.TabStop = false;
            // 
            // pbxSalirAgregarTipo
            // 
            this.pbxSalirAgregarTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSalirAgregarTipo.Image = global::Presentacion.Properties.Resources.cerrar;
            this.pbxSalirAgregarTipo.Location = new System.Drawing.Point(453, 6);
            this.pbxSalirAgregarTipo.Name = "pbxSalirAgregarTipo";
            this.pbxSalirAgregarTipo.Size = new System.Drawing.Size(15, 15);
            this.pbxSalirAgregarTipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSalirAgregarTipo.TabIndex = 67;
            this.pbxSalirAgregarTipo.TabStop = false;
            this.pbxSalirAgregarTipo.Click += new System.EventHandler(this.pbxSalirAgregarTipo_Click);
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(161, 58);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(207, 20);
            this.txtTipo.TabIndex = 74;
            // 
            // frmAgregarTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(476, 261);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.pbxMinimizarAgregarZona);
            this.Controls.Add(this.pbxSalirAgregarTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarTipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarTipo";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizarAgregarZona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalirAgregarTipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.PictureBox pbxMinimizarAgregarZona;
        private System.Windows.Forms.PictureBox pbxSalirAgregarTipo;
        private ControlesPersonalizados.txtSoloLetrasConEspacio txtTipo;
    }
}