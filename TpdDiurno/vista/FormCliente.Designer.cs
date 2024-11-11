using System.Windows.Forms;
using System.Drawing;
namespace TpdDiurno.vista
{
    partial class FormClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.PictureBox();
            this.txt_documento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_message = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dt_cliente = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(195)))), ((int)(((byte)(210)))));
            this.panel3.Location = new System.Drawing.Point(9, -7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1011, 49);
            this.panel3.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TpdDiurno.Properties.Resources.close;
            this.pictureBox1.Location = new System.Drawing.Point(965, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1011, 49);
            this.label3.TabIndex = 0;
            this.label3.Text = "ADMINISTRACION DE USUARIOS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.txt_documento);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_nombres);
            this.panel2.Controls.Add(this.btn_actualizar);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_message);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_direccion);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btn_calcular);
            this.panel2.Controls.Add(this.btn_eliminar);
            this.panel2.Controls.Add(this.btn_limpiar);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(195)))), ((int)(((byte)(210)))));
            this.panel2.Location = new System.Drawing.Point(9, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 419);
            this.panel2.TabIndex = 22;
            // 
            // btn_search
            // 
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Image = global::TpdDiurno.Properties.Resources.search;
            this.btn_search.Location = new System.Drawing.Point(268, 66);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(23, 21);
            this.btn_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_search.TabIndex = 16;
            this.btn_search.TabStop = false;
            // 
            // txt_documento
            // 
            this.txt_documento.Location = new System.Drawing.Point(120, 66);
            this.txt_documento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Size = new System.Drawing.Size(142, 20);
            this.txt_documento.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE";
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(120, 27);
            this.txt_nombres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(181, 20);
            this.txt_nombres.TabIndex = 1;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.Green;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Location = new System.Drawing.Point(47, 275);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(85, 31);
            this.btn_actualizar.TabIndex = 15;
            this.btn_actualizar.Text = "ACTUALIZAR";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DOCUMENTO";
            // 
            // lbl_message
            // 
            this.lbl_message.Location = new System.Drawing.Point(113, 151);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(188, 81);
            this.lbl_message.TabIndex = 13;
            this.lbl_message.Text = "MENSAJE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "DIRECCION";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(120, 102);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(181, 20);
            this.txt_direccion.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "MENSAJE";
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.Blue;
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular.Location = new System.Drawing.Point(62, 320);
            this.btn_calcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(70, 31);
            this.btn_calcular.TabIndex = 8;
            this.btn_calcular.Text = "AGREGAR";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click_1);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Location = new System.Drawing.Point(174, 275);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(70, 31);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Location = new System.Drawing.Point(174, 320);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(70, 31);
            this.btn_limpiar.TabIndex = 9;
            this.btn_limpiar.Text = "CANCELAR";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.dt_cliente);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(195)))), ((int)(((byte)(210)))));
            this.panel1.Location = new System.Drawing.Point(343, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(678, 419);
            this.panel1.TabIndex = 21;
            // 
            // dt_cliente
            // 
            this.dt_cliente.AllowUserToAddRows = false;
            this.dt_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dt_cliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(195)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_cliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(195)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dt_cliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dt_cliente.EnableHeadersVisualStyles = false;
            this.dt_cliente.Location = new System.Drawing.Point(10, 48);
            this.dt_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dt_cliente.Name = "dt_cliente";
            this.dt_cliente.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_cliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dt_cliente.RowHeadersVisible = false;
            this.dt_cliente.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dt_cliente.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dt_cliente.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.dt_cliente.RowTemplate.Height = 29;
            this.dt_cliente.Size = new System.Drawing.Size(656, 364);
            this.dt_cliente.TabIndex = 14;
            this.dt_cliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_cliente_CellClick);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(28)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1029, 487);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormClientes";
            this.Text = "FormUsers";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_cliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel3;
        private Label label3;
        private Panel panel2;
        private TextBox txt_documento;
        private Label label1;
        private TextBox txt_nombres;
        private Button btn_actualizar;
        private Label label2;
        private Label lbl_message;
        private Label label5;
        private TextBox txt_direccion;
        private Label label7;
        private Button btn_calcular;
        private Button btn_eliminar;
        private Button btn_limpiar;
        private Panel panel1;
        private DataGridView dt_cliente;
        private PictureBox pictureBox1;
        private PictureBox btn_search;
    }
}