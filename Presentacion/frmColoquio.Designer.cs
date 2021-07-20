namespace Presentacion
{
    partial class frmColoquio
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
            this.btnReporte = new System.Windows.Forms.Button();
            this.lblPropiet = new System.Windows.Forms.Label();
            this.cbxComboSinModif1 = new ControlesPersonalizados.cbxComboSinModif();
            this.SuspendLayout();
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReporte.Location = new System.Drawing.Point(674, 544);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(135, 49);
            this.btnReporte.TabIndex = 60;
            this.btnReporte.Text = "Ver reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // lblPropiet
            // 
            this.lblPropiet.AutoSize = true;
            this.lblPropiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropiet.ForeColor = System.Drawing.Color.White;
            this.lblPropiet.Location = new System.Drawing.Point(41, 46);
            this.lblPropiet.Name = "lblPropiet";
            this.lblPropiet.Size = new System.Drawing.Size(91, 13);
            this.lblPropiet.TabIndex = 61;
            this.lblPropiet.Text = "PROPIETARIO";
            // 
            // cbxComboSinModif1
            // 
            this.cbxComboSinModif1.FormattingEnabled = true;
            this.cbxComboSinModif1.Location = new System.Drawing.Point(138, 43);
            this.cbxComboSinModif1.Name = "cbxComboSinModif1";
            this.cbxComboSinModif1.Size = new System.Drawing.Size(121, 21);
            this.cbxComboSinModif1.TabIndex = 62;
            // 
            // frmColoquio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1080, 615);
            this.Controls.Add(this.cbxComboSinModif1);
            this.Controls.Add(this.lblPropiet);
            this.Controls.Add(this.btnReporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmColoquio";
            this.Text = "frmColoquio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Label lblPropiet;
        private ControlesPersonalizados.cbxComboSinModif cbxComboSinModif1;
    }
}