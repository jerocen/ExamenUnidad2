using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ExamenUnidad2
{
    internal class Datos
    {
        String cadenaConexion = "Data Source=INTEL7-2023;" +
        "Integrated Security=true;" +
        "Initial Catalog=Agenda;" +
        "Encrypt=false";
        SqlConnection conexion;

        private SqlConnection abrirConexion()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexion: " + ex.Message);
                return null;
            }
        }

        public bool comando(String consulta)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(consulta, abrirConexion());
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public DataSet consulta(String consulta)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(consulta, abrirConexion());
                da.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
    }
}
