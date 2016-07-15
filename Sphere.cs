using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    class Sphere : Circle
    {
        
		public Sphere() : base()										
		{		
			r = 2;
		}

		public Sphere(double x, double y, double r) : base (x, y, r)	
		{	
        
        }

		public override string SurfaceArea()
		{
            double result = Math.Round(2 * pi * r * r, 3);
            string x1 = Convert.ToString(base.r);
            string x2 = Convert.ToString(result);
            string x3 = Convert.ToString(base.x);
            string x4 = Convert.ToString(base.y);

            return "Pole powierzchni sfery o r=" + x1 + " wynosi: " + x2 + " w punkcie: x=" + x3 + ", y=" + x4;
		}
    }
}
