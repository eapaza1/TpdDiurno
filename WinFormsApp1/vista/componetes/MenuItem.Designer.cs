namespace WinFormsApp1.vista.componetes
{
    partial class MenuItem
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
            panel1 = new Panel();
            pcb_icon = new PictureBox();
            lbl_name = new Label();
            ((System.ComponentModel.ISupportInitialize)pcb_icon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(80, 137, 245);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(7, 44);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            // 
            // pcb_icon
            // 
            pcb_icon.Dock = DockStyle.Left;
            pcb_icon.Image = Properties.Resources.logo_rojo;
            pcb_icon.Location = new Point(7, 0);
            pcb_icon.Margin = new Padding(10, 3, 3, 3);
            pcb_icon.Name = "pcb_icon";
            pcb_icon.Padding = new Padding(10);
            pcb_icon.Size = new Size(44, 44);
            pcb_icon.SizeMode = PictureBoxSizeMode.StretchImage;
            pcb_icon.TabIndex = 1;
            pcb_icon.TabStop = false;
            pcb_icon.Click += pcb_icon_Click;
            // 
            // lbl_name
            // 
            lbl_name.Dock = DockStyle.Fill;
            lbl_name.Location = new Point(51, 0);
            lbl_name.Margin = new Padding(30, 0, 3, 0);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(149, 44);
            lbl_name.TabIndex = 2;
            lbl_name.Text = "label1";
            lbl_name.TextAlign = ContentAlignment.MiddleLeft;
            lbl_name.Click += lbl_name_Click;
            // 
            // MenuItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_name);
            Controls.Add(pcb_icon);
            Controls.Add(panel1);
            Name = "MenuItem";
            Size = new Size(200, 44);
            ((System.ComponentModel.ISupportInitialize)pcb_icon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pcb_icon;
        private Label lbl_name;
    }
}
