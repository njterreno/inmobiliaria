namespace Presentacion
{
    partial class frmLogin
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.linea2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.linea1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.btnMostrarClave = new System.Windows.Forms.Button();
            this.pbxMinimizarLogin = new System.Windows.Forms.PictureBox();
            this.pbxSalirLogin = new System.Windows.Forms.PictureBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizarLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalirLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlLogin.Controls.Add(this.pbxImagen);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(250, 330);
            this.pnlLogin.TabIndex = 0;
            this.pnlLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLogin_MouseDown);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Image = global::Presentacion.Properties.Resources.logo_sistema;
            this.pbxImagen.Location = new System.Drawing.Point(3, 52);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(244, 210);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 0;
            this.pbxImagen.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.linea2,
            this.linea1});
            this.shapeContainer1.Size = new System.Drawing.Size(780, 330);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // linea2
            // 
            this.linea2.BorderColor = System.Drawing.SystemColors.Menu;
            this.linea2.Enabled = false;
            this.linea2.Name = "linea2";
            this.linea2.X1 = 350;
            this.linea2.X2 = 725;
            this.linea2.Y1 = 180;
            this.linea2.Y2 = 180;
            // 
            // linea1
            // 
            this.linea1.BorderColor = System.Drawing.SystemColors.Menu;
            this.linea1.Enabled = false;
            this.linea1.Name = "linea1";
            this.linea1.X1 = 350;
            this.linea1.X2 = 725;
            this.linea1.Y1 = 116;
            this.linea1.Y2 = 116;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsuario.Location = new System.Drawing.Point(350, 99);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(376, 16);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtContraseña.Location = new System.Drawing.Point(350, 164);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(332, 16);
            this.txtContraseña.TabIndex = 2;
            this.txtContraseña.Text = "CONTRASEÑA";
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblLogin.Location = new System.Drawing.Point(452, 9);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(99, 31);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "LOGIN";
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAcceder.FlatAppearance.BorderSize = 0;
            this.btnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAcceder.Location = new System.Drawing.Point(536, 235);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(190, 40);
            this.btnAcceder.TabIndex = 3;
            this.btnAcceder.Text = "ACCEDER";
            this.btnAcceder.UseVisualStyleBackColor = false;
            this.btnAcceder.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // linkLabel
            // 
            this.linkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.linkLabel.AutoSize = true;
            this.linkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkLabel.Location = new System.Drawing.Point(543, 288);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(183, 16);
            this.linkLabel.TabIndex = 0;
            this.linkLabel.TabStop = true;
            this.linkLabel.Tag = "";
            this.linkLabel.Text = "¿Ha olvidado su contraseña?";
            // 
            // btnMostrarClave
            // 
            this.btnMostrarClave.BackgroundImage = global::Presentacion.Properties.Resources.eyeview_857671;
            this.btnMostrarClave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMostrarClave.FlatAppearance.BorderSize = 0;
            this.btnMostrarClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarClave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMostrarClave.Location = new System.Drawing.Point(693, 163);
            this.btnMostrarClave.Name = "btnMostrarClave";
            this.btnMostrarClave.Size = new System.Drawing.Size(30, 15);
            this.btnMostrarClave.TabIndex = 9;
            this.btnMostrarClave.UseVisualStyleBackColor = true;
            this.btnMostrarClave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMostrarClave_MouseDown);
            this.btnMostrarClave.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnMostrarClave_MouseUp);
            // 
            // pbxMinimizarLogin
            // 
            this.pbxMinimizarLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMinimizarLogin.Image = global::Presentacion.Properties.Resources.minimizar;
            this.pbxMinimizarLogin.Location = new System.Drawing.Point(741, 3);
            this.pbxMinimizarLogin.Name = "pbxMinimizarLogin";
            this.pbxMinimizarLogin.Size = new System.Drawing.Size(15, 15);
            this.pbxMinimizarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMinimizarLogin.TabIndex = 8;
            this.pbxMinimizarLogin.TabStop = false;
            this.pbxMinimizarLogin.Click += new System.EventHandler(this.pbxMinimizarLogin_Click);
            // 
            // pbxSalirLogin
            // 
            this.pbxSalirLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSalirLogin.Image = global::Presentacion.Properties.Resources.cerrar;
            this.pbxSalirLogin.Location = new System.Drawing.Point(762, 3);
            this.pbxSalirLogin.Name = "pbxSalirLogin";
            this.pbxSalirLogin.Size = new System.Drawing.Size(15, 15);
            this.pbxSalirLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSalirLogin.TabIndex = 7;
            this.pbxSalirLogin.TabStop = false;
            this.pbxSalirLogin.Click += new System.EventHandler(this.pbxSalirLogin_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.btnMostrarClave);
            this.Controls.Add(this.pbxMinimizarLogin);
            this.Controls.Add(this.pbxSalirLogin);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.btnAcceder);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.pnlLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinimizarLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSalirLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape linea2;
        private Microsoft.VisualBasic.PowerPacks.LineShape linea1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.PictureBox pbxSalirLogin;
        private System.Windows.Forms.PictureBox pbxMinimizarLogin;
        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Button btnMostrarClave;
    }
}