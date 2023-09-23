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
    public partial class frmEncuesta : Form
    {
        public frmEncuesta()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string Resultado;
            Resultado = "";

            if (cbVFP.Checked == true)
            {
                Resultado += cbVFP.Text + ", ";
            } 
            if (cbCSharp.Checked == true)
            {
                Resultado += cbCSharp.Text + ", ";
            }

            if (cbNet .Checked == true)
            {
                Resultado += cbNet.Text + ", ";
            }

            if (cbJava.Checked == true)
            {
                Resultado += cbJava.Text;
            }

            if (rbtnPresencial.Checked == true)
                Resultado +=" ::::: " + rbtnPresencial.Text + " ::::: ";
            else
                Resultado += " ::::: " + rbtnVirtual.Text + " ::::: ";


            txtResultado.Text = Resultado;
        }
    }
}
