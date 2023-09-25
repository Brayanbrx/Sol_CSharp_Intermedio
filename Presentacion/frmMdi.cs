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
    public partial class frmMdi : Form
    {
        //Instancias de los formularios del menu principal
        frmPrincipal  Frm_01;
        frmTrackBar Frm_02;
        public frmMdi()
        {
            InitializeComponent();
        }

        private void miPrimerFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_01 = new frmPrincipal();
            Frm_01.MdiParent = this;
            Frm_01.Show();
        }

        private void trackBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_02 = new frmTrackBar();
            Frm_02.MdiParent = this;
            Frm_02.Show();
        }
    }
}
