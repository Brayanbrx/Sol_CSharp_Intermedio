using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }
        #region "Mis Métodos"

        private void Formato_ca()
        {
            dgvPrincipal.Columns[0].Width = 80;
            dgvPrincipal.Columns[0].HeaderText = "CÓDIGO";
            dgvPrincipal.Columns[1].Width = 250;
            dgvPrincipal.Columns[1].HeaderText = "CATEGORÍA";
        }
        public void Listado_ca(string xTexto)
        {
            dgvPrincipal.DataSource = N_Categorias.Listar_ca (xTexto);
            this.Formato_ca();
        }




        #endregion

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            this.Listado_ca ("%");
        }
    }
}
