using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3EXERCICE3
{
    internal class Point
    {
       public  double x;
       public double y;


        public Point(){ }

        public Point( double x,double y) 
        {
            this.x = x;
            this.y = y;

        }

        public void setX( double x)
        {
            this.x = x;
        }

        public void setY(double y)
        {
            this.y = y;
        }

        public double getX()
        {
            return this.x;
        }

        public double getY()
        {
            return this.y;
        }

        public double Distance(Point p)
        {
            double a = this.x - p.x;
            double b = this.y - p.y;
            return Math.Sqrt(a*a+b*b);
        }

        public bool Egalite(Point p)
        {
           
            return (this.x==p.x && this.y==p.y);
        }

        public void Translation( double x,double y)
        {
            this.x += x;
            this.y += y;

        }

        public bool linearite(Point p1,Point p2)
        {
            double a = this.x - p1.x;
            double b = this.y - p1.y;
            double c = this.x - p2.x;
            double d = this.y - p2.y;

            return( a*d==b*c);
        }
    }

}
