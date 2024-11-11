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
using TpdDiurno.entidad;

namespace TpdDiurno.vista
{
    public partial class FormClientes : Form
    {
        private ClienteControlador control;

        private int id_selected = -1;
        public FormClientes()
        {
            InitializeComponent();
            control = new ClienteControlador();

            ListarTodo();
            limpiarCasillas();
        }

   




        public void update()
        {
            try
            {
                ECliente cliente = new ECliente()
                {
                    Id = id_selected,
                    Nombres=txt_nombres.Text,
                    Documento=txt_documento.Text,
                    Direccion=txt_direccion.Text
                };
                control.Update(cliente);
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
                ECliente user = new ECliente();
                user.Id = id_selected;

                control.Delete(user.Id);
                lbl_message.Text += "Registro Eliminado correctamente";
            }
            catch (Exception ex)
            {
                lbl_message.Text += "Error en eliminar: " + ex.Message;
            }

        }

        private void limpiarCasillas()
        {
            txt_direccion.Text = "";
            txt_documento.Text = "";
            txt_nombres.Text = "";
            txt_documento.Enabled = true;

            btn_actualizar.Enabled = false;
            btn_eliminar.Enabled = false;

            //botton insertar 
            btn_calcular.Enabled = true;

        }
        private void ListarTodo()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("NOMBRES");
            dt.Columns.Add("DOCUMENTO");
            dt.Columns.Add("DIRECCION");
            try
            {
                List<ECliente> lista = control.GetAll();
                foreach (var user in lista)
                {
                    dt.Rows.Add(user.Id, user.Nombres, user.Documento, user.Direccion);
                }
            }
            catch (Exception ex)
            {
                lbl_message.Text += "Error en Listar: " + ex.Message;
            }

            dt_cliente.DataSource = dt; //enlazado el datable a datagridview

        }
        private void crearUsuario()
        {
            try
            {
                ECliente cliente = new ECliente()
                {
                    Nombres = txt_nombres.Text,
                    Documento = txt_documento.Text,
                    Direccion = txt_direccion.Text
                };

                control.Create(cliente);
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



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_calcular_Click_1(object sender, EventArgs e)
        {
            //boton guardar
            crearUsuario();
            ListarTodo();

            //
            limpiarCasillas();

        }

        private void dt_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int indice = e.RowIndex;

            var fila = dt_cliente.Rows[indice];

            //recuperar datos de datagridview
            string username = fila.Cells[1].Value + "";
            string password = fila.Cells[2].Value.ToString();
            string email = fila.Cells[3].Value.ToString();

            id_selected = Convert.ToInt32(fila.Cells[0].Value.ToString());

            //mostratr en el formulario
            txt_nombres.Text = username;
            txt_direccion.Text = email;
            txt_documento.Text = password;

            //habilitar botones
            btn_actualizar.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_calcular.Enabled = false;
        }

    }
}
