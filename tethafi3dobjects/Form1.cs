using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tethafi3dobjects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Graphics g;
        public Pen pen0 = new Pen(Color.Black);
        public float cx, cy, px, py;
        public float step = (360 / 32);
        public float ctrad = (float)(180 / Math.PI);
        public float dimx, dimy, posx, posy;
        public int mx, my;
        public int rotatx = 2;
        public int rotaty = 2;

        public void drawacircle1()
        {


            for (float i = 0; i < 360 + step; i += step)
            {
                px = cx;
                py = cy;

                cx = (float)Math.Cos((i + mx) / ctrad) * dimx + posx;
                cy = (float)Math.Sin((i + my) / ctrad) * dimy + posy;

                g.DrawLine(pen0, cx, cy, px, py);
            }
        }

        public void drawacircle2()
        {


            for (float i = 0; i < 360 + step; i += step)
            {
                px = cx;
                py = cy;

                cx = (float)Math.Cos((i - mx) / ctrad) * dimx + posx;
                cy = (float)Math.Sin((i + my) / ctrad) * dimy + posy;

                g.DrawLine(pen0, cx, cy, px, py);
            }
        }

        public void drawacircle3()
        {


            for (float i = 0; i < 360 + step; i += step)
            {
                px = cx;
                py = cy;

                cx = (float)Math.Cos((i - mx) / ctrad) * dimx + posx;
                cy = (float)Math.Sin((i - my) / ctrad) * dimy + posy;

                g.DrawLine(pen0, cx, cy, px, py);
            }
        }

        public void drawacircle4()
        {


            for (float i = 0; i < 360 + step; i += step)
            {
                px = cx;
                py = cy;

                cx = (float)Math.Cos((i + mx) / ctrad) * dimx + posx;
                cy = (float)Math.Sin((i - my) / ctrad) * dimy + posy;

                g.DrawLine(pen0, cx, cy, px, py);
            }
        }

        public void drawacircle5()
        {


            for (float i = 0; i < 360 + step; i += 15)
            {
                px = cx;
                py = cy;

                cx = ((float)Math.Cos((i*i + mx/2) / ctrad) + (float)Math.Cos((i + mx/2) / ctrad)) * dimx + posx;
                cy = ((float)Math.Cos((i*i + mx/2) / ctrad) + (float)Math.Sin((i - my/2) / ctrad)) * dimy + posy;

                g.DrawLine(pen0, cx, cy, px, py);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            cx = cy = px = py = 0;
            dimx = 200;
            dimy = 200;
            posx = 400;
            posy = 400;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            g.Clear(BackColor);
            mx = e.X / rotatx;
            my = e.Y / rotaty;
           // drawacircle1();
           // drawacircle2();
           // drawacircle3();
           // drawacircle4();
            drawacircle5();
        }
    }
}
