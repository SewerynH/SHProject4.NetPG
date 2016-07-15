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
            string x1 = "Pole powierzchni okregu o r=";
            string x2 = " wynosi: ";
            string x3 = " w punkcie: x=";
            string x4 = ", y=";
            string y1 = Convert.ToString(r);
            string y2 = Convert.ToString(score);
            string y3 = Convert.ToString(base.x);
            string y4 = Convert.ToString(base.y);
            
            return x1 + y1 + x2 + y2 + x3 + y3 + x4 + y4;
        } 
    } 
}
