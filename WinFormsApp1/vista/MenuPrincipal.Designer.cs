namespace TpdDiurno.vista
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            sidebarItem1 = new ElementosUI.SidebarItem();
            button1 = new Button();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 65, 173);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 35);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(34, 41, 56);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 422);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 28);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(44, 61, 138);
            panel3.Controls.Add(sidebarItem1);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(216, 387);
            panel3.TabIndex = 2;
            // 
            // sidebarItem1
            // 
            sidebarItem1.BackColor = SystemColors.ScrollBar;
            sidebarItem1.ItemIcon = (Image)resources.GetObject("sidebarItem1.ItemIcon");
            sidebarItem1.ItemNotifyFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sidebarItem1.ItemText = "label1";
            sidebarItem1.ItemTextFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            sidebarItem1.ItemTextNotfy = "1200";
            sidebarItem1.Location = new Point(-1, 33);
            sidebarItem1.Name = "sidebarItem1";
            sidebarItem1.Size = new Size(214, 42);
            sidebarItem1.TabIndex = 2;
            sidebarItem1.Click += sidebarItem1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(46, 145);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private ElementosUI.SidebarItem sidebarItem1;
    }
}