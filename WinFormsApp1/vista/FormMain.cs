using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.entidad;

namespace WinFormsApp1.vista
{
    public partial class FormMain : Form
    {
        public EUser UserLogin { get; set; }
        public FormMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void menuItem1_Load(object sender, EventArgs e)
        {

        }

        private void menuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuItem2_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void openForm(Form formulario)
        {
            if (pn_contenedor.Controls.Count > 0)
            {
                pn_contenedor.Controls.Clear();

            }

            formulario.TopLevel = false;

            formulario.Dock = DockStyle.Fill;
            formulario.FormBorderStyle = FormBorderStyle.None;
            pn_contenedor.Controls.Add(formulario);

            pn_contenedor.Tag = formulario;
            formulario.Show();

        }

        private void btn_menu_users_Click(object sender, EventArgs e)
        {
            openForm(new FormUsers());
        }

        private void menuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lbl_user_lgin.Text = UserLogin != null ? UserLogin.Username : "no hay datos";
        }
    }
}
