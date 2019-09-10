using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidateConvexHullPoints
{
    public partial class Form1 : Form
    {
        const int PISIZE = 5;
        int counter = 0;
        Point a;
        Point b;
        Point c;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if(counter == 0)
            {
                a = new Point(e.X, e.Y);
                counter++;
            } 
            else if(counter == 1)
            {
                b = new Point(e.X, e.Y);
                counter++;
            } 
            else
            {
                c = new Point(e.X, e.Y);
                counter++;
            }
            panel1.Refresh();
            label1.Text = drawLine();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if(counter >= 1)
            {
                drawPoint(e.Graphics, a);
            }
            if(counter >= 2)
            {
                e.Graphics.DrawLine(Pens.Blue, a, b);
                drawPoint(e.Graphics, b);
            }
            if(counter >= 3)
            {
                drawPoint(e.Graphics, c);
            }
        }

        private void drawPoint(Graphics g, Point pt)
        {
            g.DrawLine(Pens.Black, pt.X - PISIZE, pt.Y, pt.X + PISIZE, pt.Y);
            g.DrawLine(Pens.Black, pt.X, pt.Y - PISIZE, pt.X, pt.Y + PISIZE);
        }

        public string drawLine()
        {
            string nums = "";
            int line = a.X * b.Y - b.X * a.Y + b.X * c.Y - c.X * b.Y + c.X * a.Y - a.X * c.Y;
            if(line > 1000)
            {
                nums = "Clockwise";
            } else if(line < -1000)
            {
                nums = "Anticlockwise";
            } else
            {
                nums = "0";
            }
            return nums;
        }
    }
}
