using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    abstract class Point
    {
        public const double pi = Math.PI; 
        protected double x { get; set; }
        protected double y { get; set; } 

        public Point()	
		{	
			x = 0;
			y = 0;
		}

        public Point (double x, double y)	
        { 
            this.x = x; 
            this.y = y; 
        } 

        public virtual string SurfaceArea()
		{
            string x = "Pole powierzchni punktu wynosi:";
            return x + 0;
		}
    }
}
