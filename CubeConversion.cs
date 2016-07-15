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
        public double EstablishedMultiplier(double x)
        {
            return Math.Round(x, 1) ;
        }
        public double Meters(string z)
        {
            double result = ConvertToDouble(z);
            return result * EstablishedMultiplier(1000000);
        }
        public double Inch(string x)
        {
            double result = ConvertToDouble(x);
            return result * EstablishedMultiplier(16.387492);
        }
        public double Gallon(string x)
        {
            double result = ConvertToDouble(x);
            return result * EstablishedMultiplier(3785.142371);
        }


    }
}
