using System;
using System.Drawing;

// DrawColoredEllipse class implements the DrawColoredShape interface to draw an ellipse with specified graphics, pen, and coordinates.
public class DrawColoredEllipse : DrawColoredShape
{
    public static void draw(Graphics g, Pen p, int dX, int dY, int cX, int cY)
    {
        g.DrawEllipse(p, Math.Min(dX, cX), Math.Min(dY, cY), Math.Abs(cX - dX), Math.Abs(cY - dY));
    }
}
