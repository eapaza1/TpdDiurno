using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.entidad;
using WinFormsApp1.modelo;

namespace WinFormsApp1.controlador
{
    public class UserControlador
    {
        private EUser usuarioLogin;
        public EUser UserLogin { get { return usuarioLogin; } }

        private UserModel model;
        public UserControlador()
        {
            model = new UserModel();
        }
        public int Create(EUser user)
        {
            user.Password = hashPassword(user.Password);

            return model.create(user);
        }
        public List<EUser> GetAll()
        {
            return model.readAll();
        }
        public int Update(EUser user)
        {
            EUser user2 = model.findById(user.Id);

            if (user.Password != "")
            {
                user.Password = hashPassword(user.Password);
            }
            else
            {
                user.Password = user2.Password;
            } 
            

            return model.update(user);
        }
        public int Delete(EUser user)
        {
            return model.delete(user);
        }

        public string hashPassword(string password)
        {
            string hash = "";

            hash = BCrypt.Net.BCrypt.HashPassword(password, workFactor: 10);

            return hash;
        }

        public bool login(string username, string password)
        {
            EUser user = model.findByUsername(username);

            if (user.Username == null)
            {
                return false;
            }

            if (BCrypt.Net.BCrypt.Verify(password, user.Password))
            {
                return true;
            }
            return false;


        }

    }
}
