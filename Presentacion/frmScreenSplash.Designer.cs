namespace Presentacion
{
    partial class frmScreenSplash
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbxScreenSplash = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tmrTiempo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxScreenSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxScreenSplash
            // 
            this.pbxScreenSplash.Image = global::Presentacion.Properties.Resources.logo_empresa;
            this.pbxScreenSplash.Location = new System.Drawing.Point(13, 13);
            this.pbxScreenSplash.Name = "pbxScreenSplash";
            this.pbxScreenSplash.Size = new System.Drawing.Size(570, 300);
            this.pbxScreenSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxScreenSplash.TabIndex = 0;
            this.pbxScreenSplash.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(60, 325);
            this.progressBar1.MarqueeAnimationSpeed = 10;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(475, 25);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 1;
            // 
            // tmrTiempo
            // 
            this.tmrTiempo.Tick += new System.EventHandler(this.tmrTiempo_Tick);
            // 
            // frmScreenSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pbxScreenSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmScreenSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScreenSplash";
            this.TransparencyKey = System.Drawing.Color.Gray;
            ((System.ComponentModel.ISupportInitialize)(this.pbxScreenSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxScreenSplash;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer tmrTiempo;
    }
}

