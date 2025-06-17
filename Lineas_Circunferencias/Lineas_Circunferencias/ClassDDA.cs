using System;
using System.Collections.Generic;
using System.Drawing;

public class ClassDDA
{
    public List<Point> CalcularLineaDDA(int x1, int y1, int x2, int y2)
    {
        List<Point> puntos = new List<Point>();

        int dx = x2 - x1;
        int dy = y2 - y1;

        int pasos = Math.Max(Math.Abs(dx), Math.Abs(dy));

        float incX = dx / (float)pasos;
        float incY = dy / (float)pasos;

        float x = x1;
        float y = y1;

        for (int i = 0; i <= pasos; i++)
        {
            puntos.Add(new Point((int)Math.Round(x), (int)Math.Round(y)));
            x += incX;
            y += incY;
        }

        return puntos;
    }
}
