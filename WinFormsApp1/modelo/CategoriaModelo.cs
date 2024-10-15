using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpdDiurno.entidad;

namespace TpdDiurno.modelo
{
    public class CategoriaModelo
    {
        private string tabla = "categoria";
        private Conexion db;

        public CategoriaModelo()
        {
            this.db = new Conexion();
        }

        public List<ECategoria> ReadAll()
        {
            List<ECategoria> lista = new List<ECategoria>();
            string sql = $"SELECT * FROM {tabla}";
            MySqlCommand cmd = new MySqlCommand(sql,db.getConexion);
            db.Open();
            var reader= cmd.ExecuteReader();
            while (reader.Read())
            {
                ECategoria categoria = new ECategoria();

                categoria.Id = reader.GetInt32("id");
                categoria.Nombre = reader.GetString("nombre");
                categoria.Descripcion = reader.GetString("Descripcion");

                lista.Add(categoria);

            }
            return lista;
        }

        public int Create(ECategoria data)
        {
            string sql = $"INSERT INTO {tabla}(nombre,descripcion) " +
                $"VALUES(@nombre,@desc)";
            MySqlCommand cmd = new MySqlCommand(sql,db.getConexion);

            cmd.Parameters.AddWithValue("@nombre", data.Nombre);
            cmd.Parameters.AddWithValue ("@desc", data.Descripcion);

            db.Open();

            return cmd.ExecuteNonQuery();
        }


    }
}
