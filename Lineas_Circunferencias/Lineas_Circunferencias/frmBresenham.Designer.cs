namespace Lineas_Circunferencias
{
    partial class frmBresenham
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
            btnGraficar = new Button();
            txtBY2 = new TextBox();
            txtBX2 = new TextBox();
            lblYFinal = new Label();
            lblXFinal = new Label();
            txtBY1 = new TextBox();
            lblYInicio = new Label();
            txtBX1 = new TextBox();
            lblXInicio = new Label();
            btnReset = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Location = new Point(234, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(536, 282);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // btnGraficar
            // 
            btnGraficar.Font = new Font("Showcard Gothic", 9F);
            btnGraficar.Location = new Point(236, 18);
            btnGraficar.Name = "btnGraficar";
            btnGraficar.Size = new Size(121, 29);
            btnGraficar.TabIndex = 18;
            btnGraficar.Text = "Graficar Línea";
            btnGraficar.UseVisualStyleBackColor = true;
            btnGraficar.Click += btnGraficar_Click;
            // 
            // txtBY2
            // 
            txtBY2.Location = new Point(65, 149);
            txtBY2.Name = "txtBY2";
            txtBY2.Size = new Size(125, 27);
            txtBY2.TabIndex = 17;
            // 
            // txtBX2
            // 
            txtBX2.Location = new Point(66, 113);
            txtBX2.Name = "txtBX2";
            txtBX2.Size = new Size(125, 27);
            txtBX2.TabIndex = 16;
            // 
            // lblYFinal
            // 
            lblYFinal.AutoSize = true;
            lblYFinal.Font = new Font("Showcard Gothic", 9F);
            lblYFinal.Location = new Point(31, 152);
            lblYFinal.Name = "lblYFinal";
            lblYFinal.Size = new Size(29, 18);
            lblYFinal.TabIndex = 15;
            lblYFinal.Text = "Y2:";
            // 
            // lblXFinal
            // 
            lblXFinal.AutoSize = true;
            lblXFinal.Font = new Font("Showcard Gothic", 9F);
            lblXFinal.Location = new Point(31, 116);
            lblXFinal.Name = "lblXFinal";
            lblXFinal.Size = new Size(31, 18);
            lblXFinal.TabIndex = 14;
            lblXFinal.Text = "X2:";
            // 
            // txtBY1
            // 
            txtBY1.Location = new Point(65, 58);
            txtBY1.Name = "txtBY1";
            txtBY1.Size = new Size(125, 27);
            txtBY1.TabIndex = 13;
            // 
            // lblYInicio
            // 
            lblYInicio.AutoSize = true;
            lblYInicio.Font = new Font("Showcard Gothic", 9F);
            lblYInicio.Location = new Point(31, 65);
            lblYInicio.Name = "lblYInicio";
            lblYInicio.Size = new Size(28, 18);
            lblYInicio.TabIndex = 12;
            lblYInicio.Text = "Y1:";
            // 
            // txtBX1
            // 
            txtBX1.Location = new Point(66, 21);
            txtBX1.Name = "txtBX1";
            txtBX1.Size = new Size(125, 27);
            txtBX1.TabIndex = 11;
            txtBX1.Text = "    ";
            // 
            // lblXInicio
            // 
            lblXInicio.AutoSize = true;
            lblXInicio.Font = new Font("Showcard Gothic", 9F);
            lblXInicio.Location = new Point(31, 24);
            lblXInicio.Name = "lblXInicio";
            lblXInicio.Size = new Size(30, 18);
            lblXInicio.TabIndex = 10;
            lblXInicio.Text = "X1:";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Showcard Gothic", 9F);
            btnReset.Location = new Point(378, 18);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(121, 29);
            btnReset.TabIndex = 20;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += BtnReset_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Showcard Gothic", 9F);
            btnSalir.Location = new Point(522, 18);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(121, 29);
            btnSalir.TabIndex = 21;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += BtnSalir_Click;
            // 
            // frmBresenham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnReset);
            Controls.Add(pictureBox1);
            Controls.Add(btnGraficar);
            Controls.Add(txtBY2);
            Controls.Add(txtBX2);
            Controls.Add(lblYFinal);
            Controls.Add(lblXFinal);
            Controls.Add(txtBY1);
            Controls.Add(lblYInicio);
            Controls.Add(txtBX1);
            Controls.Add(lblXInicio);
            Name = "frmBresenham";
            Text = "frmBresenham";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnGraficar;
        private TextBox txtBY2;
        private TextBox txtBX2;
        private Label lblYFinal;
        private Label lblXFinal;
        private TextBox txtBY1;
        private Label lblYInicio;
        private TextBox txtBX1;
        private Label lblXInicio;
        private Button btnReset;
        private Button btnSalir;
    }
}