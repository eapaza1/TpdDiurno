using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpdDiurno.vista.ElementosUI
{
    [DefaultEvent("Click")]
    public partial class SidebarItem : UserControl
    {
        public Image ItemIcon
        {
            get
            {
                return img_icon.Image;
            }
            set
            {
                img_icon.Image = value;
            }
        }

        public String ItemText
        {
            get
            {
                return lbl_menu.Text;
            }
            set
            {
                lbl_menu.Text = value;
            }
        }

        public String ItemTextNotfy
        {
            get
            {
                return lbl_notificacion.Text;
            }
            set
            {
                if (value == "" || value == null)
                {
                    lbl_notificacion.Visible = false;
                    lbl_notificacion.Text = "";
                }
                else
                {
                    lbl_notificacion.Visible = true;
                    lbl_notificacion.Text = value;
                }
            }
        }

        public Font ItemTextFont { get => lbl_menu.Font; set => lbl_menu.Font = value; }
        public Font ItemNotifyFont { get => lbl_notificacion.Font; set => lbl_notificacion.Font = value; }



        public SidebarItem()
        {
            InitializeComponent();
        }

        private void img_icon_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void lbl_menu_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
