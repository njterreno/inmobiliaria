namespace Presentacion
{
    partial class frmGenerarContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerarContrato));
            this.txtContrato = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblContrato = new System.Windows.Forms.Label();
            this.pbxMinimizarGenerarContrato = new System.Windows.Forms.PictureBox();
            this.pbxSalirGenerarContrato = new System.Windows.Forms.PictureBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizarGenerarContrato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalirGenerarContrato)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContrato
            // 
            this.txtContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrato.Location = new System.Drawing.Point(12, 81);
            this.txtContrato.Name = "txtContrato";
            this.txtContrato.Size = new System.Drawing.Size(617, 492);
            this.txtContrato.TabIndex = 1;
            this.txtContrato.Text = resources.GetString("txtContrato.Text");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(661, 81);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 492);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "[LOCALIDAD]\r\n[DIA]\r\n[MES]\r\n[AÑO]";
            // 
            // lblContrato
            // 
            this.lblContrato.AutoSize = true;
            this.lblContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrato.Location = new System.Drawing.Point(12, 17);
            this.lblContrato.Name = "lblContrato";
            this.lblContrato.Size = new System.Drawing.Size(92, 16);
            this.lblContrato.TabIndex = 5;
            this.lblContrato.Text = "CONTRATO";
            // 
            // pbxMinimizarGenerarContrato
            // 
            this.pbxMinimizarGenerarContrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMinimizarGenerarContrato.Image = global::Presentacion.Properties.Resources.minimizar;
            this.pbxMinimizarGenerarContrato.Location = new System.Drawing.Point(824, 3);
            this.pbxMinimizarGenerarContrato.Name = "pbxMinimizarGenerarContrato";
            this.pbxMinimizarGenerarContrato.Size = new System.Drawing.Size(15, 15);
            this.pbxMinimizarGenerarContrato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMinimizarGenerarContrato.TabIndex = 10;
            this.pbxMinimizarGenerarContrato.TabStop = false;
            this.pbxMinimizarGenerarContrato.Click += new System.EventHandler(this.pbxMinimizarLogin_Click);
            // 
            // pbxSalirGenerarContrato
            // 
            this.pbxSalirGenerarContrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSalirGenerarContrato.Image = global::Presentacion.Properties.Resources.cerrar;
            this.pbxSalirGenerarContrato.Location = new System.Drawing.Point(845, 3);
            this.pbxSalirGenerarContrato.Name = "pbxSalirGenerarContrato";
            this.pbxSalirGenerarContrato.Size = new System.Drawing.Size(15, 15);
            this.pbxSalirGenerarContrato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSalirGenerarContrato.TabIndex = 9;
            this.pbxSalirGenerarContrato.TabStop = false;
            this.pbxSalirGenerarContrato.Click += new System.EventHandler(this.pbxSalirLogin_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReporte.Location = new System.Drawing.Point(353, 28);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(125, 35);
            this.btnReporte.TabIndex = 17;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnImprimir.Location = new System.Drawing.Point(504, 28);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(125, 35);
            this.btnImprimir.TabIndex = 18;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // frmGenerarContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(863, 585);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.pbxMinimizarGenerarContrato);
            this.Controls.Add(this.pbxSalirGenerarContrato);
            this.Controls.Add(this.lblContrato);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtContrato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGenerarContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerarContrato";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizarGenerarContrato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalirGenerarContrato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblContrato;
        private System.Windows.Forms.PictureBox pbxMinimizarGenerarContrato;
        private System.Windows.Forms.PictureBox pbxSalirGenerarContrato;
        public System.Windows.Forms.Button btnReporte;
        public System.Windows.Forms.Button btnImprimir;
        public System.Windows.Forms.RichTextBox txtContrato;


    }
}