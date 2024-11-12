using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using TpdDiurno.entidad;

namespace TpdDiurno.modelo
{
    public class ClienteModelo
    {
        private Conexion conexion;
        private string tabla = "cliente";

        public ClienteModelo()
        {
            conexion = new Conexion();
        }

        public int Crear(ECliente cliente)
        {
            conexion.Open();
            string query = "INSERT INTO " + tabla + " (nombres, documento, direccion) VALUES (@nombres, @documento, @direccion)";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@nombres", cliente.Nombres);
            cmd.Parameters.AddWithValue("@documento", cliente.Documento);
            cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
            var res = cmd.ExecuteNonQuery();
            return res;
        }

        public List<ECliente> getAll()
        {
            List<ECliente> clientes = new List<ECliente>();

            conexion.Open();
            string query = "SELECT * FROM " + tabla;
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ECliente cliente = new ECliente
                {
                    Id = reader.GetInt32("id"),
                    Nombres = reader.GetString("nombres"),
                    Documento = reader.GetString("documento"),
                    Direccion = reader.GetString("direccion")
                };
                clientes.Add(cliente);
            }
            reader.Close();
            return clientes;
        }

        public ECliente getById(int id)
        {
            ECliente cliente = null;

            conexion.Open();
            string query = "SELECT * FROM " + tabla + " WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                cliente = new ECliente
                {
                    Id = reader.GetInt32("id"),
                    Nombres = reader.GetString("nombres"),
                    Documento = reader.GetString("documento"),
                    Direccion = reader.GetString("direccion")
                };
            }
            reader.Close();

            return cliente;
        }

        public int Actualizar(ECliente cliente)
        {
            conexion.Open();
            string query = "UPDATE cliente SET nombres = @nombres," +
            " documento = @documento, direccion = @direccion WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@id", cliente.Id);
            cmd.Parameters.AddWithValue("@nombres", cliente.Nombres);
            cmd.Parameters.AddWithValue("@documento", cliente.Documento);
            cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
            return cmd.ExecuteNonQuery();

        }

        public int Eliminar(int id)
        {
            conexion.Open();
            string query = "DELETE FROM " + tabla + " WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@id", id);
            return cmd.ExecuteNonQuery();

        }

        public ECliente getByNroDoc(string nrodoc)
        {
            ECliente cliente = null;

            conexion.Open();
            string query = "SELECT * FROM " + tabla + " WHERE documento = @doc";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@doc", nrodoc);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                cliente = new ECliente
                {
                    Id = reader.GetInt32("id"),
                    Nombres = reader.GetString("nombres"),
                    Documento = reader.GetString("documento"),
                    Direccion = reader.GetString("direccion")
                };
            }
            reader.Close();

            return cliente;
        }
    }

}





