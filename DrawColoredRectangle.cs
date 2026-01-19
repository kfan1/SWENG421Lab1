using System;
using System.Drawing;

public class DrawColoredRectangle : DrawColoredShape
{
	public static void draw(Graphics g, Pen p, int dX, int dY, int cX, int cY)
	{
        g.DrawRectangle(p, Math.Min(dX, cX), Math.Min(dY, cY), Math.Abs(cX - dX), Math.Abs(cY - dY));
    }
}
