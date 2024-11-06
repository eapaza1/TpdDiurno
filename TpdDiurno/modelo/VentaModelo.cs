using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

using TpdDiurno.entidad;
using TpdDiurno.modelo;

namespace TpdDiurno.modelo
{
    public class VentaModelo
    {
        private Conexion conexion;
        private string nombreTabla = "venta";

        public VentaModelo()
        {
            conexion = new Conexion();
        }

        public int Crear(EVenta venta)
        {
            int idGenerado = 0;

            conexion.Open();
            string query = $"INSERT INTO {nombreTabla} (cliente_id, fecha, total_pagar) VALUES (@cliente_id, @fecha, @total_pagar)";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@cliente_id", venta.Cliente_id);
            cmd.Parameters.AddWithValue("@fecha", venta.Fecha);
            cmd.Parameters.AddWithValue("@total_pagar", venta.Total_pagar);
            idGenerado = cmd.ExecuteNonQuery();
            //(int)cmd.LastInsertedId; // Obtener el ID generado

            return idGenerado;
        }

        public List<EVenta> Leer()
        {
            List<EVenta> ventas = new List<EVenta>();

            conexion.Open();
            string query = $"SELECT id, cliente_id, fecha, total_pagar FROM {nombreTabla}";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                EVenta venta = new EVenta
                {
                    Id = reader.GetInt32("id"),
                    Cliente_id = reader.GetInt32("cliente_id"),
                    Fecha = reader.GetDateTime("fecha"),
                    Total_pagar = reader.GetDouble("total_pagar")
                };
                ventas.Add(venta);
            }
            reader.Close();

            return ventas;
        }

        public EVenta LeerPorId(int id)
        {
            EVenta venta = null;

            conexion.Open();
            string query = $"SELECT id, cliente_id, fecha, total_pagar FROM {nombreTabla} WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                venta = new EVenta
                {
                    Id = reader.GetInt32("id"),
                    Cliente_id = reader.GetInt32("cliente_id"),
                    Fecha = reader.GetDateTime("fecha"),
                    Total_pagar = reader.GetDouble("total_pagar")
                };
            }
            reader.Close();

            return venta;
        }

        public int Actualizar(EVenta venta)
        {
            int filasAfectadas = 0;

            conexion.Open();
            string query = $"UPDATE {nombreTabla} SET cliente_id = @cliente_id, fecha = @fecha, total_pagar = @total_pagar WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@id", venta.Id);
            cmd.Parameters.AddWithValue("@cliente_id", venta.Cliente_id);
            cmd.Parameters.AddWithValue("@fecha", venta.Fecha);
            cmd.Parameters.AddWithValue("@total_pagar", venta.Total_pagar);
            filasAfectadas = cmd.ExecuteNonQuery(); // Retorna el número de filas afectadas

            return filasAfectadas;
        }

        public int Eliminar(int id)
        {
            int filasAfectadas = 0;

            conexion.Open();
            string query = $"DELETE FROM {nombreTabla} WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@id", id);
            filasAfectadas = cmd.ExecuteNonQuery(); // Retorna el número de filas afectadas

            return filasAfectadas;
        }
    }
}

