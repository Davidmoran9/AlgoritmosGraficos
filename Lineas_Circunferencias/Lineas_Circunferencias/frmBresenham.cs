using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lineas_Circunferencias
{
    public partial class frmBresenham : Form
    {
        private static frmBresenham instance;
        private List<Point> puntosAnimacion;
        private int indiceActual;
        private System.Windows.Forms.Timer timer;
        private Bitmap bmp;
        private int escala = 20;

        public static frmBresenham GetInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new frmBresenham();
            return instance;
        }

        public frmBresenham()
        {
            InitializeComponent();

            this.Text = "Algoritmo Bresenham";
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
            timer.Interval = 200; 
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

            txtBX1.Text = "";
            txtBY1.Text = "";
            txtBX2.Text = "";
            txtBY2.Text = "";

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
            if (string.IsNullOrWhiteSpace(txtBX1.Text) ||
                string.IsNullOrWhiteSpace(txtBY1.Text) ||
                string.IsNullOrWhiteSpace(txtBX2.Text) ||
                string.IsNullOrWhiteSpace(txtBY2.Text))
            {
                MessageBox.Show("Por favor complete todos los campos",
                               "Datos incompletos",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtBX1.Text, out int x1) ||
                !int.TryParse(txtBY1.Text, out int y1) ||
                !int.TryParse(txtBX2.Text, out int x2) ||
                !int.TryParse(txtBY2.Text, out int y2))
            {
                MessageBox.Show("Por favor ingrese solo números enteros",
                               "Datos inválidos",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                return;
            }
            try
            {
                

                ClassBresenham bres = new ClassBresenham();
                puntosAnimacion = bres.CalcularLineaBresenham(x1, y1, x2, y2);
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
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (indiceActual < puntosAnimacion.Count)
            {
                Point p = puntosAnimacion[indiceActual++];
                int x = p.X * escala;
                int y = pictureBox1.Height - (p.Y * escala); 

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

                pictureBox1.Refresh(); 
            }
            else
            {
                timer.Stop(); 
            }
        }
    }
}