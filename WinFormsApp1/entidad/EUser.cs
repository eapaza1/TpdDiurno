
namespace TpdDiurno.entidad
{
    public class EUser
    {
        //atributos
        private int id;
        private string username;
        private string password;
        private string email;
        private int person_id;
        private EPerson person;


        //declarando propiedades
        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public int PersonId { get => person_id; set => person_id = value; }


        //contructores
        public EUser(int id, string username, string password, string email)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.email = email;
        }

        public EUser() { }     



    }
}
