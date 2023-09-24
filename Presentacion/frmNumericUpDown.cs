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
    public partial class frmNumericUpDown : Form
    {
        public frmNumericUpDown()
        {
            InitializeComponent();
        }

        private void btnMostrarDia_Click(object sender, EventArgs e)
        {
            string DiaTexto;
            decimal NroDia;
            NroDia = numDia.Value;

            switch (NroDia)
            {
                case 1:
                    DiaTexto = "LUNES";
                    break;
                case 2:
                    DiaTexto = "MARTES";
                    break;
                case 3:
                    DiaTexto = "MIERCOLES";
                    break;
                case 4:
                    DiaTexto = "JUEVES";
                    break;
                case 5:
                    DiaTexto = "VIERNES";
                    break;
                case 6:
                    DiaTexto = "SABADO";
                    break;
                default:
                    DiaTexto = "DOMINGO";
                    break;
            }
            txtResultado.Text = DiaTexto;
        }
    }
}
