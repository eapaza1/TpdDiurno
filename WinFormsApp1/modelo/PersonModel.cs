
using MySql.Data.MySqlClient;
using TpdDiurno.entidad;

namespace TpdDiurno.modelo
{
    public class PersonModel 
    {
        private string tabla = "people";

        private Conexion conexion;
        

        public PersonModel()
        {
            conexion = new Conexion();
        }


        public int create(EPerson entidad)
        {
            string query = $"INSERT INTO {tabla} (nombres,apellidos,nrodoc,direccion,telefono,estado) " +
                $"VALUES (@name,@ape,@nro,@dir,@tel,@estado)";

            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);

            cmd.Parameters.AddWithValue("@name", entidad.Nombres);
            cmd.Parameters.AddWithValue("@ape", entidad.Apellidos);
            cmd.Parameters.AddWithValue("@nro", entidad.Nrodoc);
            cmd.Parameters.AddWithValue("@dir", entidad.Direccion);
            cmd.Parameters.AddWithValue("@tel", entidad.Telefono);
            cmd.Parameters.AddWithValue("@estado", entidad.Estado);

            conexion.Open();

           int res= cmd.ExecuteNonQuery();

            return res;
        }

        public List<EPerson> readAll()
        {
            List<EPerson> list = new List<EPerson>(); //creamos lista vacia

            string query = $"SELECT * FROM {tabla}";

            MySqlCommand cmd = new MySqlCommand(query , conexion.getConexion);            
            conexion.Open() ;
            MySqlDataReader reader = cmd.ExecuteReader(); //obtner todas las filas de la tabla
                       
            while (reader.Read())
            {
                EPerson row = new EPerson();
                row.Id = reader.GetInt32("id");
                row.Nombres=reader.GetString("nombres");
                row.Apellidos=reader.GetString("apellidos");
                row.Nrodoc=reader.GetString("nrodoc");
                row.Telefono=reader.GetString("telefono");
                row.Direccion=reader.GetString("direccion");
                row.Estado = reader.GetString("estado");
                list.Add(row);
            }
            reader.Close();
          
            return list;

        }
        public int update(EUser entidad) {
            int res=-1;
            string query = $"UPDATE {tabla} SET username=@user, password=@pass, " +
                $"email=@mail WHERE id=@id";

            MySqlCommand cmd = new MySqlCommand(query,conexion.getConexion);

            cmd.Parameters.AddWithValue("@user",entidad.Username);
            cmd.Parameters.AddWithValue("@pass", entidad.Password);
            cmd.Parameters.AddWithValue("@mail", entidad.Email);
            //agregadno id
            cmd.Parameters.AddWithValue("@id", entidad.Id);

            conexion.Open();

            res= cmd.ExecuteNonQuery();

            conexion.Close();

            return res;
        }
        public int delete(EUser entidad) { 

            int res=-1;

            string query = $"DELETE FROM {tabla} WHERE id=@id";

            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@id", entidad.Id);

            conexion .Open();
            res= cmd.ExecuteNonQuery();
            conexion.Close();
            return res;
        
        }



        public EUser findByUsername(string username)
        {
            EUser user = new EUser();
            string query = $"SELECT * FROM {tabla} WHERE username=@user";
            MySqlCommand cmd = new MySqlCommand(query ,conexion.getConexion);
            cmd.Parameters.AddWithValue("@user", username);

            conexion.Open();
            var reader= cmd.ExecuteReader();
            if (reader.Read())
            {
                user.Id = reader.GetInt32("id");
                user.Username = reader.GetString("username");
                user.Password = reader.GetString("password");
                user.Email = reader.GetString("email");
            }
            reader.Close();
            return user;
        }


        public EUser findById(int id)
        {
            EUser user = new EUser();
            string query = $"SELECT * FROM {tabla} WHERE id=@user";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);
            cmd.Parameters.AddWithValue("@user", id);

            conexion.Open();
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                user.Id = reader.GetInt32("id");
                user.Username = reader.GetString("username");
                user.Password = reader.GetString("password");
                user.Email = reader.GetString("email");
            }
            reader.Close();
            return user;
        }




    }
}
