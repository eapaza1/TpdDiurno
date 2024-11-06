using System.Windows.Forms;
using System.Drawing;

namespace TpdDiurno.vista.ElementosUI
{
    partial class ProductListItem
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
            img_imagen = new PictureBox();
            btn_eliminar = new PictureBox();
            btn_editar = new PictureBox();
            lbl_precio = new Label();
            lbl_cantidad = new Label();
            lbl_nombre = new Label();
            lbl_categoria = new Label();
            ((System.ComponentModel.ISupportInitialize)img_imagen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_eliminar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_editar).BeginInit();
            SuspendLayout();
            // 
            // img_imagen
            // 
            img_imagen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            img_imagen.Image = Properties.Resources.agregar_producto;
            img_imagen.Location = new Point(4, 0);
            img_imagen.Name = "img_imagen";
            img_imagen.Size = new Size(54, 50);
            img_imagen.SizeMode = PictureBoxSizeMode.Zoom;
            img_imagen.TabIndex = 0;
            img_imagen.TabStop = false;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btn_eliminar.Cursor = Cursors.Hand;
            btn_eliminar.Image = Properties.Resources.borrar;
            btn_eliminar.Location = new Point(386, 5);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(25, 40);
            btn_eliminar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_eliminar.TabIndex = 1;
            btn_eliminar.TabStop = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_editar
            // 
            btn_editar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btn_editar.Cursor = Cursors.Hand;
            btn_editar.Image = Properties.Resources.editar;
            btn_editar.Location = new Point(414, 5);
            btn_editar.Name = "btn_editar";
            btn_editar.Size = new Size(25, 40);
            btn_editar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_editar.TabIndex = 2;
            btn_editar.TabStop = false;
            btn_editar.Click += btn_editar_Click;
            // 
            // lbl_precio
            // 
            lbl_precio.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_precio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_precio.Location = new Point(312, 5);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(68, 40);
            lbl_precio.TabIndex = 3;
            lbl_precio.Text = "150000.00";
            lbl_precio.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_cantidad
            // 
            lbl_cantidad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_cantidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_cantidad.Location = new Point(246, 5);
            lbl_cantidad.Name = "lbl_cantidad";
            lbl_cantidad.Size = new Size(60, 40);
            lbl_cantidad.TabIndex = 4;
            lbl_cantidad.Text = "12000";
            lbl_cantidad.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_nombre
            // 
            lbl_nombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_nombre.Location = new Point(64, 1);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(176, 35);
            lbl_nombre.TabIndex = 5;
            lbl_nombre.Text = "LAPTOP DELL LATUDE CON PROCESARO I7 12700 RAM 32GB";
            // 
            // lbl_categoria
            // 
            lbl_categoria.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_categoria.Location = new Point(64, 33);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(176, 15);
            lbl_categoria.TabIndex = 6;
            lbl_categoria.Text = "TECNOLOGIA";
            // 
            // ProductListItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(lbl_categoria);
            Controls.Add(lbl_nombre);
            Controls.Add(lbl_cantidad);
            Controls.Add(lbl_precio);
            Controls.Add(btn_editar);
            Controls.Add(btn_eliminar);
            Controls.Add(img_imagen);
            Name = "ProductListItem";
            Size = new Size(442, 50);
            ((System.ComponentModel.ISupportInitialize)img_imagen).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_eliminar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_editar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox img_imagen;
        private PictureBox btn_eliminar;
        private PictureBox btn_editar;
        private Label lbl_precio;
        private Label lbl_cantidad;
        private Label lbl_nombre;
        private Label lbl_categoria;
        
    }
}
