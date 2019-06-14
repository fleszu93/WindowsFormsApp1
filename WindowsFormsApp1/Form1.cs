using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Figura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gp = panel1.CreateGraphics();

        }
        Graphics gp;
        Point v1;
        Point v2;
        Point v3;

        bool getv1 = false;
        bool getv2 = false;
        bool getv3 = false;

        Pen p = new Pen(Brushes.Black, 5);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (getv1)
            {
                v1 = new Point(e.X, e.Y);
                ver1.Text = "x : " + e.X + " y : " + e.Y;
            }
            if (getv2)
            {
                v2 = new Point(e.X, e.Y);
                ver2.Text = "x : " + e.X + " y : " + e.Y;
                gp.DrawLine(p, v1, v2);
            }
            if (getv3)
            {
                v3 = new Point(e.X, e.Y);
                ver3.Text = "x : " + e.X + " y : " + e.Y;
                gp.DrawLine(p, v3, v2);
                gp.DrawLine(p, v3, v1);
            }

            panel1.Cursor = Cursors.Default;
            getv1 = false;
            getv2 = false;
            getv3 = false;
        }

        private void Fill_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            SolidBrush sb = new SolidBrush(colorDialog1.Color);
            gp.FillPolygon(sb, new Point[] { v1, v2, v3 });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getv1 = true;
            panel1.Cursor = Cursors.Cross;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getv2 = true;
            panel1.Cursor = Cursors.Cross;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getv3 = true;
            panel1.Cursor = Cursors.Cross;
        }



        private void ver1_Click(object sender, EventArgs e)
        {

        }

        private void ver2_Click(object sender, EventArgs e)
        {

        }
    }
}
