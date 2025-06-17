namespace Lineas_Circunferencias
{
    partial class frmDDA
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
            lblX1 = new Label();
            txtX1 = new TextBox();
            lblY1 = new Label();
            txtY1 = new TextBox();
            lblX2 = new Label();
            lblY2 = new Label();
            txtX2 = new TextBox();
            txtY2 = new TextBox();
            btnGraficar = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnReset = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblX1
            // 
            lblX1.AutoSize = true;
            lblX1.Font = new Font("Showcard Gothic", 9F);
            lblX1.Location = new Point(38, 109);
            lblX1.Name = "lblX1";
            lblX1.Size = new Size(30, 18);
            lblX1.TabIndex = 0;
            lblX1.Text = "X1:";
            // 
            // txtX1
            // 
            txtX1.Location = new Point(73, 106);
            txtX1.Name = "txtX1";
            txtX1.Size = new Size(125, 27);
            txtX1.TabIndex = 1;
            // 
            // lblY1
            // 
            lblY1.AutoSize = true;
            lblY1.Font = new Font("Showcard Gothic", 9F);
            lblY1.Location = new Point(38, 150);
            lblY1.Name = "lblY1";
            lblY1.Size = new Size(28, 18);
            lblY1.TabIndex = 2;
            lblY1.Text = "Y1:";
            // 
            // txtY1
            // 
            txtY1.Location = new Point(72, 143);
            txtY1.Name = "txtY1";
            txtY1.Size = new Size(125, 27);
            txtY1.TabIndex = 3;
            // 
            // lblX2
            // 
            lblX2.AutoSize = true;
            lblX2.Font = new Font("Showcard Gothic", 9F);
            lblX2.Location = new Point(38, 201);
            lblX2.Name = "lblX2";
            lblX2.Size = new Size(31, 18);
            lblX2.TabIndex = 4;
            lblX2.Text = "X2:";
            // 
            // lblY2
            // 
            lblY2.AutoSize = true;
            lblY2.Font = new Font("Showcard Gothic", 9F);
            lblY2.Location = new Point(38, 237);
            lblY2.Name = "lblY2";
            lblY2.Size = new Size(29, 18);
            lblY2.TabIndex = 5;
            lblY2.Text = "Y2:";
            // 
            // txtX2
            // 
            txtX2.Location = new Point(73, 198);
            txtX2.Name = "txtX2";
            txtX2.Size = new Size(125, 27);
            txtX2.TabIndex = 6;
            // 
            // txtY2
            // 
            txtY2.Location = new Point(72, 234);
            txtY2.Name = "txtY2";
            txtY2.Size = new Size(125, 27);
            txtY2.TabIndex = 7;
            // 
            // btnGraficar
            // 
            btnGraficar.Font = new Font("Showcard Gothic", 9F);
            btnGraficar.Location = new Point(352, 24);
            btnGraficar.Name = "btnGraficar";
            btnGraficar.Size = new Size(121, 29);
            btnGraficar.TabIndex = 8;
            btnGraficar.Text = "Graficar Línea";
            btnGraficar.UseVisualStyleBackColor = true;
            btnGraficar.Click += btnGraficar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Location = new Point(241, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(428, 270);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 9F);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(294, 18);
            label1.TabIndex = 10;
            label1.Text = "Ingrese los puntos para continuar:";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Showcard Gothic", 9F);
            btnReset.Location = new Point(493, 24);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(121, 29);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += BtnReset_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Showcard Gothic", 9F);
            btnSalir.Location = new Point(629, 24);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(121, 29);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += BtnSalir_Click;
            // 
            // frmDDA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 378);
            Controls.Add(btnSalir);
            Controls.Add(btnReset);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnGraficar);
            Controls.Add(txtY2);
            Controls.Add(txtX2);
            Controls.Add(lblY2);
            Controls.Add(lblX2);
            Controls.Add(txtY1);
            Controls.Add(lblY1);
            Controls.Add(txtX1);
            Controls.Add(lblX1);
            Name = "frmDDA";
            Text = "frmDDA";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblX1;
        private TextBox txtX1;
        private Label lblY1;
        private TextBox txtY1;
        private Label lblX2;
        private Label lblY2;
        private TextBox txtX2;
        private TextBox txtY2;
        private Button btnGraficar;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnReset;
        private Button btnSalir;
    }
}