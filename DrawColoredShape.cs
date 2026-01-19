using System;

// DrawColoredShape interface defines a method for drawing shapes with specified graphics, pen, and coordinates.
interface DrawColoredShape
{
    public abstract static void draw(Graphics g, Pen p, int dX, int dY, int cX, int cY);
}
