using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace aplicacionBD
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private static Conexion Con = null;

        public Conexion()
        {
            this.Base = "ProyectoBD";
            this.Servidor = "DESKTOP-ABKR6G2";
            this.Usuario = string.Empty;
            this.Clave = string.Empty;
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "Data Source=" + this.Servidor +
                                          "; Initial Catalog=" + this.Base +
                                          "; Integrated Security=True; trustservercertificate=true";
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public void abrir()
        {
            SqlConnection miconexion = CrearConexion();

            try
            {
                miconexion.Open();
                Console.WriteLine("Conexión exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Conexión No exitosa: " + ex.Message);
                throw;
            }
        }
    }
}
