using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3EXERCICE3
{
    public class Cercle
    {
        Point centre;
        double rayon;


        public Cercle() { }

        public Cercle( Point c , double r) 
        
        {
            centre.y = c.y;
            centre.x = c.x;
            rayon = r;
        
        
        }

        public Point getCentre()
        {

            return centre;
        }

        public double getRayon()
        {

            return rayon;
        }


        public void  setCentre( Point c1 )
        {
            centre.x = c1.x;
            centre.y=c1.y;  

        }

        public void setRayon(double r)
        {
            rayon = r;
           

        }


    }
}
