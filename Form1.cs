using System.Diagnostics;

namespace Lab1
{
    public partial class Form1 : Form
    {
        int redValue, greenValue, blueValue;
        string shape = "line";
        int dX, dY, cX, cY;
        Bitmap bg, fg;
        Graphics bgg, fgg;
        bool down = false;

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
            this.down = true;
            this.dX = e.X;
            this.dY = e.Y;
            if(this.bg == null)
            {
                this.bg = new Bitmap(panel1.Width, panel1.Height);
                this.fg = new Bitmap(panel1.Width, panel1.Height);
                this.bgg = Graphics.FromImage(this.bg);
                this.bgg.FillRectangle(Brushes.White, 0, 0, panel1.Width, panel1.Height);
                this.fgg = Graphics.FromImage(this.fg);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.down)
            {
                this.cX = e.X;
                this.cY = e.Y;
                this.fgg.DrawImage(this.bg, 0, 0);
                Pen pen = new Pen(Color.FromArgb(this.redValue, this.greenValue, this.blueValue), 2);
                if (this.shape == "line")
                {
                    DrawColoredLine.draw(this.fgg, pen, this.dX, this.dY, this.cX, this.cY);
                }
                else if (this.shape == "rectangle")
                {
                    DrawColoredRectangle.draw(this.fgg, pen, this.dX, this.dY, this.cX, this.cY);
                }
                else if (this.shape == "ellipse")
                {
                    DrawColoredEllipse.draw(this.fgg, pen, this.dX, this.dY, this.cX, this.cY);
                }
                Graphics g = panel1.CreateGraphics();
                g.DrawImage(this.fg, 0, 0);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.down = false;
            this.bgg.DrawImage(this.fg, 0, 0);
            Graphics g = panel1.CreateGraphics();
            g.DrawImage(this.bg, 0, 0);
        }
    }
}
