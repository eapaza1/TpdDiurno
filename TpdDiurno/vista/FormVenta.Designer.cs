using System.Drawing;
using System.Windows.Forms;

namespace TpdDiurno.vista
{
    partial class FormVenta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.fpanel_venta = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 501);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(703, 501);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.fpanel_venta);
            this.panel2.Controls.Add(this.txt_buscar);
            this.panel2.Controls.Add(this.btn_guardar);
            this.panel2.Controls.Add(this.lbl_total);
            this.panel2.Controls.Add(this.btn_cancelar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(703, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 501);
            this.panel2.TabIndex = 2;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.Location = new System.Drawing.Point(4, 15);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(316, 20);
            this.txt_buscar.TabIndex = 1;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(219, 455);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(68, 31);
            this.btn_guardar.TabIndex = 4;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // lbl_total
            // 
            this.lbl_total.Location = new System.Drawing.Point(270, 427);
            this.lbl_total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(50, 17);
            this.lbl_total.TabIndex = 2;
            this.lbl_total.Text = "label1";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(56, 455);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(68, 31);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // fpanel_venta
            // 
            this.fpanel_venta.AutoScroll = true;
            this.fpanel_venta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fpanel_venta.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpanel_venta.Location = new System.Drawing.Point(3, 53);
            this.fpanel_venta.Name = "fpanel_venta";
            this.fpanel_venta.Size = new System.Drawing.Size(317, 371);
            this.fpanel_venta.TabIndex = 5;
            this.fpanel_venta.WrapContents = false;
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txt_buscar;
        private Button btn_guardar;
        private Button btn_cancelar;
        private Label lbl_total;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel fpanel_venta;
    }
}