
using MySql.Data.MySqlClient;
using WinFormsApp1.entidad;

namespace WinFormsApp1.modelo
{
    public class UserModel 
    {
        private string tabla = "users";

        private Conexion conexion;
        
        public UserModel()
        {
            conexion = new Conexion();
        }


        public int create(EUser entidad)
        {
            string query = $"INSERT INTO {tabla} (username,password,email) VALUES (@user,@pass,@mail)";
            MySqlCommand cmd = new MySqlCommand(query, conexion.getConexion);

            cmd.Parameters.AddWithValue("@user", entidad.Username);
            cmd.Parameters.AddWithValue("@pass", entidad.Password);
            cmd.Parameters.AddWithValue("@mail", entidad.Email);

            conexion.Open();

           int res= cmd.ExecuteNonQuery();

            return res;
        }

        public List<EUser> readAll()
        {
            List<EUser> list = new List<EUser>(); //creamos lista vacia
            string query = $"SELECT * FROM {tabla}";

            MySqlCommand cmd = new MySqlCommand(query , conexion.getConexion);            
            conexion.Open() ;
            MySqlDataReader reader = cmd.ExecuteReader(); //obtner todas las filas de la tabla
                       
            while (reader.Read())
            {
                EUser user = new EUser();
                user.Id = reader.GetInt32("id");
                user.Username= reader.GetString("username");
                user.Password= reader.GetString("password");
                user.Email= reader.GetString("email");

                list.Add(user);
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
