using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lineas_Circunferencias
{
    public partial class frmCircunferencia : Form
    {
        private static frmCircunferencia instance;
        private List<Point> puntosAnimacion;
        private int indiceActual;
        private System.Windows.Forms.Timer timer;
        private Bitmap bmp;
        private int escala = 20;

        public static frmCircunferencia GetInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new frmCircunferencia();
            return instance;
        }

        public frmCircunferencia()
        {
            InitializeComponent();

            this.Text = "Circunferencia Bresenham";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            btnReset = new Button();
            btnReset.Text = "Reset";
            btnReset.Size = new Size(80, 30);
            btnReset.Location = new Point(20, pictureBox1.Bottom + 20);
            btnReset.Click += BtnReset_Click;
            this.Controls.Add(btnReset);

            btnSalir = new Button();
            btnSalir.Text = "Salir";
            btnSalir.Size = new Size(80, 30);
            btnSalir.Location = new Point(120, pictureBox1.Bottom + 20);
            btnSalir.Click += BtnSalir_Click;
            this.Controls.Add(btnSalir);

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 50; 
            timer.Tick += Timer_Tick;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetearFormulario();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas cerrar esta ventana?",
                                               "Confirmar cierre",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ResetearFormulario()
        {
            if (timer.Enabled)
                timer.Stop();

            txtCentroX.Text = "";
            txtCentroY.Text = "";
            txtRadio.Text = "";

            if (bmp != null)
            {
                bmp.Dispose();
                bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.White);
                }
                pictureBox1.Image = bmp;
            }

            puntosAnimacion = null;
            indiceActual = 0;
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCentroX.Text) ||
                string.IsNullOrWhiteSpace(txtCentroY.Text) ||
                string.IsNullOrWhiteSpace(txtRadio.Text))
            {
                MessageBox.Show("Debe completar todos los campos",
                               "Datos incompletos",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCentroX.Text, out int centroX) ||
                !int.TryParse(txtCentroY.Text, out int centroY) ||
                !int.TryParse(txtRadio.Text, out int radio))
            {
                MessageBox.Show("Solo se permiten valores numéricos enteros",
                               "Datos inválidos",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }

            if (radio <= 0)
            {
                MessageBox.Show("El radio debe ser un valor positivo mayor que cero",
                               "Radio inválido",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return;
            }


            try
            {
                ClassCircunferencia circ = new ClassCircunferencia();
                puntosAnimacion = circ.CalcularCircunferencia(0, 0, radio);
                indiceActual = 0;

                bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.White);
                }
                pictureBox1.Image = bmp;

                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al graficar: {ex.Message}",
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (indiceActual < puntosAnimacion.Count)
            {
                Point p = puntosAnimacion[indiceActual++];

                int canvasCenterX = bmp.Width / 2;
                int canvasCenterY = bmp.Height / 2;

                int x = canvasCenterX + (p.X * escala);
                int y = canvasCenterY - (p.Y * escala);

                for (int dx = -1; dx <= 1; dx++)
                {
                    for (int dy = -1; dy <= 1; dy++)
                    {
                        int px = x + dx;
                        int py = y + dy;

                        if (px >= 0 && px < bmp.Width && py >= 0 && py < bmp.Height)
                        {
                            bmp.SetPixel(px, py, Color.Red);
                        }
                    }
                }

                pictureBox1.Refresh(); 
            }
            else
            {
                timer.Stop(); 
            }
        }
    }
}