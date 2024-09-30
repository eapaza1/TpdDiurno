
namespace WinFormsApp1.entidad
{
    public class EUser
    {
        //atributos
        private int id;
        private string username;
        private string password;
        private string email;


        //declarando propiedades
        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }


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
