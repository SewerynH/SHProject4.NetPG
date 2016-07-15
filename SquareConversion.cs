using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    class SquareConversion : IConversion
    {
        public string ConvertToString(double x)
        {
            string y = Convert.ToString(x);
            return y;
        }
        public double ConvertToDouble(string x) 
        { 
            double result = Convert.ToDouble(x);
            return result;
        }
        public double Hectare(string x)
        {
            double result = ConvertToDouble(x);
            return result * 10000;
        }
        public double Acre(string x)
        {
            double result = ConvertToDouble(x);
            return result * 4046.856;
        }
        public double Yard(string x)
        {
            double result = ConvertToDouble(x);
            return result * 0.836;
        }
    }
}
