using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpdDiurno.entidad;

namespace TpdDiurno.modelo
{
    public class ProductoModel
    {
        private string tabla = "producto";

        private Conexion conexion;

        public ProductoModel()
        {
            conexion = new Conexion();
        }



        // Método para listar productos
        public List<EProducto> ReadAll()
        {
            List<EProducto> lista = new List<EProducto>();
            string sql = $"SELECT * FROM {tabla}";
            MySqlCommand cmd = new MySqlCommand(sql, conexion.getConexion);
            conexion.Open();
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var product = new EProducto();
                product.Id = reader.GetInt32("id");
                product.Nombre = reader.GetString("nombre");
                product.Precio = reader.GetDouble("precio");
                product.Stock = reader.GetDouble("stock");
                product.CategoriaId = reader.GetInt32("categoria_id");
                // Obtener la longitud de los bytes
                long length = reader.GetBytes(reader.GetOrdinal("imagen"), 0, null, 0, 0); 

                byte[] imageData = new byte[length]; // Crear un array de bytes para almacenar la imagen
                reader.GetBytes(reader.GetOrdinal("imagen"), 0, imageData, 0, (int)length);     // Leer la imagen desde la base de datos

                product.Image = imageData;
                lista.Add(product);

            }
            conexion.Close();
            return lista;
        }

        // Método para agregar un producto
        public int Create(EProducto data)
        {
            int res = 0;

            string query = $"INSERT INTO {tabla} (nombre, precio, stock,imagen," +
                $" categoria_id) VALUES(@nombre, @precio, @stock, @imagen, @categoria_id)";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@nombre", data.Nombre);
            cmd.Parameters.AddWithValue("@precio", data.Precio);
            cmd.Parameters.AddWithValue("@stock", data.Stock);
            cmd.Parameters.AddWithValue("@imagen", data.Image);
            cmd.Parameters.AddWithValue("@categoria_id", data.CategoriaId);
            conexion.Open();
            res = cmd.ExecuteNonQuery();

            return res;
        }

        // Método para actualizar un producto
        public int Update(EProducto data)
        {
            int res = 0;
            using (var conn = conexion.getConexion)
            {
                conn.Open();
                string query = $"UPDATE {tabla} SET nombre = @nombre," +
                "precio = @precio, stock = @stock, " +
                "imagen = @imagen, categoria_id = @categoria_id WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", data.Nombre);
                cmd.Parameters.AddWithValue("@precio", data.Precio);
                cmd.Parameters.AddWithValue("@stock", data.Stock);
                cmd.Parameters.AddWithValue("@imagen", data.Image);
                cmd.Parameters.AddWithValue("@categoria_id", data.CategoriaId);
                cmd.Parameters.AddWithValue("@id", data.Id);
                res = cmd.ExecuteNonQuery();
            }
            return res;
        }

        // Método para eliminar un producto
        public int Delete(EProducto data)
        {
            int res = 0;
            using (var conn = conexion.getConexion)
            {
                conn.Open();
                string query = $"DELETE FROM {tabla} WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", data.Id);
                res = cmd.ExecuteNonQuery();
            }
            return res;
        }
    }

}
