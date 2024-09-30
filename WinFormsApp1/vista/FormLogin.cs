using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpdDiurno.controlador;

namespace TpdDiurno.vista
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            var t = (TextBox)sender;
            t.BorderStyle = BorderStyle.Fixed3D;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            var t = (TextBox)sender;
            t.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btn_minimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txt_username.Text;
                string password = txt_password.Text;
                UserControlador control = new UserControlador();
                if(control.login(username, password))
                {
                                      
                    FormUsers formulario= new FormUsers();
                    formulario.Show();
                    this.Hide();//ocultar el formuario login
                                       
                }
                else
                {
                    MessageBox.Show("ingreso incorrecto");
                }

            }catch (Exception ex)
            {
                MessageBox.Show("error en login: " + ex.Message);
            }
            
        }
    }
}
