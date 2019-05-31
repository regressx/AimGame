using System.Drawing;

namespace CI.AimGame.UI
{
    public class Target
    {
        private readonly Point _point;
        private readonly Size _size;

        public Target(Point point, Size size)
        {
            _point = point;
            _size = size;
        }

        public Point Coodinates
        {
            get { return _point; }
        }

        public Size Size
        {
            get { return _size; }
        }
    }
}