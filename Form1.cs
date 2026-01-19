using System.Diagnostics;

namespace Lab1
{
    public partial class Form1 : Form
    {
        int redValue, greenValue, blueValue;
        string shape = "line";
        int mouseDownX, mouseDownY, mouseUpX, mouseUpY;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.shape = "line";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.shape = "rectangle";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.shape = "ellipse";
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.redValue = trackBar1.Value;
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            this.greenValue = trackBar2.Value;
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            this.blueValue = trackBar3.Value;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.mouseDownX = e.X;
            this.mouseDownY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.mouseUpX = e.X;
            this.mouseUpY = e.Y;
            Graphics g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(redValue, greenValue, blueValue), 2);
            if (shape == "line")
            {
                DrawColoredLine.draw(g, pen, mouseDownX, mouseDownY, mouseUpX, mouseUpY);
            }
            else if (shape == "rectangle")
            {
                DrawColoredRectangle.draw(g, pen, mouseDownX, mouseDownY, mouseUpX, mouseUpY);
            }
            else if (shape == "ellipse")
            {
               DrawColoredEllipse.draw(g, pen, mouseDownX, mouseDownY, mouseUpX, mouseUpY);
            }
        }
    }
}
