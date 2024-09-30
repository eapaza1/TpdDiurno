using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.controlador;
using WinFormsApp1.entidad;

namespace WinFormsApp1.vista
{
    public partial class FormUsers : Form
    {
        private UserControlador control;

        private int id_selected = -1;
        public FormUsers()
        {
            InitializeComponent();
            control = new UserControlador();

            ListarTodo();
            limpiarCasillas();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            //boton guardar
            crearUsuario();
            ListarTodo();

            //
            limpiarCasillas();
        }




        public void update()
        {
            try
            {
                EUser user = new EUser();
                user.Id = id_selected;
                user.Username = txt_username.Text;
                user.Password = txt_password.Text;
                user.Email = txt_email.Text;
                control.Update(user);
                lbl_message.Text += "Registro Actualizado correctamente";
            }
            catch (Exception ex)
            {
                lbl_message.Text += "Error en registro: " + ex.Message;
            }
        }

        public void delete()
        {
            try
            {
                EUser user = new EUser();
                user.Id = id_selected;

                control.Delete(user);
                lbl_message.Text += "Registro Eliminado correctamente";
            }
            catch (Exception ex)
            {
                lbl_message.Text += "Error en eliminar: " + ex.Message;
            }

        }

        private void limpiarCasillas()
        {
            txt_email.Text = "";
            txt_password.Text = "";
            txt_username.Text = "";
            txt_password.Enabled = true;

            btn_actualizar.Enabled = false;
            btn_eliminar.Enabled = false;

            //botton insertar 
            btn_calcular.Enabled = true;

        }
        private void ListarTodo()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("USUARIO");
            dt.Columns.Add("CONTRASEÑA");
            dt.Columns.Add("CORREO");
            try
            {
                List<EUser> lista = control.GetAll();
                foreach (EUser user in lista)
                {
                    dt.Rows.Add(user.Id, user.Username, user.Password, user.Email);
                }
            }
            catch (Exception ex)
            {
                lbl_message.Text += "Error en Listar: " + ex.Message;
            }

            dt_users.DataSource = dt; //enlazado el datable a datagridview

        }
        private void crearUsuario()
        {
            try
            {
                EUser user = new EUser();
                user.Username = txt_username.Text;
                user.Password = txt_password.Text;
                user.Email = txt_email.Text;

                control.Create(user);
                lbl_message.Text += "Registro insertado correctamente";
            }
            catch (Exception ex)
            {
                lbl_message.Text += "Error en registro: " + ex.Message;
            }

        }


        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            // boton eliminar
            delete();
            ListarTodo();
            limpiarCasillas();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            //actualizar
            update();
            ListarTodo();
            limpiarCasillas();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            limpiarCasillas();
        }

        private void dt_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            var fila = dt_users.Rows[indice];

            //recuperar datos de datagridview
            string username = fila.Cells[1].Value + "";
            string password = fila.Cells[2].Value.ToString();
            string email = fila.Cells[3].Value.ToString();

            id_selected = Convert.ToInt32(fila.Cells[0].Value.ToString());

            //mostratr en el formulario
            txt_username.Text = username;
            txt_email.Text = email;
            //txt_password.Text = password;

            //habilitar botones
            btn_actualizar.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_calcular.Enabled = false;



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
