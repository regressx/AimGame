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
            _radius = Math.Sqrt((50 * 50) + (50 * 50));
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
                Rectangle rec = new Rectangle(_x,_y,50,50);
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
            //double radius = Math.Sqrt((e.X * e.X) + (e.Y * e.Y));

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
