namespace Presentacion
{
    partial class frmAgregarBarrio
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.pbxMinimizar = new System.Windows.Forms.PictureBox();
            this.pbxSalir = new System.Windows.Forms.PictureBox();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.cbxLocalidad = new ControlesPersonalizados.cbxComboSinModif();
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
            this.btnGuardar.Location = new System.Drawing.Point(184, 216);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 35);
            this.btnGuardar.TabIndex = 66;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(151, 122);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(207, 55);
            this.txtDescripcion.TabIndex = 64;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(59, 125);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 61;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(59, 80);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(34, 13);
            this.lblBarrio.TabIndex = 60;
            this.lblBarrio.Text = "Barrio";
            // 
            // pbxMinimizar
            // 
            this.pbxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMinimizar.Image = global::Presentacion.Properties.Resources.minimizar;
            this.pbxMinimizar.Location = new System.Drawing.Point(424, 3);
            this.pbxMinimizar.Name = "pbxMinimizar";
            this.pbxMinimizar.Size = new System.Drawing.Size(15, 15);
            this.pbxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMinimizar.TabIndex = 59;
            this.pbxMinimizar.TabStop = false;
            // 
            // pbxSalir
            // 
            this.pbxSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSalir.Image = global::Presentacion.Properties.Resources.cerrar;
            this.pbxSalir.Location = new System.Drawing.Point(445, 3);
            this.pbxSalir.Name = "pbxSalir";
            this.pbxSalir.Size = new System.Drawing.Size(15, 15);
            this.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSalir.TabIndex = 58;
            this.pbxSalir.TabStop = false;
            this.pbxSalir.Click += new System.EventHandler(this.pbxSalirAgregarZona_Click);
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(151, 77);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(207, 20);
            this.txtBarrio.TabIndex = 65;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(59, 36);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 85;
            this.lblLocalidad.Text = "Localidad";
            // 
            // cbxLocalidad
            // 
            this.cbxLocalidad.FormattingEnabled = true;
            this.cbxLocalidad.Location = new System.Drawing.Point(151, 33);
            this.cbxLocalidad.Name = "cbxLocalidad";
            this.cbxLocalidad.Size = new System.Drawing.Size(207, 21);
            this.cbxLocalidad.TabIndex = 84;
            // 
            // frmAgregarBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(466, 285);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.cbxLocalidad);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtBarrio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.pbxMinimizar);
            this.Controls.Add(this.pbxSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarBarrio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarZona";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.PictureBox pbxMinimizar;
        private System.Windows.Forms.PictureBox pbxSalir;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.Label lblLocalidad;
        public ControlesPersonalizados.cbxComboSinModif cbxLocalidad;
    }
}