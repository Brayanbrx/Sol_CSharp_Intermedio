﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmPrincipal());
            //Application.Run(new frmEncuesta());
            //Application.Run(new frmTrabajandoComboBox());
            //Application.Run(new frmNumericUpDown());
            //Application.Run(new frmTimer());
            //Application.Run(new frmTrackBar());
            //Application.Run(new frmDataGridView());
            //Application.Run(new frmMdi());
            Application.Run(new frmCategorias());
        }
    }
}
