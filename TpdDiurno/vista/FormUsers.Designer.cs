using System.Windows.Forms;
using System.Drawing;
namespace TpdDiurno.vista
{
    partial class FormUsers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            txt_password = new TextBox();
            label1 = new Label();
            txt_username = new TextBox();
            btn_actualizar = new Button();
            label2 = new Label();
            lbl_message = new Label();
            label5 = new Label();
            txt_email = new TextBox();
            label7 = new Label();
            btn_calcular = new Button();
            btn_eliminar = new Button();
            btn_limpiar = new Button();
            panel1 = new Panel();
            dt_users = new DataGridView();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dt_users).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(41, 41, 61);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label3);
            panel3.ForeColor = Color.FromArgb(194, 195, 210);
            panel3.Location = new Point(11, -8);
            panel3.Name = "panel3";
            panel3.Size = new Size(1180, 57);
            panel3.TabIndex = 23;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.close;
            pictureBox1.Location = new Point(1126, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1180, 57);
            label3.TabIndex = 0;
            label3.Text = "ADMINISTRACION DE USUARIOS";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(41, 41, 61);
            panel2.Controls.Add(txt_password);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txt_username);
            panel2.Controls.Add(btn_actualizar);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lbl_message);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txt_email);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btn_calcular);
            panel2.Controls.Add(btn_eliminar);
            panel2.Controls.Add(btn_limpiar);
            panel2.ForeColor = Color.FromArgb(194, 195, 210);
            panel2.Location = new Point(11, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(373, 484);
            panel2.TabIndex = 22;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(140, 76);
            txt_password.Margin = new Padding(3, 2, 3, 2);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(210, 23);
            txt_password.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 37);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "USERNAME";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(140, 31);
            txt_username.Margin = new Padding(3, 2, 3, 2);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(210, 23);
            txt_username.TabIndex = 1;
            // 
            // btn_actualizar
            // 
            btn_actualizar.BackColor = Color.Green;
            btn_actualizar.FlatStyle = FlatStyle.Flat;
            btn_actualizar.Location = new Point(55, 317);
            btn_actualizar.Margin = new Padding(3, 2, 3, 2);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(99, 22);
            btn_actualizar.TabIndex = 15;
            btn_actualizar.Text = "ACTUALIZAR";
            btn_actualizar.UseVisualStyleBackColor = false;
            btn_actualizar.Click += btn_actualizar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 81);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 2;
            label2.Text = "PASSWORD";
            // 
            // lbl_message
            // 
            lbl_message.Location = new Point(131, 154);
            lbl_message.Name = "lbl_message";
            lbl_message.Size = new Size(219, 93);
            lbl_message.TabIndex = 13;
            lbl_message.Text = "MENSAJE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 123);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 4;
            label5.Text = "EMAIL";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(140, 118);
            txt_email.Margin = new Padding(3, 2, 3, 2);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(210, 23);
            txt_email.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 154);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 6;
            label7.Text = "MENSAJE";
            // 
            // btn_calcular
            // 
            btn_calcular.BackColor = Color.Blue;
            btn_calcular.FlatStyle = FlatStyle.Flat;
            btn_calcular.Location = new Point(72, 369);
            btn_calcular.Margin = new Padding(3, 2, 3, 2);
            btn_calcular.Name = "btn_calcular";
            btn_calcular.Size = new Size(82, 22);
            btn_calcular.TabIndex = 8;
            btn_calcular.Text = "AGREGAR";
            btn_calcular.UseVisualStyleBackColor = false;
            btn_calcular.Click += btn_calcular_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.FromArgb(128, 64, 0);
            btn_eliminar.FlatStyle = FlatStyle.Flat;
            btn_eliminar.Location = new Point(203, 317);
            btn_eliminar.Margin = new Padding(3, 2, 3, 2);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(82, 22);
            btn_eliminar.TabIndex = 10;
            btn_eliminar.Text = "ELIMINAR";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_limpiar
            // 
            btn_limpiar.BackColor = Color.FromArgb(192, 0, 0);
            btn_limpiar.FlatStyle = FlatStyle.Flat;
            btn_limpiar.Location = new Point(203, 369);
            btn_limpiar.Margin = new Padding(3, 2, 3, 2);
            btn_limpiar.Name = "btn_limpiar";
            btn_limpiar.Size = new Size(82, 22);
            btn_limpiar.TabIndex = 9;
            btn_limpiar.Text = "CANCELAR";
            btn_limpiar.UseVisualStyleBackColor = false;
            btn_limpiar.Click += btn_limpiar_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(41, 41, 61);
            panel1.Controls.Add(dt_users);
            panel1.ForeColor = Color.FromArgb(194, 195, 210);
            panel1.Location = new Point(400, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(791, 484);
            panel1.TabIndex = 21;
            // 
            // dt_users
            // 
            dt_users.AllowUserToAddRows = false;
            dt_users.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dt_users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dt_users.BackgroundColor = Color.FromArgb(41, 41, 61);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(31, 28, 45);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(194, 195, 210);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dt_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dt_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 32, 30);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(194, 195, 210);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dt_users.DefaultCellStyle = dataGridViewCellStyle2;
            dt_users.EnableHeadersVisualStyles = false;
            dt_users.Location = new Point(12, 55);
            dt_users.Margin = new Padding(3, 2, 3, 2);
            dt_users.Name = "dt_users";
            dt_users.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(41, 41, 61);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ScrollBar;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dt_users.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dt_users.RowHeadersVisible = false;
            dt_users.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(41, 41, 61);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.DodgerBlue;
            dt_users.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dt_users.RowTemplate.DefaultCellStyle.BackColor = Color.FromArgb(41, 41, 61);
            dt_users.RowTemplate.Height = 29;
            dt_users.Size = new Size(765, 420);
            dt_users.TabIndex = 14;
            dt_users.CellClick += dt_users_CellClick;
            // 
            // FormUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 28, 45);
            ClientSize = new Size(1201, 562);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormUsers";
            Text = "FormUsers";
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dt_users).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label3;
        private Panel panel2;
        private TextBox txt_password;
        private Label label1;
        private TextBox txt_username;
        private Button btn_actualizar;
        private Label label2;
        private Label lbl_message;
        private Label label5;
        private TextBox txt_email;
        private Label label7;
        private Button btn_calcular;
        private Button btn_eliminar;
        private Button btn_limpiar;
        private Panel panel1;
        private DataGridView dt_users;
        private PictureBox pictureBox1;
    }
}