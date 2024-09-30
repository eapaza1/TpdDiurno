namespace WinFormsApp1.vista
{
    partial class FormLogin
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
            btn_close = new PictureBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            btn_ingresar = new Button();
            txt_password = new TextBox();
            txt_username = new TextBox();
            label1 = new Label();
            btn_minimized = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)btn_close).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_minimized).BeginInit();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.Cursor = Cursors.Hand;
            btn_close.Image = Properties.Resources.close;
            btn_close.Location = new Point(410, 3);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(30, 30);
            btn_close.SizeMode = PictureBoxSizeMode.Zoom;
            btn_close.TabIndex = 0;
            btn_close.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_rojo;
            pictureBox1.Location = new Point(32, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(279, 282);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateGray;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(btn_ingresar);
            panel2.Controls.Add(txt_password);
            panel2.Controls.Add(txt_username);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btn_close);
            panel2.Controls.Add(btn_minimized);
            panel2.Dock = DockStyle.Right;
            panel2.ForeColor = Color.Snow;
            panel2.Location = new Point(341, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 450);
            panel2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(58, 151);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 7;
            label3.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(58, 80);
            label2.Name = "label2";
            label2.Size = new Size(81, 21);
            label2.TabIndex = 6;
            label2.Text = "USUARIO";
            // 
            // btn_ingresar
            // 
            btn_ingresar.AutoEllipsis = true;
            btn_ingresar.BackColor = Color.DodgerBlue;
            btn_ingresar.FlatStyle = FlatStyle.Popup;
            btn_ingresar.Location = new Point(124, 318);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(168, 49);
            btn_ingresar.TabIndex = 5;
            btn_ingresar.Text = "INGRESAR";
            btn_ingresar.UseVisualStyleBackColor = false;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // txt_password
            // 
            txt_password.BackColor = Color.SlateGray;
            txt_password.BorderStyle = BorderStyle.FixedSingle;
            txt_password.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.ForeColor = SystemColors.Menu;
            txt_password.Location = new Point(58, 175);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.PlaceholderText = "PASSWORD";
            txt_password.Size = new Size(344, 34);
            txt_password.TabIndex = 4;
            txt_password.Enter += textBox1_Enter;
            txt_password.Leave += textBox2_Leave;
            // 
            // txt_username
            // 
            txt_username.BackColor = Color.SlateGray;
            txt_username.BorderStyle = BorderStyle.FixedSingle;
            txt_username.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.ForeColor = SystemColors.Menu;
            txt_username.Location = new Point(58, 104);
            txt_username.Name = "txt_username";
            txt_username.PlaceholderText = "USERNAME";
            txt_username.Size = new Size(344, 34);
            txt_username.TabIndex = 1;
            txt_username.Enter += textBox1_Enter;
            txt_username.Leave += textBox2_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(165, 31);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 2;
            label1.Text = "LOGIN";
            // 
            // btn_minimized
            // 
            btn_minimized.Cursor = Cursors.Hand;
            btn_minimized.Image = Properties.Resources.minimized;
            btn_minimized.Location = new Point(376, 3);
            btn_minimized.Name = "btn_minimized";
            btn_minimized.Size = new Size(30, 30);
            btn_minimized.SizeMode = PictureBoxSizeMode.Zoom;
            btn_minimized.TabIndex = 1;
            btn_minimized.TabStop = false;
            btn_minimized.Click += btn_minimized_Click;
            // 
            // log
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "log";
            Text = "log";
            ((System.ComponentModel.ISupportInitialize)btn_close).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_minimized).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btn_close;
        private Panel panel1;
        private PictureBox btn_minimized;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox txt_password;
        private TextBox txt_username;
        private Label label1;
        private Button btn_ingresar;
        private Label label3;
        private Label label2;
    }
}