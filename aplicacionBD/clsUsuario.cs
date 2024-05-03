using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicacionBD
{
   class clsUsuario
    {
        public string strNombreUsuario {  get; set; }
        public string strUsuario { get; set; }
        public string strcontra {  get; set; }

        public clsUsuario(string strusuario, string strcontrase)
        {
            this.strUsuario = strusuario;
            this.strcontra = strcontrase;
        }

        public int consultarUsuario( string strusuario, string strcontrase)
        {
            clsConexion SqlCon = new clsConexion();
            SqlDataReader resultado;
            try
            {
                SqlCommand cmd = new SqlCommand("loginusuarios", SqlCon.abrir());
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", strusuario);
                cmd.Parameters.AddWithValue("@contrase", strcontrase);
                resultado = cmd.ExecuteReader();

                if (resultado.Read())
                {
                    return resultado.GetInt32(0);
                }

            }
            catch (Exception)
            {

                throw;
            }
            
            return 0;
        }
    }
}
