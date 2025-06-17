using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lineas_Circunferencias
{
    public partial class frmRelleno : Form
    {
        private Bitmap bmp;
        private static frmRelleno instancia;
        private Point[] romboPoints; // Almacenamos los puntos del rombo para validación

        public static frmRelleno GetInstance()
        {
            if (instancia == null || instancia.IsDisposed)
                instancia = new frmRelleno();
            return instancia;
        }

        public frmRelleno()
        {
            InitializeComponent();
            pictureBox1.MouseClick += PictureBox1_MouseClick;
            btnReset.Click += BtnReset_Click;
            btnSalir.Click += BtnSalir_Click;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                bmp.Dispose();
                bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.Clear(Color.White);
                }
                pictureBox1.Image = bmp;
                romboPoints = null;
            }

            txtRadio.Text = "";

            MessageBox.Show("La aplicación ha sido reiniciada correctamente.", "Reset completado",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            // Mostrar diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas salir de la aplicación?",
                                                "Confirmar salida",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Cerrar el formulario
            }
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            try
            {
                int radioUsuario = int.Parse(txtRadio.Text);
                int factorEscala = 10;
                int radio = radioUsuario * factorEscala;

                if (radio <= 0) throw new Exception("El radio debe ser mayor que 0");

                int ancho = pictureBox1.Width;
                int alto = pictureBox1.Height;

                bmp = new Bitmap(ancho, alto);
                Graphics g = Graphics.FromImage(bmp);
                g.Clear(Color.White);

                Point centro = new Point(ancho / 2, alto / 2);

                // Dibujar rombo con 4 puntos (N, E, S, O)
                romboPoints = new Point[]
                {
                    new Point(centro.X, centro.Y - radio),  // Norte
                    new Point(centro.X + radio, centro.Y),  // Este
                    new Point(centro.X, centro.Y + radio),  // Sur
                    new Point(centro.X - radio, centro.Y)   // Oeste
                };

                g.DrawPolygon(Pens.Black, romboPoints);
                pictureBox1.Image = bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EstaDentroDelRombo(Point punto)
        {
            if (romboPoints == null || romboPoints.Length != 4)
                return false;

            int i, j;
            bool resultado = false;
            for (i = 0, j = romboPoints.Length - 1; i < romboPoints.Length; j = i++)
            {
                if ((romboPoints[i].Y > punto.Y) != (romboPoints[j].Y > punto.Y) &&
                    (punto.X < (romboPoints[j].X - romboPoints[i].X) * (punto.Y - romboPoints[i].Y) /
                    (romboPoints[j].Y - romboPoints[i].Y) + romboPoints[i].X))
                {
                    resultado = !resultado;
                }
            }
            return resultado;
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (bmp == null)
            {
                MessageBox.Show("Primero dibuja un polígono.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Point clickPoint = new Point(e.X, e.Y);

            if (!EstaDentroDelRombo(clickPoint))
            {
                MessageBox.Show("Debes hacer clic DENTRO del rombo.", "Ubicación incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Color colorSemilla = bmp.GetPixel(e.X, e.Y);
            if (colorSemilla.ToArgb() == Color.Black.ToArgb())
            {
                MessageBox.Show("Haz clic dentro del área del polígono, no en el borde.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClassRelleno relleno = new ClassRelleno(bmp, Color.Red, Color.Black, pictureBox1);
            relleno.Rellenar(e.X, e.Y);
            pictureBox1.Image = bmp;
        }
    }
}