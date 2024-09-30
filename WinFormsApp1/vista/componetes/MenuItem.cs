using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.vista.componetes
{
    [DefaultEvent("Click")]
    public partial class MenuItem : UserControl
    {

        public Image MenuIcon
        {
            get
            {
                return pcb_icon.Image;
            }
            set
            {
                pcb_icon.Image = value;
            }
        }
        public string MenuText
        {
            get
            {
                return lbl_name.Text.Trim();
            }
            set
            {
                lbl_name.Text = "  " + value;
            }
        }

        public Color MenuTextColor
        {
            get
            {
                return lbl_name.ForeColor;
            }
            set
            {
                lbl_name.ForeColor = value;
            }
        }

        public Font MenuTextFont
        {
            get { return lbl_name.Font; }
            set { lbl_name.Font = value; }
        }

        public MenuItem()
        {
            InitializeComponent();

        }

        private void lbl_name_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void pcb_icon_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
