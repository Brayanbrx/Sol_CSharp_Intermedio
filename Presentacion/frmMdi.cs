﻿using System;
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
            if(Frm_01 == null)
            {
                Frm_01 = new frmPrincipal();
                Frm_01.MdiParent = this;
                Frm_01.FormClosed += new FormClosedEventHandler(Alta_frm_01);
                Frm_01.Show();
            }
            else
            {
                Frm_01.Activate();
            }
        }

        void Alta_frm_01(object sender, EventArgs e)
        {
            Frm_01 = null;
        }

        private void trackBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Frm_02 == null)
            {
                Frm_02 = new frmTrackBar();
                Frm_02.MdiParent = this;
                Frm_02.FormClosed += new FormClosedEventHandler(Alta_frm_02);
                Frm_02.Show();
            }
            else
            {
                Frm_02.Activate();
            }
        }
        void Alta_frm_02(object sender, EventArgs e)
        {
            Frm_02 = null;
        }

        private void m_btn01_Click(object sender, EventArgs e)
        {
            if (Frm_01 == null)
            {
                Frm_01 = new frmPrincipal();
                Frm_01.MdiParent = this;
                Frm_01.FormClosed += new FormClosedEventHandler(Alta_frm_01);
                Frm_01.Show();
            }
            else
            {
                Frm_01.Activate();
            }
        }

        private void m_btn02_Click(object sender, EventArgs e)
        {
            if (Frm_02 == null)
            {
                Frm_02 = new frmTrackBar();
                Frm_02.MdiParent = this;
                Frm_02.FormClosed += new FormClosedEventHandler(Alta_frm_02);
                Frm_02.Show();
            }
            else
            {
                Frm_02.Activate();
            }
        }
    }
}
