using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyPoint
    {
        private int x, y;
        public MyPoint()
        {
            x = 0;
            y = 0;
        }
        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int GetX() { return x; }
        public int GetY() { return y; }
        public void SetX(int x) { this.x = x; }
        public void SetY(int y) { this.y = y; }
        public void SetXY(int x, int y) { this.x = x; this.y = y; }
        public int[] GetXY()
        {
            int[] xy = new int[2];
            xy[0] = this.x;
            xy[1] = this.y;
            return xy;
        }
        public override string ToString()
        {
            return String.Format("({0},{1}", x, y);
        }
        public double Distance(int x,int y)
        {
            int deltaX = this.x - x;
            int deltaY = this.y - y;
            return Math.Sqrt((deltaX*deltaX)+(deltaY*deltaY));
        }
        public double Distance(MyPoint Point)
        {
            return Distance(Point.x, Point.y);
        }
        public double Distance()
        {
            return Distance(0, 0);
        }
    }
}
