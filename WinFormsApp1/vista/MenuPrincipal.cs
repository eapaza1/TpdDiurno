using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpdDiurno.vista
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void sidebarItem1_Load(object sender, EventArgs e)
        {

        }

        private void sidebarItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EVENTO DESDE ITEM DE MENU");

        }
    }
}
