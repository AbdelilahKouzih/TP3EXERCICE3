using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TP3EXERCICE3
{
    public class Droite
    {
        private Point p1;
        private Point p2;
        public Droite() { }


        public Droite( Point a,Point b) 
        {
            p1.x = a.x;
            p2.y = a.y;


        }

        public Point GetPoint1()
        {

            return p1;
        }
        public Point GetPoint2()
        {

            return p2;
        }

        public void SetExtrimety( Point p1 ,Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
             
        }

        public bool Egalite(Droite d)
        {


            return this.p1.Egalite(d.p1) == this.p2.Egalite(d.p2); 
        }


        public bool parallelisme(Droite d)
        {

            double n = d.p1.x -  this.p1.x;
            double m = d.p1.y - this.p1.y;
            double y = d.p2.x - this.p2.x;
            double w = d.p2.y - this.p2.y;


            return  n*w==m*y;
        }

        public bool intersection(Droite d)
        {
            
            double wn = ((d.p2.y - d.p1.y) * (this.p2.x - this.p1.x)) -
                            ((d.p2.x - d.p1.x) * (this.p2.y - this.p1.y));
                
                
                    return wn == 0;
                

            }
        
           



    }
}
