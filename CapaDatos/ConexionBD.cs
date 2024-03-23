using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ConexionBD
    {
        static private string CadenaConexion = "Data Source=DESKTOP-JOJRB03\\SQLEXPRESS;Initial Catalog=BDVENTA;User ID=PC;Password=password;";
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}