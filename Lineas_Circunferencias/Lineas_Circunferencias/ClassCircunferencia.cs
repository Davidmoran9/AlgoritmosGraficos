using System;
using System.Collections.Generic;
using System.Drawing;

public class ClassCircunferencia
{
    public List<Point> CalcularCircunferencia(int cx, int cy, int radio)
    {
        List<Point> puntos = new List<Point>();
        int x = 0;
        int y = radio;
        int d = 3 - 2 * radio; 

        while (x <= y)
        {
            puntos.Add(new Point(cx + x, cy + y));
            puntos.Add(new Point(cx + y, cy + x));
            puntos.Add(new Point(cx - x, cy + y));
            puntos.Add(new Point(cx - y, cy + x));
            puntos.Add(new Point(cx - x, cy - y));
            puntos.Add(new Point(cx - y, cy - x));
            puntos.Add(new Point(cx + x, cy - y));
            puntos.Add(new Point(cx + y, cy - x));

            if (d <= 0)
            {
                d = d + 4 * x + 6;
            }
            else
            {
                d = d + 4 * (x - y) + 10;
                y--;
            }
            x++;
        }
        return puntos;
    }
}
