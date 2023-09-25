using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private static Conexion Con = null;


        private Conexion()
        {
            this.Base = "MiBaseDatos";
            this.Servidor = "DESKTOP-HP44CUK\\SQLEXPRESS";
            this.Usuario = "brayanbrx1";
            this.Clave = "Elohell245";
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Server=" + this.Servidor + "; Database =" + this.Base + "; User Id =" + this.Usuario + "; Password=" + this.Clave; 
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }
        public static Conexion GetInstancia()
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }


    }
}
