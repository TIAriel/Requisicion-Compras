using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acceso_Datos
{
    public class Acceso_Archivos
    {

        static string connectionString = "Server=database-1.cgm3ihm3dur0.us-east-2.rds.amazonaws.com;Database=Requisicion;Uid=root;Pwd=GSerrano2023.;";
        //static string connectionString = "Server=localhost;Database=requisicion;Uid=root;Pwd=;"; 
        MySqlConnection conexion = new MySqlConnection(connectionString);

        Conexion connection;

        public Acceso_Archivos()
        {
            connection = new Conexion("database-1.cgm3ihm3dur0.us-east-2.rds.amazonaws.com", "root", "GSerrano2023.", "Requisicion");
        }

        public void GuardarArchivo(string nombreArchivo, byte[] contenidoPDF, int idSolicitud)
        {
            try
            {
                string query = "INSERT INTO Archivos VALUES(NULL," + idSolicitud + ", @nombre, @contenido)";

                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@nombre", nombreArchivo);
                comando.Parameters.AddWithValue("@contenido", contenidoPDF);

                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show("Archivo Subido", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conexion.Close(); }
        }

        public void AbrirPDF(int ID)
        {
            try
            {
                string query = "SELECT contenidoArchivo FROM Archivos WHERE id = " + ID;

                MySqlCommand comando = new MySqlCommand(query, conexion);

                conexion.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    byte[] contenidoPDF = (byte[])reader["contenidoArchivo"];

                    string rutaTemporalPDF = Path.GetTempFileName() + ".pdf";
                    File.WriteAllBytes(rutaTemporalPDF, contenidoPDF);

                    System.Diagnostics.Process.Start(rutaTemporalPDF);
                }
                else
                {
                    MessageBox.Show("No se encontró el archovo PDF en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el archivo PDF desde la base de datos: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public DataSet MostrarPDF(int id)
        {
            return connection.Obtener(string.Format("CALL showArchivos({0})", id), "archivos");
        }
    }
}
