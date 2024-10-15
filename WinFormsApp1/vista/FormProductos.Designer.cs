namespace TpdDiurno.vista
{
    partial class FormProductos
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
            layout_fill = new FlowLayoutPanel();
            txt_filtrar = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // layout_fill
            // 
            layout_fill.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            layout_fill.AutoScroll = true;
            layout_fill.FlowDirection = FlowDirection.TopDown;
            layout_fill.Location = new Point(290, 64);
            layout_fill.Name = "layout_fill";
            layout_fill.Size = new Size(451, 338);
            layout_fill.TabIndex = 0;
            layout_fill.WrapContents = false;
            // 
            // txt_filtrar
            // 
            txt_filtrar.Location = new Point(295, 29);
            txt_filtrar.Name = "txt_filtrar";
            txt_filtrar.Size = new Size(240, 23);
            txt_filtrar.TabIndex = 1;
            txt_filtrar.TextChanged += txt_filtar_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(89, 150);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 414);
            Controls.Add(button1);
            Controls.Add(txt_filtrar);
            Controls.Add(layout_fill);
            Name = "FormProductos";
            Text = "FormProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel layout_fill;
        private TextBox txt_filtrar;
        private Button button1;
    }
}