using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Security.AccessControl;

namespace Acceso_Datos
{
    public class Conexion
    {
        MySqlConnection connection;
        public Conexion(string server, string user, string password, string database)
        {
            string connectionString = $"Server={server};Database={database};Uid={user};Password={password}";
            connection = new MySqlConnection(connectionString);
        }

        public void EjecutarConsulta(string query)
        {
            try
            {
                connection.Open();

                var command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { connection.Close(); }
        }

        public DataSet Obtener(string query, string table)
        {
            var ds = new DataSet();
            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, connection);
                da.Fill(ds,table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ds;
        }

        public string ObtenerDato(string query)
        {
            string rs = "";
            try
            {
                connection.Open();

                var command = new MySqlCommand(query, connection);
                rs = command.ExecuteScalar()?.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { connection.Close(); }
            return rs;
        }

        public int Existencia(string query)
        {
            int rs = 0;
            try
            {
                connection.Open();

                var command = new MySqlCommand(query, connection);
                rs = Convert.ToInt32(command.ExecuteScalar().ToString());

            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { connection.Close(); }
           
            return rs;
        }
    }
}
