using System;
using System.Drawing;

// DrawColoredLine class implements the DrawColoredShape interface to draw a line with specified graphics, pen, and coordinates.
public class DrawColoredLine : DrawColoredShape
{
    public static void draw(Graphics g, Pen p, int dX, int dY, int cX, int cY)
    {
        g.DrawLine(p, dX, dY, cX, cY);
    }
}
