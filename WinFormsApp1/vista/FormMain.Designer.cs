namespace WinFormsApp1.vista
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            lbl_role = new Label();
            lbl_user_lgin = new Label();
            pictureBox2 = new PictureBox();
            btn_menu_users = new componetes.MenuItem();
            btn_menu_home = new componetes.MenuItem();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btn_minimized = new PictureBox();
            btn_close = new PictureBox();
            pn_contenedor = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_minimized).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_close).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 28, 45);
            panel1.Controls.Add(lbl_role);
            panel1.Controls.Add(lbl_user_lgin);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btn_menu_users);
            panel1.Controls.Add(btn_menu_home);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.FromArgb(194, 195, 210);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 721);
            panel1.TabIndex = 0;
            // 
            // lbl_role
            // 
            lbl_role.Location = new Point(3, 225);
            lbl_role.Name = "lbl_role";
            lbl_role.Size = new Size(234, 20);
            lbl_role.TabIndex = 5;
            lbl_role.Text = "Administrador";
            lbl_role.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_user_lgin
            // 
            lbl_user_lgin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_user_lgin.Location = new Point(3, 203);
            lbl_user_lgin.Name = "lbl_user_lgin";
            lbl_user_lgin.Size = new Size(231, 29);
            lbl_user_lgin.TabIndex = 4;
            lbl_user_lgin.Text = "label1";
            lbl_user_lgin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user_main;
            pictureBox2.Location = new Point(52, 66);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(138, 134);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // btn_menu_users
            // 
            btn_menu_users.BackColor = Color.FromArgb(41, 41, 61);
            btn_menu_users.Cursor = Cursors.Hand;
            btn_menu_users.Location = new Point(12, 298);
            btn_menu_users.MenuIcon = (Image)resources.GetObject("btn_menu_users.MenuIcon");
            btn_menu_users.MenuText = "USERS";
            btn_menu_users.MenuTextColor = Color.FromArgb(194, 195, 210);
            btn_menu_users.MenuTextFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_menu_users.Name = "btn_menu_users";
            btn_menu_users.Size = new Size(222, 44);
            btn_menu_users.TabIndex = 2;
            btn_menu_users.Click += btn_menu_users_Click;
            // 
            // btn_menu_home
            // 
            btn_menu_home.BackColor = Color.FromArgb(41, 41, 61);
            btn_menu_home.Cursor = Cursors.Hand;
            btn_menu_home.Location = new Point(12, 248);
            btn_menu_home.MenuIcon = (Image)resources.GetObject("btn_menu_home.MenuIcon");
            btn_menu_home.MenuText = "HOME";
            btn_menu_home.MenuTextColor = Color.FromArgb(194, 195, 210);
            btn_menu_home.MenuTextFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_menu_home.Name = "btn_menu_home";
            btn_menu_home.Size = new Size(222, 44);
            btn_menu_home.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 57);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(31, 28, 45);
            panel2.Controls.Add(btn_minimized);
            panel2.Controls.Add(btn_close);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(240, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1110, 60);
            panel2.TabIndex = 1;
            // 
            // btn_minimized
            // 
            btn_minimized.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_minimized.Cursor = Cursors.Hand;
            btn_minimized.Image = Properties.Resources.minimized;
            btn_minimized.Location = new Point(1028, 12);
            btn_minimized.Name = "btn_minimized";
            btn_minimized.Size = new Size(32, 32);
            btn_minimized.SizeMode = PictureBoxSizeMode.Zoom;
            btn_minimized.TabIndex = 1;
            btn_minimized.TabStop = false;
            // 
            // btn_close
            // 
            btn_close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_close.Cursor = Cursors.Hand;
            btn_close.Image = Properties.Resources.close;
            btn_close.Location = new Point(1066, 12);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(32, 32);
            btn_close.SizeMode = PictureBoxSizeMode.Zoom;
            btn_close.TabIndex = 0;
            btn_close.TabStop = false;
            btn_close.Click += btn_close_Click;
            // 
            // pn_contenedor
            // 
            pn_contenedor.BackColor = Color.FromArgb(31, 28, 45);
            pn_contenedor.Dock = DockStyle.Fill;
            pn_contenedor.Location = new Point(240, 60);
            pn_contenedor.Name = "pn_contenedor";
            pn_contenedor.Size = new Size(1110, 661);
            pn_contenedor.TabIndex = 2;
            pn_contenedor.Paint += panel3_Paint;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 721);
            Controls.Add(pn_contenedor);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_minimized).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_close).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel pn_contenedor;
        private componetes.MenuItem btn_menu_users;
        private componetes.MenuItem btn_menu_home;
        private PictureBox btn_minimized;
        private PictureBox btn_close;
        private Label lbl_user_lgin;
        private PictureBox pictureBox2;
        private Label lbl_role;
    }
}