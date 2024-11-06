
using System.Windows.Forms;
using System.Drawing;

namespace TpdDiurno.vista.ElementosUI
{
    partial class ItemProductoVenta
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.pb_btn_add = new System.Windows.Forms.PictureBox();
            this.lbl_precio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_btn_add)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TpdDiurno.Properties.Resources.agregar_producto;
            this.pictureBox1.Location = new System.Drawing.Point(11, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Location = new System.Drawing.Point(11, 53);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(82, 37);
            this.lbl_nombre.TabIndex = 1;
            this.lbl_nombre.Text = "COMPUTADORA HP VICTUS";
            // 
            // pb_btn_add
            // 
            this.pb_btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_btn_add.Image = global::TpdDiurno.Properties.Resources.icons8_carrito_de_compras_100;
            this.pb_btn_add.Location = new System.Drawing.Point(61, 92);
            this.pb_btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.pb_btn_add.Name = "pb_btn_add";
            this.pb_btn_add.Size = new System.Drawing.Size(32, 20);
            this.pb_btn_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_btn_add.TabIndex = 2;
            this.pb_btn_add.TabStop = false;
            this.pb_btn_add.Click += new System.EventHandler(this.pb_btn_add_Click);
            // 
            // lbl_precio
            // 
            this.lbl_precio.Location = new System.Drawing.Point(2, 92);
            this.lbl_precio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(56, 20);
            this.lbl_precio.TabIndex = 3;
            this.lbl_precio.Text = "2999.00";
            // 
            // ItemProductoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.pb_btn_add);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ItemProductoVenta";
            this.Size = new System.Drawing.Size(100, 115);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_btn_add)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_nombre;
        private PictureBox pb_btn_add;
        private Label lbl_precio;

      
    }
}
