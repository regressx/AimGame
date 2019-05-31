using System;
using System.Drawing;
using System.Windows.Forms;

namespace CI.AimGame.UI
{
    public partial class Form1 : Form
    {
        private Graphics _graphics;
        private Target _target;
        private double _radius;
        private int _x;
        private int _y;
        public Form1()
        {
            InitializeComponent();
            _radius = 50;
        }

        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            SolidBrush brush = null;
            try
            {
                _graphics = panel1.CreateGraphics();
                _graphics.Clear(Color.Aqua);
                _x = rnd.Next(100);
                _y = rnd.Next(100);
                Rectangle rec = new Rectangle(_x,_y,100,100);
                _x += 50;
                _y += 50;
                brush = new SolidBrush(Color.Black);
                _graphics.FillEllipse(brush, rec);
            }
            finally
            {
                if (brush != null)
                {
                    brush.Dispose();
                }
                _graphics.Dispose();
            }


        }

        private int _hits;

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            int a = e.X - _x;
            int b = e.Y - _y;

            double radius = Math.Sqrt((a*a) + (b*b));

            if (radius <= _radius)
            {
                _hits++;
                label3.Text = _hits.ToString();
            }

            try
            {
                _graphics = panel1.CreateGraphics();
                _graphics.Clear(Color.Aqua);
            }
            finally
            {
                _graphics.Dispose();
            }



        }
    }
}
