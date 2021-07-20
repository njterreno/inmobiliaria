using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Presentacion
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        public enum Opciones
        {
            Inquilinos,
            Propietarios,
            Garantes,
        }

        private void btnSalirInicio_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int LX, LY;
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            btnMaximizar.Visible = false;
            btnRestaurarInicio.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal; 1300; 650
            this.Size = new Size(1300, 650);
            this.Location = new Point(LX,LY);
            btnMaximizar.Visible = true;
            btnRestaurarInicio.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSalirMenuVerticalInicio_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void AbrirFormHijo(Form formhijo, string titulo, Label lbl)
        private void AbrirFormHijo(Form formhijo)
        {
            if (this.pnlContenedorInicio.Controls.Count > 0)
            {
                this.pnlContenedorInicio.Controls.RemoveAt(0);                
            }

            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedorInicio.Controls.Add(fh);
            this.pnlContenedorInicio.Tag = fh;
            //lbl.Text = titulo;

            fh.Show();            
        }

        private void btnInquilinoInicio_Click(object sender, EventArgs e)
        {
            //Inquilinos inquilino = new Inquilinos(Opciones.AgregarInquilino);
            AbrirFormHijo(new frmInqPropGar(frmInicio.Opciones.Inquilinos));

            //inquilino.ShowDialog();
            //AbrirFormHijo(inquilino, "INQUILINOS", inquilino.lblTitulo);
        }

        private void btnSlide_Click(object sender, EventArgs e)
        {
            if (pnlMenuVerticalInicio.Width == 220)
            {
                pnlMenuVerticalInicio.Width = 65;
                pbxLogoSistemaInicio.Visible = false;
            }
            else
            {
                pnlMenuVerticalInicio.Width = 220;
                pbxLogoSistemaInicio.Visible = true;
            }
        }

        private void btnPropietariosInicio_Click(object sender, EventArgs e)
        {   
            AbrirFormHijo(new frmInqPropGar(frmInicio.Opciones.Propietarios));
        }

        private void btnPropiedadesInicio_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmPropiedades());
        }

        private void btnAlquileresInicio_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmAlquileres());
        }

        private void inquilinosToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            AbrirFormHijo(new frmInqPropGar(frmInicio.Opciones.Inquilinos));
        }

        private void propietariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmInqPropGar(frmInicio.Opciones.Propietarios));
        }

        private void propiedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmPropiedades());
        }

        private void alquileresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmAlquileres());
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe acercade = new frmAcercaDe();
            acercade.ShowDialog();
        }

        private void btnConsAlqXPropied_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmConsAlqXPropied());
        }

        private void btnReportesInicio_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new frmColoquio());
        }
    }
}
