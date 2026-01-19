using System;
using System.Drawing;

public class DrawColoredLine : DrawColoredShape
{
    public static void draw(Graphics g, Pen p, int dX, int dY, int uX, int uY)
    {
        g.DrawLine(p, dX, dY, uX, uY);
    }
}
