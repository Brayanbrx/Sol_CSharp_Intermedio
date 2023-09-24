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
    public partial class frmTrabajandoComboBox : Form
    {
        public frmTrabajandoComboBox()
        {
            InitializeComponent();
        }

        private void cboCursosDisponibles_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCursoSeleccionado.Text = "Curso Seleccionado: " + cboCursosDisponibles.SelectedItem + " y se encuentra en la posicion " + cboCursosDisponibles.SelectedIndex;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            cboCursosDisponibles.Items.Add(txtCursoNuevo.Text);
            txtCursoNuevo.Text = "";
            MessageBox.Show("Curso registrado");
        }
    }
}
