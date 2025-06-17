using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lineas_Circunferencias
{
    public partial class frmDDA : Form
    {
        private static frmDDA instance;
        private List<Point> puntosAnimacion;
        private int indiceActual;
        private System.Windows.Forms.Timer timer;
        private Bitmap bmp;
        private int escala = 20;

        public static frmDDA GetInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new frmDDA();
            return instance;
        }

        public frmDDA()
        {
            InitializeComponent();

            this.Text = "Algoritmo DDA";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            CrearBotones();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 300;
            timer.Tick += Timer_Tick;
        }

        private void CrearBotones()
        {
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
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (timer != null && timer.Enabled)
                timer.Stop();

            txtX1.Text = "";
            txtY1.Text = "";
            txtX2.Text = "";
            txtY2.Text = "";

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

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtX1.Text) ||
                string.IsNullOrWhiteSpace(txtY1.Text) ||
                string.IsNullOrWhiteSpace(txtX2.Text) ||
                string.IsNullOrWhiteSpace(txtY2.Text))
            {
                MessageBox.Show("Debe completar todos los campos",
                               "Datos incompletos",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtX1.Text, out int x1) ||
                !int.TryParse(txtY1.Text, out int y1) ||
                !int.TryParse(txtX2.Text, out int x2) ||
                !int.TryParse(txtY2.Text, out int y2))
            {
                MessageBox.Show("Solo se permiten valores numéricos enteros",
                               "Datos inválidos",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }
            try
            {
                ClassDDA dda = new ClassDDA();
                puntosAnimacion = dda.CalcularLineaDDA(x1, y1, x2, y2);
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
                int x = p.X * escala;
                int y = pictureBox1.Height - p.Y * escala;

                for (int dx = -1; dx <= 1; dx++)
                {
                    for (int dy = -1; dy <= 1; dy++)
                    {
                        int px = x + dx;
                        int py = y + dy;

                        if (px >= 0 && px < bmp.Width && py >= 0 && py < bmp.Height)
                        {
                            bmp.SetPixel(px, py, Color.Black);
                        }
                    }
                }

                pictureBox1.Image = bmp;
            }
            else
            {
                timer.Stop();
            }
        }
    }
}