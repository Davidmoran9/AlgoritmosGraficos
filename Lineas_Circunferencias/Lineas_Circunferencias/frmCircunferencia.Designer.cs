namespace Lineas_Circunferencias
{
    partial class frmCircunferencia
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
            txtRadio = new TextBox();
            lblRadio = new Label();
            txtCentroY = new TextBox();
            lblCentroY = new Label();
            txtCentroX = new TextBox();
            lblCentroX = new Label();
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
            pictureBox1.Size = new Size(536, 371);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // btnGraficar
            // 
            btnGraficar.Font = new Font("Showcard Gothic", 9F);
            btnGraficar.Location = new Point(281, 19);
            btnGraficar.Name = "btnGraficar";
            btnGraficar.Size = new Size(121, 29);
            btnGraficar.TabIndex = 18;
            btnGraficar.Text = "Graficar Línea";
            btnGraficar.UseVisualStyleBackColor = true;
            btnGraficar.Click += btnGraficar_Click;
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(103, 113);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(125, 27);
            txtRadio.TabIndex = 16;
            // 
            // lblRadio
            // 
            lblRadio.AutoSize = true;
            lblRadio.Font = new Font("Showcard Gothic", 9F);
            lblRadio.Location = new Point(31, 116);
            lblRadio.Name = "lblRadio";
            lblRadio.Size = new Size(59, 18);
            lblRadio.TabIndex = 14;
            lblRadio.Text = "Radio:";
            // 
            // txtCentroY
            // 
            txtCentroY.Location = new Point(103, 62);
            txtCentroY.Name = "txtCentroY";
            txtCentroY.Size = new Size(125, 27);
            txtCentroY.TabIndex = 13;
            // 
            // lblCentroY
            // 
            lblCentroY.AutoSize = true;
            lblCentroY.Font = new Font("Showcard Gothic", 9F);
            lblCentroY.Location = new Point(14, 71);
            lblCentroY.Name = "lblCentroY";
            lblCentroY.Size = new Size(83, 18);
            lblCentroY.TabIndex = 12;
            lblCentroY.Text = "Centro Y:";
            // 
            // txtCentroX
            // 
            txtCentroX.Location = new Point(105, 21);
            txtCentroX.Name = "txtCentroX";
            txtCentroX.Size = new Size(125, 27);
            txtCentroX.TabIndex = 11;
            // 
            // lblCentroX
            // 
            lblCentroX.AutoSize = true;
            lblCentroX.Font = new Font("Showcard Gothic", 9F);
            lblCentroX.Location = new Point(14, 25);
            lblCentroX.Name = "lblCentroX";
            lblCentroX.Size = new Size(85, 18);
            lblCentroX.TabIndex = 10;
            lblCentroX.Text = "Centro X:";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Showcard Gothic", 9F);
            btnReset.Location = new Point(419, 20);
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
            btnSalir.Location = new Point(560, 21);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(121, 29);
            btnSalir.TabIndex = 21;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += BtnSalir_Click;
            // 
            // frmCircunferencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnReset);
            Controls.Add(pictureBox1);
            Controls.Add(btnGraficar);
            Controls.Add(txtRadio);
            Controls.Add(lblRadio);
            Controls.Add(txtCentroY);
            Controls.Add(lblCentroY);
            Controls.Add(txtCentroX);
            Controls.Add(lblCentroX);
            Name = "frmCircunferencia";
            Text = "frmCircunferencia";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnGraficar;
        private TextBox txtRadio;
        private Label lblRadio;
        private TextBox txtCentroY;
        private Label lblCentroY;
        private TextBox txtCentroX;
        private Label lblCentroX;
        private Button btnReset;
        private Button btnSalir;
    }
}