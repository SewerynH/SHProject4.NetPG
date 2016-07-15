using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    public class CubeConversion : IConversion
    {
        public double ConvertToDouble(string x) 
        { 
            double result = Convert.ToDouble(x);
            return result;
        }
        public string ConvertToString(double x)
        {
            string y = Convert.ToString(x);
            return y;
        }

        public double Meters(string z)
        {
            double result = ConvertToDouble(z);
            result *= 1000000;
            return result;
        }
        public double Inch(string x)
        {
            double result = ConvertToDouble(x);
            result *= 16.387;
            return result;
        }
        public double Gallon(string x)
        {
            double result = ConvertToDouble(x);
            result *= 3785.142;
            return result;
        }


    }
}
