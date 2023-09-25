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
    public partial class frmTimer : Form
    {

        //Declaracion de variables para el formulario
        int Contador = 0; //inicializando variable para timer
        //fin declaracion de variables
        public frmTimer()
        {
            InitializeComponent();
        }


        
        private void timer1_Tick(object sender, EventArgs e)
        {
            /*if (Contador < 100)
            {
                Contador++;
                txtContador.Text = Convert.ToString(Contador);
                //progressBar1.Value = Contador;
                progressBar1.Increment(1);
            }
            else
            {
                timer1.Stop();
            }*/
            //Segunda forma de trabajo con progressbar y timer
            if(progressBar1.Value < 100)
            {
                progressBar1.Increment(1);
                txtContador.Text = Convert.ToString(progressBar1.Value);
            }
            else
            {
                timer1.Stop();
            }
                

            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start(); 
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            timer1 .Stop();
        }
    }
}
