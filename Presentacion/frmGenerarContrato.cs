using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmGenerarContrato : Form
    {
        public frmGenerarContrato()
        {
            InitializeComponent();
        }

        private void pbxSalirLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxMinimizarLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            //var u = usuario.TraerPorUsuario(usuarioAlquiler);
            //string contrato = txtContrato.ToString();
            //var a = alquileres.MostrarXID(IDAlquiler);

            //contrato = contrato.Replace("[LOCALIDAD]", u.Ciudad.ToString());
            //contrato = contrato.Replace("[DIA]", alq.FechaInicioContrato.Day);
            //contrato = contrato.Replace("[MES]", alq.FechaInicioContrato.Month);
            //contrato = contrato.Replace("[AÑO]", alq.FechaInicioContrato.Year);

            //rptContrato rpt = new rptContrato();
            //rpt.SetParameterValue("Contrato", contrato.ToString());
            //frmReporte frm = new frmReporte();
            //frm.crvVisor.ReportSource = rpt;
            //frm.crvVisor.Refresh();

            //frm.Show();
            

            

        }      
    }
}
