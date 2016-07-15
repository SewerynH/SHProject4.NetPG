using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    class Circle : Point
    {
        protected double r { get; set; }
        public Circle() : base()	
        {	
            r = 2;	
        } 

        public Circle (double x, double y, double r) : base (x, y)	
        {	
            this.r = r; 
        } 

        public override string SurfaceArea() 
        {
            double score = Math.Round(pi * r * r, 3);
            string x1 = Convert.ToString(r);
            string x2 = Convert.ToString(score);
            string x3 = Convert.ToString(base.x);
            string x4 = Convert.ToString(base.y);

            return "Pole powierzchni okregu o r=" + x1 + " wynosi: " + x2 + " w punkcie: x=" + x3 + ", y=" + x4;
        } 
    } 
}
