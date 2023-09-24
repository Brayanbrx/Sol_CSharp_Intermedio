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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";

            gbMantenimiento.Enabled = true;
            
            txtCodigo.Focus();

            gbBotonesPrincipales.Enabled = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            txtCodigo.Text = "";
            txtDescripcion.Text = "";

            gbMantenimiento.Enabled = false;
            gbBotonesPrincipales.Enabled = true;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Registro;
            Registro = txtCodigo.Text.Trim() + " | " + txtDescripcion.Text.Trim();
            lbxListaMantenimiento.Items.Add(Registro);

            MessageBox.Show("Guardado Exitosamente");

            gbMantenimiento.Enabled = false;
            gbBotonesPrincipales.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            lbxListaMantenimiento.Items.Remove(lbxListaMantenimiento.SelectedItem);
            MessageBox.Show("Eliminado Exitosamente");
        }

        private void lbxListaMantenimiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TextoSeleccionado;
            int LongitudTexto;
            TextoSeleccionado = lbxListaMantenimiento.SelectedItem.ToString().Trim();
            LongitudTexto = TextoSeleccionado.Length;
            txtCodigo.Text = TextoSeleccionado.Substring(0,3);
            txtDescripcion.Text = TextoSeleccionado.Substring(6,TextoSeleccionado.Length);

        }
    }
}
