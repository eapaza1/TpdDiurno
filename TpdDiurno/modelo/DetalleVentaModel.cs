using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using TpdDiurno.entidad;
using TpdDiurno.modelo;

namespace TpdDiurno.modelo
{
    public class DetalleVentaModel
    {
        private Conexion conexion;
        private string nombreTabla = "detalle_venta"; // Cambia el nombre de la tabla según corresponda

        public DetalleVentaModel()
        {
            conexion = new Conexion();
        }

        public int Crear(EDetalleVenta detalleVenta)
        {
            int idGenerado = 0;
            try
            {
                conexion.Open();
                string query = $"INSERT INTO {nombreTabla} (venta_id, producto_id, cantidad, precio, total) VALUES (@venta_id, @producto_id, @cantidad, @precio, @total)";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
                cmd.Parameters.AddWithValue("@venta_id", detalleVenta.Venta_id);
                cmd.Parameters.AddWithValue("@producto_id", detalleVenta.Producto_id);
                cmd.Parameters.AddWithValue("@cantidad", detalleVenta.Cantidad);
                cmd.Parameters.AddWithValue("@precio", detalleVenta.Precio);
                cmd.Parameters.AddWithValue("@total", detalleVenta.Total);
                idGenerado= cmd.ExecuteNonQuery();
            }
            finally
            {
                conexion.Close();
            }
            return idGenerado;
        }

        public List<EDetalleVenta> Leer()
        {
            List<EDetalleVenta> detalles = new List<EDetalleVenta>();
            try
            {
                conexion.Open();
                string query = $"SELECT id, venta_id, producto_id, cantidad, precio, total FROM {nombreTabla}";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EDetalleVenta detalleVenta = new EDetalleVenta
                    {
                        Id = reader.GetInt32("id"),
                        Venta_id = reader.GetInt32("venta_id"),
                        Producto_id = reader.GetInt32("producto_id"),
                        Cantidad = reader.GetDouble("cantidad"),
                        Precio = reader.GetDouble("precio"),
                        Total = reader.GetDouble("total")
                    };
                    detalles.Add(detalleVenta);
                }
                reader.Close();
            }
            finally
            {
                conexion.Close();
            }
            return detalles;
        }

        public EDetalleVenta LeerPorId(int id)
        {
            EDetalleVenta detalleVenta = null;
            try
            {
                conexion.Open();
                string query = $"SELECT id, venta_id, producto_id, cantidad, precio, total FROM {nombreTabla} WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    detalleVenta = new EDetalleVenta
                    {
                        Id = reader.GetInt32("id"),
                        Venta_id = reader.GetInt32("venta_id"),
                        Producto_id = reader.GetInt32("producto_id"),
                        Cantidad = reader.GetDouble("cantidad"),
                        Precio = reader.GetDouble("precio"),
                        Total = reader.GetDouble("total")
                    };
                }
                reader.Close();
            }
            finally
            {
                conexion.Close();
            }
            return detalleVenta;
        }

        public int Actualizar(EDetalleVenta detalleVenta)
        {
            int filasAfectadas = 0;
            try
            {
                conexion.Open();
                string query = $"UPDATE {nombreTabla} SET venta_id = @venta_id, producto_id = @producto_id, cantidad = @cantidad, precio = @precio, total = @total WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
                cmd.Parameters.AddWithValue("@id", detalleVenta.Id);
                cmd.Parameters.AddWithValue("@venta_id", detalleVenta.Venta_id);
                cmd.Parameters.AddWithValue("@producto_id", detalleVenta.Producto_id);
                cmd.Parameters.AddWithValue("@cantidad", detalleVenta.Cantidad);
                cmd.Parameters.AddWithValue("@precio", detalleVenta.Precio);
                cmd.Parameters.AddWithValue("@total", detalleVenta.Total);
                filasAfectadas = cmd.ExecuteNonQuery(); // Retorna el número de filas afectadas
            }
            finally
            {
                conexion.Close();
            }
            return filasAfectadas;
        }

        public int Eliminar(int id)
        {
            int filasAfectadas = 0;
            try
            {
                conexion.Open();
                string query = $"DELETE FROM {nombreTabla} WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
                cmd.Parameters.AddWithValue("@id", id);
                filasAfectadas = cmd.ExecuteNonQuery(); // Retorna el número de filas afectadas
            }
            finally
            {
                conexion.Close();
            }
            return filasAfectadas;
        }
    }
}





