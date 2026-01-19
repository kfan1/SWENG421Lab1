using System;
using System.Drawing;

public class DrawColoredLine : DrawColoredShape
{
    public static void draw(Graphics g, Pen p, int dX, int dY, int cX, int cY)
    {
        g.DrawLine(p, dX, dY, cX, cY);
    }
}
