using System;
using System.Drawing;

public class DrawColoredRectangle : DrawColoredShape
{
	public static void draw(Graphics g, Pen p, int dX, int dY, int uX, int uY)
	{
        g.DrawRectangle(p, Math.Min(dX, uX), Math.Min(dY, uY), Math.Abs(uX - dX), Math.Abs(uY - dY));
    }
}
