namespace Presentacion
{
    partial class frmAlquilerMensual
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pbxMinimizar = new System.Windows.Forms.PictureBox();
            this.pbxSalir = new System.Windows.Forms.PictureBox();
            this.txtSoloNumeros1 = new ControlesPersonalizados.txtSoloNumeros();
            this.txtSoloNumeros2 = new ControlesPersonalizados.txtSoloNumeros();
            this.txtSoloNumeros3 = new ControlesPersonalizados.txtSoloNumeros();
            this.txtSoloNumeros4 = new ControlesPersonalizados.txtSoloNumeros();
            this.lblPrimerSemestre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAceptar.Location = new System.Drawing.Point(200, 214);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(125, 35);
            this.btnAceptar.TabIndex = 91;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pbxMinimizar
            // 
            this.pbxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMinimizar.Image = global::Presentacion.Properties.Resources.minimizar;
            this.pbxMinimizar.Location = new System.Drawing.Point(437, 3);
            this.pbxMinimizar.Name = "pbxMinimizar";
            this.pbxMinimizar.Size = new System.Drawing.Size(15, 15);
            this.pbxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMinimizar.TabIndex = 88;
            this.pbxMinimizar.TabStop = false;
            this.pbxMinimizar.Click += new System.EventHandler(this.pbxMinimizar_Click);
            // 
            // pbxSalir
            // 
            this.pbxSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSalir.Image = global::Presentacion.Properties.Resources.cerrar;
            this.pbxSalir.Location = new System.Drawing.Point(458, 3);
            this.pbxSalir.Name = "pbxSalir";
            this.pbxSalir.Size = new System.Drawing.Size(15, 15);
            this.pbxSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSalir.TabIndex = 87;
            this.pbxSalir.TabStop = false;
            this.pbxSalir.Click += new System.EventHandler(this.pbxSalir_Click);
            // 
            // txtSoloNumeros1
            // 
            this.txtSoloNumeros1.Location = new System.Drawing.Point(191, 40);
            this.txtSoloNumeros1.Name = "txtSoloNumeros1";
            this.txtSoloNumeros1.Size = new System.Drawing.Size(147, 20);
            this.txtSoloNumeros1.TabIndex = 95;
            // 
            // txtSoloNumeros2
            // 
            this.txtSoloNumeros2.Location = new System.Drawing.Point(191, 75);
            this.txtSoloNumeros2.Name = "txtSoloNumeros2";
            this.txtSoloNumeros2.Size = new System.Drawing.Size(147, 20);
            this.txtSoloNumeros2.TabIndex = 96;
            // 
            // txtSoloNumeros3
            // 
            this.txtSoloNumeros3.Location = new System.Drawing.Point(191, 111);
            this.txtSoloNumeros3.Name = "txtSoloNumeros3";
            this.txtSoloNumeros3.Size = new System.Drawing.Size(147, 20);
            this.txtSoloNumeros3.TabIndex = 97;
            // 
            // txtSoloNumeros4
            // 
            this.txtSoloNumeros4.Location = new System.Drawing.Point(191, 147);
            this.txtSoloNumeros4.Name = "txtSoloNumeros4";
            this.txtSoloNumeros4.Size = new System.Drawing.Size(147, 20);
            this.txtSoloNumeros4.TabIndex = 98;
            // 
            // lblPrimerSemestre
            // 
            this.lblPrimerSemestre.AutoSize = true;
            this.lblPrimerSemestre.Location = new System.Drawing.Point(93, 43);
            this.lblPrimerSemestre.Name = "lblPrimerSemestre";
            this.lblPrimerSemestre.Size = new System.Drawing.Size(75, 13);
            this.lblPrimerSemestre.TabIndex = 99;
            this.lblPrimerSemestre.Text = "Semestre N° 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Semestre N° 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 101;
            this.label3.Text = "Semestre N° 3";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(93, 150);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(75, 13);
            this.lbl.TabIndex = 102;
            this.lbl.Text = "Semestre N° 4";
            // 
            // frmAlquilerMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(476, 261);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrimerSemestre);
            this.Controls.Add(this.txtSoloNumeros4);
            this.Controls.Add(this.txtSoloNumeros3);
            this.Controls.Add(this.txtSoloNumeros2);
            this.Controls.Add(this.txtSoloNumeros1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.pbxMinimizar);
            this.Controls.Add(this.pbxSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlquilerMensual";
            this.Text = "frmAlquilerMensual";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.PictureBox pbxMinimizar;
        private System.Windows.Forms.PictureBox pbxSalir;
        private ControlesPersonalizados.txtSoloNumeros txtSoloNumeros1;
        private ControlesPersonalizados.txtSoloNumeros txtSoloNumeros2;
        private ControlesPersonalizados.txtSoloNumeros txtSoloNumeros3;
        private ControlesPersonalizados.txtSoloNumeros txtSoloNumeros4;
        private System.Windows.Forms.Label lblPrimerSemestre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
    }
}