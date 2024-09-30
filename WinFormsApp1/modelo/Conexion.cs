

using MySql.Data.MySqlClient;

namespace WinFormsApp1.modelo
{
    public class Conexion
    {
        //datos de conexion
        private string server = "localhost";
        private string db_name = "test_csharp";
        private string db_user = "root";
        private string db_pass = "";

        //atributo de mysql
        private MySqlConnection conn;

        // propiedad
        public MySqlConnection getConexion { get => conn; }

        public Conexion() {
            string connectionString = $"Server={server};Database={db_name};User ID={db_user};Password={db_pass};SslMode=none;";
            conn = new MySqlConnection(connectionString) ;
        }

        public void Open()
        {
            if (conn.State==System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void Close()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }      
    }
}
