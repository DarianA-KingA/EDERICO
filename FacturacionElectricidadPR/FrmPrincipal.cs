using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionElectricidadPR
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            FrmAgregarFacturacs frmAgregarFacturacs = new FrmAgregarFacturacs();
            frmAgregarFacturacs.MdiParent = this;
            frmAgregarFacturacs.Show();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in this.MdiChildren)
            {
                if (item.Text == "FrmReporte") return;
            }
            FrmReporte frmReporte = new FrmReporte();
            //MessageBox.Show(this.MdiChildren.ToString());
            frmReporte.MdiParent = this;
            frmReporte.Dock = DockStyle.Fill;
            frmReporte.Show();
        }
    }
}
