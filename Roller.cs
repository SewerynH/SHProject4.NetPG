using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    class Roller : Sphere
    {
        private double h { get; set; }

		public Roller(): base()											
		{	
			this.h = 4.5;	
		}

		public Roller(double x, double y, double r, double h) : base (x, y, r)	
		{
			this.h = h;	
		}

		public override string SurfaceArea()
		{
            double result = Math.Round((2 * pi * r * r) + (2 * pi * r * h), 3);
            string x1 = Convert.ToString(base.r);
            string x2 = Convert.ToString(h);
            string x3 = Convert.ToString(result);
            string x4 = Convert.ToString(base.x);
            string x5 = Convert.ToString(base.y);

            return "Pole powierzchni walca o r=" + x1 + " i h=" + x2 + " wynosi: " + x3 + " w punkcie: x=" + x4 + ", y=" + x5;
		}
    }
}
