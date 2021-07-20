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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            btnMostrarClave.Visible = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.WhiteSmoke;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void pbxSalirLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxMinimizarLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMostrarClave_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtContraseña.Text != "CONTRASEÑA")
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnMostrarClave_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtContraseña.Text != "CONTRASEÑA")
            {
                txtContraseña.UseSystemPasswordChar = true;
            }

            btnAcceder.Focus();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text != "CONTRASEÑA" || txtContraseña.Text == "")
            {
                btnMostrarClave.Visible = true;
            }
            else
            {
                btnMostrarClave.Visible = false;
            }
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" & txtContraseña.Text == "admin")
            {
                frmInicio Menu = new frmInicio();
                this.Visible = false;
                Menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTO","ALERTA",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }
        }
    }
}
