namespace Presentacion
{
    partial class frmCobroAlquiler
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
            this.dgvDatosInquilinos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPeriodoAPagar = new System.Windows.Forms.TextBox();
            this.lblPeriodoAPagar = new System.Windows.Forms.Label();
            this.lblCobroAlquiler = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosInquilinos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatosInquilinos
            // 
            this.dgvDatosInquilinos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatosInquilinos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDatosInquilinos.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvDatosInquilinos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatosInquilinos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosInquilinos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDatosInquilinos.ColumnHeadersHeight = 27;
            this.dgvDatosInquilinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatosInquilinos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column2});
            this.dgvDatosInquilinos.EnableHeadersVisualStyles = false;
            this.dgvDatosInquilinos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvDatosInquilinos.Location = new System.Drawing.Point(17, 125);
            this.dgvDatosInquilinos.Name = "dgvDatosInquilinos";
            this.dgvDatosInquilinos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosInquilinos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDatosInquilinos.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDatosInquilinos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDatosInquilinos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosInquilinos.Size = new System.Drawing.Size(715, 250);
            this.dgvDatosInquilinos.TabIndex = 59;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Periodo";
            this.Column1.Name = "Column1";
            this.Column1.Width = 91;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Monto Alquiler";
            this.Column3.Name = "Column3";
            this.Column3.Width = 140;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Adicional por retraso";
            this.Column4.Name = "Column4";
            this.Column4.Width = 189;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Adicional por multas";
            this.Column5.Name = "Column5";
            this.Column5.Width = 185;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Estado";
            this.Column2.Name = "Column2";
            this.Column2.Width = 85;
            // 
            // txtPeriodoAPagar
            // 
            this.txtPeriodoAPagar.Location = new System.Drawing.Point(25, 76);
            this.txtPeriodoAPagar.Name = "txtPeriodoAPagar";
            this.txtPeriodoAPagar.Size = new System.Drawing.Size(82, 20);
            this.txtPeriodoAPagar.TabIndex = 63;
            // 
            // lblPeriodoAPagar
            // 
            this.lblPeriodoAPagar.AutoSize = true;
            this.lblPeriodoAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodoAPagar.Location = new System.Drawing.Point(22, 50);
            this.lblPeriodoAPagar.Name = "lblPeriodoAPagar";
            this.lblPeriodoAPagar.Size = new System.Drawing.Size(95, 15);
            this.lblPeriodoAPagar.TabIndex = 60;
            this.lblPeriodoAPagar.Text = "Periodo a pagar";
            // 
            // lblCobroAlquiler
            // 
            this.lblCobroAlquiler.AutoSize = true;
            this.lblCobroAlquiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCobroAlquiler.Location = new System.Drawing.Point(22, 9);
            this.lblCobroAlquiler.Name = "lblCobroAlquiler";
            this.lblCobroAlquiler.Size = new System.Drawing.Size(163, 16);
            this.lblCobroAlquiler.TabIndex = 66;
            this.lblCobroAlquiler.Text = "COBRO DE ALQUILER";
            // 
            // CobroAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(750, 400);
            this.Controls.Add(this.lblCobroAlquiler);
            this.Controls.Add(this.txtPeriodoAPagar);
            this.Controls.Add(this.lblPeriodoAPagar);
            this.Controls.Add(this.dgvDatosInquilinos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CobroAlquiler";
            this.Text = "CobroAlquiler";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosInquilinos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvDatosInquilinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txtPeriodoAPagar;
        private System.Windows.Forms.Label lblPeriodoAPagar;
        private System.Windows.Forms.Label lblCobroAlquiler;
    }
}