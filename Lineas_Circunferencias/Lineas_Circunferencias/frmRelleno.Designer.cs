namespace Lineas_Circunferencias
{
    partial class frmRelleno
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
            pictureBox1 = new PictureBox();
            btnDibujar = new Button();
            txtRadio = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnReset = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Location = new Point(338, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(427, 354);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += btnDibujar_Click;
            // 
            // btnDibujar
            // 
            btnDibujar.Font = new Font("Showcard Gothic", 9F);
            btnDibujar.Location = new Point(150, 235);
            btnDibujar.Name = "btnDibujar";
            btnDibujar.Size = new Size(125, 41);
            btnDibujar.TabIndex = 1;
            btnDibujar.Text = "Graficar";
            btnDibujar.UseVisualStyleBackColor = true;
            btnDibujar.Click += btnDibujar_Click;
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(150, 160);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(125, 27);
            txtRadio.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 9F);
            label2.Location = new Point(43, 160);
            label2.Name = "label2";
            label2.Size = new Size(59, 18);
            label2.TabIndex = 5;
            label2.Text = "Radio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9F);
            label1.Location = new Point(43, 126);
            label1.Name = "label1";
            label1.Size = new Size(232, 18);
            label1.TabIndex = 6;
            label1.Text = "Ingrese el radio del rombo:";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Showcard Gothic", 9F);
            btnReset.Location = new Point(150, 282);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(125, 41);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Showcard Gothic", 9F);
            btnSalir.Location = new Point(150, 329);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(125, 41);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmRelleno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(847, 457);
            Controls.Add(btnSalir);
            Controls.Add(btnReset);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtRadio);
            Controls.Add(btnDibujar);
            Controls.Add(pictureBox1);
            Name = "frmRelleno";
            Text = "frmRelleno";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnDibujar;
        private TextBox txtRadio;
        private Label label2;
        private Label label1;
        private Button btnReset;
        private Button btnSalir;
    }
}