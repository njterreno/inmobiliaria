namespace Presentacion
{
    partial class frmBusqueda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvDatosInquilinos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pbxMinimizarBusqueda = new System.Windows.Forms.PictureBox();
            this.pbxSalirBusqueda = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosInquilinos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizarBusqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalirBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(12, 33);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(176, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // dgvDatosInquilinos
            // 
            this.dgvDatosInquilinos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatosInquilinos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatosInquilinos.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvDatosInquilinos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatosInquilinos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosInquilinos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDatosInquilinos.ColumnHeadersHeight = 27;
            this.dgvDatosInquilinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatosInquilinos.EnableHeadersVisualStyles = false;
            this.dgvDatosInquilinos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvDatosInquilinos.Location = new System.Drawing.Point(12, 69);
            this.dgvDatosInquilinos.Name = "dgvDatosInquilinos";
            this.dgvDatosInquilinos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosInquilinos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDatosInquilinos.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDatosInquilinos.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDatosInquilinos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosInquilinos.Size = new System.Drawing.Size(418, 366);
            this.dgvDatosInquilinos.TabIndex = 45;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.Location = new System.Drawing.Point(207, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 29);
            this.btnBuscar.TabIndex = 46;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // pbxMinimizarBusqueda
            // 
            this.pbxMinimizarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMinimizarBusqueda.Image = global::Presentacion.Properties.Resources.minimizar;
            this.pbxMinimizarBusqueda.Location = new System.Drawing.Point(401, 2);
            this.pbxMinimizarBusqueda.Name = "pbxMinimizarBusqueda";
            this.pbxMinimizarBusqueda.Size = new System.Drawing.Size(15, 15);
            this.pbxMinimizarBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMinimizarBusqueda.TabIndex = 48;
            this.pbxMinimizarBusqueda.TabStop = false;
            this.pbxMinimizarBusqueda.Click += new System.EventHandler(this.pbxMinimizarBusqueda_Click);
            // 
            // pbxSalirBusqueda
            // 
            this.pbxSalirBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSalirBusqueda.Image = global::Presentacion.Properties.Resources.cerrar;
            this.pbxSalirBusqueda.Location = new System.Drawing.Point(422, 2);
            this.pbxSalirBusqueda.Name = "pbxSalirBusqueda";
            this.pbxSalirBusqueda.Size = new System.Drawing.Size(15, 15);
            this.pbxSalirBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSalirBusqueda.TabIndex = 47;
            this.pbxSalirBusqueda.TabStop = false;
            this.pbxSalirBusqueda.Click += new System.EventHandler(this.pbxSalirBusqueda_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::Presentacion.Properties.Resources.signo_mas;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(331, 27);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(33, 27);
            this.btnAgregar.TabIndex = 790;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(441, 447);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxMinimizarBusqueda);
            this.Controls.Add(this.pbxSalirBusqueda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvDatosInquilinos);
            this.Controls.Add(this.txtBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Busqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosInquilinos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizarBusqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalirBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        public System.Windows.Forms.DataGridView dgvDatosInquilinos;
        public System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pbxMinimizarBusqueda;
        private System.Windows.Forms.PictureBox pbxSalirBusqueda;
        public System.Windows.Forms.Button btnAgregar;
    }
}