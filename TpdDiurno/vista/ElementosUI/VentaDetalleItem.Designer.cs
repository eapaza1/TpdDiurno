namespace TpdDiurno.vista.ElementosUI
{
    partial class VentaDetalleItem
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
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_up = new System.Windows.Forms.PictureBox();
            this.btn_down = new System.Windows.Forms.PictureBox();
            this.btn_delete = new System.Windows.Forms.PictureBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_cantidad.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_cantidad.Location = new System.Drawing.Point(0, 0);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(31, 26);
            this.lbl_cantidad.TabIndex = 0;
            this.lbl_cantidad.Text = "Cant";
            this.lbl_cantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_up);
            this.panel1.Controls.Add(this.btn_down);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(31, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 26);
            this.panel1.TabIndex = 2;
            // 
            // btn_up
            // 
            this.btn_up.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_up.Image = global::TpdDiurno.Properties.Resources.arriba_select;
            this.btn_up.Location = new System.Drawing.Point(0, 0);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(20, 13);
            this.btn_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_up.TabIndex = 1;
            this.btn_up.TabStop = false;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_down
            // 
            this.btn_down.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_down.Image = global::TpdDiurno.Properties.Resources.abajo_cheuron;
            this.btn_down.Location = new System.Drawing.Point(0, 13);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(20, 13);
            this.btn_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_down.TabIndex = 0;
            this.btn_down.TabStop = false;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_delete.Image = global::TpdDiurno.Properties.Resources.borrar;
            this.btn_delete.Location = new System.Drawing.Point(300, 0);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(20, 26);
            this.btn_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_delete.TabIndex = 3;
            this.btn_delete.TabStop = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_total.Location = new System.Drawing.Point(245, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(55, 26);
            this.lbl_total.TabIndex = 4;
            this.lbl_total.Text = "TOTAL";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_precio
            // 
            this.lbl_precio.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_precio.Location = new System.Drawing.Point(204, 0);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(41, 26);
            this.lbl_precio.TabIndex = 5;
            this.lbl_precio.Text = "P. U.";
            this.lbl_precio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_nombre.Location = new System.Drawing.Point(51, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(153, 26);
            this.lbl_nombre.TabIndex = 6;
            this.lbl_nombre.Text = "NOMBRE DE PRODUCTO";
            this.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VentaDetalleItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_cantidad);
            this.Name = "VentaDetalleItem";
            this.Size = new System.Drawing.Size(320, 26);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_up;
        private System.Windows.Forms.PictureBox btn_down;
        private System.Windows.Forms.PictureBox btn_delete;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_nombre;
    }
}
