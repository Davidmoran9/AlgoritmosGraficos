namespace Lineas_Circunferencias
{
    partial class FrmHomee
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
            menuStrip1 = new MenuStrip();
            cuadranguloToolStripMenuItem = new ToolStripMenuItem();
            dDAToolStripMenuItem = new ToolStripMenuItem();
            bresenhamToolStripMenuItem = new ToolStripMenuItem();
            discretizaciónToolStripMenuItem = new ToolStripMenuItem();
            rellenoPorInundaciónToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonFace;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Font = new Font("Showcard Gothic", 9F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cuadranguloToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(158, 405);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // cuadranguloToolStripMenuItem
            // 
            cuadranguloToolStripMenuItem.BackColor = SystemColors.ButtonFace;
            cuadranguloToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dDAToolStripMenuItem, bresenhamToolStripMenuItem, discretizaciónToolStripMenuItem, rellenoPorInundaciónToolStripMenuItem });
            cuadranguloToolStripMenuItem.ForeColor = SystemColors.ActiveCaptionText;
            cuadranguloToolStripMenuItem.Name = "cuadranguloToolStripMenuItem";
            cuadranguloToolStripMenuItem.Size = new Size(141, 22);
            cuadranguloToolStripMenuItem.Text = "Algoritmos";
            // 
            // dDAToolStripMenuItem
            // 
            dDAToolStripMenuItem.Name = "dDAToolStripMenuItem";
            dDAToolStripMenuItem.Size = new Size(366, 26);
            dDAToolStripMenuItem.Text = "DDA";
            dDAToolStripMenuItem.Click += dDAToolStripMenuItem_Click;
            // 
            // bresenhamToolStripMenuItem
            // 
            bresenhamToolStripMenuItem.Name = "bresenhamToolStripMenuItem";
            bresenhamToolStripMenuItem.Size = new Size(366, 26);
            bresenhamToolStripMenuItem.Text = "Bresenham";
            bresenhamToolStripMenuItem.Click += bresenhamToolStripMenuItem_Click;
            // 
            // discretizaciónToolStripMenuItem
            // 
            discretizaciónToolStripMenuItem.Name = "discretizaciónToolStripMenuItem";
            discretizaciónToolStripMenuItem.Size = new Size(366, 26);
            discretizaciónToolStripMenuItem.Text = "Discretización de circunferencias";
            discretizaciónToolStripMenuItem.Click += discretizaciónToolStripMenuItem_Click;
            // 
            // rellenoPorInundaciónToolStripMenuItem
            // 
            rellenoPorInundaciónToolStripMenuItem.Name = "rellenoPorInundaciónToolStripMenuItem";
            rellenoPorInundaciónToolStripMenuItem.Size = new Size(366, 26);
            rellenoPorInundaciónToolStripMenuItem.Text = "Relleno por inundación";
            rellenoPorInundaciónToolStripMenuItem.Click += rellenoPorInundaciónToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 119);
            label1.Name = "label1";
            label1.Size = new Size(738, 35);
            label1.TabIndex = 3;
            label1.Text = "Implementación de Algoritmos Gráficos Básicos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Font = new Font("Castellar", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(243, 178);
            label2.Name = "label2";
            label2.Size = new Size(334, 27);
            label2.TabIndex = 4;
            label2.Text = "Nombre: David Morán";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Castellar", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(243, 205);
            label3.Name = "label3";
            label3.Size = new Size(142, 27);
            label3.TabIndex = 5;
            label3.Text = "NRC: 22419";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Castellar", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(142, 0);
            label4.Name = "label4";
            label4.Size = new Size(266, 27);
            label4.TabIndex = 6;
            label4.Text = "<- Presionar aquí";
            // 
            // FrmHomee
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1000, 405);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Showcard Gothic", 9F);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmHomee";
            Text = "FrmHomee";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cuadranguloToolStripMenuItem;
        private ToolStripMenuItem dDAToolStripMenuItem;
        private ToolStripMenuItem bresenhamToolStripMenuItem;
        private ToolStripMenuItem discretizaciónToolStripMenuItem;
        private ToolStripMenuItem rellenoPorInundaciónToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}