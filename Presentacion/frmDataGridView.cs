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
    public partial class frmDataGridView : Form
    {
        public frmDataGridView()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtEmail.Text != "") 
            { 
                dgvDatos.Rows.Add(txtNombre.Text, txtEmail.Text);
                txtNombre.Text = "";
                txtEmail.Text = "";
                MessageBox.Show("Datos Guardados");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta;
            Respuesta = MessageBox.Show("Estas seguro de eliminar la fila seleccionada=", "Aviso del Sistema", MessageBoxButtons.YesNo);
            if (Respuesta == DialogResult.Yes)
            {
                int nFila;
                nFila = dgvDatos.CurrentRow.Index;
                dgvDatos.Rows.RemoveAt(nFila);
                MessageBox.Show("Fila Eliminada");
            }
            
            
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNombre.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["Column1"].Value);
            txtEmail.Text = Convert.ToString(dgvDatos.CurrentRow.Cells["Column2"].Value);
        }
    }
}
