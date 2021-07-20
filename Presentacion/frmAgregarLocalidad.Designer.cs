namespace Presentacion
{
    partial class frmAgregarLocalidad
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
            this.pbxMinimizarAgregarLocalidad = new System.Windows.Forms.PictureBox();
            this.pbxSalirAgregarLocalidad = new System.Windows.Forms.PictureBox();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtLocalidad = new ControlesPersonalizados.txtSoloLetrasConEspacio();
            this.txtCodPos = new ControlesPersonalizados.txtSoloNumeros();
            this.cbxProvincia = new ControlesPersonalizados.cbxComboSinModif();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizarAgregarLocalidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalirAgregarLocalidad)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxMinimizarAgregarLocalidad
            // 
            this.pbxMinimizarAgregarLocalidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMinimizarAgregarLocalidad.Image = global::Presentacion.Properties.Resources.minimizar;
            this.pbxMinimizarAgregarLocalidad.Location = new System.Drawing.Point(436, 5);
            this.pbxMinimizarAgregarLocalidad.Name = "pbxMinimizarAgregarLocalidad";
            this.pbxMinimizarAgregarLocalidad.Size = new System.Drawing.Size(15, 15);
            this.pbxMinimizarAgregarLocalidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMinimizarAgregarLocalidad.TabIndex = 50;
            this.pbxMinimizarAgregarLocalidad.TabStop = false;
            this.pbxMinimizarAgregarLocalidad.Click += new System.EventHandler(this.pbxMinimizarAgregarLocalidad_Click);
            // 
            // pbxSalirAgregarLocalidad
            // 
            this.pbxSalirAgregarLocalidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSalirAgregarLocalidad.Image = global::Presentacion.Properties.Resources.cerrar;
            this.pbxSalirAgregarLocalidad.Location = new System.Drawing.Point(457, 5);
            this.pbxSalirAgregarLocalidad.Name = "pbxSalirAgregarLocalidad";
            this.pbxSalirAgregarLocalidad.Size = new System.Drawing.Size(15, 15);
            this.pbxSalirAgregarLocalidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSalirAgregarLocalidad.TabIndex = 49;
            this.pbxSalirAgregarLocalidad.TabStop = false;
            this.pbxSalirAgregarLocalidad.Click += new System.EventHandler(this.pbxSalirAgregarLocalidad_Click);
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPostal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCodPostal.Location = new System.Drawing.Point(69, 49);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(83, 15);
            this.lblCodPostal.TabIndex = 51;
            this.lblCodPostal.Text = "Codigo Postal";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLocalidad.Location = new System.Drawing.Point(69, 96);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(61, 15);
            this.lblLocalidad.TabIndex = 52;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProvincia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblProvincia.Location = new System.Drawing.Point(69, 143);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(57, 15);
            this.lblProvincia.TabIndex = 53;
            this.lblProvincia.Text = "Provincia";
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
            this.btnGuardar.Location = new System.Drawing.Point(180, 198);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 35);
            this.btnGuardar.TabIndex = 57;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(161, 95);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(207, 20);
            this.txtLocalidad.TabIndex = 60;
            // 
            // txtCodPos
            // 
            this.txtCodPos.Location = new System.Drawing.Point(161, 48);
            this.txtCodPos.Name = "txtCodPos";
            this.txtCodPos.Size = new System.Drawing.Size(115, 20);
            this.txtCodPos.TabIndex = 58;
            // 
            // cbxProvincia
            // 
            this.cbxProvincia.FormattingEnabled = true;
            this.cbxProvincia.Location = new System.Drawing.Point(161, 142);
            this.cbxProvincia.Name = "cbxProvincia";
            this.cbxProvincia.Size = new System.Drawing.Size(207, 21);
            this.cbxProvincia.TabIndex = 61;
            // 
            // AgregarLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(478, 250);
            this.Controls.Add(this.cbxProvincia);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.txtCodPos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblCodPostal);
            this.Controls.Add(this.pbxMinimizarAgregarLocalidad);
            this.Controls.Add(this.pbxSalirAgregarLocalidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarLocalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarLocalidad";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizarAgregarLocalidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalirAgregarLocalidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMinimizarAgregarLocalidad;
        private System.Windows.Forms.PictureBox pbxSalirAgregarLocalidad;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblProvincia;
        public System.Windows.Forms.Button btnGuardar;
        private ControlesPersonalizados.txtSoloNumeros txtCodPos;
        private ControlesPersonalizados.txtSoloLetrasConEspacio txtLocalidad;
        private ControlesPersonalizados.cbxComboSinModif cbxProvincia;
    }
}