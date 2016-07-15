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
            double score = Math.Round((2 * pi * r * r) + (2 * pi * r * h), 3);
            string x1 = "Pole powierzchni walca o r=";
            string x2 = " i h=";
            string x3 = " wynosi: ";
            string x4 = " w punkcie: x=";
            string x5 = ", y=";
            string y1 = Convert.ToString(base.r);
            string y2 = Convert.ToString(h);
            string y3 = Convert.ToString(score);
            string y4 = Convert.ToString(base.x);
            string y5 = Convert.ToString(base.y);

            return x1 + y1 + x2 + y2 + x3 + y3 + x4 + y4 + x5 + y5;
		}
    }
}
