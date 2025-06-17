using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lineas_Circunferencias
{
    internal class ClassRelleno
    {
        private Bitmap bmp;
        private Color colorRelleno;
        private Color colorBorde;
        private PictureBox pictureBox;

        public ClassRelleno(Bitmap bmp, Color colorRelleno, Color colorBorde, PictureBox pictureBox)
        {
            this.bmp = bmp;
            this.colorRelleno = colorRelleno;
            this.colorBorde = colorBorde;
            this.pictureBox = pictureBox;
        }

        public void Rellenar(int x, int y)
        {
            Stack<Point> pila = new Stack<Point>();
            pila.Push(new Point(x, y));

            while (pila.Count > 0)
            {
                Point actual = pila.Pop();

                if (!EsPintable(actual.X, actual.Y))
                    continue;

                bmp.SetPixel(actual.X, actual.Y, colorRelleno);
                pictureBox.Refresh();
                Application.DoEvents();

                Point oeste = new Point(actual.X - 1, actual.Y);
                Point sur = new Point(actual.X, actual.Y + 1);
                Point este = new Point(actual.X + 1, actual.Y);
                Point norte = new Point(actual.X, actual.Y - 1);

                if (EsPintable(oeste.X, oeste.Y)) pila.Push(oeste);
                if (EsPintable(sur.X, sur.Y)) pila.Push(sur);
                if (EsPintable(este.X, este.Y)) pila.Push(este);
                if (EsPintable(norte.X, norte.Y)) pila.Push(norte);
            }
        }

        private bool EsPintable(int x, int y)
        {
            if (x < 0 || y < 0 || x >= bmp.Width || y >= bmp.Height)
                return false;

            Color actual = bmp.GetPixel(x, y);
            return actual.ToArgb() != colorBorde.ToArgb() && actual.ToArgb() != colorRelleno.ToArgb();
        }
    }
}