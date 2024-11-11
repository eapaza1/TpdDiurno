using System.Drawing;
using System.Windows.Forms;
namespace TpdDiurno.vista.ElementosUI
{
    partial class SidebarItem
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            img_icon = new PictureBox();
            lbl_menu = new Label();
            lbl_notificacion = new Label();
            ((System.ComponentModel.ISupportInitialize)img_icon).BeginInit();
            SuspendLayout();
            // 
            // img_icon
            // 
            img_icon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            img_icon.Image = Properties.Resources.icon_user;
            img_icon.Location = new Point(3, 6);
            img_icon.Name = "img_icon";
            img_icon.Size = new Size(26, 33);
            img_icon.SizeMode = PictureBoxSizeMode.Zoom;
            img_icon.TabIndex = 0;
            img_icon.TabStop = false;
            img_icon.Click += img_icon_Click;
            // 
            // lbl_menu
            // 
            lbl_menu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_menu.Location = new Point(35, 6);
            lbl_menu.Name = "lbl_menu";
            lbl_menu.Size = new Size(139, 33);
            lbl_menu.TabIndex = 1;
            lbl_menu.Text = "label1";
            lbl_menu.TextAlign = ContentAlignment.MiddleLeft;
            lbl_menu.Click += lbl_menu_Click;
            // 
            // lbl_notificacion
            // 
            lbl_notificacion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_notificacion.Location = new Point(180, 6);
            lbl_notificacion.Name = "lbl_notificacion";
            lbl_notificacion.Size = new Size(31, 33);
            lbl_notificacion.TabIndex = 2;
            lbl_notificacion.Text = "1200";
            lbl_notificacion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SidebarItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            Controls.Add(lbl_notificacion);
            Controls.Add(lbl_menu);
            Controls.Add(img_icon);
            Name = "SidebarItem";
            Size = new Size(214, 42);
            ((System.ComponentModel.ISupportInitialize)img_icon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox img_icon;
        private Label lbl_menu;
        private Label lbl_notificacion;
    }
}
