using System;

interface DrawColoredShape
{
    abstract static void draw(Graphics g, Pen p, int dX, int dY, int uX, int uY);
}
