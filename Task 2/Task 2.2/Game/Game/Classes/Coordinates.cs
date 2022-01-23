using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Classes
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public static bool operator ==(Point firstPoint, Point secondPoint)
        {
            if (firstPoint.X == secondPoint.X && firstPoint.Y == secondPoint.Y)
            {
                return true;
            }
            else return false;
        }
        public static bool operator !=(Point firstPoint, Point secondPoint)
        {
            if (firstPoint.X != secondPoint.X || firstPoint.Y != secondPoint.Y)
            {
                return true;
            }
            else return false;
        }
    }
    public abstract class Coordinates
    {
        public Point position;
        protected char visual;
        public char Visual => visual;
    }
}
